// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRemittanceInformation12"/>
[IsoId("_W8isJx77EeSxevWRRWxNAg")]
[DisplayName("Structured Remittance Information")]
public partial record StructuredRemittanceInformation12
{
    /// <inheritdoc cref="IStructuredRemittanceInformation12.ReferredDocumentInformation"/>
    [IsoId("_XN5h4x77EeSxevWRRWxNAg")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation6> ReferredDocumentInformation { get; init; } = [];

    /// <inheritdoc cref="IStructuredRemittanceInformation12.ReferredDocumentAmount"/>
    [IsoId("_XN5h5R77EeSxevWRRWxNAg")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount2? ReferredDocumentAmount { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation12.CreditorReferenceInformation"/>
    [IsoId("_XN5h5x77EeSxevWRRWxNAg")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation12.Invoicer"/>
    [IsoId("_XN5h6R77EeSxevWRRWxNAg")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification43? Invoicer { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation12.Invoicee"/>
    [IsoId("_XN5h6x77EeSxevWRRWxNAg")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification43? Invoicee { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation12.TaxRemittance"/>
    [IsoId("_WWEskh78EeSxevWRRWxNAg")]
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    public TaxInformation4? TaxRemittance { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation12.GarnishmentRemittance"/>
    [IsoId("_WWKzMB78EeSxevWRRWxNAg")]
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    public Garnishment1? GarnishmentRemittance { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation12.AdditionalRemittanceInformation"/>
    [IsoId("_XN5h7R77EeSxevWRRWxNAg")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<string> AdditionalRemittanceInformation { get; init; } = [];
}
