// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="ProxyAccountIdentification1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _luR59Xh2EeidzqjNEfehPg
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Information related to a proxy identification of the account.
/// <list type="table">
///   <item><term>Type</term><description>ProxyAccountType1Choice_ — optional (0..1)</description></item>
///   <item><term>Identification</term><description>Max2048Text — required (1..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>Type</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class ProxyAccountIdentification1Validator : AbstractValidator<ProxyAccountIdentification1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>Type</c> building block — e.g. resolved from a DI container — instead
    /// of this type constructing its own.
    /// </summary>
    /// <param name="typeValidator">
    /// Validator for the optional <c>Type</c> building block (ProxyAccountType1Choice_, 0..1) —
    /// only invoked when present.
    /// </param>
    public ProxyAccountIdentification1Validator(IValidator<ProxyAccountType1Choice_> typeValidator)
    {
        // Identification: Max2048Text, required (1..1) and already `required` C# property —
        // length enforced by struct constructor.

        When(x => x.Type is not null, () => RuleFor(x => x.Type).SetValidator(typeValidator!));
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Type</c> building block is
    /// validated by its own default validator (<see cref="ProxyAccountType1Choice_Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public ProxyAccountIdentification1Validator()
        : this(new ProxyAccountType1Choice_Validator()) { }
}
