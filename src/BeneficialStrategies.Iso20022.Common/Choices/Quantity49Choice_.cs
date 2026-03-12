// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [KnownType(typeof(Quantity49Choice.QuantityChoice))]
    [KnownType(typeof(Quantity49Choice.ProprietaryQuantity))]
    [JsonDerivedType(typeof(Quantity49Choice.QuantityChoice),nameof(Quantity49Choice.QuantityChoice))]
    [JsonDerivedType(typeof(Quantity49Choice.ProprietaryQuantity),nameof(Quantity49Choice.ProprietaryQuantity))]
    [IsoId("_KpeatxuyEeyhRdHRjakS2w")]
    [DisplayName("Quantity 49 Choice")]
    public abstract partial record Quantity49Choice_
    {
    }
}
