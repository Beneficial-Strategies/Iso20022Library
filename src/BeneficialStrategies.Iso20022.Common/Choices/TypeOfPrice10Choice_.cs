// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice10Choice.Code))]
    [KnownType(typeof(TypeOfPrice10Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice10Choice.Code),nameof(TypeOfPrice10Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice10Choice.Proprietary),nameof(TypeOfPrice10Choice.Proprietary))]
    [IsoId("_Ac1iddokEeC60axPepSq7g_1161874888")]
    [DisplayName("Type Of Price 10 Choice")]
    public abstract partial record TypeOfPrice10Choice_
    {
    }
}
