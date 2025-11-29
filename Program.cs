string pergunta, resposta;
const string tchau = "tchau";

Console.WriteLine("--- Groot Chatbot ---");

do
{

Console.Write("Pergunta:");
pergunta = Console.ReadLine()!;


resposta = eusougroot(pergunta);
exibe(eusougroot(pergunta));

} while (pergunta.Trim().ToLower() !=tchau);

void exibe(string resposta)
{
    Console.WriteLine($"Resposta: {resposta}");
}
string eusougroot(string pergunta)
{
    return pergunta.Trim().ToLower() == tchau ?
        "Eu sou Groot!" :
        "Eu sou Groot.";
}