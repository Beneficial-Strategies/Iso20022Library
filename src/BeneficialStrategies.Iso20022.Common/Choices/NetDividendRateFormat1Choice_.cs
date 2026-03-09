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
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat1Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat1Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRateFormat1Choice.Amount),nameof(NetDividendRateFormat1Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus),nameof(NetDividendRateFormat1Choice.RateTypeAndAmountAndRateStatus))]
    [JsonDerivedType(typeof(NetDividendRateFormat1Choice.NotSpecifiedRate),nameof(NetDividendRateFormat1Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_UOfXvNp-Ed-ak6NoX_4Aeg_1518190054")]
    [DisplayName("Net Dividend Rate Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat1Choice_
    #else
    public abstract partial class NetDividendRateFormat1Choice_
    #endif
    {
    }
}
