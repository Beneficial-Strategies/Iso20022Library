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
[IsoId("_38NMwR3pEeKWfegf-2AeBQ")]
[DisplayName("Exchange Configuration")]
public partial record ExchangeConfiguration3
{
    #nullable enable
    
    /// <summary>
    /// Exchange policy between parties.
    /// </summary>
    [IsoId("_4IG6xR3pEeKWfegf-2AeBQ")]
    [DisplayName("Exchange Policy")]
    [IsoXmlTag("XchgPlcy")]
    public SimpleValueList<ExchangePolicy1Code> ExchangePolicy { get; init; } = new SimpleValueList<ExchangePolicy1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _4IG6xR3pEeKWfegf-2AeBQ
    
    /// <summary>
    /// Maximum number of transactions without exchange.
    /// </summary>
    [IsoId("_4IG6zB3pEeKWfegf-2AeBQ")]
    [DisplayName("Maximum Number")]
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumNumber { get; init; } 
    
    /// <summary>
    /// Maximum cumulative amount of the transactions without exchange.
    /// </summary>
    [IsoId("_4IG60x3pEeKWfegf-2AeBQ")]
    [DisplayName("Maximum Amount")]
    [IsoXmlTag("MaxAmt")]
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    
    /// <summary>
    /// Timing condition for periodic exchanges.
    /// </summary>
    [IsoId("_4IG62h3pEeKWfegf-2AeBQ")]
    [DisplayName("Time Condition")]
    [IsoXmlTag("TmCond")]
    public ProcessTiming2? TimeCondition { get; init; } 
    
    /// <summary>
    /// Failed transaction must be exchanged.
    /// </summary>
    [IsoId("_WMDPgB3qEeKWfegf-2AeBQ")]
    [DisplayName("Exchange Failed")]
    [IsoXmlTag("XchgFaild")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ExchangeFailed { get; init; } 
    
    /// <summary>
    /// Indicates that declined transaction must be exchanged.
    /// </summary>
    [IsoId("_QdDP4B3rEeKWfegf-2AeBQ")]
    [DisplayName("Exchange Declined")]
    [IsoXmlTag("XchgDclnd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ExchangeDeclined { get; init; } 
    
    
    #nullable disable
    
}
