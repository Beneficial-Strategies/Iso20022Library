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
[IsoId("_CfQVMXh3EeStacoNRHtESA")]
[DisplayName("Exchange Configuration")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExchangeConfiguration6
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
    [IsoId("_CsI6oXh3EeStacoNRHtESA")]
    [DisplayName("Exchange Policy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgPlcy")]
    #endif
    [IsoXmlTag("XchgPlcy")]
    public SimpleValueList<ExchangePolicy1Code> ExchangePolicy { get; init; } = new SimpleValueList<ExchangePolicy1Code>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _CsI6oXh3EeStacoNRHtESA
    
    /// <summary>
    /// Maximum number of transactions without exchange.
    /// </summary>
    [IsoId("_CsI6o3h3EeStacoNRHtESA")]
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
    [IsoId("_CsI6pXh3EeStacoNRHtESA")]
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
    /// Definition of retry process if activation of an action fails.
    /// </summary>
    [IsoId("_CsI6p3h3EeStacoNRHtESA")]
    [DisplayName("Re Try")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReTry")]
    #endif
    [IsoXmlTag("ReTry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessRetry2? ReTry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessRetry2? ReTry { get; init; } 
    #else
    public ProcessRetry2? ReTry { get; set; } 
    #endif
    
    /// <summary>
    /// Timing condition for periodic exchanges.
    /// </summary>
    [IsoId("_CsI6qXh3EeStacoNRHtESA")]
    [DisplayName("Time Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TmCond")]
    #endif
    [IsoXmlTag("TmCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessTiming4? TimeCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessTiming4? TimeCondition { get; init; } 
    #else
    public ProcessTiming4? TimeCondition { get; set; } 
    #endif
    
    
    #nullable disable
    
}
