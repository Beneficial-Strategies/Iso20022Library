// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Position Set Aggregated4.
/// </summary>
[IsoId("_jQT8dRTjEe61h9tfoUrWyw")]
[DisplayName("Position Set Aggregated4")]
public partial record PositionSetAggregated4
{
    #nullable enable

    /// <summary>
    /// Collateral Position Set.
    /// </summary>
    [DisplayName("Collateral Position Set")]
    [IsoXmlTag("CollPosSet")]
    public ValueList<PositionSet22> CollateralPositionSet { get; init; } = [];

    /// <summary>
    /// Currency Collateral Position Set.
    /// </summary>
    [DisplayName("Currency Collateral Position Set")]
    [IsoXmlTag("CcyCollPosSet")]
    public ValueList<PositionSet22> CurrencyCollateralPositionSet { get; init; } = [];

    /// <summary>
    /// Currency Position Set.
    /// </summary>
    [DisplayName("Currency Position Set")]
    [IsoXmlTag("CcyPosSet")]
    public ValueList<PositionSet21> CurrencyPositionSet { get; init; } = [];

    /// <summary>
    /// Position Set.
    /// </summary>
    [DisplayName("Position Set")]
    [IsoXmlTag("PosSet")]
    public ValueList<PositionSet21> PositionSet { get; init; } = [];

    /// <summary>
    /// Reference Date.
    /// </summary>
    [DisplayName("Reference Date")]
    [IsoXmlTag("RefDt")]
    public required IsoISODate ReferenceDate { get; init; } 

    
    #nullable disable
    
}
