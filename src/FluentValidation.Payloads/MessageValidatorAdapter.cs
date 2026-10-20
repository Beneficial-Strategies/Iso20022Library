// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Payloads;

/// <summary>
/// Lets the validator of a message interface be resolved as <c>IValidator&lt;TheRecord&gt;</c>, so code that
/// validates one of our message records (and the XML and JSON envelope validators, which deserialize to the record)
/// keeps working. All rules are those of the interface validator; the adapter only forwards.
/// </summary>
internal sealed class MessageValidatorAdapter<TRecord, TInterface> : AbstractValidator<TRecord>
    where TRecord : class, TInterface
    where TInterface : class
{
    private readonly IValidator<TInterface> _inner;

    public MessageValidatorAdapter(IValidator<TInterface> inner) => _inner = inner;

    public override ValidationResult Validate(ValidationContext<TRecord> context) =>
        _inner.Validate(new ValidationContext<TInterface>(context.InstanceToValidate));

    public override Task<ValidationResult> ValidateAsync(
        ValidationContext<TRecord> context,
        CancellationToken cancellation = default
    ) => _inner.ValidateAsync(new ValidationContext<TInterface>(context.InstanceToValidate), cancellation);
}

/// <summary>Finds the record of a message interface.</summary>
internal static class MessageValidatorAdapters
{
    /// <summary>The message record that implements <paramref name="messageInterface"/>, from the registry, or null.</summary>
    public static Type? RecordOf(Type messageInterface) =>
        Iso20022MessageTypeRegistry.ByIsoIdentifier.Values.FirstOrDefault(record => messageInterface.IsAssignableFrom(record));

    /// <summary>The message interface of a record (the one named <c>I</c> + its name), or null.</summary>
    public static Type? InterfaceOf(Type record) =>
        record.GetInterfaces().FirstOrDefault(i => i.Name == "I" + record.Name && typeof(IOuterRecord).IsAssignableFrom(i));
}
