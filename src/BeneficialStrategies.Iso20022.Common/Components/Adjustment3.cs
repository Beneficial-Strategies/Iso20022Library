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
/// Modification on the value of goods and / or services. For example: rebate, discount, surcharge.
/// </summary>
[IsoId("_SpUJotp-Ed-ak6NoX_4Aeg_912882684")]
[DisplayName("Adjustment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Adjustment3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Adjustment3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Adjustment3( AdjustmentType2Code reqType,System.String reqOtherAdjustmentType,CurrencyAndAmount reqAmount,System.Decimal reqRate,AdjustmentDirection1Code reqDirection )
    {
        Type = reqType;
        OtherAdjustmentType = reqOtherAdjustmentType;
        Amount = reqAmount;
        Rate = reqRate;
        Direction = reqDirection;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of adjustment applied to the amount of goods/services by means of a code.
    /// </summary>
    [IsoId("_SpUJo9p-Ed-ak6NoX_4Aeg_912882709")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdjustmentType2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdjustmentType2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdjustmentType2Code Type { get; init; } 
    #else
    public AdjustmentType2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a type of adjustment not present in the code list.
    /// </summary>
    [IsoId("_SpUJpNp-Ed-ak6NoX_4Aeg_912882726")]
    [DisplayName("Other Adjustment Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrAdjstmntTp")]
    #endif
    [IsoXmlTag("OthrAdjstmntTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OtherAdjustmentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OtherAdjustmentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OtherAdjustmentType { get; init; } 
    #else
    public System.String OtherAdjustmentType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the monetary amount of the adjustment.
    /// </summary>
    [IsoId("_SpUJpdp-Ed-ak6NoX_4Aeg_912882986")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyAndAmount Amount { get; init; } 
    #else
    public CurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the percentage rate of the adjustment.
    /// </summary>
    [IsoId("_SpUJptp-Ed-ak6NoX_4Aeg_912883021")]
    [DisplayName("Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rate")]
    #endif
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Rate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Rate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Rate { get; init; } 
    #else
    public System.Decimal Rate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the adjustment must be subtracted or added to the total amount.
    /// </summary>
    [IsoId("_SpUJp9p-Ed-ak6NoX_4Aeg_912882744")]
    [DisplayName("Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Drctn")]
    #endif
    [IsoXmlTag("Drctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdjustmentDirection1Code Direction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdjustmentDirection1Code Direction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdjustmentDirection1Code Direction { get; init; } 
    #else
    public AdjustmentDirection1Code Direction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
