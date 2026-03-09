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
/// Interest rate of the loan.
/// </summary>
[IsoId("_0_3dUc-nEeufOvGsyZiDWA")]
[DisplayName("Rates")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Rates3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Details of the fixed rate.
    /// </summary>
    [IsoId("_1CZz88-nEeufOvGsyZiDWA")]
    [DisplayName("Fixed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fxd")]
    #endif
    [IsoXmlTag("Fxd")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Fixed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Fixed { get; init; } 
    #else
    public System.Decimal? Fixed { get; set; } 
    #endif
    
    /// <summary>
    /// Details about the variable rate.
    /// </summary>
    [IsoId("_1CZz9c-nEeufOvGsyZiDWA")]
    [DisplayName("Floating")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fltg")]
    #endif
    [IsoXmlTag("Fltg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? Floating { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? Floating { get; init; } 
    #else
    public System.Decimal? Floating { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction by which a counterparty buys or sells securities, commodities, or guaranteed rights relating to title to securities or commodities, agreeing, respectively, to sell or to buy back securities, commodities or such guaranteed rights of the same description at a specified price on a future date, that transaction being a buy-sell back transaction for the counterparty buying the securities, commodities or guaranteed rights, and a sell-buy back transaction for the counterparty selling them, such buy-sell back transaction or sell-buy back transaction not being governed by a repurchase agreement or by a reverse-repurchase agreement.
    /// </summary>
    [IsoId("_1CZz98-nEeufOvGsyZiDWA")]
    [DisplayName("Buy Sell Back")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuySellBck")]
    #endif
    [IsoXmlTag("BuySellBck")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice18Choice_? BuySellBack { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice18Choice_? BuySellBack { get; init; } 
    #else
    public SecuritiesTransactionPrice18Choice_? BuySellBack { get; set; } 
    #endif
    
    
    #nullable disable
    
}
