// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of consent status.
    /// </summary>
    [KnownType(typeof(ConsentStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(ConsentStatus4Choice.Reason))]
    [JsonDerivedType(
        typeof(ConsentStatus4Choice.NoSpecifiedReason),
        nameof(ConsentStatus4Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(ConsentStatus4Choice.Reason), nameof(ConsentStatus4Choice.Reason))]
    [IsoId("_n--vUTzpEeWeNtT0s2RbkQ")]
    [DisplayName("Consent Status 4 Choice")]
    public abstract record ConsentStatus4Choice_ { }
}
