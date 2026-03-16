// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Date Type2Choice.
    /// </summary>
    [KnownType(typeof(DateType2Choice.Code))]
    [KnownType(typeof(DateType2Choice.Proprietary))]
    [JsonDerivedType(typeof(DateType2Choice.Code), nameof(DateType2Choice.Code))]
    [JsonDerivedType(typeof(DateType2Choice.Proprietary), nameof(DateType2Choice.Proprietary))]
    [IsoId("_5NXe0DLNEe6C5PjOhOZ_sw")]
    [DisplayName("Date Type2Choice")]
    public abstract record DateType2Choice_ { }
}
