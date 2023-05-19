using OpenAI_API;
class Program
{
    static async Task Main(string[] args)
    {
        // Loop para poder fazer mais de uma pergunta com o mesmo console
        while (true)
        {
            // https://platform.openai.com/account/api-keys
            // Cria uma instancia da classe APIAuthentication com a sua chave API
            var autenticacao = new APIAuthentication("suaChaveAqui");

            // Cria uma instancia da classe OpenAIAPI com o objeto APIAuthentication
            var api = new OpenAIAPI(autenticacao);

            // Cria uma nova conversa com o ChatGPT
            var conversa = api.Chat.CreateConversation();

            // Pega o input perguntado usuario
            Console.Write("Faça uma pergunta ao chat: ");
            string? pergunta = Console.ReadLine();

            // Anexa pergunta ao objeto Conversa
            conversa.AppendUserInput(pergunta);

            // Traz a resposta do from ChatGPT
            string resposta = await conversa.GetResponseFromChatbotAsync();
            Console.WriteLine("\n" + resposta + "\n");

            // Adicionar um tracejado para ficar mais facil de ler
            Console.WriteLine("----------------------------------------------\n");


        }
    }
}