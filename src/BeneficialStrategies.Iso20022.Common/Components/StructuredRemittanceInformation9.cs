// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IStructuredRemittanceInformation9"/>
[IsoId("_tdxcIVkyEeGeoaLUQk__nA_1056984745")]
[DisplayName("Structured Remittance Information")]
public partial record StructuredRemittanceInformation9
{
    /// <inheritdoc cref="IStructuredRemittanceInformation9.ReferredDocumentInformation"/>
    [IsoId("_tdxcIlkyEeGeoaLUQk__nA_-1066811179")]
    [DisplayName("Referred Document Information")]
    [IsoXmlTag("RfrdDocInf")]
    public ValueList<ReferredDocumentInformation3> ReferredDocumentInformation { get; init; } = [];

    /// <inheritdoc cref="IStructuredRemittanceInformation9.ReferredDocumentAmount"/>
    [IsoId("_tdxcI1kyEeGeoaLUQk__nA_-1109880720")]
    [DisplayName("Referred Document Amount")]
    [IsoXmlTag("RfrdDocAmt")]
    public RemittanceAmount2? ReferredDocumentAmount { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation9.CreditorReferenceInformation"/>
    [IsoId("_td7NIFkyEeGeoaLUQk__nA_1629216987")]
    [DisplayName("Creditor Reference Information")]
    [IsoXmlTag("CdtrRefInf")]
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation9.Invoicer"/>
    [IsoId("_td7NIVkyEeGeoaLUQk__nA_-1445901897")]
    [DisplayName("Invoicer")]
    [IsoXmlTag("Invcr")]
    public PartyIdentification43? Invoicer { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation9.Invoicee"/>
    [IsoId("_td7NIlkyEeGeoaLUQk__nA_-1617073264")]
    [DisplayName("Invoicee")]
    [IsoXmlTag("Invcee")]
    public PartyIdentification43? Invoicee { get; init; }

    /// <inheritdoc cref="IStructuredRemittanceInformation9.AdditionalRemittanceInformation"/>
    [IsoId("_td7NI1kyEeGeoaLUQk__nA_2032156950")]
    [DisplayName("Additional Remittance Information")]
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<string> AdditionalRemittanceInformation { get; init; } = [];
}
