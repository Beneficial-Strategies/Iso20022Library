// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the reversal of an authorisation or financial message.
/// </summary>
[IsoId("_Uw4hZlUCEeetiruPyDPo0Q")]
[DisplayName("Reversal Initiation")]
public record ReversalInitiation1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Uw4halUCEeetiruPyDPo0Q")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment13 Environment { get; init; }

    /// <summary>
    /// Context of the reversal transaction.
    /// </summary>
    [IsoId("_3WdboEP_EeiFlYmBVFSxUw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context7? Context { get; init; }

    /// <summary>
    /// Reversal initiation transaction.
    /// </summary>
    [IsoId("_Uw4haVUCEeetiruPyDPo0Q")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction77 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_Uw4ha1UCEeetiruPyDPo0Q")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult1? ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_Uw4haFUCEeetiruPyDPo0Q")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_26uYIdXxEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_ycS8oaK6EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
