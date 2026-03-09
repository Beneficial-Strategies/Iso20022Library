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
    /// Choice of format to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRate1Choice.NotSpecifiedRate))]
    [KnownType(typeof(NetDividendRate1Choice.Amount))]
    [KnownType(typeof(NetDividendRate1Choice.RateTypeAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(NetDividendRate1Choice.NotSpecifiedRate),nameof(NetDividendRate1Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(NetDividendRate1Choice.Amount),nameof(NetDividendRate1Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRate1Choice.RateTypeAmount),nameof(NetDividendRate1Choice.RateTypeAmount))]
    #endif
    [IsoId("_UPYvmNp-Ed-ak6NoX_4Aeg_1659440967")]
    [DisplayName("Net Dividend Rate 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRate1Choice_
    #else
    public abstract partial class NetDividendRate1Choice_
    #endif
    {
    }
}
