// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="GroupHeader124"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _5P03sTEyEe6g-ffJsqGiSA
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Provides characteristics shared by all individual transactions included in the message.
/// <list type="table">
///   <item><term>Authorisation</term><description>Authorisation1Choice_ collection — optional (0..2)</description></item>
///   <item><term>ControlSum</term><description>DecimalNumber — optional (0..1), fully struct-enforced</description></item>
///   <item><term>CreationDateTime</term><description>ISODateTime — required (1..1), fully struct-enforced</description></item>
///   <item><term>CreditorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>DebtorAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>ForwardingAgent</term><description>BranchAndFinancialInstitutionIdentification8 — optional (0..1)</description></item>
///   <item><term>GroupReversal</term><description>TrueFalseIndicator — optional (0..1), fully struct-enforced; drives the message-level cross-field rules on <see cref="CustomerPaymentReversalV13Validator"/></description></item>
///   <item><term>InitiatingParty</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>MessageIdentification</term><description>Max35Text — required (1..1), fully struct-enforced</description></item>
///   <item><term>NumberOfTransactions</term><description>Max15NumericText — required (1..1), fully struct-enforced</description></item>
/// </list>
///
/// No cross-field constraints attach directly to this component — the four real cross-field
/// rules referencing <c>GroupHeader/GroupReversal</c> (<c>GroupReversalAndPaymentInformationNotPresentRule</c>,
/// <c>GroupReversalAndReasonRule</c>, <c>GroupReversalAndNumberOfTransactionsGuideline</c>,
/// <c>GroupReversalAndPaymentInformationPresentRule</c>) span multiple top-level message building
/// blocks and are enforced on <see cref="CustomerPaymentReversalV13Validator"/> instead, where
/// both sides of each rule are visible.
///
/// Note: MCP's <c>maxOccurs</c> facet for <c>Authorisation</c> is 2 (not unbounded) — not
/// independently enforceable at the FluentValidation layer without a dedicated <c>Must</c> rule;
/// left unenforced here as a minor, low-risk gap (same category as the tracked Defect-2
/// minimum-collection-size gaps, but a maximum instead of a minimum).
///
/// Dependency injection: <c>Authorisation</c>, <c>CreditorAgent</c>/<c>DebtorAgent</c>/
/// <c>ForwardingAgent</c>, and <c>InitiatingParty</c> are each validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — the same
/// <see cref="BranchAndFinancialInstitutionIdentification8"/> validator instance is reused across
/// all three agent fields — see the two constructors below.
/// </remarks>
public class GroupHeader124Validator : AbstractValidator<GroupHeader124>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public GroupHeader124Validator(
        IValidator<Authorisation1Choice_> authorisationValidator,
        IValidator<BranchAndFinancialInstitutionIdentification8> agentValidator,
        IValidator<PartyIdentification272> initiatingPartyValidator
    )
    {
        RuleForEach(x => x.Authorisation).SetValidator(authorisationValidator!);
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
    public GroupHeader124Validator()
        : this(
            new Authorisation1Choice_Validator(),
            new BranchAndFinancialInstitutionIdentification8Validator(),
            new PartyIdentification272Validator()
        ) { }
}
