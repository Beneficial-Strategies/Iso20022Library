// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status.
    /// </summary>
    [KnownType(typeof(Status13Choice.Code))]
    [KnownType(typeof(Status13Choice.Proprietary))]
    [JsonDerivedType(typeof(Status13Choice.Code),nameof(Status13Choice.Code))]
    [JsonDerivedType(typeof(Status13Choice.Proprietary),nameof(Status13Choice.Proprietary))]
    [IsoId("_b2fBN5K2EeKOmdt7wkELkg")]
    [DisplayName("Status 13 Choice")]
    public abstract partial record Status13Choice_
    {
    }
}
