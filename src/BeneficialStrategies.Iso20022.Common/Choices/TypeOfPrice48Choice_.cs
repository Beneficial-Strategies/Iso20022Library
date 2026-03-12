// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice48Choice.Code))]
    [KnownType(typeof(TypeOfPrice48Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice48Choice.Code),nameof(TypeOfPrice48Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice48Choice.Proprietary),nameof(TypeOfPrice48Choice.Proprietary))]
    [IsoId("_eyLGUddnEeispNOuywCdbA")]
    [DisplayName("Type Of Price 48 Choice")]
    public abstract partial record TypeOfPrice48Choice_
    {
    }
}
