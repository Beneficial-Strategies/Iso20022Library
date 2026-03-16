// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice30Choice.Code))]
    [KnownType(typeof(TypeOfPrice30Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice30Choice.Code), nameof(TypeOfPrice30Choice.Code))]
    [JsonDerivedType(
        typeof(TypeOfPrice30Choice.Proprietary),
        nameof(TypeOfPrice30Choice.Proprietary)
    )]
    [IsoId("_n_xxwTp-EeWVrPy0StzzSg")]
    [DisplayName("Type Of Price 30 Choice")]
    public abstract record TypeOfPrice30Choice_ { }
}
