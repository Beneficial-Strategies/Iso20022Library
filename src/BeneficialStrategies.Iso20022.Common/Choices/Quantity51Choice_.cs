// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the quantity.
    /// </summary>
    [KnownType(typeof(Quantity51Choice.Quantity))]
    [KnownType(typeof(Quantity51Choice.OriginalAndCurrentFace))]
    [JsonDerivedType(typeof(Quantity51Choice.Quantity), nameof(Quantity51Choice.Quantity))]
    [JsonDerivedType(
        typeof(Quantity51Choice.OriginalAndCurrentFace),
        nameof(Quantity51Choice.OriginalAndCurrentFace)
    )]
    [IsoId("_LU-10RuyEeyhRdHRjakS2w")]
    [DisplayName("Quantity 51 Choice")]
    public abstract record Quantity51Choice_ { }
}
