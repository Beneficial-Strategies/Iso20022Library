// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and or a data source scheme to determine the settlement date.
    /// </summary>
    [KnownType(typeof(DateType1Choice.Code))]
    [KnownType(typeof(DateType1Choice.Proprietary))]
    [JsonDerivedType(typeof(DateType1Choice.Code),nameof(DateType1Choice.Code))]
    [JsonDerivedType(typeof(DateType1Choice.Proprietary),nameof(DateType1Choice.Proprietary))]
    [IsoId("_Q-6dU9p-Ed-ak6NoX_4Aeg_1965888715")]
    [DisplayName("Date Type 1 Choice")]
    public abstract partial record DateType1Choice_
    {
    }
}
