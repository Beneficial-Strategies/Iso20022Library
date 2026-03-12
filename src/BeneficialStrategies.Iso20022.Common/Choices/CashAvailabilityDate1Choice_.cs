// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indicates when the amount of money will become available.
    /// </summary>
    [KnownType(typeof(CashAvailabilityDate1Choice.NumberOfDays))]
    [KnownType(typeof(CashAvailabilityDate1Choice.ActualDate))]
    [JsonDerivedType(typeof(CashAvailabilityDate1Choice.NumberOfDays),nameof(CashAvailabilityDate1Choice.NumberOfDays))]
    [JsonDerivedType(typeof(CashAvailabilityDate1Choice.ActualDate),nameof(CashAvailabilityDate1Choice.ActualDate))]
    [IsoId("_Vf2nGTqwEeWZFYSPlduMhw")]
    [DisplayName("Cash Availability Date 1 Choice")]
    public abstract partial record CashAvailabilityDate1Choice_
    {
    }
}
