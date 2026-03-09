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
[IsoId("_SpUJrtp-Ed-ak6NoX_4Aeg_-1123474716")]
[DisplayName("Adjustment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Adjustment5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Adjustment5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Adjustment5( AdjustmentDirection1Code reqDirection,ActiveCurrencyAndAmount reqAmount )
    {
        Direction = reqDirection;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the adjustment must be substracted or added to the total amount.
    /// </summary>
    [IsoId("_SpdTkNp-Ed-ak6NoX_4Aeg_-1123474593")]
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
    
    /// <summary>
    /// Specifies the monetary amount of the adjustment.
    /// </summary>
    [IsoId("_SpdTkdp-Ed-ak6NoX_4Aeg_-1123474532")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
