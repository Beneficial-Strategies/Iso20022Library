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
[IsoId("_VpWwllT5EeetiruPyDPo0Q")]
[DisplayName("Financial Response")]
public record FinancialResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_VpWwl1T5EeetiruPyDPo0Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment2 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_VpWwmlT5EeetiruPyDPo0Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context2 Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_VpWwmFT5EeetiruPyDPo0Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction78 Transaction { get; init; }

    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages.
    /// </summary>
    [IsoId("_-XLGcP5pEeiLerArw36g0w")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData2? AddendumData { get; init; }

    /// <summary>
    /// Outcome of processing of the authorisation.
    /// </summary>
    [IsoId("_VpWwm1T5EeetiruPyDPo0Q")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult2 ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_VpWwmVT5EeetiruPyDPo0Q")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_9IKGwUP6EeiFlYmBVFSxUw")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_hkd5UaK5EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
