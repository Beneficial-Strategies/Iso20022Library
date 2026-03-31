// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity5Choice.Code))]
    [KnownType(typeof(Quantity5Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity5Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity5Choice.Code), nameof(Quantity5Choice.Code))]
    [JsonDerivedType(
        typeof(Quantity5Choice.OriginalAndCurrentFaceAmount),
        nameof(Quantity5Choice.OriginalAndCurrentFaceAmount)
    )]
    [JsonDerivedType(typeof(Quantity5Choice.Quantity), nameof(Quantity5Choice.Quantity))]
    [IsoId("_Sn0U1dp-Ed-ak6NoX_4Aeg_89127208")]
    [DisplayName("Quantity 5 Choice")]
    public abstract record Quantity5Choice_ { }
}
