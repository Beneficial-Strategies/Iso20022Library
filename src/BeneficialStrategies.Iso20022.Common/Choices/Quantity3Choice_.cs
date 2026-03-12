// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity3Choice.QuantityChoice))]
    [KnownType(typeof(Quantity3Choice.ProprietaryQuantity))]
    [JsonDerivedType(typeof(Quantity3Choice.QuantityChoice),nameof(Quantity3Choice.QuantityChoice))]
    [JsonDerivedType(typeof(Quantity3Choice.ProprietaryQuantity),nameof(Quantity3Choice.ProprietaryQuantity))]
    [IsoId("_Qz45G9p-Ed-ak6NoX_4Aeg_-354691076")]
    [DisplayName("Quantity 3 Choice")]
    public abstract partial record Quantity3Choice_
    {
    }
}
