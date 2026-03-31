// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityIdentification26Choice.Identification))]
    [KnownType(typeof(SecurityIdentification26Choice.NotAvailable))]
    [JsonDerivedType(
        typeof(SecurityIdentification26Choice.Identification),
        nameof(SecurityIdentification26Choice.Identification)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification26Choice.NotAvailable),
        nameof(SecurityIdentification26Choice.NotAvailable)
    )]
    [IsoId("_OG6hAY7DEeaxxtxaoOwzAg")]
    [DisplayName("Security Identification 26 Choice")]
    public abstract record SecurityIdentification26Choice_ { }
}
