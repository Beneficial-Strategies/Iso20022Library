// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice28Choice.Code))]
    [KnownType(typeof(TypeOfPrice28Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice28Choice.Code), nameof(TypeOfPrice28Choice.Code))]
    [JsonDerivedType(
        typeof(TypeOfPrice28Choice.Proprietary),
        nameof(TypeOfPrice28Choice.Proprietary)
    )]
    [IsoId("_jSvm2znVEeWV5sr121Fc8A")]
    [DisplayName("Type Of Price 28 Choice")]
    public abstract record TypeOfPrice28Choice_ { }
}
