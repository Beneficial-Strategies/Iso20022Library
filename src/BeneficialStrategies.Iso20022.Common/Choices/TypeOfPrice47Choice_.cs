// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice47Choice.Code))]
    [KnownType(typeof(TypeOfPrice47Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice47Choice.Code),nameof(TypeOfPrice47Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice47Choice.Proprietary),nameof(TypeOfPrice47Choice.Proprietary))]
    [IsoId("_Pe1UEZBhEeakHoV5BVecAQ")]
    [DisplayName("Type Of Price 47 Choice")]
    public abstract partial record TypeOfPrice47Choice_
    {
    }
}
