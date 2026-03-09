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
/// Elements used to calculate the collateral margin call for the segregated independent amount.
/// </summary>
[IsoId("_UnXxwNp-Ed-ak6NoX_4Aeg_-1126124883")]
[DisplayName("Segregated Independent Amount Margin")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SegregatedIndependentAmountMargin1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SegregatedIndependentAmountMargin1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SegregatedIndependentAmountMargin1( ActiveCurrencyAndAmount reqMinimumTransferAmount )
    {
        MinimumTransferAmount = reqMinimumTransferAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Minimum amount to pay/receive as specified in the agreement in the base currency (to avoid the need to transfer an inconveniently small amount of segregated independent amount).
    /// </summary>
    [IsoId("_UnXxwdp-Ed-ak6NoX_4Aeg_-1412205814")]
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
    /// Amount specified to avoid the need to transfer uneven amounts of independent amount collateral.
    /// </summary>
    [IsoId("_UnXxwtp-Ed-ak6NoX_4Aeg_-756493516")]
    [DisplayName("Rounding Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgAmt")]
    #endif
    [IsoXmlTag("RndgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? RoundingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? RoundingAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? RoundingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Defines how the rounding amount was applied in the calculation. For example, should the amount of collateral required be rounded up, down, to the closer integral multiple specified or not rounded.
    /// </summary>
    [IsoId("_UnXxw9p-Ed-ak6NoX_4Aeg_-1527248442")]
    [DisplayName("Rounding Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RndgMtd")]
    #endif
    [IsoXmlTag("RndgMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RoundingMethod1Code? RoundingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RoundingMethod1Code? RoundingMethod { get; init; } 
    #else
    public RoundingMethod1Code? RoundingMethod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
