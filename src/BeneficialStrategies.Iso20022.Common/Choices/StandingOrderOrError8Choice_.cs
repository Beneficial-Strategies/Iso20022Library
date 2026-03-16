// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the standing order details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError8Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrError8Choice.BusinessError))]
    [JsonDerivedType(
        typeof(StandingOrderOrError8Choice.StandingOrder),
        nameof(StandingOrderOrError8Choice.StandingOrder)
    )]
    [JsonDerivedType(
        typeof(StandingOrderOrError8Choice.BusinessError),
        nameof(StandingOrderOrError8Choice.BusinessError)
    )]
    [IsoId("_eb5ypdcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order Or Error 8 Choice")]
    public abstract record StandingOrderOrError8Choice_ { }
}
