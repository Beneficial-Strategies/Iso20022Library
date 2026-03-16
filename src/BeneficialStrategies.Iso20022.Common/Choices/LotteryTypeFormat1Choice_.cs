// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of lottery.
    /// </summary>
    [KnownType(typeof(LotteryTypeFormat1Choice.Code))]
    [KnownType(typeof(LotteryTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(LotteryTypeFormat1Choice.Code), nameof(LotteryTypeFormat1Choice.Code))]
    [JsonDerivedType(
        typeof(LotteryTypeFormat1Choice.Proprietary),
        nameof(LotteryTypeFormat1Choice.Proprietary)
    )]
    [IsoId("_Q3BFmtp-Ed-ak6NoX_4Aeg_-29945278")]
    [DisplayName("Lottery Type Format 1 Choice")]
    public abstract record LotteryTypeFormat1Choice_ { }
}
