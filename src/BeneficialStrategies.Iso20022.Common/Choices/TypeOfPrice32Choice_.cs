// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice32Choice.Code))]
    [KnownType(typeof(TypeOfPrice32Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice32Choice.Code),nameof(TypeOfPrice32Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice32Choice.Proprietary),nameof(TypeOfPrice32Choice.Proprietary))]
    [IsoId("_5TJ-M5NLEeWGlc8L7oPDIg")]
    [DisplayName("Type Of Price 32 Choice")]
    public abstract partial record TypeOfPrice32Choice_
    {
    }
}
