// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a frequency, for example, the frequency of delivery of a statement.
    /// </summary>
    [KnownType(typeof(Frequency9Choice.Code))]
    [KnownType(typeof(Frequency9Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency9Choice.Code),nameof(Frequency9Choice.Code))]
    [JsonDerivedType(typeof(Frequency9Choice.Proprietary),nameof(Frequency9Choice.Proprietary))]
    [IsoId("_muwIS_70EeCKvdA5_Kg7Aw")]
    [DisplayName("Frequency 9 Choice")]
    public abstract partial record Frequency9Choice_
    {
    }
}
