// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GroupHeader112"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _yI87oTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-20).
///
/// Set of characteristics shared by all individual transactions included in the message.
/// <list type="table">
///   <item><term>ControlSum</term><description>DecimalNumber — optional (0..1), fully struct-enforced</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1), fully struct-enforced</description></item>
///   <item><term>ForwardingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InitiatingParty</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>NumberOfTransactions</term><description>Max15NumericText — required (1..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Dependency injection: <c>ForwardingAgent</c> and <c>InitiatingParty</c> are each validated by
/// an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
///
/// Known test-coverage gap (2026-08-21): the test suite's happy-path case supplies
/// <c>ForwardingAgent</c>/<c>InitiatingParty</c> instances with no field values populated beyond
/// what's structurally required, so none of <see cref="BranchAndFinancialInstitutionIdentification8Validator"/>'s
/// or <see cref="PartyIdentification272Validator"/>'s conditional rules ever trigger — the test
/// produces zero validation errors whether or not the <c>SetValidator</c> calls below are
/// actually present. A future pass should add a case that populates a nested field with a value
/// a populated <see cref="IExternalCodeRegistry{TCode}"/> would reject, to close this gap.
/// </remarks>
public class GroupHeader112Validator : AbstractValidator<GroupHeader112>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public GroupHeader112Validator(
        IValidator<BranchAndFinancialInstitutionIdentification8> forwardingAgentValidator,
        IValidator<PartyIdentification272> initiatingPartyValidator
    )
    {
        When(
            x => x.ForwardingAgent is not null,
            () => RuleFor(x => x.ForwardingAgent).SetValidator(forwardingAgentValidator!)
        );
        RuleFor(x => x.InitiatingParty).SetValidator(initiatingPartyValidator!);
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public GroupHeader112Validator()
        : this(
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new PartyIdentification272Validator()
        ) { }
}
