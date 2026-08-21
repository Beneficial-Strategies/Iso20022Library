// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="StructuredRemittanceInformation18"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _7sv01TEsEe6GxLzpkVnWYg
/// Spec source: queried via ISO 20022 MCP server (2026-08-21).
///
/// Information supplied to enable the matching/reconciliation of an entry with the items that
/// the payment is intended to settle, such as commercial invoices in an accounts' receivable
/// system, in a structured form.
/// <list type="table">
///   <item><term>AdditionalRemittanceInformation</term><description>Max140Text collection — optional (0..3), fully struct-enforced</description></item>
///   <item><term>CreditorReferenceInformation</term><description>CreditorReferenceInformation3 — optional (0..1)</description></item>
///   <item><term>GarnishmentRemittance</term><description>Garnishment4 — optional (0..1)</description></item>
///   <item><term>Invoicee</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>Invoicer</term><description>PartyIdentification272 — optional (0..1)</description></item>
///   <item><term>ReferredDocumentAmount</term><description>RemittanceAmount4 — optional (0..1)</description></item>
///   <item><term>ReferredDocumentInformation</term><description>ReferredDocumentInformation8 collection — optional (0..n)</description></item>
///   <item><term>TaxRemittance</term><description>TaxData1 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this component (no "constraint" declaration rows under
/// its ISO dictionary entry).
///
/// Note: MCP's <c>maxOccurs</c> facet for <c>AdditionalRemittanceInformation</c> is 3 (not
/// unbounded) — not independently enforceable at the FluentValidation layer without a dedicated
/// <c>Must</c> rule; left unenforced here as a minor, low-risk gap (same category as the tracked
/// Defect-2 minimum-collection-size gaps, but a maximum instead of a minimum).
///
/// Dependency injection: every building block above is validated by an injected
/// <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — the same
/// <see cref="PartyIdentification272"/> validator instance is reused across <c>Invoicee</c> and
/// <c>Invoicer</c> — see the two constructors below.
/// </remarks>
public class StructuredRemittanceInformation18Validator : AbstractValidator<StructuredRemittanceInformation18>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validators
    /// — e.g. resolved from a DI container — instead of this type constructing its own.
    /// </summary>
    public StructuredRemittanceInformation18Validator(
        IValidator<CreditorReferenceInformation3> creditorReferenceInformationValidator,
        IValidator<Garnishment4> garnishmentRemittanceValidator,
        IValidator<PartyIdentification272> partyValidator,
        IValidator<RemittanceAmount4> referredDocumentAmountValidator,
        IValidator<ReferredDocumentInformation8> referredDocumentInformationValidator,
        IValidator<TaxData1> taxRemittanceValidator
    )
    {
        When(
            x => x.CreditorReferenceInformation is not null,
            () => RuleFor(x => x.CreditorReferenceInformation).SetValidator(creditorReferenceInformationValidator!)
        );
        When(
            x => x.GarnishmentRemittance is not null,
            () => RuleFor(x => x.GarnishmentRemittance).SetValidator(garnishmentRemittanceValidator!)
        );
        When(x => x.Invoicee is not null, () => RuleFor(x => x.Invoicee).SetValidator(partyValidator!));
        When(x => x.Invoicer is not null, () => RuleFor(x => x.Invoicer).SetValidator(partyValidator!));
        When(
            x => x.ReferredDocumentAmount is not null,
            () => RuleFor(x => x.ReferredDocumentAmount).SetValidator(referredDocumentAmountValidator!)
        );
        RuleForEach(x => x.ReferredDocumentInformation).SetValidator(referredDocumentInformationValidator!);
        When(
            x => x.TaxRemittance is not null,
            () => RuleFor(x => x.TaxRemittance).SetValidator(taxRemittanceValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies. Convenience constructor for callers
    /// not using a DI container.
    /// </summary>
    public StructuredRemittanceInformation18Validator()
        : this(
            new CreditorReferenceInformation3Validator(),
            new Garnishment4Validator(),
            new PartyIdentification272Validator(),
            new RemittanceAmount4Validator(),
            new ReferredDocumentInformation8Validator(),
            new TaxData1Validator()
        ) { }
}
