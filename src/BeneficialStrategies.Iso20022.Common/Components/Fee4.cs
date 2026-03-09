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
/// Amount of money associated with a service.
/// </summary>
[IsoId("_Xqq34YjJEeeqaMoyJI1HbA")]
[DisplayName("Fee")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Fee4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Fee4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Fee4( ChargeType6Choice_ reqType,ActiveCurrencyAndAmount reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of fee.
    /// </summary>
    [IsoId("_X518V4jJEeeqaMoyJI1HbA")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ChargeType6Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ChargeType6Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeType6Choice_ Type { get; init; } 
    #else
    public ChargeType6Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Method used to calculate the fee.
    /// </summary>
    [IsoId("_X518WYjJEeeqaMoyJI1HbA")]
    [DisplayName("Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bsis")]
    #endif
    [IsoXmlTag("Bsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBasis2Choice_? Basis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBasis2Choice_? Basis { get; init; } 
    #else
    public ChargeBasis2Choice_? Basis { get; set; } 
    #endif
    
    /// <summary>
    /// Fee amount.
    /// </summary>
    [IsoId("_X518W4jJEeeqaMoyJI1HbA")]
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
    
    /// <summary>
    /// Discount or waiver applied to the fee.
    /// </summary>
    [IsoId("_X518X4jJEeeqaMoyJI1HbA")]
    [DisplayName("Discount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntDtls")]
    #endif
    [IsoXmlTag("DscntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeOrCommissionDiscount2? DiscountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeOrCommissionDiscount2? DiscountDetails { get; init; } 
    #else
    public ChargeOrCommissionDiscount2? DiscountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Party that bears the fee.
    /// </summary>
    [IsoId("_SMRgEYjKEeeqaMoyJI1HbA")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearer1Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearer1Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearer1Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Party entitled to the amount of money resulting from the fee.
    /// </summary>
    [IsoId("_X518Z4jJEeeqaMoyJI1HbA")]
    [DisplayName("Recipient Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcptId")]
    #endif
    [IsoXmlTag("RcptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification113? RecipientIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification113? RecipientIdentification { get; init; } 
    #else
    public PartyIdentification113? RecipientIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
