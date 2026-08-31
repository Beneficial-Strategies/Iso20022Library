// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace RequestToPayDebtorActivation.Demo.Diagnostics;

/// <summary>
/// Proves — rather than merely asserts — that MassTransit's in-memory transport genuinely
/// serializes and deserializes every message, exactly as a real broker transport would.
/// </summary>
/// <remarks>
/// SIMULATING: nothing — this is not a simulation. <c>ConsumeContext.ReceiveContext.Body</c> is
/// the literal byte stream this consumer's message was deserialized FROM. Printing it demonstrates
/// that "in-memory queueing" here is not two components sharing a .NET object reference in
/// process: the object gets encoded to JSON on publish and decoded back on consume, on every hop,
/// the same as it would over RabbitMQ, Azure Service Bus, or any other real transport. This was
/// discovered the hard way while building BeneficialStrategies.Iso20022.MassTransit.Sagas itself —
/// without merging <c>Iso20022JsonSerializerOptions.Default</c>'s converters into MassTransit's own
/// JSON options, <c>ValueList&lt;T&gt;</c> deserialization threw <c>NotSupportedException</c> at
/// runtime specifically because a real serialize/deserialize round-trip was happening.
/// </remarks>
internal sealed class WireSerializationObserver : IConsumeObserver
{
    public Task PreConsume<T>(ConsumeContext<T> context)
        where T : class
    {
        var raw = context.ReceiveContext.Body.GetString();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine($"    [wire] {typeof(T).Name} deserialized from {raw.Length} bytes of real JSON:");
        Console.WriteLine($"    {Truncate(raw, 300)}");
        Console.ResetColor();
        return Task.CompletedTask;
    }

    public Task PostConsume<T>(ConsumeContext<T> context)
        where T : class => Task.CompletedTask;

    public Task ConsumeFault<T>(ConsumeContext<T> context, Exception exception)
        where T : class => Task.CompletedTask;

    private static string Truncate(string value, int maxLength) =>
        value.Length <= maxLength ? value : value[..maxLength] + " …";
}
