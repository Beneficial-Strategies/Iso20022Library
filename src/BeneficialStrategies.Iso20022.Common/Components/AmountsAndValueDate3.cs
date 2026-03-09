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
/// Specifies the value date and the amounts traded in a foreign exchange option trade.
/// </summary>
[IsoId("_TImttNp-Ed-ak6NoX_4Aeg_128911716")]
[DisplayName("Amounts And Value Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountsAndValueDate3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountsAndValueDate3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountsAndValueDate3( ActiveOrHistoricCurrencyAndAmount reqCallAmount,ActiveOrHistoricCurrencyAndAmount reqPutAmount )
    {
        CallAmount = reqCallAmount;
        PutAmount = reqPutAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Call amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TImttdp-Ed-ak6NoX_4Aeg_128911718")]
    [DisplayName("Call Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CallAmt")]
    #endif
    [IsoXmlTag("CallAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount CallAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount CallAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount CallAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount CallAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Put amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TImtttp-Ed-ak6NoX_4Aeg_128911993")]
    [DisplayName("Put Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PutAmt")]
    #endif
    [IsoXmlTag("PutAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount PutAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount PutAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount PutAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount PutAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the trade is settled, ie, the amounts are due.
    /// </summary>
    [IsoId("_TImtt9p-Ed-ak6NoX_4Aeg_128911758")]
    [DisplayName("Final Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlSttlmDt")]
    #endif
    [IsoXmlTag("FnlSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FinalSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FinalSettlementDate { get; init; } 
    #else
    public System.DateOnly? FinalSettlementDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
