// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of price.
    /// </summary>
    [KnownType(typeof(TypeOfPrice27Choice.Code))]
    [KnownType(typeof(TypeOfPrice27Choice.Proprietary))]
    [JsonDerivedType(typeof(TypeOfPrice27Choice.Code),nameof(TypeOfPrice27Choice.Code))]
    [JsonDerivedType(typeof(TypeOfPrice27Choice.Proprietary),nameof(TypeOfPrice27Choice.Proprietary))]
    [IsoId("_nAFOc_NBEeCuA5Tr22BnwA_1435844003")]
    [DisplayName("Type Of Price 27 Choice")]
    public abstract partial record TypeOfPrice27Choice_
    {
    }
}
