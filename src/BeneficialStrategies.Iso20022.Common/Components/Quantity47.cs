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
/// Quantity of assets.
/// </summary>
[IsoId("_wsgl8QVUEeq4ZaI1b_-GPA")]
[DisplayName("Quantity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Quantity47
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of security to be transferred.
    /// </summary>
    [IsoId("_xCEmQQVUEeq4ZaI1b_-GPA")]
    [DisplayName("Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Unit")]
    #endif
    [IsoXmlTag("Unit")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? Unit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? Unit { get; init; } 
    #else
    public System.UInt64? Unit { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage rate of assets to be transferred.
    /// </summary>
    [IsoId("_xCEmQwVUEeq4ZaI1b_-GPA")]
    [DisplayName("Percentage Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PctgRate")]
    #endif
    [IsoXmlTag("PctgRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? PercentageRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? PercentageRate { get; init; } 
    #else
    public System.Decimal? PercentageRate { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
    /// </summary>
    [IsoId("_xCEmRQVUEeq4ZaI1b_-GPA")]
    [DisplayName("Face Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaceAmt")]
    #endif
    [IsoXmlTag("FaceAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? FaceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? FaceAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? FaceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond&apos;s principal amount.
    /// </summary>
    [IsoId("_xCEmRwVUEeq4ZaI1b_-GPA")]
    [DisplayName("Amortised Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtsdVal")]
    #endif
    [IsoXmlTag("AmtsdVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? AmortisedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? AmortisedValue { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? AmortisedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Cash amount to be transferred.
    /// </summary>
    [IsoId("_xCEmSQVUEeq4ZaI1b_-GPA")]
    [DisplayName("Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAmt")]
    #endif
    [IsoXmlTag("CshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAnd13DecimalAmount? CashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd13DecimalAmount? CashAmount { get; init; } 
    #else
    public ActiveCurrencyAnd13DecimalAmount? CashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of asset to be transferred.
    /// </summary>
    [IsoId("_xCEmSwVUEeq4ZaI1b_-GPA")]
    [DisplayName("Other Asset")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAsst")]
    #endif
    [IsoXmlTag("OthrAsst")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherAsset { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherAsset { get; init; } 
    #else
    public System.String? OtherAsset { get; set; } 
    #endif
    
    
    #nullable disable
    
}
