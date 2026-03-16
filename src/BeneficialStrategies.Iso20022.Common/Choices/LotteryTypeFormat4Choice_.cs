// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of lottery.
    /// </summary>
    [KnownType(typeof(LotteryTypeFormat4Choice.Code))]
    [KnownType(typeof(LotteryTypeFormat4Choice.Proprietary))]
    [JsonDerivedType(typeof(LotteryTypeFormat4Choice.Code), nameof(LotteryTypeFormat4Choice.Code))]
    [JsonDerivedType(
        typeof(LotteryTypeFormat4Choice.Proprietary),
        nameof(LotteryTypeFormat4Choice.Proprietary)
    )]
    [IsoId("_YSkWQUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Lottery Type Format 4 Choice")]
    public abstract record LotteryTypeFormat4Choice_ { }
}
