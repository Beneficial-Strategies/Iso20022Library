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
/// Financial instrument which represents a title of ownership in a company, ie, the shareholder is entitled to a part of the company&apos;s profit - usually by payment of a dividend - and to voting rights, if any. Each company issues generally different classes of shares, eg, ordinary or common shares, which have no guaranteed amount of dividend but carry voting rights, or preferred shares, which receive dividends before ordinary shares but have no voting right.
/// </summary>
[IsoId("_Trn7Odp-Ed-ak6NoX_4Aeg_1255525531")]
[DisplayName("Equity")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Equity1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Equity1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Equity1( PreferenceToIncome1Code reqPreferenceToIncome )
    {
        PreferenceToIncome = reqPreferenceToIncome;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the level of priority to claim on income and assets of the company in case of the payment of dividends and in the event of a bankruptcy, for example, ordinary/common stocks, preferred stocks, subordinated debt, etc.
    /// </summary>
    [IsoId("_Trn7Otp-Ed-ak6NoX_4Aeg_-1622516641")]
    [DisplayName("Preference To Income")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrefToIncm")]
    #endif
    [IsoXmlTag("PrefToIncm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PreferenceToIncome1Code PreferenceToIncome { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PreferenceToIncome1Code PreferenceToIncome { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PreferenceToIncome1Code PreferenceToIncome { get; init; } 
    #else
    public PreferenceToIncome1Code PreferenceToIncome { get; set; } 
    #endif
    
    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_Trn7O9p-Ed-ak6NoX_4Aeg_1861986259")]
    [DisplayName("Payment Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSts")]
    #endif
    [IsoXmlTag("PmtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesPaymentStatus1Code? PaymentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesPaymentStatus1Code? PaymentStatus { get; init; } 
    #else
    public SecuritiesPaymentStatus1Code? PaymentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the investor or the issuer has a conversion option.
    /// </summary>
    [IsoId("_TrxFINp-Ed-ak6NoX_4Aeg_1866604916")]
    [DisplayName("Convertible Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvtblInd")]
    #endif
    [IsoXmlTag("ConvtblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ConvertibleIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConvertibleIndicator { get; init; } 
    #else
    public System.String? ConvertibleIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the security will no longer exist, for example, redeemable preference shares.
    /// </summary>
    [IsoId("_TrxFIdp-Ed-ak6NoX_4Aeg_1886922279")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? MaturityDate { get; init; } 
    #else
    public System.DateTime? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Nominal amount which is not paid yet.
    /// </summary>
    [IsoId("_TrxFItp-Ed-ak6NoX_4Aeg_1902621286")]
    [DisplayName("Non Paid Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonPdAmt")]
    #endif
    [IsoXmlTag("NonPdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? NonPaidAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? NonPaidAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? NonPaidAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Nominal value of an equity security.
    /// </summary>
    [IsoId("_TrxFI9p-Ed-ak6NoX_4Aeg_1916473047")]
    [DisplayName("Par Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ParVal")]
    #endif
    [IsoXmlTag("ParVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? ParValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? ParValue { get; init; } 
    #else
    public ActiveCurrencyAndAmount? ParValue { get; set; } 
    #endif
    
    /// <summary>
    /// Number of voting rights per share.
    /// </summary>
    [IsoId("_TrxFJNp-Ed-ak6NoX_4Aeg_1921092172")]
    [DisplayName("Voting Rights Per Share")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VtngRghtsPerShr")]
    #endif
    [IsoXmlTag("VtngRghtsPerShr")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? VotingRightsPerShare { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? VotingRightsPerShare { get; init; } 
    #else
    public System.UInt64? VotingRightsPerShare { get; set; } 
    #endif
    
    
    #nullable disable
    
}
