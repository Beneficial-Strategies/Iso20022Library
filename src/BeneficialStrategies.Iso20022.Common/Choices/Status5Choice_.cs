// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status.
    /// </summary>
    [KnownType(typeof(Status5Choice.Code))]
    [KnownType(typeof(Status5Choice.Proprietary))]
    [JsonDerivedType(typeof(Status5Choice.Code),nameof(Status5Choice.Code))]
    [JsonDerivedType(typeof(Status5Choice.Proprietary),nameof(Status5Choice.Proprietary))]
    [IsoId("_Su5UCwEcEeCQm6a_G2yO_w_-778618996")]
    [DisplayName("Status 5 Choice")]
    public abstract partial record Status5Choice_
    {
    }
}
