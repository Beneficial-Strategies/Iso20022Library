// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ways to express an amount.
    /// </summary>
    [KnownType(typeof(AmountPrice1Choice.Amount))]
    [KnownType(typeof(AmountPrice1Choice.UnitPrice))]
    [JsonDerivedType(typeof(AmountPrice1Choice.Amount),nameof(AmountPrice1Choice.Amount))]
    [JsonDerivedType(typeof(AmountPrice1Choice.UnitPrice),nameof(AmountPrice1Choice.UnitPrice))]
    [IsoId("_VMB-CNp-Ed-ak6NoX_4Aeg_834424130")]
    [DisplayName("Amount Price 1 Choice")]
    public abstract partial record AmountPrice1Choice_
    {
    }
}
