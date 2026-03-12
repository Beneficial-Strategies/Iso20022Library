// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Measure of the total capital requirement all the clearing members are required to hold against their default fund contributions to a central counterparty.
/// </summary>
[IsoId("_LK-vILb2EeabfchHYoktpA")]
[DisplayName("Hypothetical Capital Measure")]
public partial record HypotheticalCapitalMeasure1
{
    #nullable enable
    
    /// <summary>
    /// Indicates the amount of the total capital requirement all the clearing members are required to hold against their default fund contributions to a central counterparty.
    /// </summary>
    [IsoId("_UHwc4Lb2EeabfchHYoktpA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Unique internal identifier for each default waterfall at the central counterparty.
    /// </summary>
    [IsoId("_qdBOsLb2EeabfchHYoktpA")]
    [DisplayName("Default Waterfall Identification")]
    [IsoXmlTag("DfltWtrfllId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text DefaultWaterfallIdentification { get; init; } 
    
    
    #nullable disable
    
}
