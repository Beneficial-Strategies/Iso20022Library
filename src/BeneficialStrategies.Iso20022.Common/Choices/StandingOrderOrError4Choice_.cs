// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the standing order details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError4Choice.StandingOrder))]
    [KnownType(typeof(StandingOrderOrError4Choice.BusinessError))]
    [JsonDerivedType(typeof(StandingOrderOrError4Choice.StandingOrder),nameof(StandingOrderOrError4Choice.StandingOrder))]
    [JsonDerivedType(typeof(StandingOrderOrError4Choice.BusinessError),nameof(StandingOrderOrError4Choice.BusinessError))]
    [IsoId("_kIiN9RbvEeOy-PlRuFSUzQ")]
    [DisplayName("Standing Order Or Error 4 Choice")]
    public abstract partial record StandingOrderOrError4Choice_
    {
    }
}
