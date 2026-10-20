// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas;

/// <summary>
/// The MassTransit test harness answers <c>Any()</c> with <c>false</c> as soon as no message activity has been seen for its
/// inactivity timeout (about a second by default). A freshly started in-memory bus on a busy CI runner can take longer than
/// that for its first message, and a positive assertion such as <c>Assert.True(await sagaHarness.Created.Any())</c> then fails
/// although nothing is wrong (#30). A longer timeout only costs time in the few tests that assert that something did NOT happen.
/// </summary>
internal static class TestHarnessTimeouts
{
    public static IServiceCollection WithGenerousTestTimeouts(this IServiceCollection services) =>
        services.Configure<TestHarnessOptions>(options =>
        {
            options.TestInactivityTimeout = TimeSpan.FromSeconds(5);
            options.TestTimeout = TimeSpan.FromSeconds(60);
        });
}
