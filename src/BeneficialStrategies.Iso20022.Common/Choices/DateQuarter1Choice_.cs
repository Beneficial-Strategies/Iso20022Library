// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a date or quarter.
    /// </summary>
    [KnownType(typeof(DateQuarter1Choice.Date))]
    [KnownType(typeof(DateQuarter1Choice.Period))]
    [JsonDerivedType(typeof(DateQuarter1Choice.Date),nameof(DateQuarter1Choice.Date))]
    [JsonDerivedType(typeof(DateQuarter1Choice.Period),nameof(DateQuarter1Choice.Period))]
    [IsoId("_CUTHIKFTEei_VZq-6SQkuQ")]
    [DisplayName("Date Quarter 1 Choice")]
    public abstract partial record DateQuarter1Choice_
    {
    }
}
