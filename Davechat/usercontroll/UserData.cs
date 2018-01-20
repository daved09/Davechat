using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davechat.usercontroll
{
    class UserData
    {

        public UserData() : this("User")
        {
        }

        public UserData(string UserName)
        {
            this.UserName = UserName;
            Initalize();
        }
    
        public string UserName { get; set; }
        private List<String> Messages;

        //initalizer
        private void Initalize()
        {
            Messages = new List<string>();
        }


    }
}
