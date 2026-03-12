// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of quantity of assets.
    /// </summary>
    [KnownType(typeof(Quantity44Choice.Unit))]
    [KnownType(typeof(Quantity44Choice.PercentageRate))]
    [KnownType(typeof(Quantity44Choice.FaceAmount))]
    [KnownType(typeof(Quantity44Choice.AmortisedValue))]
    [KnownType(typeof(Quantity44Choice.CashAmount))]
    [KnownType(typeof(Quantity44Choice.OtherAsset))]
    [JsonDerivedType(typeof(Quantity44Choice.Unit),nameof(Quantity44Choice.Unit))]
    [JsonDerivedType(typeof(Quantity44Choice.PercentageRate),nameof(Quantity44Choice.PercentageRate))]
    [JsonDerivedType(typeof(Quantity44Choice.FaceAmount),nameof(Quantity44Choice.FaceAmount))]
    [JsonDerivedType(typeof(Quantity44Choice.AmortisedValue),nameof(Quantity44Choice.AmortisedValue))]
    [JsonDerivedType(typeof(Quantity44Choice.CashAmount),nameof(Quantity44Choice.CashAmount))]
    [JsonDerivedType(typeof(Quantity44Choice.OtherAsset),nameof(Quantity44Choice.OtherAsset))]
    [IsoId("_Qfjh0U3WEeidB49bWZiS0g")]
    [DisplayName("Quantity 44 Choice")]
    public abstract partial record Quantity44Choice_
    {
    }
}
