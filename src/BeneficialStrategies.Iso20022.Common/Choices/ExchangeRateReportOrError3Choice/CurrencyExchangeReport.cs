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
namespace BeneficialStrategies.Iso20022.Choices.ExchangeRateReportOrError3Choice
{
    /// <summary>
    /// Reports on currency exchange information.
    /// </summary>
    [IsoId("_MmlkkdfiEeqoweZZxm4TPQ")]
    [DisplayName("Currency Exchange Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record CurrencyExchangeReport : ExchangeRateReportOrError3Choice_
    #else
    public partial class CurrencyExchangeReport : ExchangeRateReportOrError3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a CurrencyExchangeReport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public CurrencyExchangeReport( CurrencySourceTarget1 reqCurrencyReference,ExchangeRateReportOrError4Choice_ reqCurrencyExchangeOrError )
        {
            CurrencyReference = reqCurrencyReference;
            CurrencyExchangeOrError = reqCurrencyExchangeOrError;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Source and target currencies for which information is request.
        /// </summary>
        [IsoId("_MobXodfiEeqoweZZxm4TPQ")]
        [DisplayName("Currency Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CcyRef")]
        #endif
        [IsoXmlTag("CcyRef")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CurrencySourceTarget1 CurrencyReference { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CurrencySourceTarget1 CurrencyReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CurrencySourceTarget1 CurrencyReference { get; init; } 
        #else
        public CurrencySourceTarget1 CurrencyReference { get; set; } 
        #endif
        
        /// <summary>
        /// Reports either on currency exchange information or on a business error.
        /// </summary>
        [IsoId("_MobXo9fiEeqoweZZxm4TPQ")]
        [DisplayName("Currency Exchange Or Error")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CcyXchgOrErr")]
        #endif
        [IsoXmlTag("CcyXchgOrErr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ExchangeRateReportOrError4Choice_ CurrencyExchangeOrError { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ExchangeRateReportOrError4Choice_ CurrencyExchangeOrError { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExchangeRateReportOrError4Choice_ CurrencyExchangeOrError { get; init; } 
        #else
        public ExchangeRateReportOrError4Choice_ CurrencyExchangeOrError { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
