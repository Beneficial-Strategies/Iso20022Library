// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Results of a scenario used to test whether a legal entity or other financial construct has sufficient liquid resources to meet its obligations as they arise.
/// </summary>
[IsoId("_PwgG8LJPEeaYqc4G3TTwhA")]
[DisplayName("Liquidity Stress Test Result")]
public partial record LiquidityStressTestResult1
{
    #nullable enable
    
    /// <summary>
    /// CCP’s internal unique identifier of the stress scenario that generates the reported liquidity need.
    /// </summary>
    [IsoId("_W2YkgLJPEeaYqc4G3TTwhA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text Identification { get; init; } 
    
    /// <summary>
    /// Identification of assumed defaulters under the stress scenario.
    /// </summary>
    [IsoId("_fBdIgLJPEeaYqc4G3TTwhA")]
    [DisplayName("Scenario Defaulters")]
    [IsoXmlTag("ScnroDfltrs")]
    public required CoverTwoDefaulters1 ScenarioDefaulters { get; init; } 
    
    /// <summary>
    /// Indicates the stressed resources and liquidity requirements under the liquidity stress test. The balance of resources are reported as of day ‘T‐1’. The requirements and any flows of resources are reported on their respective day from day ’ T’ to ‘T+5&apos;.
    /// </summary>
    [IsoId("_E8PuQLbxEeaqL_M7XFD7PQ")]
    [DisplayName("Liquidity Required And Available")]
    [IsoXmlTag("LqdtyReqrdAndAvlbl")]
    [MinLength(6)]
    [MaxLength(6)]
    public ValueList<LiquidityRequiredAndAvailable1> LiquidityRequiredAndAvailable { get; init; } = [];
    
    
    #nullable disable
    
}
