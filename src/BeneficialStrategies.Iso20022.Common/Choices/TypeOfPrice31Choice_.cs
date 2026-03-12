// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice31Choice.Code))]
    [KnownType(typeof(TypeOfPrice31Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice31Choice.Code),nameof(TypeOfPrice31Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice31Choice.Proprietary),nameof(TypeOfPrice31Choice.Proprietary))]
    [IsoId("_V-uWUSVlEeWV8IT-SD_UOg")]
    [DisplayName("Type Of Price 31 Choice")]
    public abstract partial record TypeOfPrice31Choice_
    {
    }
}
