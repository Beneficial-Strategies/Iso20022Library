// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice29Choice.Code))]
    [KnownType(typeof(TypeOfPrice29Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice29Choice.Code),nameof(TypeOfPrice29Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice29Choice.Proprietary),nameof(TypeOfPrice29Choice.Proprietary))]
    [IsoId("_Qih-PznXEeWV5sr121Fc8A")]
    [DisplayName("Type Of Price 29 Choice")]
    public abstract partial record TypeOfPrice29Choice_
    {
    }
}
