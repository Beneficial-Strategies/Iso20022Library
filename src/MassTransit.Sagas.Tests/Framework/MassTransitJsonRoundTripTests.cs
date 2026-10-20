// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Concurrent;
using System.Text.Json;
using BeneficialStrategies.Iso20022.Serialization;
using static BeneficialStrategies.Iso20022.MassTransit.Sagas.reda.RequestToPayDebtorActivation.DebtorActivationFixtures;

namespace BeneficialStrategies.Iso20022.MassTransit.Sagas;

/// <summary>
/// What the saga events do on the wire (#70): they go through MassTransit's System.Text.Json serializer, and the library's
/// converters have to be registered with <c>ConfigureJsonSerializerOptions</c> for the ISO types to read back.
/// </summary>
/// <remarks>
/// There is deliberately no test that a bus <em>without</em> the converters drops the event: <c>ConfigureJsonSerializerOptions</c>
/// changes MassTransit's process-wide options, so once any bus in the test run has registered the converters every bus has them,
/// and such a test would depend on the order the tests run in. The README of the saga package says what happens without them.
/// </remarks>
public class MassTransitJsonRoundTripTests
{
    /// <summary>Remembers what a consumer received, and the JSON it arrived as.</summary>
    private sealed class Received
    {
        public ConcurrentBag<DebtorActivationAmendmentRequested> Events { get; } = [];
        public ConcurrentBag<string> Bodies { get; } = [];
        public ConcurrentBag<string> ContentTypes { get; } = [];
    }

    private sealed class CapturingConsumer(Received received) : IConsumer<DebtorActivationAmendmentRequested>
    {
        public Task Consume(ConsumeContext<DebtorActivationAmendmentRequested> context)
        {
            received.Events.Add(context.Message);
            received.Bodies.Add(context.ReceiveContext.Body.GetString());
            received.ContentTypes.Add(context.ReceiveContext.ContentType?.MediaType ?? "");
            return Task.CompletedTask;
        }
    }

    private static DebtorActivationAmendmentRequested AnEvent()
    {
        var amendment = AAmendment("MSG-AMEND-1", "MSG-ORIG-1").AmendmentData.Single();
        return new DebtorActivationAmendmentRequested(
            Guid.NewGuid(),
            "MSG-AMEND-1",
            new DateTime(2026, 1, 2, 3, 4, 5, DateTimeKind.Utc),
            AParty("Debtor RTP Service Provider"),
            0,
            amendment
        );
    }

    private static async Task<(ServiceProvider Provider, ITestHarness Harness, Received Received)> StartAsync(bool withLibraryConverters)
    {
        var received = new Received();
        var provider = new ServiceCollection()
            .WithGenerousTestTimeouts()
            .AddSingleton(received)
            .AddMassTransitTestHarness(cfg =>
            {
                cfg.AddConsumer<CapturingConsumer>();
                cfg.UsingInMemory(
                    (context, busCfg) =>
                    {
                        if (withLibraryConverters)
                            busCfg.ConfigureIso20022Json();
                        busCfg.ConfigureEndpoints(context);
                    }
                );
            })
            .BuildServiceProvider(true);
        var harness = provider.GetRequiredService<ITestHarness>();
        await harness.Start();
        return (provider, harness, received);
    }

    [Fact]
    public async Task AnEvent_WithListsAndAChoice_ArrivesEqual_ThroughMassTransitsJson()
    {
        var (provider, harness, received) = await StartAsync(withLibraryConverters: true);
        await using var scope = provider;
        var sent = AnEvent();

        await harness.Bus.Publish(sent);

        Assert.True(await harness.Consumed.Any<DebtorActivationAmendmentRequested>());
        var arrived = Assert.Single(received.Events);
        Assert.Equal(sent, arrived);   // records compare their members; the lists by item
        Assert.Equal(sent.Amendment.OriginalActivation.GetType(), arrived.Amendment.OriginalActivation.GetType());
        Assert.Contains("json", Assert.Single(received.ContentTypes));   // it really was serialized
    }

    [Fact]
    public async Task TheEventsOnTheWire_UseMassTransitsPropertyNames_NotTheIsoOnes()
    {
        var (provider, harness, received) = await StartAsync(withLibraryConverters: true);
        await using var scope = provider;

        await harness.Bus.Publish(AnEvent());
        Assert.True(await harness.Consumed.Any<DebtorActivationAmendmentRequested>());

        using var body = JsonDocument.Parse(Assert.Single(received.Bodies));
        var message = body.RootElement.GetProperty("message");
        // the event's own members, in MassTransit's camelCase; the library's naming policy is not applied to them
        Assert.True(message.TryGetProperty("messageIdentification", out _), message.ToString());
        Assert.True(message.TryGetProperty("initiatingParty", out _), message.ToString());
    }

    [Fact]
    public void WithoutTheLibrarysConverters_AValueListCannotBeRead_AsTheSagaTestsComment()
    {
        // Options like MassTransit's default ones: camel case, case-insensitive, and no converter for ValueList<T>.
        var plain = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, PropertyNameCaseInsensitive = true };
        var withList = new ValueList<string>(["a", "b"]);
        var json = JsonSerializer.Serialize(withList, plain);

        Assert.ThrowsAny<Exception>(() => JsonSerializer.Deserialize<ValueList<string>>(json, plain));
        Assert.Equal(withList, JsonSerializer.Deserialize<ValueList<string>>(json, Iso20022JsonSerializerOptions.Default));
    }
}
