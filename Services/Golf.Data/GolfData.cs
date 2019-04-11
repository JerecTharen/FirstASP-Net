using System;
using System.Linq;
using System.Collections.Generic;
using Scorecard.Core;

namespace Golf.Data
{

    public interface IGolfData
    {
        IEnumerable<GolfHole> GetAll();
        IEnumerable<GolfHole> GetHolesByName(int holeId);
        GolfHole GetHoleByNum(int holeNum);
    }

    public class InMemoryGolfHoleData: IGolfData
    {
        List<GolfHole> holes;

        public InMemoryGolfHoleData(){
            holes = new List<GolfHole>{
                new GolfHole {HoleNum = 1, Tee = GolfHole.TeeType.Mens, Par = 4, PlayerScore = -1},
                new GolfHole {HoleNum = 2, Tee = GolfHole.TeeType.Mens, Par = 3, PlayerScore = -1},
                new GolfHole {HoleNum = 3, Tee = GolfHole.TeeType.Mens, Par = 7, PlayerScore = -1},
            };
        }
        public IEnumerable<GolfHole> GetAll(){
            return from h in holes
                orderby h.HoleNum
                select h;
        }
        public IEnumerable<GolfHole> GetHolesByName(int holeId){
            return from h in holes
                where h.HoleNum == holeId
                orderby h.HoleNum
                select h;
        }

        public GolfHole GetHoleByNum (int holeNum){
            return holes.SingleOrDefault(h => h.HoleNum == holeNum);
        }
    }
}
