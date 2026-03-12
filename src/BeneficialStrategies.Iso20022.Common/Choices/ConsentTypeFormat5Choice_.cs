// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the consent type format required.
    /// </summary>
    [KnownType(typeof(ConsentTypeFormat5Choice.Code))]
    [KnownType(typeof(ConsentTypeFormat5Choice.Proprietary))]
    [JsonDerivedType(typeof(ConsentTypeFormat5Choice.Code),nameof(ConsentTypeFormat5Choice.Code))]
    [JsonDerivedType(typeof(ConsentTypeFormat5Choice.Proprietary),nameof(ConsentTypeFormat5Choice.Proprietary))]
    [IsoId("_c5Whf5KQEeWHWpTQn1FFVg")]
    [DisplayName("Consent Type Format 5 Choice")]
    public abstract partial record ConsentTypeFormat5Choice_
    {
    }
}
