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
/// Signed face amount and amortised value.
/// </summary>
[IsoId("_L9-5KTq5EeWQ1Y7f8kds2A")]
[DisplayName("Original And Current Quantities")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OriginalAndCurrentQuantities6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OriginalAndCurrentQuantities6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OriginalAndCurrentQuantities6( ShortLong1Code reqShortLongPosition,ImpliedCurrencyAndAmount reqFaceAmount,ImpliedCurrencyAndAmount reqAmortisedValue )
    {
        ShortLongPosition = reqShortLongPosition;
        FaceAmount = reqFaceAmount;
        AmortisedValue = reqAmortisedValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    [IsoId("_MLOD4zq5EeWQ1Y7f8kds2A")]
    [DisplayName("Short Long Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtLngPos")]
    #endif
    [IsoXmlTag("ShrtLngPos")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ShortLong1Code ShortLongPosition { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ShortLong1Code ShortLongPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShortLong1Code ShortLongPosition { get; init; } 
    #else
    public ShortLong1Code ShortLongPosition { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity expressed as an amount representing the face amount, that is, the principal, of a debt instrument.
    /// </summary>
    [IsoId("_MLOD5Tq5EeWQ1Y7f8kds2A")]
    [DisplayName("Face Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaceAmt")]
    #endif
    [IsoXmlTag("FaceAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount FaceAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount FaceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount FaceAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount FaceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond&apos;s principal amount.
    /// </summary>
    [IsoId("_MLOD7Tq5EeWQ1Y7f8kds2A")]
    [DisplayName("Amortised Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmtsdVal")]
    #endif
    [IsoXmlTag("AmtsdVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount AmortisedValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount AmortisedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount AmortisedValue { get; init; } 
    #else
    public ImpliedCurrencyAndAmount AmortisedValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
