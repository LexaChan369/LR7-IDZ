using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    internal class UserStorage
    {
        private Dictionary<AuthorizeInfo, UserInfo> data;

        public UserStorage()
        {
            data= new Dictionary<AuthorizeInfo, UserInfo>();
            data.Add(new AuthorizeInfo("Belik", "1"), new UserInfo("Belik A.I.", "belik@mail.ru","Stavropol"));
            data.Add(new AuthorizeInfo("Gevorgyan", "2"), new UserInfo("Gevorgyan F.A.", "gevorgyan@list.ru", "Moscow"));
            data.Add(new AuthorizeInfo("Danilov", "3"), new UserInfo("Danilov E.D.", "danilov@yandex.ru", "Sevostopol"));
        }

        public UserInfo GetUser(AuthorizeInfo ob)
        {
            if(data.ContainsKey(ob)) return data[ob];
            else return null;
        }
    }
}
