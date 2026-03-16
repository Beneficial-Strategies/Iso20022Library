// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a fee collection initiation message.
/// </summary>
[IsoId("_ZhYGsVaIEeeFltjJxERUxw")]
[DisplayName("Fee Collection Initiation")]
public record FeeCollectionInitiation1
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_ZtIDsVaIEeeFltjJxERUxw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment5 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_oCUAYc5dEeiEmaZryQQ14Q")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context9? Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_ZtIDtVaIEeeFltjJxERUxw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction103 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_ZtIDt1aIEeeFltjJxERUxw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult4? ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_dMLy0dXwEee5XtaG1wqDfQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ProtectedData1? ProtectedData { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_EVMiwaK5EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
