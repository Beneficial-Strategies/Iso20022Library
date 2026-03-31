// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the status.
    /// </summary>
    [KnownType(typeof(Status27Choice.Code))]
    [KnownType(typeof(Status27Choice.Proprietary))]
    [JsonDerivedType(typeof(Status27Choice.Code), nameof(Status27Choice.Code))]
    [JsonDerivedType(typeof(Status27Choice.Proprietary), nameof(Status27Choice.Proprietary))]
    [IsoId("_KmBEpZU7EeaYkf5FCqYMeA")]
    [DisplayName("Status 27 Choice")]
    public abstract record Status27Choice_ { }
}
