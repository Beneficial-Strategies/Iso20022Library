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
/// Card account balance.
/// </summary>
[IsoId("_Fwe7QEUSEeea-M6VZkEPUw")]
[DisplayName("Balance")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Balance15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Balance15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Balance15( BalanceType14Code reqType,ImpliedCurrencyAndAmount reqAmount )
    {
        Type = reqType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of card account balance.
    /// </summary>
    [IsoId("_oJ_iEEUSEeea-M6VZkEPUw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceType14Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BalanceType14Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceType14Code Type { get; init; } 
    #else
    public BalanceType14Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Other card account balance type.
    /// </summary>
    [IsoId("_zHWngEUSEeea-M6VZkEPUw")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_5k1oUEUSEeea-M6VZkEPUw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount Amount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the account
    /// </summary>
    [IsoId("_AbuAkEUTEeea-M6VZkEPUw")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ISO3NumericCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the value of the balance id positive or negative.
    /// </summary>
    [IsoId("_JUXcQEUTEeea-M6VZkEPUw")]
    [DisplayName("Sign")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sgn")]
    #endif
    [IsoXmlTag("Sgn")]
    [IsoSimpleType(IsoSimpleType.PlusOrMinusIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPlusOrMinusIndicator? Sign { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Sign { get; init; } 
    #else
    public System.String? Sign { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the value of balance is expressed in the currency of the cardholder or not.
    /// True: Balance is expressed in the currency of the cardholder
    /// False: Balance is expressed in a different currency.
    /// </summary>
    [IsoId("_hsI4YEUTEeea-M6VZkEPUw")]
    [DisplayName("Cardholder Currency Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrdhldrCcyInd")]
    #endif
    [IsoXmlTag("CrdhldrCcyInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? CardholderCurrencyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CardholderCurrencyIndicator { get; init; } 
    #else
    public System.String? CardholderCurrencyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Date of the balance.
    /// </summary>
    [IsoId("_n0y4sEUTEeea-M6VZkEPUw")]
    [DisplayName("Balance Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BalDt")]
    #endif
    [IsoXmlTag("BalDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BalanceDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BalanceDate { get; init; } 
    #else
    public System.DateOnly? BalanceDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
