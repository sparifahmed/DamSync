
namespace DamSync.Terminal.Models
{
    public class ListItem : Entity
    {
        public string ListItemId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public int FileSize { get; set; }
    }
}
