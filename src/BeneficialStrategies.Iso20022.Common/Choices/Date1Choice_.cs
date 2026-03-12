// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine a date format.
    /// </summary>
    [KnownType(typeof(Date1Choice.Code))]
    [KnownType(typeof(Date1Choice.Proprietary))]
    [JsonDerivedType(typeof(Date1Choice.Code),nameof(Date1Choice.Code))]
    [JsonDerivedType(typeof(Date1Choice.Proprietary),nameof(Date1Choice.Proprietary))]
    [IsoId("_Q-eYd9p-Ed-ak6NoX_4Aeg_-1377076499")]
    [DisplayName("Date 1 Choice")]
    public abstract partial record Date1Choice_
    {
    }
}
