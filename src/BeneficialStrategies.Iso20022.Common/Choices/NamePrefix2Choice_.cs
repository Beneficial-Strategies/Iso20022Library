// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Prefix used for name.
    /// </summary>
    [KnownType(typeof(NamePrefix2Choice.NamePrefix))]
    [KnownType(typeof(NamePrefix2Choice.ExtendedNamePrefix))]
    [JsonDerivedType(typeof(NamePrefix2Choice.NamePrefix),nameof(NamePrefix2Choice.NamePrefix))]
    [JsonDerivedType(typeof(NamePrefix2Choice.ExtendedNamePrefix),nameof(NamePrefix2Choice.ExtendedNamePrefix))]
    [IsoId("_HMqgQQ2fEeSNWNtJlXOAhg")]
    [DisplayName("Name Prefix 2 Choice")]
    public abstract partial record NamePrefix2Choice_
    {
    }
}
