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
        public int _currentYes { get; set; }
        public int _currentNo { get; set; }

        public string GetNextNarration(int Id)
        {
            //go retrieve the row from the narration table that matches the Id arg
            KotareParableDBcontext context = new KotareParableDBcontext();
            //context.Narrations.

            //_currentYes = row.Yes
            //_currentNo = row.No
            //_currentId = row.Id

            //

            return "nextNarration";
        }

        public bool GameIsActive()
        {
            //if id 99 comes back, set to false
            return true;
        } 

        //public void

    }
}
