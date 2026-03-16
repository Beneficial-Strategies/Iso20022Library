// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice33Choice.Code))]
    [KnownType(typeof(TypeOfPrice33Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice33Choice.Code), nameof(TypeOfPrice33Choice.Code))]
    [JsonDerivedType(
        typeof(TypeOfPrice33Choice.Proprietary),
        nameof(TypeOfPrice33Choice.Proprietary)
    )]
    [IsoId("_5W2yu5NLEeWGlc8L7oPDIg")]
    [DisplayName("Type Of Price 33 Choice")]
    public abstract record TypeOfPrice33Choice_ { }
}
