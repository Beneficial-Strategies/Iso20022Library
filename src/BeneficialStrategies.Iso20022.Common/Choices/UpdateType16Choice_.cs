// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the update information.
    /// </summary>
    [KnownType(typeof(UpdateType16Choice.Code))]
    [KnownType(typeof(UpdateType16Choice.Proprietary))]
    [JsonDerivedType(typeof(UpdateType16Choice.Code), nameof(UpdateType16Choice.Code))]
    [JsonDerivedType(
        typeof(UpdateType16Choice.Proprietary),
        nameof(UpdateType16Choice.Proprietary)
    )]
    [IsoId("_cfq115KQEeWHWpTQn1FFVg")]
    [DisplayName("Update Type 16 Choice")]
    public abstract record UpdateType16Choice_ { }
}
