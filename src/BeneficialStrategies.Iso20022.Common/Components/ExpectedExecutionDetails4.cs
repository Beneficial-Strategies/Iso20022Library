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
/// Expected trade date and expected settlement date of the order execution.
/// </summary>
[IsoId("_6azDQUgXEea9YuSvQGoi-w")]
[DisplayName("Expected Execution Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExpectedExecutionDetails4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Expected date or expected date and time at which a price will be applied according to the terms of the prospectus.
    /// </summary>
    [IsoId("_60PeA0gXEea9YuSvQGoi-w")]
    [DisplayName("Expected Trade Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdTradDtTm")]
    #endif
    [IsoXmlTag("XpctdTradDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? ExpectedTradeDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? ExpectedTradeDateTime { get; init; } 
    #else
    public DateAndDateTimeChoice_? ExpectedTradeDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Date of a payment, for example, a prepayment date.
    /// </summary>
    [IsoId("_60PeBUgXEea9YuSvQGoi-w")]
    [DisplayName("Expected Cash Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdCshSttlmDt")]
    #endif
    [IsoXmlTag("XpctdCshSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpectedCashSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpectedCashSettlementDate { get; init; } 
    #else
    public System.DateOnly? ExpectedCashSettlementDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
