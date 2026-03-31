// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response of a financial initiation message.
/// </summary>
[IsoId("_owpLcYzMEeujJfnIQ4NlpQ")]
[DisplayName("Financial Response")]
public record FinancialResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_o13CoYzMEeujJfnIQ4NlpQ")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment26 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_o13Co4zMEeujJfnIQ4NlpQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context13 Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_o13CpYzMEeujJfnIQ4NlpQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction143 Transaction { get; init; }

    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages.
    /// </summary>
    [IsoId("_o13Cp4zMEeujJfnIQ4NlpQ")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData4? AddendumData { get; init; }

    /// <summary>
    /// Outcome of processing of the authorisation.
    /// </summary>
    [IsoId("_o13CqYzMEeujJfnIQ4NlpQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult10 ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_o13Cq4zMEeujJfnIQ4NlpQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_o13CrYzMEeujJfnIQ4NlpQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_o13Cr4zMEeujJfnIQ4NlpQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
