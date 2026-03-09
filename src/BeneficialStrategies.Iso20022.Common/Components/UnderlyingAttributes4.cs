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
/// Provides additional details on the underlying. In securities financing deals, it is used to identify and provide information on the collateral.
/// </summary>
[IsoId("_1RJ4sWp7EemmaZLSPtWX5A")]
[DisplayName("Underlying Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingAttributes4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Percent of the strike price that this underlying represents.
    /// </summary>
    [IsoId("_1cvdoWp7EemmaZLSPtWX5A")]
    [DisplayName("Allocation Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllcnPctg")]
    #endif
    [IsoXmlTag("AllcnPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? AllocationPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AllocationPercentage { get; init; } 
    #else
    public System.Decimal? AllocationPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Unit amount of the underlying security.
    /// </summary>
    [IsoId("_1cwEt2p7EemmaZLSPtWX5A")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? Quantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates order settlement period for the underlying instrument. Represents the number of days until settlement; for example, 2 means T+1 settlement, 4 means T+3 settlement, 5 means T+4 settlement.
    /// </summary>
    [IsoId("_1cwEuWp7EemmaZLSPtWX5A")]
    [DisplayName("Settlement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmTp")]
    #endif
    [IsoXmlTag("SttlmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementType3Choice_? SettlementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementType3Choice_? SettlementType { get; init; } 
    #else
    public SettlementType3Choice_? SettlementType { get; set; } 
    #endif
    
    /// <summary>
    /// Cash amount associated with the underlying component. Necessary for derivatives that deliver into more than one underlying instrument and one of the underlying&apos;s is a fixed cash value.
    /// </summary>
    [IsoId("_1cwEwWp7EemmaZLSPtWX5A")]
    [DisplayName("Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAmt")]
    #endif
    [IsoXmlTag("CshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CashAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Represents how the cash will be calculated. Indicates that the cash is either fixed or a difference value (difference between strike and current underlying price).
    /// </summary>
    [IsoId("_1cwEyWp7EemmaZLSPtWX5A")]
    [DisplayName("Cash Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshTp")]
    #endif
    [IsoXmlTag("CshTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CashType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CashType { get; init; } 
    #else
    public System.String? CashType { get; set; } 
    #endif
    
    /// <summary>
    /// In a financing deal, clean price (percent-of-par or per unit) of the underlying security or basket.
    /// </summary>
    [IsoId("_1cwE0Wp7EemmaZLSPtWX5A")]
    [DisplayName("Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pric")]
    #endif
    [IsoXmlTag("Pric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price8? Price { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price8? Price { get; init; } 
    #else
    public Price8? Price { get; set; } 
    #endif
    
    /// <summary>
    /// In a financing deal, price (percent-of-par or per unit) of the underlying security or basket. &quot;Dirty&quot; means it includes accrued interest.
    /// </summary>
    [IsoId("_1cwE2Wp7EemmaZLSPtWX5A")]
    [DisplayName("Dirty Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrtyPric")]
    #endif
    [IsoXmlTag("DrtyPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price8? DirtyPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price8? DirtyPrice { get; init; } 
    #else
    public Price8? DirtyPrice { get; set; } 
    #endif
    
    /// <summary>
    /// In a financing deal, price (percent-of-par or per unit) of the underlying security or basket at the end of the agreement.
    /// </summary>
    [IsoId("_1cwE4Wp7EemmaZLSPtWX5A")]
    [DisplayName("End Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndPric")]
    #endif
    [IsoXmlTag("EndPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price8? EndPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price8? EndPrice { get; init; } 
    #else
    public Price8? EndPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Currency value attributed to this collateral at the start of the agreement.
    /// </summary>
    [IsoId("_1cwE6Wp7EemmaZLSPtWX5A")]
    [DisplayName("Start Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartVal")]
    #endif
    [IsoXmlTag("StartVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? StartValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? StartValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? StartValue { get; set; } 
    #endif
    
    /// <summary>
    /// Currency value currently attributed to this collateral.
    /// </summary>
    [IsoId("_1cwE8Wp7EemmaZLSPtWX5A")]
    [DisplayName("Current Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurVal")]
    #endif
    [IsoXmlTag("CurVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CurrentValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CurrentValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CurrentValue { get; set; } 
    #endif
    
    /// <summary>
    /// Currency value attributed to this collateral at the end of the agreement.
    /// </summary>
    [IsoId("_1cwE-Wp7EemmaZLSPtWX5A")]
    [DisplayName("End Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndVal")]
    #endif
    [IsoXmlTag("EndVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? EndValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? EndValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? EndValue { get; set; } 
    #endif
    
    /// <summary>
    /// Unit amount of the underlying security (shares) adjusted for pending corporate action not yet allocated.
    /// </summary>
    [IsoId("_1cwFAWp7EemmaZLSPtWX5A")]
    [DisplayName("Adjusted Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstdQty")]
    #endif
    [IsoXmlTag("AdjstdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? AdjustedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? AdjustedQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? AdjustedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Foreign exchange rate used to compute the current value.
    /// </summary>
    [IsoId("_1cwFA2p7EemmaZLSPtWX5A")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ExchangeRate { get; init; } 
    #else
    public System.Decimal? ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum notional value for a financial instrument that is capped.
    /// </summary>
    [IsoId("_1cwFC2p7EemmaZLSPtWX5A")]
    [DisplayName("Cap Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CapVal")]
    #endif
    [IsoXmlTag("CapVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? CapValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? CapValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? CapValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
