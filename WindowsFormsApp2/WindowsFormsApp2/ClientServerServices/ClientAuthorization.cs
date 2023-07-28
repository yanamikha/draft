using Auth;
using Authenticity;
using ClientServerServices.Exceptions;
using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace ClientServerServices
{
    public static class ClientAuthorization
    {
        private static Channel channel;
        private static AuthorizationService.AuthorizationServiceClient authorization;
        static ClientAuthorization()
        {
            channel = ClientChannel.GetChannel();
            authorization = new AuthorizationService.AuthorizationServiceClient(channel);
        }

        public static async Task<string> AuthorizeAsync(string login, string password)
        {
            try
            {
                User user = new User { Log = login, Pass = password };
                Token token = await authorization.LogInAsync(user);
                return token.Value;
            }
            catch (RpcException exc)
            {
                if (exc.StatusCode == StatusCode.NotFound)
                {
                    throw new AuthorizationException("Виникла помилка під час авторизації.\nПереконайтесь у коректності введених даних.", exc);
                }
                else
                {
                    throw new AuthorizationException(exc.Message, exc);
                }
            }
        }

    }
}
