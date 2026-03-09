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
/// Set of elements used to provide information on the original amount and currency exchange.
/// </summary>
[IsoId("_mEJhEQ5rEe2xs7BqO31w6w")]
[DisplayName("Amount And Currency Exchange Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountAndCurrencyExchangeDetails5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountAndCurrencyExchangeDetails5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountAndCurrencyExchangeDetails5( ActiveOrHistoricCurrencyAndAmount reqAmount )
    {
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_mOGHQw5rEe2xs7BqO31w6w")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide details on the currency exchange.
    /// </summary>
    [IsoId("_mOGHRQ5rEe2xs7BqO31w6w")]
    [DisplayName("Currency Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyXchg")]
    #endif
    [IsoXmlTag("CcyXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange24? CurrencyExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange24? CurrencyExchange { get; init; } 
    #else
    public CurrencyExchange24? CurrencyExchange { get; set; } 
    #endif
    
    
    #nullable disable
    
}
