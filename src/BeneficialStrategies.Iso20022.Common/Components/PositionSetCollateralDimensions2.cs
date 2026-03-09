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
/// Variables related to derivatives that are used to group derivatives together into positions for collateral position sets and currency collateral position sets reports. 
/// </summary>
[IsoId("_83N69eNfEeiTop2HXWk15w")]
[DisplayName("Position Set Collateral Dimensions")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PositionSetCollateralDimensions2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_9BppUeNfEeiTop2HXWk15w")]
    [DisplayName("Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyId")]
    #endif
    [IsoXmlTag("CtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeCounterpartyReport9? CounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeCounterpartyReport9? CounterpartyIdentification { get; init; } 
    #else
    public TradeCounterpartyReport9? CounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Information indicating the type of collateral agreement existing between counterparties.
    /// </summary>
    [IsoId("_9BppU-NfEeiTop2HXWk15w")]
    [DisplayName("Collateralisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Collstn")]
    #endif
    [IsoXmlTag("Collstn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralisationType1Code? Collateralisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralisationType1Code? Collateralisation { get; init; } 
    #else
    public CollateralisationType1Code? Collateralisation { get; set; } 
    #endif
    
    /// <summary>
    /// A unique code determined by the reporting counterparty to identify the portfolio if collateral is reported on a portfolio basis.
    /// </summary>
    [IsoId("_9BppVeNfEeiTop2HXWk15w")]
    [DisplayName("Portfolio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtfl")]
    #endif
    [IsoXmlTag("Prtfl")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? Portfolio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Portfolio { get; init; } 
    #else
    public System.String? Portfolio { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the initial margin posted by the reporting counterparty to the other counterparty.
    /// </summary>
    [IsoId("_9BppV-NfEeiTop2HXWk15w")]
    [DisplayName("Initial Margin Posted Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnPstdCcy")]
    #endif
    [IsoXmlTag("InitlMrgnPstdCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? InitialMarginPostedCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? InitialMarginPostedCurrency { get; init; } 
    #else
    public string? InitialMarginPostedCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the variation margin posted, including cash settled, by the reporting counterparty to the other counterparty.
    /// </summary>
    [IsoId("_9BppWeNfEeiTop2HXWk15w")]
    [DisplayName("Variation Margin Posted Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnPstdCcy")]
    #endif
    [IsoXmlTag("VartnMrgnPstdCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? VariationMarginPostedCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? VariationMarginPostedCurrency { get; init; } 
    #else
    public string? VariationMarginPostedCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the initial margin received by the reporting counterparty from the other counterparty.
    /// </summary>
    [IsoId("_9BppW-NfEeiTop2HXWk15w")]
    [DisplayName("Initial Margin Received Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlMrgnRcvdCcy")]
    #endif
    [IsoXmlTag("InitlMrgnRcvdCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? InitialMarginReceivedCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? InitialMarginReceivedCurrency { get; init; } 
    #else
    public string? InitialMarginReceivedCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the variation margin received, including cash settled, by the reporting counterparty from the other counterparty.
    /// </summary>
    [IsoId("_9BppXeNfEeiTop2HXWk15w")]
    [DisplayName("Variation Margin Received Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VartnMrgnRcvdCcy")]
    #endif
    [IsoXmlTag("VartnMrgnRcvdCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? VariationMarginReceivedCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? VariationMarginReceivedCurrency { get; init; } 
    #else
    public string? VariationMarginReceivedCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of collateral posted in excess of the required collateral.
    /// </summary>
    [IsoId("_9BppX-NfEeiTop2HXWk15w")]
    [DisplayName("Excess Collateral Posted Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollPstdCcy")]
    #endif
    [IsoXmlTag("XcssCollPstdCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? ExcessCollateralPostedCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ExcessCollateralPostedCurrency { get; init; } 
    #else
    public string? ExcessCollateralPostedCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of collateral received in excess of the required collateral.
    /// </summary>
    [IsoId("_9BppYeNfEeiTop2HXWk15w")]
    [DisplayName("Excess Collateral Received Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XcssCollRcvdCcy")]
    #endif
    [IsoXmlTag("XcssCollRcvdCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? ExcessCollateralReceivedCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ExcessCollateralReceivedCurrency { get; init; } 
    #else
    public string? ExcessCollateralReceivedCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
