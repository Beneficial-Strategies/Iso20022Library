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
[IsoId("_Y75JsYmKEeybbN9emGqfiw")]
[DisplayName("Posted Margin Or Collateral")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PostedMarginOrCollateral6
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
    [IsoId("_Y8_88YmKEeybbN9emGqfiw")]
    [DisplayName("Initial Margin Posted Pre Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnPstdPreHrcut")]
    #endif
    [IsoXmlTag("InitlMrgnPstdPreHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginPostedPreHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginPostedPreHaircut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginPostedPreHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the initial margin posted by the reporting counterparty to the other counterparty.
    /// Where initial margin is posted on a portfolio basis, this field should include the overall value of initial margin posted for the portfolio.
    /// Post-haircut values of margins depend on associated risk of changes in collateral value and therefore on the nature of the collateral posted (or collected).
    /// </summary>
    [IsoId("_Y8_884mKEeybbN9emGqfiw")]
    [DisplayName("Initial Margin Posted Post Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnPstdPstHrcut")]
    #endif
    [IsoXmlTag("InitlMrgnPstdPstHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginPostedPostHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginPostedPostHaircut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? InitialMarginPostedPostHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty.
    /// Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// </summary>
    [IsoId("_Y8_89YmKEeybbN9emGqfiw")]
    [DisplayName("Variation Margin Posted Pre Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnPstdPreHrcut")]
    #endif
    [IsoXmlTag("VartnMrgnPstdPreHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginPostedPreHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginPostedPreHaircut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginPostedPreHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty.
    /// Where variation margin is posted on a portfolio basis, this field should include the overall value of variation margin posted for the portfolio.
    /// Post-haircut values of margins depend on associated risk of changes in collateral value and therefore on the nature of the collateral posted (or collected).
    /// </summary>
    [IsoId("_Y8_894mKEeybbN9emGqfiw")]
    [DisplayName("Variation Margin Posted Post Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnPstdPstHrcut")]
    #endif
    [IsoXmlTag("VartnMrgnPstdPstHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginPostedPostHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginPostedPostHaircut { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? VariationMarginPostedPostHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Value of collateral posted in excess of the required collateral.
    /// </summary>
    [IsoId("_Y8_8-YmKEeybbN9emGqfiw")]
    [DisplayName("Excess Collateral Posted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollPstd")]
    #endif
    [IsoXmlTag("XcssCollPstd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? ExcessCollateralPosted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? ExcessCollateralPosted { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAnd20DecimalAmount? ExcessCollateralPosted { get; set; } 
    #endif
    
    
    #nullable disable
    
}
