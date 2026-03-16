// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity48Choice.Quantity))]
    [KnownType(typeof(Quantity48Choice.ProprietaryQuantity))]
    [JsonDerivedType(typeof(Quantity48Choice.Quantity), nameof(Quantity48Choice.Quantity))]
    [JsonDerivedType(
        typeof(Quantity48Choice.ProprietaryQuantity),
        nameof(Quantity48Choice.ProprietaryQuantity)
    )]
    [IsoId("_JrCchRuyEeyhRdHRjakS2w")]
    [DisplayName("Quantity 48 Choice")]
    public abstract record Quantity48Choice_ { }
}
