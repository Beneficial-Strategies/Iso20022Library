// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters of data exchanges.
/// </summary>
[IsoId("_38NMwR3pEeKWfegf-2AeBQ")]
[DisplayName("Exchange Configuration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExchangeConfiguration3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Exchange policy between parties.
    /// </summary>
    [IsoId("_4IG6xR3pEeKWfegf-2AeBQ")]
    [DisplayName("Exchange Policy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgPlcy")]
    #endif
    [IsoXmlTag("XchgPlcy")]
    public SimpleValueList<ExchangePolicy1Code> ExchangePolicy { get; init; } = new SimpleValueList<ExchangePolicy1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _4IG6xR3pEeKWfegf-2AeBQ
    
    /// <summary>
    /// Maximum number of transactions without exchange.
    /// </summary>
    [IsoId("_4IG6zB3pEeKWfegf-2AeBQ")]
    [DisplayName("Maximum Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxNb")]
    #endif
    [IsoXmlTag("MaxNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? MaximumNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? MaximumNumber { get; init; } 
    #else
    public System.UInt64? MaximumNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum cumulative amount of the transactions without exchange.
    /// </summary>
    [IsoId("_4IG60x3pEeKWfegf-2AeBQ")]
    [DisplayName("Maximum Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxAmt")]
    #endif
    [IsoXmlTag("MaxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? MaximumAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? MaximumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Timing condition for periodic exchanges.
    /// </summary>
    [IsoId("_4IG62h3pEeKWfegf-2AeBQ")]
    [DisplayName("Time Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmCond")]
    #endif
    [IsoXmlTag("TmCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessTiming2? TimeCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessTiming2? TimeCondition { get; init; } 
    #else
    public ProcessTiming2? TimeCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Failed transaction must be exchanged.
    /// </summary>
    [IsoId("_WMDPgB3qEeKWfegf-2AeBQ")]
    [DisplayName("Exchange Failed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgFaild")]
    #endif
    [IsoXmlTag("XchgFaild")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ExchangeFailed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExchangeFailed { get; init; } 
    #else
    public System.String? ExchangeFailed { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that declined transaction must be exchanged.
    /// </summary>
    [IsoId("_QdDP4B3rEeKWfegf-2AeBQ")]
    [DisplayName("Exchange Declined")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgDclnd")]
    #endif
    [IsoXmlTag("XchgDclnd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ExchangeDeclined { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExchangeDeclined { get; init; } 
    #else
    public System.String? ExchangeDeclined { get; set; } 
    #endif
    
    
    #nullable disable
    
}
