// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice49Choice.Code))]
    [KnownType(typeof(TypeOfPrice49Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice49Choice.Code), nameof(TypeOfPrice49Choice.Code))]
    [JsonDerivedType(
        typeof(TypeOfPrice49Choice.Proprietary),
        nameof(TypeOfPrice49Choice.Proprietary)
    )]
    [IsoId("_sanRSffZEeiNZp_PtLohLw")]
    [DisplayName("Type Of Price 49 Choice")]
    public abstract record TypeOfPrice49Choice_ { }
}
