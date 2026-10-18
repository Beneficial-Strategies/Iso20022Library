// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRemittanceInformation6"/>
[IsoId("_QFZbYtp-Ed-ak6NoX_4Aeg_-141764551")]
[DisplayName("Structured Remittance Information")]
public partial record StructuredRemittanceInformation6
{
    /// <inheritdoc cref="IStructuredRemittanceInformation6.ReferredDocumentInformation"/>
    [IsoId("_QFZbY9p-Ed-ak6NoX_4Aeg_758670115")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ReferredDocumentInformation1? ReferredDocumentInformation { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation6.ReferredDocumentRelatedDate"/>
    [IsoId("_QFZbZNp-Ed-ak6NoX_4Aeg_-141764239")]
    [DisplayName("Referred Document Related Date")]
    [IsoXmlTag("RfrdDocRltdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ReferredDocumentRelatedDate { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation6.ReferredDocumentAmount"/>
    [IsoId("_QFZbZdp-Ed-ak6NoX_4Aeg_-141764204")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public ValueList<ReferredDocumentAmount1Choice_> ReferredDocumentAmount { get; init; } = [];

    /// <inheritdoc cref="IStructuredRemittanceInformation6.CreditorReferenceInformation"/>
    [IsoId("_QFZbZtp-Ed-ak6NoX_4Aeg_1486861224")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation1? CreditorReferenceInformation { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation6.Invoicer"/>
    [IsoId("_QFZbZ9p-Ed-ak6NoX_4Aeg_-141763664")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification8? Invoicer { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation6.Invoicee"/>
    [IsoId("_QFZbaNp-Ed-ak6NoX_4Aeg_-141763290")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification8? Invoicee { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation6.AdditionalRemittanceInformation"/>
    [IsoId("_QFjMYNp-Ed-ak6NoX_4Aeg_-141764179")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalRemittanceInformation { get; init; }
}
