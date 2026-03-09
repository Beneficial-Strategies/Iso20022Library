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
[IsoId("_TRivacKzEeuFNp8LZAnorg")]
[DisplayName("Reinvested Cash Type And Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReinvestedCashTypeAndAmount2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReinvestedCashTypeAndAmount2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReinvestedCashTypeAndAmount2( ReinvestmentType1Code reqType,string reqReinvestedCashCurrency )
    {
        Type = reqType;
        ReinvestedCashCurrency = reqReinvestedCashCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details on the type of the cash reinvestment in a given currency.
    /// </summary>
    [IsoId("_TS8dgcKzEeuFNp8LZAnorg")]
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
    /// Medium of exchange of currency.
    /// </summary>
    [IsoId("_TS8dg8KzEeuFNp8LZAnorg")]
    [DisplayName("Reinvested Cash Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RinvstdCshCcy")]
    #endif
    [IsoXmlTag("RinvstdCshCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode ReinvestedCashCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string ReinvestedCashCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string ReinvestedCashCurrency { get; init; } 
    #else
    public string ReinvestedCashCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
