// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRemittanceInformation7"/>
[IsoId("_QF2HUdp-Ed-ak6NoX_4Aeg_542333263")]
[DisplayName("Structured Remittance Information")]
public partial record StructuredRemittanceInformation7
{
    /// <inheritdoc cref="IStructuredRemittanceInformation7.ReferredDocumentInformation"/>
    [IsoId("_QF2HUtp-Ed-ak6NoX_4Aeg_542333666")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation3> ReferredDocumentInformation { get; init; } = [];

    /// <inheritdoc cref="IStructuredRemittanceInformation7.ReferredDocumentAmount"/>
    [IsoId("_QF2HU9p-Ed-ak6NoX_4Aeg_-730090400")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount1? ReferredDocumentAmount { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation7.CreditorReferenceInformation"/>
    [IsoId("_QF2HVNp-Ed-ak6NoX_4Aeg_542333719")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation7.Invoicer"/>
    [IsoId("_QF2HVdp-Ed-ak6NoX_4Aeg_542333781")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification32? Invoicer { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation7.Invoicee"/>
    [IsoId("_QF2HVtp-Ed-ak6NoX_4Aeg_542333811")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification32? Invoicee { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation7.AdditionalRemittanceInformation"/>
    [IsoId("_QF2HV9p-Ed-ak6NoX_4Aeg_542333379")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<string> AdditionalRemittanceInformation { get; init; } = [];
}
