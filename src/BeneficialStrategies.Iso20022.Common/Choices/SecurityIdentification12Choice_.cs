// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between ISIN and an alternative format for the identification of a security. ISIN is the preferred format.
    /// </summary>
    [KnownType(typeof(SecurityIdentification12Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification12Choice.OtherIdentification))]
    [JsonDerivedType(
        typeof(SecurityIdentification12Choice.ISIN),
        nameof(SecurityIdentification12Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification12Choice.OtherIdentification),
        nameof(SecurityIdentification12Choice.OtherIdentification)
    )]
    [IsoId("_XMCG4tp-Ed-ak6NoX_4Aeg_1099227898")]
    [DisplayName("Security Identification 12 Choice")]
    public abstract record SecurityIdentification12Choice_ { }
}
