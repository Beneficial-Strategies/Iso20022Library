// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the standing order details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError5Choice.Report))]
    [KnownType(typeof(StandingOrderOrError5Choice.OperationalError))]
    [JsonDerivedType(typeof(StandingOrderOrError5Choice.Report),nameof(StandingOrderOrError5Choice.Report))]
    [JsonDerivedType(typeof(StandingOrderOrError5Choice.OperationalError),nameof(StandingOrderOrError5Choice.OperationalError))]
    [IsoId("_CEqH124-EeiU9cctagi5ow")]
    [DisplayName("Standing Order Or Error 5 Choice")]
    public abstract partial record StandingOrderOrError5Choice_
    {
    }
}
