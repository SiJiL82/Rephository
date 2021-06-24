using System;

namespace Rephository.Models
{
    public class Photo
    {
        public int ID { get; set; }
        public string FileName { get; set; }
        public string RelativePath { get; set; }
        public DateTime CreationDate { get; set; }
        public string Hash { get; set; }
        public DateTime UploadDate { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsArchived { get; set; }
        public int OwnerID { get; set; }


    }
}