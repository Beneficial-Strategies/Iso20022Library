// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status.
    /// </summary>
    [KnownType(typeof(Status6Choice.Code))]
    [KnownType(typeof(Status6Choice.Proprietary))]
    [JsonDerivedType(typeof(Status6Choice.Code), nameof(Status6Choice.Code))]
    [JsonDerivedType(typeof(Status6Choice.Proprietary), nameof(Status6Choice.Proprietary))]
    [IsoId("_Su5UCAEcEeCQm6a_G2yO_w_-54288396")]
    [DisplayName("Status 6 Choice")]
    public abstract record Status6Choice_ { }
}
