// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of lottery.
    /// </summary>
    [KnownType(typeof(LotteryTypeFormat5Choice.Code))]
    [KnownType(typeof(LotteryTypeFormat5Choice.Proprietary))]
    [JsonDerivedType(typeof(LotteryTypeFormat5Choice.Code), nameof(LotteryTypeFormat5Choice.Code))]
    [JsonDerivedType(
        typeof(LotteryTypeFormat5Choice.Proprietary),
        nameof(LotteryTypeFormat5Choice.Proprietary)
    )]
    [IsoId("_cdS3gZKQEeWHWpTQn1FFVg")]
    [DisplayName("Lottery Type Format 5 Choice")]
    public abstract record LotteryTypeFormat5Choice_ { }
}
