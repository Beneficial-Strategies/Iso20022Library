// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRate1Choice.NotSpecifiedRate))]
    [KnownType(typeof(GrossDividendRate1Choice.Amount))]
    [KnownType(typeof(GrossDividendRate1Choice.RateTypeAmount))]
    [JsonDerivedType(
        typeof(GrossDividendRate1Choice.NotSpecifiedRate),
        nameof(GrossDividendRate1Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRate1Choice.Amount),
        nameof(GrossDividendRate1Choice.Amount)
    )]
    [JsonDerivedType(
        typeof(GrossDividendRate1Choice.RateTypeAmount),
        nameof(GrossDividendRate1Choice.RateTypeAmount)
    )]
    [IsoId("_UPO-mdp-Ed-ak6NoX_4Aeg_1360546700")]
    [DisplayName("Gross Dividend Rate 1 Choice")]
    public abstract record GrossDividendRate1Choice_ { }
}
