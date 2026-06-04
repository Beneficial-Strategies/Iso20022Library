// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.Quantity82Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Total quantity of securities to be transferred, expressed in a number of units or a percentage rate.</summary>
    [IsoId("c704e737-08fc-44aa-b295-87d3d33a6d9b")]
    [DisplayName("Quantity 82 Choice")]
    [KnownType(typeof(Quantity82Choice.TotalUnitsNumber))]
    [KnownType(typeof(Quantity82Choice.TransferRate))]
    [JsonDerivedType(typeof(Quantity82Choice.TotalUnitsNumber))]
    [JsonDerivedType(typeof(Quantity82Choice.TransferRate))]
    public abstract record Quantity82Choice_
    {
    }
}
