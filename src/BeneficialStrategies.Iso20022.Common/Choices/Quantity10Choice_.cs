// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the quantity.
    /// </summary>
    [KnownType(typeof(Quantity10Choice.Quantity))]
    [KnownType(typeof(Quantity10Choice.OriginalAndCurrentFace))]
    [JsonDerivedType(typeof(Quantity10Choice.Quantity), nameof(Quantity10Choice.Quantity))]
    [JsonDerivedType(
        typeof(Quantity10Choice.OriginalAndCurrentFace),
        nameof(Quantity10Choice.OriginalAndCurrentFace)
    )]
    [IsoId("_WsJF49p-Ed-ak6NoX_4Aeg_-333234735")]
    [DisplayName("Quantity 10 Choice")]
    public abstract record Quantity10Choice_ { }
}
