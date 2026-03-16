// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of an EU capital gain type.
    /// </summary>
    [KnownType(typeof(EUCapitalGainType3Choice.EUCapitalGain))]
    [KnownType(typeof(EUCapitalGainType3Choice.Proprietary))]
    [JsonDerivedType(
        typeof(EUCapitalGainType3Choice.EUCapitalGain),
        nameof(EUCapitalGainType3Choice.EUCapitalGain)
    )]
    [JsonDerivedType(
        typeof(EUCapitalGainType3Choice.Proprietary),
        nameof(EUCapitalGainType3Choice.Proprietary)
    )]
    [IsoId("_XolpcZBhEeakHoV5BVecAQ")]
    [DisplayName("EU Capital Gain Type 3 Choice")]
    public abstract record EUCapitalGainType3Choice_ { }
}
