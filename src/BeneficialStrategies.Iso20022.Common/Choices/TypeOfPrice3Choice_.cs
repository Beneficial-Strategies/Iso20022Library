// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice3Choice.Code))]
    [KnownType(typeof(TypeOfPrice3Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice3Choice.Code), nameof(TypeOfPrice3Choice.Code))]
    [JsonDerivedType(
        typeof(TypeOfPrice3Choice.Proprietary),
        nameof(TypeOfPrice3Choice.Proprietary)
    )]
    [IsoId("_Qu0y4dp-Ed-ak6NoX_4Aeg_-470141536")]
    [DisplayName("Type Of Price 3 Choice")]
    public abstract record TypeOfPrice3Choice_ { }
}
