namespace Bai1_ChinhThuc.Model
{
    public class Summernote
    {
        public string IDeditor { get; set; }
        public bool LoadLibrary { get; set; }
        public int height { get; set; } = 120;
        public string toolbar { get; set; } = @"[
                ['style', ['style']],
                ['font', ['bold', 'underline', 'clear']],
                ['color', ['color']],
                ['para', ['ul', 'ol', 'paragraph']],
                ['table', ['table']],
                ['insert', ['link', 'picture', 'video', 'elfinder']],
                ['view', ['fullscreen', 'codeview', 'help']]
            ]";
        public Summernote(string _IDeditor, bool _LoadLubrary = true)
        {
            IDeditor = _IDeditor;
            LoadLibrary = _LoadLubrary;
        }
    }
}
