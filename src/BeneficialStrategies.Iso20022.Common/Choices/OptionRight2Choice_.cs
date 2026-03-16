// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the option rights.
    /// </summary>
    [KnownType(typeof(OptionRight2Choice.Code))]
    [KnownType(typeof(OptionRight2Choice.Proprietary))]
    [JsonDerivedType(typeof(OptionRight2Choice.Code), nameof(OptionRight2Choice.Code))]
    [JsonDerivedType(
        typeof(OptionRight2Choice.Proprietary),
        nameof(OptionRight2Choice.Proprietary)
    )]
    [IsoId("_PwmrYZEjEeakHoV5BVecAQ")]
    [DisplayName("Option Right 2 Choice")]
    public abstract record OptionRight2Choice_ { }
}
