using System;
using System.Collections.Generic;
using System.Text;

namespace HollowDesk.Models
{
    class Entity
    {
            public Entity(string Name,string codeName , string imagePath, Dangerosity dangerosity, string combatInfo, string currentIntel, string FactionName, string TypeName, int ResFire, int ResElectric, int ResIce, int ResEther, int ResPhysical, int ResWind )
            {
            this.Name = Name;
            this.CodeName = codeName;
            this.ImagePath = imagePath;
            this.Dangerosity = dangerosity;
            this.CombatInfo = combatInfo;
            this.CurrentIntel = currentIntel;
            this.FactionName = FactionName;
            this.TypeName = TypeName;
            this.ResFire = ResFire;
            this.ResElectric = ResElectric;
            this.ResIce = ResIce;
            this.ResEther = ResEther;
            this.ResPhysical = ResPhysical;
            this.ResWind = ResWind;
        }

        
        required
        public string CodeName { get; set; }

        public string Name { get; set; }
        public string ImagePath { get; set; }
        public Dangerosity Dangerosity { get; set; }
        public string CombatInfo { get; set; }
        public string CurrentIntel { get; set; }
        public string FactionName { get; set; }
        public string TypeName { get; set; }
        public int ResFire { get; set; } = 0;
        public int ResElectric   { get; set; } = 0;
        public int ResIce { get; set; } = 0;
        public int ResEther { get; set;} = 0;
        public int ResPhysical { get; set; } = 0;
        public int ResWind { get; set; } = 0;

    }
}
