// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GroupHeader104"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _7o6soQcYEeyTDbUIoCmuCw
/// Spec source: queried via ISO 20022 MCP server (2026-08-25).
///
/// Set of characteristics shared by all individual instructions included in the message.
/// <list type="table">
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1); length enforced by struct constructor — no rule needed</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1); lexical form enforced by struct constructor — no rule needed</description></item>
///   <item><term>NumberOfSettlementRequests</term><description>Max15NumericText — required (1..1); pattern enforced by struct constructor — no rule needed</description></item>
///   <item><term>ControlSum</term><description>DecimalNumber — optional (0..1)</description></item>
///   <item><term>SettlementInformation</term><description>SettlementInstruction14 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry — no rule ties ControlSum to the sum of the settlement requests'
/// movement amounts, unlike some other GroupHeader variants elsewhere in the spec).
///
/// Dependency injection: <c>SettlementInformation</c> is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class GroupHeader104Validator : AbstractValidator<GroupHeader104>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the optional <c>SettlementInformation</c> building block — e.g. resolved from a DI
    /// container — instead of this type constructing its own.
    /// </summary>
    /// <param name="settlementInformationValidator">
    /// Validator for the optional <c>SettlementInformation</c> building block
    /// (SettlementInstruction14, 0..1) — only invoked when present.
    /// </param>
    public GroupHeader104Validator(IValidator<SettlementInstruction14> settlementInformationValidator)
    {
        // MessageIdentification, NumberOfSettlementRequests: required scalars, format/length
        // enforced by struct constructors — no rule needed.
        // CreationDateTime: required, lexical form enforced by struct constructor — no rule needed.
        // ControlSum: optional decimal, no spec-declared range constraint — no rule needed.

        When(
            x => x.SettlementInformation is not null,
            () => RuleFor(x => x.SettlementInformation).SetValidator(settlementInformationValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>SettlementInformation</c> is
    /// validated by its own default validator (<see cref="SettlementInstruction14Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public GroupHeader104Validator()
        : this(new SettlementInstruction14Validator()) { }
}
