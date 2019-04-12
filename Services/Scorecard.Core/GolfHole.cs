using System;
using System.ComponentModel.DataAnnotations;

namespace Scorecard.Core
{
    public class GolfHole
    {

        public enum TeeType
        {
            Womans,
            Mens,
            Champion,
            Pro,
        }

        [Required]
        public int HoleNum { get; set;}
        public TeeType Tee {get; set;}
        public int Par {get; set;}

        public int PlayerScore {get; set;}

    }
}
