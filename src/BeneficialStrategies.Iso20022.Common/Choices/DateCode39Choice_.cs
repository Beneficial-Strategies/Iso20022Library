// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Date Code39Choice.
    /// </summary>
    [KnownType(typeof(DateCode39Choice.Code))]
    [KnownType(typeof(DateCode39Choice.Proprietary))]
    [JsonDerivedType(typeof(DateCode39Choice.Code),nameof(DateCode39Choice.Code))]
    [JsonDerivedType(typeof(DateCode39Choice.Proprietary),nameof(DateCode39Choice.Proprietary))]
    [IsoId("_zENAsaAdEe-6zfgb2Rwrlw")]
    [DisplayName("Date Code39Choice")]
    public abstract partial record DateCode39Choice_
    {
    }
}
