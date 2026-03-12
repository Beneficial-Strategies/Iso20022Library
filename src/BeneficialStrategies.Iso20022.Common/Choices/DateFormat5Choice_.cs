// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat5Choice.Date))]
    [KnownType(typeof(DateFormat5Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat5Choice.Date),nameof(DateFormat5Choice.Date))]
    [JsonDerivedType(typeof(DateFormat5Choice.DateCode),nameof(DateFormat5Choice.DateCode))]
    [IsoId("_Qy_hN9p-Ed-ak6NoX_4Aeg_407445243")]
    [DisplayName("Date Format 5 Choice")]
    public abstract partial record DateFormat5Choice_
    {
    }
}
