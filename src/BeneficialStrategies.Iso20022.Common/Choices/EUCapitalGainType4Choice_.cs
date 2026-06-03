// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of an EU capital gain type.
    /// </summary>
    [KnownType(typeof(EUCapitalGainType4Choice.Code))]
    [KnownType(typeof(EUCapitalGainType4Choice.Proprietary))]
    [JsonDerivedType(typeof(EUCapitalGainType4Choice.Code), nameof(EUCapitalGainType4Choice.Code))]
    [JsonDerivedType(typeof(EUCapitalGainType4Choice.Proprietary), nameof(EUCapitalGainType4Choice.Proprietary))]
    [IsoId("f26bb989-1ff2-44c7-9138-732039689e4c")]
    [DisplayName("EU Capital Gain Type 4 Choice")]
    public abstract record EUCapitalGainType4Choice_ { }
}
