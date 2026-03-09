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
/// Provides details on the type and amount of the cash reinvestment in a given currency.
/// </summary>
[IsoId("_08jc8JLiEeelrYORFsXWZg")]
[DisplayName("Reinvested Cash Type And Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReinvestedCashTypeAndAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReinvestedCashTypeAndAmount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReinvestedCashTypeAndAmount1( ReinvestmentType1Code reqType,ActiveOrHistoricCurrencyAndAmount reqReinvestedCashAmount )
    {
        Type = reqType;
        ReinvestedCashAmount = reqReinvestedCashAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details on the type of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_TpPMsJLjEeelrYORFsXWZg")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReinvestmentType1Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReinvestmentType1Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReinvestmentType1Code Type { get; init; } 
    #else
    public ReinvestmentType1Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the amount of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_ZdId8JLjEeelrYORFsXWZg")]
    [DisplayName("Reinvested Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstdCshAmt")]
    #endif
    [IsoXmlTag("RinvstdCshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyAndAmount ReinvestedCashAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveOrHistoricCurrencyAndAmount ReinvestedCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount ReinvestedCashAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount ReinvestedCashAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
