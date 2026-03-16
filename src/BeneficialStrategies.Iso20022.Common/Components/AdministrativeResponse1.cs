// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the Administrative initiation.
/// </summary>
[IsoId("_wdv6MTZ3EeysP8L3U1Ot-g")]
[DisplayName("Administrative Response")]
public record AdministrativeResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_wpOKYTZ3EeysP8L3U1Ot-g")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment34 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_wpOKYzZ3EeysP8L3U1Ot-g")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context18? Context { get; init; }

    /// <summary>
    /// Card transaction for which a financial process is requested.
    /// </summary>
    [IsoId("_wpOKZTZ3EeysP8L3U1Ot-g")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction144 Transaction { get; init; }

    /// <summary>
    /// Contains details of the transaction to be retrieved.
    /// </summary>
    [IsoId("_wpOKZzZ3EeysP8L3U1Ot-g")]
    [DisplayName("Original Transaction")]
    [IsoXmlTag("OrgnlTx")]
    public OriginalTransaction2? OriginalTransaction { get; init; }

    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages.
    /// </summary>
    [IsoId("_wpOKaTZ3EeysP8L3U1Ot-g")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData3? AddendumData { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_wpOKazZ3EeysP8L3U1Ot-g")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData2? AdditionalData { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation
    /// </summary>
    [IsoId("_wpOKbTZ3EeysP8L3U1Ot-g")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult17 ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_wpOKbzZ3EeysP8L3U1Ot-g")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_wpOKcTZ3EeysP8L3U1Ot-g")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_wpOKczZ3EeysP8L3U1Ot-g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
