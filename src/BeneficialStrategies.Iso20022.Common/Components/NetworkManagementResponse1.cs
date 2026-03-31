// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to network management services.
/// </summary>
[IsoId("_BQQigVWTEeeiG_nL4vgKnQ")]
[DisplayName("Network Management Response")]
public record NetworkManagementResponse1
{
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_trx8kWqYEema8a4DGUe7Lw")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context8? Context { get; init; }

    /// <summary>
    /// Details of an exchange or interaction between parties to perform a specific function.
    /// </summary>
    [IsoId("_Bb3Vk1WTEeeiG_nL4vgKnQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction99 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_Bb3VlVWTEeeiG_nL4vgKnQ")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public required ProcessingResult1 ProcessingResult { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_RXZYUaK6EeeQobSgLcPRvA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
