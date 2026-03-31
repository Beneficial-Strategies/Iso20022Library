// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response to a reversal of an authorisation or financial message.
/// </summary>
[IsoId("_7yoA8YwDEeuC5632vxUfGg")]
[DisplayName("Reversal Response")]
public record ReversalResponse4
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_72qzcYwDEeuC5632vxUfGg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment29 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_72qzc4wDEeuC5632vxUfGg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required TransactionContext8 Context { get; init; }

    /// <summary>
    /// Reversal response transaction.
    /// </summary>
    [IsoId("_72qzdYwDEeuC5632vxUfGg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction137 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the transaction.
    /// </summary>
    [IsoId("_72qzd4wDEeuC5632vxUfGg")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult10 ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_72qzeYwDEeuC5632vxUfGg")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_72qze4wDEeuC5632vxUfGg")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_72qzfYwDEeuC5632vxUfGg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
