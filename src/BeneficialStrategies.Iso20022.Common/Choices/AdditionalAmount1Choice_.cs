// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between additional cash in or resulting cash out.
    /// </summary>
    [KnownType(typeof(AdditionalAmount1Choice.AdditionalCashIn))]
    [KnownType(typeof(AdditionalAmount1Choice.ResultingCashOut))]
    [JsonDerivedType(
        typeof(AdditionalAmount1Choice.AdditionalCashIn),
        nameof(AdditionalAmount1Choice.AdditionalCashIn)
    )]
    [JsonDerivedType(
        typeof(AdditionalAmount1Choice.ResultingCashOut),
        nameof(AdditionalAmount1Choice.ResultingCashOut)
    )]
    [IsoId("_hlWuoEG_EeaNEqIb_fgRZg")]
    [DisplayName("Additional Amount 1 Choice")]
    public abstract record AdditionalAmount1Choice_ { }
}
