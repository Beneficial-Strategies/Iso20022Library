// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRemittanceInformation16"/>
[IsoId("_-5awV248EeiU9cctagi5ow")]
[DisplayName("Structured Remittance Information")]
public partial record StructuredRemittanceInformation16
{
    /// <inheritdoc cref="IStructuredRemittanceInformation16.ReferredDocumentInformation"/>
    [IsoId("__Cz84248EeiU9cctagi5ow")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation7> ReferredDocumentInformation { get; init; } = [];

    /// <inheritdoc cref="IStructuredRemittanceInformation16.ReferredDocumentAmount"/>
    [IsoId("__Cz85W48EeiU9cctagi5ow")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount2? ReferredDocumentAmount { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation16.CreditorReferenceInformation"/>
    [IsoId("__Cz85248EeiU9cctagi5ow")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation16.Invoicer"/>
    [IsoId("__Cz86W48EeiU9cctagi5ow")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification135? Invoicer { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation16.Invoicee"/>
    [IsoId("__Cz86248EeiU9cctagi5ow")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification135? Invoicee { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation16.TaxRemittance"/>
    [IsoId("__Cz87W48EeiU9cctagi5ow")]
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    public TaxInformation7? TaxRemittance { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation16.GarnishmentRemittance"/>
    [IsoId("__Cz87248EeiU9cctagi5ow")]
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    public Garnishment3? GarnishmentRemittance { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation16.AdditionalRemittanceInformation"/>
    [IsoId("__Cz88W48EeiU9cctagi5ow")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<string> AdditionalRemittanceInformation { get; init; } = [];
}
