// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRemittanceInformation17"/>
[IsoId("_n5V1sd4lEeqt1ZcLzWyWFw")]
[DisplayName("Structured Remittance Information")]
public partial record StructuredRemittanceInformation17
{
    /// <inheritdoc cref="IStructuredRemittanceInformation17.ReferredDocumentInformation"/>
    [IsoId("_n7Ds8d4lEeqt1ZcLzWyWFw")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation7> ReferredDocumentInformation { get; init; } = [];

    /// <inheritdoc cref="IStructuredRemittanceInformation17.ReferredDocumentAmount"/>
    [IsoId("_n7Ds894lEeqt1ZcLzWyWFw")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount2? ReferredDocumentAmount { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation17.CreditorReferenceInformation"/>
    [IsoId("_n7Ds9d4lEeqt1ZcLzWyWFw")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation17.Invoicer"/>
    [IsoId("_n7Ds994lEeqt1ZcLzWyWFw")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification135? Invoicer { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation17.Invoicee"/>
    [IsoId("_n7Ds-d4lEeqt1ZcLzWyWFw")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification135? Invoicee { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation17.TaxRemittance"/>
    [IsoId("_n7Ds-94lEeqt1ZcLzWyWFw")]
    [DisplayName("Tax Remittance")]
    [IsoXmlTag("TaxRmt")]
    public TaxData1? TaxRemittance { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation17.GarnishmentRemittance"/>
    [IsoId("_n7Ds_d4lEeqt1ZcLzWyWFw")]
    [DisplayName("Garnishment Remittance")]
    [IsoXmlTag("GrnshmtRmt")]
    public Garnishment3? GarnishmentRemittance { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation17.AdditionalRemittanceInformation"/>
    [IsoId("_n7Ds_94lEeqt1ZcLzWyWFw")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<string> AdditionalRemittanceInformation { get; init; } = [];
}
