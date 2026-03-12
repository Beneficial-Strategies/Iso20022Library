// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the consent type format required.
    /// </summary>
    [KnownType(typeof(ConsentTypeFormat1Choice.Code))]
    [KnownType(typeof(ConsentTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(ConsentTypeFormat1Choice.Code),nameof(ConsentTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(ConsentTypeFormat1Choice.Proprietary),nameof(ConsentTypeFormat1Choice.Proprietary))]
    [IsoId("_aqkpwCHnEeOQ7qT4JUI53A")]
    [DisplayName("Consent Type Format 1 Choice")]
    public abstract partial record ConsentTypeFormat1Choice_
    {
    }
}
