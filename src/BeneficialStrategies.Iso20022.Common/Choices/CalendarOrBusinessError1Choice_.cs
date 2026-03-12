// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the audit trail or a business error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(CalendarOrBusinessError1Choice.CalendarData))]
    [KnownType(typeof(CalendarOrBusinessError1Choice.BusinessError))]
    [JsonDerivedType(typeof(CalendarOrBusinessError1Choice.CalendarData),nameof(CalendarOrBusinessError1Choice.CalendarData))]
    [JsonDerivedType(typeof(CalendarOrBusinessError1Choice.BusinessError),nameof(CalendarOrBusinessError1Choice.BusinessError))]
    [IsoId("_dVcQ2Im7Eeipw6hHPgB4Sw")]
    [DisplayName("Calendar Or Business Error 1 Choice")]
    public abstract partial record CalendarOrBusinessError1Choice_
    {
    }
}
