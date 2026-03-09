// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.ExchangeRateReportOrError2Choice
{
    /// <summary>
    /// Requested business information.
    /// </summary>
    [IsoId("_77TPQ6MgEeCJ6YNENx4h-w_-1305206641")]
    [DisplayName("Currency Exchange")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CurrencyExchange : ExchangeRateReportOrError2Choice_
    #else
    public partial class CurrencyExchange : ExchangeRateReportOrError2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CurrencyExchange instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CurrencyExchange( System.Decimal reqExchangeRate,string reqQuotedCurrency,System.DateTime reqQuotationDate )
        {
            ExchangeRate = reqExchangeRate;
            QuotedCurrency = reqQuotedCurrency;
            QuotationDate = reqQuotationDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
        /// </summary>
        [IsoId("_77cZMKMgEeCJ6YNENx4h-w_150823148")]
        [DisplayName("Exchange Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="XchgRate")]
        #endif
        [IsoXmlTag("XchgRate")]
        [IsoSimpleType(IsoSimpleType.BaseOneRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoBaseOneRate ExchangeRate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.Decimal ExchangeRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal ExchangeRate { get; init; } 
        #else
        public System.Decimal ExchangeRate { get; set; } 
        #endif
        
        /// <summary>
        /// Currency into which the base currency is converted, in a currency exchange.
        /// </summary>
        [IsoId("_77cZMaMgEeCJ6YNENx4h-w_-47235485")]
        [DisplayName("Quoted Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="QtdCcy")]
        #endif
        [IsoXmlTag("QtdCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveOrHistoricCurrencyCode QuotedCurrency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string QuotedCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string QuotedCurrency { get; init; } 
        #else
        public string QuotedCurrency { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which an exchange rate is quoted.
        /// </summary>
        [IsoId("_77cZMqMgEeCJ6YNENx4h-w_1808142586")]
        [DisplayName("Quotation Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="QtnDt")]
        #endif
        [IsoXmlTag("QtnDt")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime QuotationDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateTime QuotationDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime QuotationDate { get; init; } 
        #else
        public System.DateTime QuotationDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
