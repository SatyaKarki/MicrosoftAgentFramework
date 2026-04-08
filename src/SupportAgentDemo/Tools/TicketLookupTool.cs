namespace SupportAgentDemo.Tools;
public static class TicketLookupTool
{
    public static string GetCustomerStatus(string id) =>
        id == "CUST-100" ? "Premium customer" : "Unknown";
}
