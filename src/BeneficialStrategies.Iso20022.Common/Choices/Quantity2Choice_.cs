// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity2Choice.Quantity))]
    [KnownType(typeof(Quantity2Choice.ProprietaryQuantity))]
    [JsonDerivedType(typeof(Quantity2Choice.Quantity), nameof(Quantity2Choice.Quantity))]
    [JsonDerivedType(
        typeof(Quantity2Choice.ProprietaryQuantity),
        nameof(Quantity2Choice.ProprietaryQuantity)
    )]
    [IsoId("_Q0fWDdp-Ed-ak6NoX_4Aeg_1384564891")]
    [DisplayName("Quantity 2 Choice")]
    public abstract record Quantity2Choice_ { }
}
