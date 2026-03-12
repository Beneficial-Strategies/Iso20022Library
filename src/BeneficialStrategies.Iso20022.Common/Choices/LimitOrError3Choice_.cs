// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between risk management limit details or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(LimitOrError3Choice.Limit))]
    [KnownType(typeof(LimitOrError3Choice.BusinessError))]
    [JsonDerivedType(typeof(LimitOrError3Choice.Limit),nameof(LimitOrError3Choice.Limit))]
    [JsonDerivedType(typeof(LimitOrError3Choice.BusinessError),nameof(LimitOrError3Choice.BusinessError))]
    [IsoId("_RRErR5lhEeeE1Ya-LgRsuQ")]
    [DisplayName("Limit Or Error 3 Choice")]
    public abstract partial record LimitOrError3Choice_
    {
    }
}
