// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of an EU capital gain type.
    /// </summary>
    [KnownType(typeof(EUCapitalGainType2Choice.EUCapitalGain))]
    [KnownType(typeof(EUCapitalGainType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(EUCapitalGainType2Choice.EUCapitalGain),
        nameof(EUCapitalGainType2Choice.EUCapitalGain)
    )]
    [JsonDerivedType(
        typeof(EUCapitalGainType2Choice.Proprietary),
        nameof(EUCapitalGainType2Choice.Proprietary)
    )]
    [IsoId("_f57zwNoqEeCWg-hsBVGrDA_-1171256508")]
    [DisplayName("EU Capital Gain Type 2 Choice")]
    public abstract record EUCapitalGainType2Choice_ { }
}
