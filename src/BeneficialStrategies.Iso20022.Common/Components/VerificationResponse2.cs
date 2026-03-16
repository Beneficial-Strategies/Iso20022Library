// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the verification response message.
/// </summary>
[IsoId("_i0v8MYwFEeugeuahCxXQ-Q")]
[DisplayName("Verification Response")]
public record VerificationResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_i47RkYwFEeugeuahCxXQ-Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment32 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_i47Rk4wFEeugeuahCxXQ-Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context13 Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_i47RlYwFEeugeuahCxXQ-Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction140 Transaction { get; init; }

    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages
    /// </summary>
    [IsoId("_2_NYoSX7Eeym0KcvJF9aDQ")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData5? AddendumData { get; init; }

    /// <summary>
    /// Outcome of the processing of the verification.
    /// </summary>
    [IsoId("_i47Rl4wFEeugeuahCxXQ-Q")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult18 ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_i47RmYwFEeugeuahCxXQ-Q")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_i47Rm4wFEeugeuahCxXQ-Q")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_i47RnYwFEeugeuahCxXQ-Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
