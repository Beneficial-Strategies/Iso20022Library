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
[IsoId("_OIXCoDh4EeamLZQeccJa7w")]
[DisplayName("Fee")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Fee1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Fee1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Fee1( ChargeType5Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of fee (charge/commission).
    /// </summary>
    [IsoId("_8tq38jh4EeaH-93K5JKmzw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ChargeType5Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ChargeType5Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeType5Choice_ Type { get; init; } 
    #else
    public ChargeType5Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Method used to calculate the fee (charge/commission).
    /// </summary>
    [IsoId("__VgAYjh5EeaH-93K5JKmzw")]
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
    /// Standard fee (charge/commission) amount as specified in the fund prospectus or agreed for the account.
    /// </summary>
    [IsoId("_U-gJIzh6EeaH-93K5JKmzw")]
    [DisplayName("Standard Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StdAmt")]
    #endif
    [IsoXmlTag("StdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? StandardAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? StandardAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? StandardAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Standard fee (charge/commission) rate used to calculate the amount of the charge or fee, as specified in the fund prospectus or agreed for the account.
    /// </summary>
    [IsoId("_U-gJJDh6EeaH-93K5JKmzw")]
    [DisplayName("Standard Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StdRate")]
    #endif
    [IsoXmlTag("StdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? StandardRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? StandardRate { get; init; } 
    #else
    public System.Decimal? StandardRate { get; set; } 
    #endif
    
    /// <summary>
    /// Discount or waiver applied to the fee (charge/commission).
    /// </summary>
    [IsoId("_gJBNQViZEeaMNZxYNthMeA")]
    [DisplayName("Discount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntDtls")]
    #endif
    [IsoXmlTag("DscntDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeOrCommissionDiscount1? DiscountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeOrCommissionDiscount1? DiscountDetails { get; init; } 
    #else
    public ChargeOrCommissionDiscount1? DiscountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Requested fee (charge/commission) amount as agreed for the account.
    /// </summary>
    [IsoId("_rBKSYGRIEeaj9PFzwy2f6A")]
    [DisplayName("Requested Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdAmt")]
    #endif
    [IsoXmlTag("ReqdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? RequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? RequestedAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? RequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Requested rate used to calculate the amount of the fee (charge/commission), as agreed for the account.
    /// </summary>
    [IsoId("_0cBqUWRIEeaj9PFzwy2f6A")]
    [DisplayName("Requested Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdRate")]
    #endif
    [IsoXmlTag("ReqdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? RequestedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RequestedRate { get; init; } 
    #else
    public System.Decimal? RequestedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a sales agreement that overrides normal processing or the Service Level Agreement (SLA), such as a fee (charge/commission).
    /// </summary>
    [IsoId("_WCFjcTkyEeapUO0vUIo9Xw")]
    [DisplayName("Non Standard SLA Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonStdSLARef")]
    #endif
    [IsoXmlTag("NonStdSLARef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? NonStandardSLAReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonStandardSLAReference { get; init; } 
    #else
    public System.String? NonStandardSLAReference { get; set; } 
    #endif
    
    /// <summary>
    /// Party entitled to the amount of money resulting from a fee (charge/commission).
    /// </summary>
    [IsoId("_U-gJJTh6EeaH-93K5JKmzw")]
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
