// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different formats of securities quantity.
    /// </summary>
    [KnownType(typeof(Quantity52Choice.Code))]
    [KnownType(typeof(Quantity52Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity52Choice.Quantity))]
    [JsonDerivedType(typeof(Quantity52Choice.Code),nameof(Quantity52Choice.Code))]
    [JsonDerivedType(typeof(Quantity52Choice.OriginalAndCurrentFaceAmount),nameof(Quantity52Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(Quantity52Choice.Quantity),nameof(Quantity52Choice.Quantity))]
    [IsoId("_OT3o3RuyEeyhRdHRjakS2w")]
    [DisplayName("Quantity 52 Choice")]
    public abstract partial record Quantity52Choice_
    {
    }
}
