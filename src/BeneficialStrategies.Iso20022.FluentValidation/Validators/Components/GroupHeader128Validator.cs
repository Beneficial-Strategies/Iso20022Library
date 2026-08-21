// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GroupHeader128"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _6hTGoTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides the characteristics shared by all individual transactions included in the message.
/// <list type="table">
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1), fully struct-enforced</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>ForwardingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InitiatingParty</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>CreditorAgent</c>/<c>DebtorAgent</c>/<c>ForwardingAgent</c> and
/// <c>InitiatingParty</c> are each validated by an injected <see cref="IValidator{T}"/> rather
/// than a hardcoded <c>new</c> — the same <see cref="BranchAndFinancialInstitutionIdentification8"/>
/// validator instance is reused across all three agent fields — see the two constructors below.
/// </remarks>
public class GroupHeader128Validator : AbstractValidator<GroupHeader128>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public GroupHeader128Validator(
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<PartyIdentification272> initiatingPartyValidator
    )
    {
        When(x => x.CreditorAgent is not null, () => RuleFor(x => x.CreditorAgent).SetValidator(agentValidator!));
        When(x => x.DebtorAgent is not null, () => RuleFor(x => x.DebtorAgent).SetValidator(agentValidator!));
        When(
            x => x.ForwardingAgent is not null,
            () => RuleFor(x => x.ForwardingAgent).SetValidator(agentValidator!)
        );
        When(
            x => x.InitiatingParty is not null,
            () => RuleFor(x => x.InitiatingParty).SetValidator(initiatingPartyValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public GroupHeader128Validator()
        : this(new BranchAndFinancialInstitutionIdentification8Validator(), new PartyIdentification272Validator()) { }
}
