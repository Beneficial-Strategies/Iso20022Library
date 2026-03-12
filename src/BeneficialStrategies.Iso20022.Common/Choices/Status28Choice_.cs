// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status.
    /// </summary>
    [KnownType(typeof(Status28Choice.Code))]
    [KnownType(typeof(Status28Choice.Proprietary))]
    [JsonDerivedType(typeof(Status28Choice.Code),nameof(Status28Choice.Code))]
    [JsonDerivedType(typeof(Status28Choice.Proprietary),nameof(Status28Choice.Proprietary))]
    [IsoId("_thmBQZU8EeaYkf5FCqYMeA")]
    [DisplayName("Status 28 Choice")]
    public abstract partial record Status28Choice_
    {
    }
}
