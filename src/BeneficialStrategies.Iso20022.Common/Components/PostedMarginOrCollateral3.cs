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
/// Information on the posted margin or collateral of the transaction.
/// </summary>
[IsoId("_6UHOsayGEem81-uIvTF5rQ")]
[DisplayName("Posted Margin Or Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PostedMarginOrCollateral3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Value of the initial margin posted by the reporting counterparty to the other counterparty.
    /// Where initial margin is posted on a portfolio basis, this field should include the overall value of initial margin posted for the portfolio.
    /// </summary>
    [IsoId("_6YIzEayGEem81-uIvTF5rQ")]
    [DisplayName("Initial Margin Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnPstd")]
    #endif
    [IsoXmlTag("InitlMrgnPstd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? InitialMarginPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? InitialMarginPosted { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? InitialMarginPosted { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty.
    /// Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// </summary>
    [IsoId("_6YIzE6yGEem81-uIvTF5rQ")]
    [DisplayName("Variation Margin Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnPstd")]
    #endif
    [IsoXmlTag("VartnMrgnPstd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? VariationMarginPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? VariationMarginPosted { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? VariationMarginPosted { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral posted in excess of the required collateral.
    /// </summary>
    [IsoId("_6YIzFayGEem81-uIvTF5rQ")]
    [DisplayName("Excess Collateral Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollPstd")]
    #endif
    [IsoXmlTag("XcssCollPstd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ExcessCollateralPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ExcessCollateralPosted { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ExcessCollateralPosted { get; set; } 
    #endif
    
    
    #nullable disable
    
}
