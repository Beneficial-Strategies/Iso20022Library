// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option rights.
    /// </summary>
    [KnownType(typeof(OptionRight1Choice.Code))]
    [KnownType(typeof(OptionRight1Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionRight1Choice.Code), nameof(OptionRight1Choice.Code))]
    [JsonDerivedType(
        typeof(OptionRight1Choice.Proprietary),
        nameof(OptionRight1Choice.Proprietary)
    )]
    [IsoId("_AeoSNdokEeC60axPepSq7g_-1501938465")]
    [DisplayName("Option Right 1 Choice")]
    public abstract record OptionRight1Choice_ { }
}
