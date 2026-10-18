// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRemittanceInformation13"/>
[IsoId("_0Pit5zq4EeWZFYSPlduMhw")]
[DisplayName("Structured Remittance Information")]
public partial record StructuredRemittanceInformation13
{
    /// <inheritdoc cref="IStructuredRemittanceInformation13.ReferredDocumentInformation"/>
    [IsoId("_0X1uQzq4EeWZFYSPlduMhw")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation7> ReferredDocumentInformation { get; init; } = [];

    /// <inheritdoc cref="IStructuredRemittanceInformation13.ReferredDocumentAmount"/>
    [IsoId("_0X1uRTq4EeWZFYSPlduMhw")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount2? ReferredDocumentAmount { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation13.CreditorReferenceInformation"/>
    [IsoId("_0X1uRzq4EeWZFYSPlduMhw")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation13.Invoicer"/>
    [IsoId("_0X1uSTq4EeWZFYSPlduMhw")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification43? Invoicer { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation13.Invoicee"/>
    [IsoId("_0X1uSzq4EeWZFYSPlduMhw")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification43? Invoicee { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation13.TaxRemittance"/>
    [IsoId("_0X1uTTq4EeWZFYSPlduMhw")]
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    public TaxInformation4? TaxRemittance { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation13.GarnishmentRemittance"/>
    [IsoId("_0X1uTzq4EeWZFYSPlduMhw")]
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    public Garnishment1? GarnishmentRemittance { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation13.AdditionalRemittanceInformation"/>
    [IsoId("_0X1uUTq4EeWZFYSPlduMhw")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<string> AdditionalRemittanceInformation { get; init; } = [];
}
