// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a net dividend.
    /// </summary>
    [KnownType(typeof(NetDividendRate1Choice.NotSpecifiedRate))]
    [KnownType(typeof(NetDividendRate1Choice.Amount))]
    [KnownType(typeof(NetDividendRate1Choice.RateTypeAmount))]
    [JsonDerivedType(typeof(NetDividendRate1Choice.NotSpecifiedRate),nameof(NetDividendRate1Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(NetDividendRate1Choice.Amount),nameof(NetDividendRate1Choice.Amount))]
    [JsonDerivedType(typeof(NetDividendRate1Choice.RateTypeAmount),nameof(NetDividendRate1Choice.RateTypeAmount))]
    [IsoId("_UPYvmNp-Ed-ak6NoX_4Aeg_1659440967")]
    [DisplayName("Net Dividend Rate 1 Choice")]
    public abstract partial record NetDividendRate1Choice_
    {
    }
}
