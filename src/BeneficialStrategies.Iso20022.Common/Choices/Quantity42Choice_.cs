// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Total quantity of securities to be transferred, expressed in a number of units or a percentage rate.
    /// </summary>
    [KnownType(typeof(Quantity42Choice.TotalUnitsNumber))]
    [KnownType(typeof(Quantity42Choice.TransferRate))]
    [JsonDerivedType(typeof(Quantity42Choice.TotalUnitsNumber),nameof(Quantity42Choice.TotalUnitsNumber))]
    [JsonDerivedType(typeof(Quantity42Choice.TransferRate),nameof(Quantity42Choice.TransferRate))]
    [IsoId("_SOqu0IfwEeevKP8c-ilVhA")]
    [DisplayName("Quantity 42 Choice")]
    public abstract partial record Quantity42Choice_
    {
    }
}
