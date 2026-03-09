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
/// Provides information about the CA entitlement.
/// </summary>
[IsoId("_UJIWmdp-Ed-ak6NoX_4Aeg_1024355345")]
[DisplayName("Entitlement Advice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EntitlementAdvice1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EntitlementAdvice1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EntitlementAdvice1( CorporateActionOption1FormatChoice_ reqOptionType,System.String reqOptionNumber )
    {
        OptionType = reqOptionType;
        OptionNumber = reqOptionNumber;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UJIWmtp-Ed-ak6NoX_4Aeg_1854599346")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #else
    public CorporateActionOption1FormatChoice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UJIWm9p-Ed-ak6NoX_4Aeg_1854599377")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OptionNumber { get; init; } 
    #else
    public System.String OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the holders of securities are/will be recorded for the income being paid or for entitlement to the rights or offer/privilege.
    /// </summary>
    [IsoId("_UJIWnNp-Ed-ak6NoX_4Aeg_235074739")]
    [DisplayName("Record Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdDt")]
    #endif
    [IsoXmlTag("RcrdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? RecordDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? RecordDate { get; init; } 
    #else
    public DateFormat4Choice_? RecordDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which securities/cash will be paid.
    /// </summary>
    [IsoId("_UJRggNp-Ed-ak6NoX_4Aeg_295101123")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat4Choice_? PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat4Choice_? PaymentDate { get; init; } 
    #else
    public DateFormat4Choice_? PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the entitlement and the entitled account.
    /// </summary>
    [IsoId("_UJRggdp-Ed-ak6NoX_4Aeg_-1335835024")]
    [DisplayName("Account And Distribution Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctAndDstrbtnDtls")]
    #endif
    [IsoXmlTag("AcctAndDstrbtnDtls")]
    public ValueList<Entitlement1> AccountAndDistributionDetails { get; init; } = new ValueList<Entitlement1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _UJRggdp-Ed-ak6NoX_4Aeg_-1335835024
    
    
    #nullable disable
    
}
