using Microsoft.AspNet.SignalR;


namespace SignalRChat
{
    public class ChatHub : Hub
    {
        //hub sınıfımız clientlar ile server arasında bağlantı kurar 
        //gelen mesajı diğer tüm clientlara iletmemizi sağlar 
        public void Send(string username, string message)
        {
            Clients.All.sendMessage(username, message);
        }
    }
}