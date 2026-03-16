// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, the frequency of payment.
    /// </summary>
    [KnownType(typeof(Frequency36Choice.Type))]
    [KnownType(typeof(Frequency36Choice.Period))]
    [KnownType(typeof(Frequency36Choice.PointInTime))]
    [JsonDerivedType(typeof(Frequency36Choice.Type), nameof(Frequency36Choice.Type))]
    [JsonDerivedType(typeof(Frequency36Choice.Period), nameof(Frequency36Choice.Period))]
    [JsonDerivedType(typeof(Frequency36Choice.PointInTime), nameof(Frequency36Choice.PointInTime))]
    [IsoId("_sVM2vWk2Eeanu6HLe77Rkg")]
    [DisplayName("Frequency 36 Choice")]
    public abstract record Frequency36Choice_ { }
}
