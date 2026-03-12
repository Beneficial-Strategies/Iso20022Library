// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters of data exchanges.
/// </summary>
[IsoId("_TMz1kTAREeugIJ3Gvoevmg")]
[DisplayName("Exchange Configuration")]
public partial record ExchangeConfiguration9
{
    #nullable enable
    
    /// <summary>
    /// Exchange policy between parties.
    /// </summary>
    [IsoId("_TZtCETAREeugIJ3Gvoevmg")]
    [DisplayName("Exchange Policy")]
    [IsoXmlTag("XchgPlcy")]
    public SimpleValueList<ExchangePolicy2Code> ExchangePolicy { get; init; } = new SimpleValueList<ExchangePolicy2Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _TZtCETAREeugIJ3Gvoevmg
    
    /// <summary>
    /// Maximum number of transactions without exchange.
    /// </summary>
    [IsoId("_TZtCEzAREeugIJ3Gvoevmg")]
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumber { get; init; } 
    
    /// <summary>
    /// Maximum cumulative amount of the transactions without exchange.
    /// </summary>
    [IsoId("_TZtCFTAREeugIJ3Gvoevmg")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    
    /// <summary>
    /// Definition of retry process if activation of an action fails.
    /// </summary>
    [IsoId("_TZtCFzAREeugIJ3Gvoevmg")]
    [DisplayName("Re Try")]
    [IsoXmlTag("ReTry")]
    public ProcessRetry3? ReTry { get; init; } 
    
    /// <summary>
    /// Timing condition for periodic exchanges.
    /// </summary>
    [IsoId("_TZtCGTAREeugIJ3Gvoevmg")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming6? TimeCondition { get; init; } 
    
    
    #nullable disable
    
}
