// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the quantity.
    /// </summary>
    [KnownType(typeof(Quantity6Choice.Quantity))]
    [KnownType(typeof(Quantity6Choice.OriginalAndCurrentFace))]
    [JsonDerivedType(typeof(Quantity6Choice.Quantity),nameof(Quantity6Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity6Choice.OriginalAndCurrentFace),nameof(Quantity6Choice.OriginalAndCurrentFace))]
    [IsoId("_Sotss9p-Ed-ak6NoX_4Aeg_502290625")]
    [DisplayName("Quantity 6 Choice")]
    public abstract partial record Quantity6Choice_
    {
    }
}
