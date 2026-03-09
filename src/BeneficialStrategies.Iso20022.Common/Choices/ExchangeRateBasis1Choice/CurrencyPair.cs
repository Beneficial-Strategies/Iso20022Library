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
namespace BeneficialStrategies.Iso20022.Choices.ExchangeRateBasis1Choice
{
    /// <summary>
    /// Exchange rate basis expressed as a currency pair.
    /// </summary>
    [IsoId("_PV2OYLpqEea_jI1vMH_RbA")]
    [DisplayName("Currency Pair")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CurrencyPair : ExchangeRateBasis1Choice_
    #else
    public partial class CurrencyPair : ExchangeRateBasis1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CurrencyPair instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CurrencyPair( string reqBaseCurrency,string reqQuotedCurrency )
        {
            BaseCurrency = reqBaseCurrency;
            QuotedCurrency = reqQuotedCurrency;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Currency in which the rate of exchange is expressed in a currency exchange.
        /// Usage: In the example one GBP equals xxxUSD, the unit currency is GBP.
        /// </summary>
        [IsoId("_ui8blg3WEeW9YKj3GUmIEw")]
        [DisplayName("Base Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BaseCcy")]
        #endif
        [IsoXmlTag("BaseCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyCode BaseCurrency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string BaseCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string BaseCurrency { get; init; } 
        #else
        public string BaseCurrency { get; set; } 
        #endif
        
        /// <summary>
        /// Currency into which the base currency is converted, in a currency exchange.
        /// </summary>
        [IsoId("_ui8bng3WEeW9YKj3GUmIEw")]
        [DisplayName("Quoted Currency")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="QtdCcy")]
        #endif
        [IsoXmlTag("QtdCcy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ActiveCurrencyCode QuotedCurrency { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required string QuotedCurrency { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string QuotedCurrency { get; init; } 
        #else
        public string QuotedCurrency { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
