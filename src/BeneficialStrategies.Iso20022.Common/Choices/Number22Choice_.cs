// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice number format.
    /// </summary>
    [KnownType(typeof(Number22Choice.Short))]
    [KnownType(typeof(Number22Choice.Long))]
    [JsonDerivedType(typeof(Number22Choice.Short), nameof(Number22Choice.Short))]
    [JsonDerivedType(typeof(Number22Choice.Long), nameof(Number22Choice.Long))]
    [IsoId("_GgDHITnEEeWV5sr121Fc8A")]
    [DisplayName("Number 22 Choice")]
    public abstract record Number22Choice_ { }
}
