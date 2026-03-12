// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the standing order details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError1Choice.Report))]
    [KnownType(typeof(StandingOrderOrError1Choice.OperationalError))]
    [JsonDerivedType(typeof(StandingOrderOrError1Choice.Report),nameof(StandingOrderOrError1Choice.Report))]
    [JsonDerivedType(typeof(StandingOrderOrError1Choice.OperationalError),nameof(StandingOrderOrError1Choice.OperationalError))]
    [IsoId("_759LdqMgEeCJ6YNENx4h-w_1400148199")]
    [DisplayName("Standing Order Or Error 1 Choice")]
    public abstract partial record StandingOrderOrError1Choice_
    {
    }
}
