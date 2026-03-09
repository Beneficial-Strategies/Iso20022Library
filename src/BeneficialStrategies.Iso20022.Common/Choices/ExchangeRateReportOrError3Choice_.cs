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
    /// It is used to provide information on static data maintained by the transaction administrator and related to currency exchange details as maintained for system operations by the transaction administrator.
    /// </summary>
    [KnownType(typeof(ExchangeRateReportOrError3Choice.CurrencyExchangeReport))]
    [KnownType(typeof(ExchangeRateReportOrError3Choice.OperationalError))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ExchangeRateReportOrError3Choice.CurrencyExchangeReport),nameof(ExchangeRateReportOrError3Choice.CurrencyExchangeReport))]
    [JsonDerivedType(typeof(ExchangeRateReportOrError3Choice.OperationalError),nameof(ExchangeRateReportOrError3Choice.OperationalError))]
    #endif
    [IsoId("_MkkyYNfiEeqoweZZxm4TPQ")]
    [DisplayName("Exchange Rate Report Or Error 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExchangeRateReportOrError3Choice_
    #else
    public abstract partial class ExchangeRateReportOrError3Choice_
    #endif
    {
    }
}
