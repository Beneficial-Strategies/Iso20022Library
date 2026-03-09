// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reports either on currency exchange information or on a business error.
    /// </summary>
    [KnownType(typeof(ExchangeRateReportOrError2Choice.BusinessError))]
    [KnownType(typeof(ExchangeRateReportOrError2Choice.CurrencyExchange))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ExchangeRateReportOrError2Choice.BusinessError),nameof(ExchangeRateReportOrError2Choice.BusinessError))]
    [JsonDerivedType(typeof(ExchangeRateReportOrError2Choice.CurrencyExchange),nameof(ExchangeRateReportOrError2Choice.CurrencyExchange))]
    #endif
    [IsoId("_77TPQaMgEeCJ6YNENx4h-w_315557702")]
    [DisplayName("Exchange Rate Report Or Error 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExchangeRateReportOrError2Choice_
    #else
    public abstract partial class ExchangeRateReportOrError2Choice_
    #endif
    {
    }
}
