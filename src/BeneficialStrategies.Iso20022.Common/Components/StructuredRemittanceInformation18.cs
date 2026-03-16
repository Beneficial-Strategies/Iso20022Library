// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured Remittance Information18.
/// </summary>
[IsoId("_7sv01TEsEe6GxLzpkVnWYg")]
[DisplayName("Structured Remittance Information18")]
public record StructuredRemittanceInformation18
{
    /// <summary>
    /// Additional Remittance Information.
    /// </summary>
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    public IsoMax140Text? AdditionalRemittanceInformation { get; init; }

    /// <summary>
    /// Creditor Reference Information.
    /// </summary>
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation3? CreditorReferenceInformation { get; init; }

    /// <summary>
    /// Garnishment Remittance.
    /// </summary>
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    public Garnishment4? GarnishmentRemittance { get; init; }

    /// <summary>
    /// Invoicee.
    /// </summary>
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification272? Invoicee { get; init; }

    /// <summary>
    /// Invoicer.
    /// </summary>
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification272? Invoicer { get; init; }

    /// <summary>
    /// Referred Document Amount.
    /// </summary>
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount4? ReferredDocumentAmount { get; init; }

    /// <summary>
    /// Referred Document Information.
    /// </summary>
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation8> ReferredDocumentInformation { get; init; } = [];

    /// <summary>
    /// Tax Remittance.
    /// </summary>
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    public TaxData1? TaxRemittance { get; init; }
}
