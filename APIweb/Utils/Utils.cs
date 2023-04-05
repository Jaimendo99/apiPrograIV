
using APIweb.Models;

namespace APIweb.Utils
{
    public class Utils
    {
        public static List<Client> clients = new List<Client>
        {
            new Client()
            {
                id=1,
                name="jaime",
                email="jaimendo@gmail.com",
                phoneNumber="65432"
            },
            new Client()
            {
                id=2,
                name="josue",
                email="jaimendo@gmail.com",
                phoneNumber="2345"
            },
            new Client()
            {
                id=3,
                name="mendoza",
                email="jaimendo@gmail.com",
                phoneNumber="098765"
            },
        };

    }
}
