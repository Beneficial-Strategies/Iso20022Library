// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRemittanceInformation8"/>
[IsoId("_QFQRctp-Ed-ak6NoX_4Aeg_216518890")]
[DisplayName("Structured Remittance Information")]
public partial record StructuredRemittanceInformation8
{
    /// <inheritdoc cref="IStructuredRemittanceInformation8.ReferredDocumentInformation"/>
    [IsoId("_QFQRc9p-Ed-ak6NoX_4Aeg_-1276003119")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation3> ReferredDocumentInformation { get; init; } = [];

    /// <inheritdoc cref="IStructuredRemittanceInformation8.ReferredDocumentAmount"/>
    [IsoId("_QFQRdNp-Ed-ak6NoX_4Aeg_-515237966")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount1? ReferredDocumentAmount { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation8.CreditorReferenceInformation"/>
    [IsoId("_QFQRddp-Ed-ak6NoX_4Aeg_-2008205652")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation8.Invoicer"/>
    [IsoId("_QFQRdtp-Ed-ak6NoX_4Aeg_1758673695")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification43? Invoicer { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation8.Invoicee"/>
    [IsoId("_QFQRd9p-Ed-ak6NoX_4Aeg_-2082206332")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification43? Invoicee { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation8.AdditionalRemittanceInformation"/>
    [IsoId("_QFQReNp-Ed-ak6NoX_4Aeg_-1674377978")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<string> AdditionalRemittanceInformation { get; init; } = [];
}
