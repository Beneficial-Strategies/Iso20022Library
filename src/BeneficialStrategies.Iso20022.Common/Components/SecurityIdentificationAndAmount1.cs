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
/// Specifies the current valuation of a security.
/// </summary>
[IsoId("_HfBSwK_7EeaE9YROwd69hA")]
[DisplayName("Security Identification And Amount")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityIdentificationAndAmount1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityIdentificationAndAmount1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityIdentificationAndAmount1( System.String reqIdentification,ActiveCurrencyAnd24Amount reqMarketValue,ProductType7Code reqFinancialInstrumentType )
    {
        Identification = reqIdentification;
        MarketValue = reqMarketValue;
        FinancialInstrumentType = reqFinancialInstrumentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// ISIN of the outright investment.
    /// </summary>
    [IsoId("_RK0CoK_7EeaE9YROwd69hA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINOct2015Identifier Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the outright investment according to the CCP’s system of record.
    /// </summary>
    [IsoId("_ULeXQK_7EeaE9YROwd69hA")]
    [DisplayName("Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktVal")]
    #endif
    [IsoXmlTag("MktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAnd24Amount MarketValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAnd24Amount MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAnd24Amount MarketValue { get; init; } 
    #else
    public ActiveCurrencyAnd24Amount MarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Type of a financial instrument: an equity, bond or other.
    /// </summary>
    [IsoId("_kn10ADXsEemdWfjs3tykFQ")]
    [DisplayName("Financial Instrument Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmTp")]
    #endif
    [IsoXmlTag("FinInstrmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ProductType7Code FinancialInstrumentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ProductType7Code FinancialInstrumentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductType7Code FinancialInstrumentType { get; init; } 
    #else
    public ProductType7Code FinancialInstrumentType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
