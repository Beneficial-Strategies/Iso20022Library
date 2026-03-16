// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity22Choice.QuantityChoice))]
    [KnownType(typeof(Quantity22Choice.ProprietaryQuantity))]
    [JsonDerivedType(
        typeof(Quantity22Choice.QuantityChoice),
        nameof(Quantity22Choice.QuantityChoice)
    )]
    [JsonDerivedType(
        typeof(Quantity22Choice.ProprietaryQuantity),
        nameof(Quantity22Choice.ProprietaryQuantity)
    )]
    [IsoId("_cfsEVZKQEeWHWpTQn1FFVg")]
    [DisplayName("Quantity 22 Choice")]
    public abstract record Quantity22Choice_ { }
}
