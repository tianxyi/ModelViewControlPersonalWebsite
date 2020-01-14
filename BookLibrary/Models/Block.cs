using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookLibrary.Models
{
    public class Block
    {
        public int BlockId { get; set; }
        public string Title { get; set; }

        [Column(TypeName="ntext")]
        public string Text { get; set; }

        public string Diagram { get; set; }
        public string Photo { get; set;}
        public string Genre { get; set; }

        public ICollection<Record> Records { get; set; }
    }
    public class Record
    {
    public Record()
    {
      Time = DateTime.Now;
    }
        public int RecordId { get; set; }
        public string Name { get; set; }

        [Column(TypeName ="ntext")]
        public string Comment { get; set; }

        public DateTime Time { get; set; }
        
        public int? BlockId { get; set; }//farent?? id map lecture onto the courese
        public Block Block { get; set; }//navigation property easy to get data . dont have to take id get course from database
    }


}
