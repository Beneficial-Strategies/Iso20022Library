// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the card management response message.
/// </summary>
[IsoId("_TwkBsVgUEeedJb6VxsnkPg")]
[DisplayName("Card Management Response")]
public record CardManagementResponse1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_T7uI0VgUEeedJb6VxsnkPg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment7 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_T7uI01gUEeedJb6VxsnkPg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context5 Context { get; init; }

    /// <summary>
    /// Response to a card management Initiation transaction.
    /// </summary>
    [IsoId("_T7uI1VgUEeedJb6VxsnkPg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction81 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the transaction.
    /// </summary>
    [IsoId("_T7uI11gUEeedJb6VxsnkPg")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult1 ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_T7uI2VgUEeedJb6VxsnkPg")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_JsancdXwEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_yiCDIaK4EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
