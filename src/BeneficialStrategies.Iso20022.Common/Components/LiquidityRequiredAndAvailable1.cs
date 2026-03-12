// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Obligations of a legal entity or other financial construct that must be met in cash and the resources such legal entity of financial construct has available to meet those obligations.
/// </summary>
[IsoId("_IW-vwLbxEeaqL_M7XFD7PQ")]
[DisplayName("Liquidity Required And Available")]
public partial record LiquidityRequiredAndAvailable1
{
    #nullable enable
    
    /// <summary>
    /// Flows of resources that are estimated to be available to the CCP on each day of the reporting horizon. That is, balances as of close‐of‐business on day ‘T‐1’, then flows from day ‘T’ of the default to ‘T+5 onwards’.
    /// </summary>
    [IsoId("_UdHbI7bxEeaqL_M7XFD7PQ")]
    [DisplayName("Liquid Resources")]
    [IsoXmlTag("LqdRsrcs")]
    public required LiquidResources1 LiquidResources { get; init; } 
    
    /// <summary>
    /// Period of reporting of liquidity requirements and resources relative to a set date.
    /// </summary>
    [IsoId("_UdHbJLbxEeaqL_M7XFD7PQ")]
    [DisplayName("Liquidity Horizon")]
    [IsoXmlTag("LqdtyHrzn")]
    public required SettlementDate6Code LiquidityHorizon { get; init; } 
    
    /// <summary>
    /// Total expected liquidity need under Scenario ID for the relevant currency over each day of the horizon from day T onwards.
    /// </summary>
    [IsoId("_UmNQQbbyEeaqL_M7XFD7PQ")]
    [DisplayName("Stress Liquid Resource Requirement")]
    [IsoXmlTag("StrssLqdRsrcRqrmnt")]
    public required StressLiquidResourceRequirement1 StressLiquidResourceRequirement { get; init; } 
    
    
    #nullable disable
    
}
