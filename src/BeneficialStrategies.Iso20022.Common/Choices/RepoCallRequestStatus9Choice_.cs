// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase agreement call acknowledgement.
    /// </summary>
    [KnownType(typeof(RepoCallRequestStatus9Choice.AcknowledgedAccepted))]
    [KnownType(typeof(RepoCallRequestStatus9Choice.Denied))]
    [KnownType(typeof(RepoCallRequestStatus9Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus9Choice.AcknowledgedAccepted),
        nameof(RepoCallRequestStatus9Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus9Choice.Denied),
        nameof(RepoCallRequestStatus9Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus9Choice.Proprietary),
        nameof(RepoCallRequestStatus9Choice.Proprietary)
    )]
    [IsoId("_6BKUgZNLEeWGlc8L7oPDIg")]
    [DisplayName("Repo Call Request Status 9 Choice")]
    public abstract record RepoCallRequestStatus9Choice_ { }
}
