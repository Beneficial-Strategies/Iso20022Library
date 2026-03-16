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
[IsoId("_YvpLFlUEEeetiruPyDPo0Q")]
[DisplayName("Reversal Response")]
public record ReversalResponse2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_YvpLG1UEEeetiruPyDPo0Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment14 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_YvpLGFUEEeetiruPyDPo0Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required TransactionContext3 Context { get; init; }

    /// <summary>
    /// Reversal response transaction.
    /// </summary>
    [IsoId("_YvpLF1UEEeetiruPyDPo0Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction86 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the transaction.
    /// </summary>
    [IsoId("_YvpLGVUEEeetiruPyDPo0Q")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult2 ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_YvpLGlUEEeetiruPyDPo0Q")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_6A10gdXxEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_WBTQwaK8EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
