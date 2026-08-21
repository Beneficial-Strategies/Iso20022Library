// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GroupHeader114"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _yjuzITEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Set of characteristics shared by all individual transactions included in the message.
/// <list type="table">
///   <item><term>Authorisation</term><description>Authorisation1Choice_ collection — optional (0..2)</description></item>
///   <item><term>ControlSum</term><description>DecimalNumber — optional (0..1), fully struct-enforced</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1), fully struct-enforced</description></item>
///   <item><term>ForwardingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>InitiatingParty</term><description>PartyIdentification272 — required (1..1)</description></item>
///   <item><term>InitiationSource</term><description>PaymentInitiationSource1 — optional (0..1)</description></item>
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>NumberOfTransactions</term><description>Max15NumericText — required (1..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Note: MCP's <c>maxOccurs</c> facet for <c>Authorisation</c> is 2 (not unbounded) — not
/// independently enforceable at the FluentValidation layer without a dedicated <c>Must</c> rule;
/// left unenforced here as a minor, low-risk gap (same category as the tracked Defect-2
/// minimum-collection-size gaps, but a maximum instead of a minimum).
///
/// Dependency injection: <c>Authorisation</c>, <c>ForwardingAgent</c>, <c>InitiatingParty</c>,
/// and <c>InitiationSource</c> are each validated by an injected <see cref="IValidator{T}"/>
/// rather than a hardcoded <c>new</c> — see the two constructors below.
/// </remarks>
public class GroupHeader114Validator : AbstractValidator<GroupHeader114>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public GroupHeader114Validator(
        IValidator<Authorisation1Choice_> authorisationValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> forwardingAgentValidator,
        IValidator<PartyIdentification272> initiatingPartyValidator,
        IValidator<PaymentInitiationSource1> initiationSourceValidator
    )
    {
        RuleForEach(x => x.Authorisation).SetValidator(authorisationValidator!);
        When(
            x => x.ForwardingAgent is not null,
            () => RuleFor(x => x.ForwardingAgent).SetValidator(forwardingAgentValidator!)
        );
        RuleFor(x => x.InitiatingParty).SetValidator(initiatingPartyValidator!);
        When(
            x => x.InitiationSource is not null,
            () => RuleFor(x => x.InitiationSource).SetValidator(initiationSourceValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public GroupHeader114Validator()
        : this(
            new Authorisation1Choice_Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new PartyIdentification272Validator(),
            new PaymentInitiationSource1Validator()
        ) { }
}
