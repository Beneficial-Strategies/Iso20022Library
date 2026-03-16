// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for the identification of a financial instrument.
    /// </summary>
    [KnownType(typeof(SecurityIdentification4Choice.ISIN))]
    [KnownType(typeof(SecurityIdentification4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecurityIdentification4Choice.ISIN),
        nameof(SecurityIdentification4Choice.ISIN)
    )]
    [JsonDerivedType(
        typeof(SecurityIdentification4Choice.Proprietary),
        nameof(SecurityIdentification4Choice.Proprietary)
    )]
    [IsoId("_Qd1wltp-Ed-ak6NoX_4Aeg_1243215798")]
    [DisplayName("Security Identification 4 Choice")]
    public abstract record SecurityIdentification4Choice_ { }
}
