using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotareParable
{
    class Model
    {
        public int _currentId { get; set; }
        //public int _currentYes { get; set; }
        //public int _currentNo { get; set; }

        public string GetNextNarration(int Id)
        {
            //go retrieve the row from the narration table that matches the Id arg
            KotareParableDBcontext context = new KotareParableDBcontext();
            Narration n = context.Narrations.Find(Id);
            
            //_currentYes = n.Yes;
            //_currentNo = n.No;
            _currentId = n.Id;

            return n.Statement;
        }

        public int CheckResponse(string response)
        {
            KotareParableDBcontext context = new KotareParableDBcontext();
            List<Response> list = context.Responses.ToList();
            int index = list.FindIndex(x => x.Statement == response);
            if (!(index >= 0))
            {
                return 0;
            }

            Response r = list.Find(x => x.Statement == response);
            List<NtoR> joins = context.NarrationJoinResponses.ToList();
            var NjR = joins.Find(x => x.ResponseId == r.Id);

            return NjR.NarrationId;
        }

        public bool GameIsActive()
        {
            //if id 999 comes back, set to false
            if (this._currentId == 999)
            {
                return false;
            }
            return true;
        } 

    }
}
