// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a key exchange activity.
/// </summary>
[IsoId("_Y2XogYv6EeumSPwlS1PkxQ")]
[DisplayName("Key Exchange Initiation")]
public record KeyExchangeInitiation2
{
    /// <summary>
    /// Contains or describes conditions and characteristics of the transaction.
    /// </summary>
    [IsoId("_Y7gAIYv6EeumSPwlS1PkxQ")]
    [DisplayName("Context")]
    [IsoXmlTag("Cntxt")]
    public Context17? Context { get; init; }

    /// <summary>
    /// Details of an exchange or interaction between parties to perform a specific function.
    /// </summary>
    [IsoId("_Y7gAI4v6EeumSPwlS1PkxQ")]
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public required Transaction133 Transaction { get; init; }

    /// <summary>
    /// Contains protected data and the attributes used to protect the data.
    /// </summary>
    [IsoId("_Y7gAJYv6EeumSPwlS1PkxQ")]
    [DisplayName("Protected Data")]
    [IsoXmlTag("PrtctdData")]
    public ValueList<ProtectedData1> ProtectedData { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or other specific block.
    /// </summary>
    [IsoId("_Y7gAJ4v6EeumSPwlS1PkxQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
