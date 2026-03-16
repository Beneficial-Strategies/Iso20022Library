// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between action to request on a security.
    /// </summary>
    [KnownType(typeof(UpdateType36Choice.UpdateType))]
    [KnownType(typeof(UpdateType36Choice.Replace))]
    [JsonDerivedType(typeof(UpdateType36Choice.UpdateType), nameof(UpdateType36Choice.UpdateType))]
    [JsonDerivedType(typeof(UpdateType36Choice.Replace), nameof(UpdateType36Choice.Replace))]
    [IsoId("_QGUHDZJKEeuAlLVx8pyt3w")]
    [DisplayName("Update Type 36 Choice")]
    public abstract record UpdateType36Choice_ { }
}
