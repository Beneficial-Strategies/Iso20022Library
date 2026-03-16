// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the standing order details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError3Choice.Report))]
    [KnownType(typeof(StandingOrderOrError3Choice.OperationalError))]
    [JsonDerivedType(
        typeof(StandingOrderOrError3Choice.Report),
        nameof(StandingOrderOrError3Choice.Report)
    )]
    [JsonDerivedType(
        typeof(StandingOrderOrError3Choice.OperationalError),
        nameof(StandingOrderOrError3Choice.OperationalError)
    )]
    [IsoId("_imo9YRbvEeOy-PlRuFSUzQ")]
    [DisplayName("Standing Order Or Error 3 Choice")]
    public abstract record StandingOrderOrError3Choice_ { }
}
