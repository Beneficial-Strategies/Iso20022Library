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
/// Elements used to calculate the collateral margin call for the variation margin.
/// </summary>
[IsoId("_UnE22tp-Ed-ak6NoX_4Aeg_12968577")]
[DisplayName("Variation Margin")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VariationMargin1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VariationMargin1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VariationMargin1( ActiveCurrencyAndAmount reqThresholdAmount,ActiveCurrencyAndAmount reqMinimumTransferAmount,ActiveCurrencyAndAmount reqRoundingAmount,RoundingMethod1Code reqRoundingMethod )
    {
        ThresholdAmount = reqThresholdAmount;
        MinimumTransferAmount = reqMinimumTransferAmount;
        RoundingAmount = reqRoundingAmount;
        RoundingMethod = reqRoundingMethod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Amount of unsecured exposure a counterparty will accept before issuing a margin call in the base currency.
    /// </summary>
    [IsoId("_UnOn0Np-Ed-ak6NoX_4Aeg_-1210355091")]
    [DisplayName("Threshold Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrshldAmt")]
    #endif
    [IsoXmlTag("ThrshldAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount ThresholdAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount ThresholdAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount ThresholdAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount ThresholdAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the threshold amount is secured or unsecured.
    /// </summary>
    [IsoId("_UnOn0dp-Ed-ak6NoX_4Aeg_-554608677")]
    [DisplayName("Threshold Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrshldTp")]
    #endif
    [IsoXmlTag("ThrshldTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ThresholdType1Code? ThresholdType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ThresholdType1Code? ThresholdType { get; init; } 
    #else
    public ThresholdType1Code? ThresholdType { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum amount to pay/receive as specified in the agreement in the base currency (to avoid the need to transfer an inconveniently small amount of variation margin).
    /// </summary>
    [IsoId("_UnOn0tp-Ed-ak6NoX_4Aeg_1747658948")]
    [DisplayName("Minimum Transfer Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinTrfAmt")]
    #endif
    [IsoXmlTag("MinTrfAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount MinimumTransferAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount MinimumTransferAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount MinimumTransferAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount MinimumTransferAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount specified to avoid the need to transfer uneven amounts of collateral.
    /// </summary>
    [IsoId("_UnOn09p-Ed-ak6NoX_4Aeg_-1680572847")]
    [DisplayName("Rounding Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgAmt")]
    #endif
    [IsoXmlTag("RndgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount RoundingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount RoundingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount RoundingAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount RoundingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Defines how the rounding amount was applied in the calculation. For example, should the amount of collateral required be rounded up, down, to the closer integral multiple specified or not rounded.
    /// </summary>
    [IsoId("_UnOn1Np-Ed-ak6NoX_4Aeg_2069494905")]
    [DisplayName("Rounding Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgMtd")]
    #endif
    [IsoXmlTag("RndgMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RoundingMethod1Code RoundingMethod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RoundingMethod1Code RoundingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RoundingMethod1Code RoundingMethod { get; init; } 
    #else
    public RoundingMethod1Code RoundingMethod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
