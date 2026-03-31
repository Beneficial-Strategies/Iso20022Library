// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the financial initiation message.
/// </summary>
[IsoId("_hOV95lTREeeeIYOiLZFQGg")]
[DisplayName("Financial Initiation")]
public record FinancialInitiation1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_hOV96FTREeeeIYOiLZFQGg")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment1 Environment { get; init; }

    /// <summary>
    /// Context in which the card transaction is performed.
    /// </summary>
    [IsoId("_hOV961TREeeeIYOiLZFQGg")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public required Context1 Context { get; init; }

    /// <summary>
    /// Card transaction for which a financial process is requested.
    /// </summary>
    [IsoId("_hOV96VTREeeeIYOiLZFQGg")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction77 Transaction { get; init; }

    /// <summary>
    /// Component contains data structures applicable to certain industries that require specific data within transaction messages.
    /// </summary>
    [IsoId("_tXy0MP5pEeiLerArw36g0w")]
    [DisplayName("Addendum Data")]
    [IsoXmlTag("AdddmData")]
    public AddendumData1? AddendumData { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation
    /// </summary>
    [IsoId("_hOV96lTREeeeIYOiLZFQGg")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult1? ProcessingResult { get; init; }

    /// <summary>
    /// Data related to an integrated circuit card application embedded in the payment card of the cardholder.
    /// ISO 8583 bit 55
    /// </summary>
    [IsoId("_hOV951TREeeeIYOiLZFQGg")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10KHexBinaryText)]
    public IsoMax10KHexBinaryText? ICCRelatedData { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_oWFfcdXwEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_d2RwUaK5EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
