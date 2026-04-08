using Microsoft.Agents.AI;
using SupportAgentDemo.Tools;
using SupportAgentDemo.Workflows;

Console.WriteLine("Microsoft Agent Framework (.NET 10) Demo");
while (true)
{
    Console.Write("Customer: ");
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input)) break;

    Console.WriteLine(TicketLookupTool.GetCustomerStatus("CUST-100"));
    Console.WriteLine(EscalationWorkflow.Run(input));
}
