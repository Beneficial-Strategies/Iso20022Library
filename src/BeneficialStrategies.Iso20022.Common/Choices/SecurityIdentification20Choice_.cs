// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ISIN and an alternative format for the identification of a financial instrument. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification20Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification20Choice.Name))]
    [JsonDerivedType(
        typeof(SecurityIdentification20Choice.ISIN),
        nameof(SecurityIdentification20Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification20Choice.Name),
        nameof(SecurityIdentification20Choice.Name)
    )]
    [IsoId("_R1-IMT9DEeWqd8_TqzDNuw")]
    [DisplayName("Security Identification 20 Choice")]
    public abstract record SecurityIdentification20Choice_ { }
}
