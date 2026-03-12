// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an ISODate format or a date code.
    /// </summary>
    [KnownType(typeof(DateFormat14Choice.Date))]
    [KnownType(typeof(DateFormat14Choice.DateCode))]
    [JsonDerivedType(typeof(DateFormat14Choice.Date),nameof(DateFormat14Choice.Date))]
    [JsonDerivedType(typeof(DateFormat14Choice.DateCode),nameof(DateFormat14Choice.DateCode))]
    [IsoId("_QnElEtp-Ed-ak6NoX_4Aeg_-686892635")]
    [DisplayName("Date Format 14 Choice")]
    public abstract partial record DateFormat14Choice_
    {
    }
}
