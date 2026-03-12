// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of side pocket units, or amount, or rate.
    /// </summary>
    [KnownType(typeof(SidePocketUnitsOrAmountOrRate1Choice.UnitsNumber))]
    [KnownType(typeof(SidePocketUnitsOrAmountOrRate1Choice.OrderedAmount))]
    [KnownType(typeof(SidePocketUnitsOrAmountOrRate1Choice.HoldingsRate))]
    [JsonDerivedType(typeof(SidePocketUnitsOrAmountOrRate1Choice.UnitsNumber),nameof(SidePocketUnitsOrAmountOrRate1Choice.UnitsNumber))]
    [JsonDerivedType(typeof(SidePocketUnitsOrAmountOrRate1Choice.OrderedAmount),nameof(SidePocketUnitsOrAmountOrRate1Choice.OrderedAmount))]
    [JsonDerivedType(typeof(SidePocketUnitsOrAmountOrRate1Choice.HoldingsRate),nameof(SidePocketUnitsOrAmountOrRate1Choice.HoldingsRate))]
    [IsoId("_Rhe-4dp-Ed-ak6NoX_4Aeg_-1345719140")]
    [DisplayName("Side Pocket Units Or Amount Or Rate 1 Choice")]
    public abstract partial record SidePocketUnitsOrAmountOrRate1Choice_
    {
    }
}
