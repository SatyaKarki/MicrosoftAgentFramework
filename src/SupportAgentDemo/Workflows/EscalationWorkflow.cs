namespace SupportAgentDemo.Workflows;
public static class EscalationWorkflow
{
    public static string Run(string issue) =>
        issue.Contains("payment", StringComparison.OrdinalIgnoreCase)
        ? "Escalate to Billing Team"
        : "Handle in Support Queue";
}
