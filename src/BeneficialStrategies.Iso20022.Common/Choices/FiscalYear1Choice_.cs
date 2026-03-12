// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of start date and end date for the fiscal year.
    /// </summary>
    [KnownType(typeof(FiscalYear1Choice.StartDate))]
    [KnownType(typeof(FiscalYear1Choice.EndDate))]
    [JsonDerivedType(typeof(FiscalYear1Choice.StartDate),nameof(FiscalYear1Choice.StartDate))]
    [JsonDerivedType(typeof(FiscalYear1Choice.EndDate),nameof(FiscalYear1Choice.EndDate))]
    [IsoId("_534EEFxREeW8MLuBzR10cg")]
    [DisplayName("Fiscal Year 1 Choice")]
    public abstract partial record FiscalYear1Choice_
    {
    }
}
