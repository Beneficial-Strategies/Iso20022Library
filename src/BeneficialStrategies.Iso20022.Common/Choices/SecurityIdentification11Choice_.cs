// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ISIN and an alternative format for the identification of a security. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification11Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification11Choice.OtherIdentification))]
    [JsonDerivedType(
        typeof(SecurityIdentification11Choice.ISIN),
        nameof(SecurityIdentification11Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification11Choice.OtherIdentification),
        nameof(SecurityIdentification11Choice.OtherIdentification)
    )]
    [IsoId("_RCMa0dp-Ed-ak6NoX_4Aeg_191397587")]
    [DisplayName("Security Identification 11 Choice")]
    public abstract record SecurityIdentification11Choice_ { }
}
