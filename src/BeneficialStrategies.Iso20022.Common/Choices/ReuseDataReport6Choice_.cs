// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information on reusability of previously submitted data.
    /// </summary>
    [KnownType(typeof(ReuseDataReport6Choice.New))]
    [KnownType(typeof(ReuseDataReport6Choice.Error))]
    [KnownType(typeof(ReuseDataReport6Choice.Correction))]
    [KnownType(typeof(ReuseDataReport6Choice.CollateralReuseUpdate))]
    [JsonDerivedType(typeof(ReuseDataReport6Choice.New),nameof(ReuseDataReport6Choice.New))]
    [JsonDerivedType(typeof(ReuseDataReport6Choice.Error),nameof(ReuseDataReport6Choice.Error))]
    [JsonDerivedType(typeof(ReuseDataReport6Choice.Correction),nameof(ReuseDataReport6Choice.Correction))]
    [JsonDerivedType(typeof(ReuseDataReport6Choice.CollateralReuseUpdate),nameof(ReuseDataReport6Choice.CollateralReuseUpdate))]
    [IsoId("_MxqLscK8EeuMhqg3CsEu6Q")]
    [DisplayName("Reuse Data Report 6 Choice")]
    public abstract partial record ReuseDataReport6Choice_
    {
    }
}
