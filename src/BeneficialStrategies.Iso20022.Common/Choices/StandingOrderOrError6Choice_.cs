// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the standing order details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError6Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrError6Choice.BusinessError))]
    [JsonDerivedType(
        typeof(StandingOrderOrError6Choice.StandingOrder),
        nameof(StandingOrderOrError6Choice.StandingOrder)
    )]
    [JsonDerivedType(
        typeof(StandingOrderOrError6Choice.BusinessError),
        nameof(StandingOrderOrError6Choice.BusinessError)
    )]
    [IsoId("_Cj8r6W4-EeiU9cctagi5ow")]
    [DisplayName("Standing Order Or Error 6 Choice")]
    public abstract record StandingOrderOrError6Choice_ { }
}
