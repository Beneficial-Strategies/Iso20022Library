// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between date and date-time for the specification of a period.
    /// </summary>
    [KnownType(typeof(Period2Choice.FromDateTimeToDateTime))]
    [KnownType(typeof(Period2Choice.FromDateToDate))]
    [JsonDerivedType(typeof(Period2Choice.FromDateTimeToDateTime),nameof(Period2Choice.FromDateTimeToDateTime))]
    [JsonDerivedType(typeof(Period2Choice.FromDateToDate),nameof(Period2Choice.FromDateToDate))]
    [IsoId("_T5exEdp-Ed-ak6NoX_4Aeg_913439020")]
    [DisplayName("Period 2 Choice")]
    public abstract partial record Period2Choice_
    {
    }
}
