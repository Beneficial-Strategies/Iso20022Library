// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a date or a date and time format.
    /// </summary>
    [KnownType(typeof(DateAndDateTime1Choice.Date))]
    [KnownType(typeof(DateAndDateTime1Choice.DateTime))]
    [JsonDerivedType(typeof(DateAndDateTime1Choice.Date),nameof(DateAndDateTime1Choice.Date))]
    [JsonDerivedType(typeof(DateAndDateTime1Choice.DateTime),nameof(DateAndDateTime1Choice.DateTime))]
    [IsoId("_Axs_MNokEeC60axPepSq7g_-1588891689")]
    [DisplayName("Date And Date Time 1 Choice")]
    public abstract partial record DateAndDateTime1Choice_
    {
    }
}
