// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRemittanceInformation18"/>
[IsoId("_7sv01TEsEe6GxLzpkVnWYg")]
[Description(
    @"Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts' receivable system, in a structured form."
)]
[DisplayName("Structured Remittance Information18")]
public partial record StructuredRemittanceInformation18
{
    /// <inheritdoc cref="IStructuredRemittanceInformation18.AdditionalRemittanceInformation"/>
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    public SimpleValueList<IsoMax140Text> AdditionalRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="IStructuredRemittanceInformation18.CreditorReferenceInformation"/>
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation3? CreditorReferenceInformation { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation18.GarnishmentRemittance"/>
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    public Garnishment4? GarnishmentRemittance { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation18.Invoicee"/>
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification272? Invoicee { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation18.Invoicer"/>
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification272? Invoicer { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation18.ReferredDocumentAmount"/>
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount4? ReferredDocumentAmount { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation18.ReferredDocumentInformation"/>
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation8> ReferredDocumentInformation { get; init; } = [];

    /// <inheritdoc cref="IStructuredRemittanceInformation18.TaxRemittance"/>
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    public TaxData1? TaxRemittance { get; init; }
}
