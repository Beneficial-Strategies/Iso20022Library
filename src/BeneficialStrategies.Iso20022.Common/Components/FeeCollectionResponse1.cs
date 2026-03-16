// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a fee collection response message.
/// </summary>
[IsoId("_6pSKMVchEeeFltjJxERUxw")]
[DisplayName("Fee Collection Response")]
public record FeeCollectionResponse1
{
    /// <summary>
    /// Environment of the transaction
    /// </summary>
    [IsoId("_6049QVchEeeFltjJxERUxw")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment5 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_fMPFQdCGEei_pMueJh_zOA")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context9? Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_6049Q1chEeeFltjJxERUxw")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction103 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation
    /// </summary>
    [IsoId("_6049RVchEeeFltjJxERUxw")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult4 ProcessingResult { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_JCKBIaK5EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
