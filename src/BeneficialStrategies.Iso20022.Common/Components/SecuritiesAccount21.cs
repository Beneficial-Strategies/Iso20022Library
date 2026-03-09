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
/// Unambiguous identification for the account between the account owner and the account servicer.
/// </summary>
[IsoId("_m-Itu_NBEeCuA5Tr22BnwA_1737617622")]
[DisplayName("Securities Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccount21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesAccount21 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesAccount21( AccountIdentification5 reqAccount )
    {
        Account = reqAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Account identification.
    /// </summary>
    [IsoId("_m-SesPNBEeCuA5Tr22BnwA_1237780923")]
    [DisplayName("Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Acct")]
    #endif
    [IsoXmlTag("Acct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountIdentification5 Account { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountIdentification5 Account { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification5 Account { get; init; } 
    #else
    public AccountIdentification5 Account { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-account identification.
    /// </summary>
    [IsoId("_m-SesfNBEeCuA5Tr22BnwA_607511995")]
    [DisplayName("Sub Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubAcct")]
    #endif
    [IsoXmlTag("SubAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification5? SubAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification5? SubAccount { get; init; } 
    #else
    public AccountIdentification5? SubAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Base currency for the account.
    /// </summary>
    [IsoId("_m-SesvNBEeCuA5Tr22BnwA_1306004853")]
    [DisplayName("Base Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BaseCcy")]
    #endif
    [IsoXmlTag("BaseCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? BaseCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? BaseCurrency { get; init; } 
    #else
    public string? BaseCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency chosen for reporting purposes by the account owner in agreement with the account servicer.
    /// </summary>
    [IsoId("_m-Ses_NBEeCuA5Tr22BnwA_1419598212")]
    [DisplayName("Reporting Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCcy")]
    #endif
    [IsoXmlTag("RptgCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? ReportingCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? ReportingCurrency { get; init; } 
    #else
    public string? ReportingCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Foreign exchange rate applied between the reporting and base currencies. It is assumed the valuation date is the same as the report date.
    /// </summary>
    [IsoId("_m-SetPNBEeCuA5Tr22BnwA_-2029423443")]
    [DisplayName("Foreign Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXRate")]
    #endif
    [IsoXmlTag("FXRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? ForeignExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ForeignExchangeRate { get; init; } 
    #else
    public System.Decimal? ForeignExchangeRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
