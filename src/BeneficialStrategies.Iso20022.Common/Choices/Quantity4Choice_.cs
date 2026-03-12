// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity4Choice.OriginalAndCurrentFaceAmount))]
    [KnownType(typeof(Quantity4Choice.SignedQuantity))]
    [JsonDerivedType(typeof(Quantity4Choice.OriginalAndCurrentFaceAmount),nameof(Quantity4Choice.OriginalAndCurrentFaceAmount))]
    [JsonDerivedType(typeof(Quantity4Choice.SignedQuantity),nameof(Quantity4Choice.SignedQuantity))]
    [IsoId("_Qz45Etp-Ed-ak6NoX_4Aeg_-1944007584")]
    [DisplayName("Quantity 4 Choice")]
    public abstract partial record Quantity4Choice_
    {
    }
}
