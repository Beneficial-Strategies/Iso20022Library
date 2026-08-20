// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="MandateAuthentication1"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _HSGqsGVVEeacpJ-gG9kyUQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Specifies the transport authentication details related to the mandate.
/// <list type="table">
///   <item><term>MessageAuthenticationCode</term><description>Max16Text — optional (0..1)</description></item>
///   <item><term>Date</term><description>ISODate — optional (0..1)</description></item>
///   <item><term>Channel</term><description>AuthenticationChannel1Choice_ — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: the <c>Channel</c> building block is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class MandateAuthentication1Validator : AbstractValidator<MandateAuthentication1>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>Channel</c> building block — e.g. resolved from a DI container —
    /// instead of this type constructing its own.
    /// </summary>
    /// <param name="channelValidator">
    /// Validator for the optional <c>Channel</c> building block (AuthenticationChannel1Choice_,
    /// 0..1) — only invoked when present.
    /// </param>
    public MandateAuthentication1Validator(IValidator<AuthenticationChannel1Choice_> channelValidator)
    {
        // MessageAuthenticationCode, Date: optional scalars, length/format enforced by struct
        // constructors — no rule needed.

        When(
            x => x.Channel is not null,
            () => RuleFor(x => x.Channel).SetValidator(channelValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: the <c>Channel</c> building block
    /// is validated by its own default validator
    /// (<see cref="AuthenticationChannel1Choice_Validator"/>). Convenience constructor for
    /// callers not using a DI container.
    /// </summary>
    public MandateAuthentication1Validator()
        : this(new AuthenticationChannel1Choice_Validator()) { }
}
