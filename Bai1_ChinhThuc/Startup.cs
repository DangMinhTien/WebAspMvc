using Bai1_ChinhThuc.Model;
using Bai1_ChinhThuc.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bai1_ChinhThuc.Security.Requirements;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Bai1_ChinhThuc.Areas.Product.Service;
using Bai1_ChinhThuc.Menu;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Bai1_ChinhThuc
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                string connectString = Configuration.GetConnectionString("AppAspMVC");
                options.UseSqlServer(connectString);
            });
            //Đăng ký mail
            services.AddOptions();
            var mailSetting = Configuration.GetSection("MailSetting");
            services.Configure<MailSettings>(mailSetting);
            services.AddSingleton<IEmailSender, SendMailService>();

            //Đăng ký Identity
            services.AddIdentity<AppUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>()
                .AddDefaultTokenProviders();

            services.AddControllersWithViews();

            services.AddRazorPages();

            services.AddTransient(typeof(ILogger<>), typeof(Logger<>));
            //Tạo vùng mới hiển thị view
            services.Configure<RazorViewEngineOptions>(option =>
            {
                //View/Controller/Action.cshtml

                // {0} -> Tên action
                //  {1} -> Tên Controller
                // {2} -> Tên Area
                option.ViewLocationFormats.Add("/MyView/{1}/{0}" + RazorViewEngine.ViewExtension);
            });

            services.Configure<IdentityOptions>(options => {
                // Thiết lập về Password
                options.Password.RequireDigit = false; // Không bắt phải có số
                options.Password.RequireLowercase = false; // Không bắt phải có chữ thường
                options.Password.RequireNonAlphanumeric = false; // Không bắt ký tự đặc biệt
                options.Password.RequireUppercase = false; // Không bắt buộc chữ in
                options.Password.RequiredLength = 3; // Số ký tự tối thiểu của password
                options.Password.RequiredUniqueChars = 1; // Số ký tự riêng biệt

                // Cấu hình Lockout - khóa user
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5); // Khóa 5 phút
                options.Lockout.MaxFailedAccessAttempts = 5; // Thất bại 5 lầ thì khóa
                options.Lockout.AllowedForNewUsers = true;

                // Cấu hình về User.
                options.User.AllowedUserNameCharacters = // các ký tự đặt tên user
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;  // Email là duy nhất

                // Cấu hình đăng nhập.
                options.SignIn.RequireConfirmedEmail = true;            // Cấu hình xác thực địa chỉ email (email phải tồn tại)
                options.SignIn.RequireConfirmedPhoneNumber = false;     // Xác thực số điện thoại

            });
            services.AddRazorPages();

            services.ConfigureApplicationCookie(option =>
            {
                option.LoginPath = "/login/";
                option.LogoutPath = "/logout/";
                option.AccessDeniedPath = "/accessdenied/";
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AllowEditorRole", policyBuilder =>
                {
                    policyBuilder.RequireAuthenticatedUser();
                    //policyBuilder.RequireRole("Admin");
                    //policyBuilder.RequireRole("Editor");
                    // Claims => Đặc tính, tính chất của một đối tượng (User)

                    policyBuilder.RequireClaim("can edit","user","post");
                });
                options.AddPolicy("ShowAdminMenu", policyBuilder =>
                {
                    policyBuilder.RequireAuthenticatedUser();
                    policyBuilder.RequireRole("Admin");
                });

                options.AddPolicy("InGenZ", policyBuilder =>
                {
                    policyBuilder.RequireAuthenticatedUser();
                    policyBuilder.Requirements.Add(new GenZRequirement());
                });
                options.AddPolicy("CanEditContact", policyBuilder =>
                {
                    policyBuilder.Requirements.Add(new CanEditContactRequirement());
                });
            });
            services.AddTransient<IAuthorizationHandler, AppAuthorizationHandler>();
            //Đăng ký dichj vụ session
            services.AddDistributedMemoryCache();           // Đăng ký dịch vụ lưu cache trong bộ nhớ (Session sẽ sử dụng nó)
            services.AddSession(cfg => {                    // Đăng ký dịch vụ Session
                cfg.Cookie.Name = "appmvc";             // Đặt tên Session - tên này sử dụng ở Browser (Cookie)
                cfg.IdleTimeout = new TimeSpan(1, 30, 0);    // Thời gian tồn tại của Session
            });
            services.AddTransient<CartService>();
            services.AddTransient<IActionContextAccessor, ActionContextAccessor>();
            services.AddTransient<AdminSideBarService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context, next) =>
            {
                context.Request.QueryString = context.Request.QueryString.Add("your_custom_key", "your_custom_value");
                await next.Invoke();
            });
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.UseStaticFiles(new StaticFileOptions(){
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(Directory.GetCurrentDirectory(),"Uploads")
                    ),
                RequestPath = "/contents"
            });
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "firstroute",
                    pattern: "/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapRazorPages();
            });
        }
    }
}
