// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity50Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity50Choice.SignedQuantity))]
    [JsonDerivedType(typeof(Quantity50Choice.OriginalAndCurrentFaceAmount),nameof(Quantity50Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(Quantity50Choice.SignedQuantity),nameof(Quantity50Choice.SignedQuantity))]
    [IsoId("_K-7tVRuyEeyhRdHRjakS2w")]
    [DisplayName("Quantity 50 Choice")]
    public abstract partial record Quantity50Choice_
    {
    }
}
