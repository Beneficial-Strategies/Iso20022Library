// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between risk management limit details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(LimitOrError4Choice.Limit))]
    [KnownType(typeof(LimitOrError4Choice.BusinessError))]
    [JsonDerivedType(typeof(LimitOrError4Choice.Limit), nameof(LimitOrError4Choice.Limit))]
    [JsonDerivedType(
        typeof(LimitOrError4Choice.BusinessError),
        nameof(LimitOrError4Choice.BusinessError)
    )]
    [IsoId("_RYTBoXhdEeidzqjNEfehPg")]
    [DisplayName("Limit Or Error 4 Choice")]
    public abstract record LimitOrError4Choice_ { }
}
