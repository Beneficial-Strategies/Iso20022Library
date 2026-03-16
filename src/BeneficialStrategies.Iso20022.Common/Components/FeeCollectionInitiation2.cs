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
[IsoId("_EXWGMYaBEeuSbct6WWD-Ng")]
[DisplayName("Fee Collection Initiation")]
public record FeeCollectionInitiation2
{
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_Ecx_0YaBEeuSbct6WWD-Ng")]
    [DisplayName("Environment")]
    [IsoXmlTag("Envt")]
    public required Environment23 Environment { get; init; }

    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_Ecx_04aBEeuSbct6WWD-Ng")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context16? Context { get; init; }

    /// <summary>
    /// Card transaction for which an authorisation is requested.
    /// </summary>
    [IsoId("_Ecx_1YaBEeuSbct6WWD-Ng")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction156 Transaction { get; init; }

    /// <summary>
    /// Outcome of the processing of the authorisation.
    /// </summary>
    [IsoId("_Ecx_14aBEeuSbct6WWD-Ng")]
    [DisplayName("Processing Result")]
    [IsoXmlTag("PrcgRslt")]
    public ProcessingResult14? ProcessingResult { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_Ecx_2YaBEeuSbct6WWD-Ng")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_Ecx_24aBEeuSbct6WWD-Ng")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
