// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities restriction information.
    /// </summary>
    [KnownType(typeof(Restriction5Choice.Code))]
    [KnownType(typeof(Restriction5Choice.Proprietary))]
    [JsonDerivedType(typeof(Restriction5Choice.Code),nameof(Restriction5Choice.Code))]
    [JsonDerivedType(typeof(Restriction5Choice.Proprietary),nameof(Restriction5Choice.Proprietary))]
    [IsoId("_EFd7ATqIEeWVrPy0StzzSg")]
    [DisplayName("Restriction 5 Choice")]
    public abstract partial record Restriction5Choice_
    {
    }
}
