// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRemittanceInformation15"/>
[IsoId("_svCZ0bTMEeeYQd8Z9bqFog")]
[DisplayName("Structured Remittance Information")]
public partial record StructuredRemittanceInformation15
{
    /// <inheritdoc cref="IStructuredRemittanceInformation15.ReferredDocumentInformation"/>
    [IsoId("_s3jco7TMEeeYQd8Z9bqFog")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation7> ReferredDocumentInformation { get; init; } = [];

    /// <inheritdoc cref="IStructuredRemittanceInformation15.ReferredDocumentAmount"/>
    [IsoId("_s3jcpbTMEeeYQd8Z9bqFog")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount2? ReferredDocumentAmount { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation15.CreditorReferenceInformation"/>
    [IsoId("_s3jcp7TMEeeYQd8Z9bqFog")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation15.Invoicer"/>
    [IsoId("_s3jcqbTMEeeYQd8Z9bqFog")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification125? Invoicer { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation15.Invoicee"/>
    [IsoId("_s3jcq7TMEeeYQd8Z9bqFog")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification125? Invoicee { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation15.TaxRemittance"/>
    [IsoId("_s3jcrbTMEeeYQd8Z9bqFog")]
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    public TaxInformation7? TaxRemittance { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation15.GarnishmentRemittance"/>
    [IsoId("_s3jcr7TMEeeYQd8Z9bqFog")]
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    public Garnishment2? GarnishmentRemittance { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation15.AdditionalRemittanceInformation"/>
    [IsoId("_s3jcsbTMEeeYQd8Z9bqFog")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<string> AdditionalRemittanceInformation { get; init; } = [];
}
