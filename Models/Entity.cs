using Postgrest.Attributes;
using Postgrest.Models;

namespace HollowDesk.Models 
{
    
    [Table("entities")]
    public class Entity : BaseModel
    {
        
        // Le paramètre "false" signifie que c'est la base de données qui gère l'ID (auto-incrément)
        [PrimaryKey("id", false)]
        public int Id { get; set; }

        [Column("Name")]
        public string Name { get; set; } = string.Empty;

        [Column("CodeName")]
        public string CodeName { get; set; } = string.Empty;

        [Column("ImagePath")]
        public string ImagePath { get; set; } = string.Empty;

        [Column("Dangerosity")]
        public Dangerosity Dangerosity { get; set; }

        [Column("CombatInfo")]
        public string CombatInfo { get; set; } = string.Empty;

        [Column("CurrentIntel")]
        public string CurrentIntel { get; set; } = string.Empty;

        [Column("Faction")]
        public string Faction { get; set; } = string.Empty;

        [Column("Type")]
        public string Type { get; set; } = string.Empty;

        [Column("ResFire")]
        public int ResFire { get; set; }

        [Column("ResElectric")]
        public int ResElectric { get; set; }

        [Column("ResIce")]
        public int ResIce { get; set; }

        [Column("ResEther")]
        public int ResEther { get; set; }

        [Column("ResPhysical")]
        public int ResPhysical { get; set; }

        [Column("ResWind")]
        public int ResWind { get; set; }


        public Entity() { }

        
    }
}