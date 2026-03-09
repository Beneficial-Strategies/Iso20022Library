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
/// Details an individual currency including details on which country trades the currency.
/// </summary>
[IsoId("_c7l_wX58EeaUaa1DpZmwUw")]
[DisplayName("Securities Currency Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesCurrencyIdentification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesCurrencyIdentification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesCurrencyIdentification2( CurrencyCodeAndName1 reqCurrency,CountryCodeAndName3 reqCountryDetails,System.String reqPreEuro,Period4Choice_ reqValidityPeriod )
    {
        Currency = reqCurrency;
        CountryDetails = reqCountryDetails;
        PreEuro = reqPreEuro;
        ValidityPeriod = reqValidityPeriod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details the currency name and ISO 4217 currency code.
    /// </summary>
    [IsoId("_dGAgAX58EeaUaa1DpZmwUw")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyCodeAndName1 Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyCodeAndName1 Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyCodeAndName1 Currency { get; init; } 
    #else
    public CurrencyCodeAndName1 Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Fractional digit for the currency, that is, the number of decimals to use.
    /// </summary>
    [IsoId("_dGAgA358EeaUaa1DpZmwUw")]
    [DisplayName("Fractional Digit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrctnlDgt")]
    #endif
    [IsoXmlTag("FrctnlDgt")]
    [IsoSimpleType(IsoSimpleType.Max1Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1Number? FractionalDigit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? FractionalDigit { get; init; } 
    #else
    public System.UInt64? FractionalDigit { get; set; } 
    #endif
    
    /// <summary>
    /// Details the country name and ISO 3166 country code.
    /// </summary>
    [IsoId("_dGAgBX58EeaUaa1DpZmwUw")]
    [DisplayName("Country Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryDtls")]
    #endif
    [IsoXmlTag("CtryDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CountryCodeAndName3 CountryDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CountryCodeAndName3 CountryDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CountryCodeAndName3 CountryDetails { get; init; } 
    #else
    public CountryCodeAndName3 CountryDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if a currency is a pre Euro currency or not.
    /// </summary>
    [IsoId("_dGAgB358EeaUaa1DpZmwUw")]
    [DisplayName("Pre Euro")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreEuro")]
    #endif
    [IsoXmlTag("PreEuro")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator PreEuro { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PreEuro { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PreEuro { get; init; } 
    #else
    public System.String PreEuro { get; set; } 
    #endif
    
    /// <summary>
    /// Modification status for the record compared to the previous report.
    /// </summary>
    [IsoId("_dGAgCX58EeaUaa1DpZmwUw")]
    [DisplayName("Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mod")]
    #endif
    [IsoXmlTag("Mod")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Modification1Code? Modification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Modification1Code? Modification { get; init; } 
    #else
    public Modification1Code? Modification { get; set; } 
    #endif
    
    /// <summary>
    /// Details the validity of the specific record.
    /// </summary>
    [IsoId("_dGAgC358EeaUaa1DpZmwUw")]
    [DisplayName("Validity Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyPrd")]
    #endif
    [IsoXmlTag("VldtyPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Period4Choice_ ValidityPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Period4Choice_ ValidityPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_ ValidityPeriod { get; init; } 
    #else
    public Period4Choice_ ValidityPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Date when this record was last modified.
    /// </summary>
    [IsoId("_dGAgDX58EeaUaa1DpZmwUw")]
    [DisplayName("Last Updated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastUpdtd")]
    #endif
    [IsoXmlTag("LastUpdtd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LastUpdated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LastUpdated { get; init; } 
    #else
    public System.DateOnly? LastUpdated { get; set; } 
    #endif
    
    
    #nullable disable
    
}
