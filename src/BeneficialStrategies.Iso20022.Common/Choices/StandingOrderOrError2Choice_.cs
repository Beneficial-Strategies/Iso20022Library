// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the standing order details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError2Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrError2Choice.BusinessError))]
    [JsonDerivedType(typeof(StandingOrderOrError2Choice.StandingOrder),nameof(StandingOrderOrError2Choice.StandingOrder))]
    [JsonDerivedType(typeof(StandingOrderOrError2Choice.BusinessError),nameof(StandingOrderOrError2Choice.BusinessError))]
    [IsoId("_7-uWsaMgEeCJ6YNENx4h-w_2147346159")]
    [DisplayName("Standing Order Or Error 2 Choice")]
    public abstract partial record StandingOrderOrError2Choice_
    {
    }
}
