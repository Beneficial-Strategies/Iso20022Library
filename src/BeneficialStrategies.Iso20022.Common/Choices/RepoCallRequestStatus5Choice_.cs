// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase agreement call acknowledgement.
    /// </summary>
    [KnownType(typeof(RepoCallRequestStatus5Choice.AcknowledgedAccepted))]
    [KnownType(typeof(RepoCallRequestStatus5Choice.Denied))]
    [KnownType(typeof(RepoCallRequestStatus5Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus5Choice.AcknowledgedAccepted),
        nameof(RepoCallRequestStatus5Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus5Choice.Denied),
        nameof(RepoCallRequestStatus5Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus5Choice.Proprietary),
        nameof(RepoCallRequestStatus5Choice.Proprietary)
    )]
    [IsoId("_fHQhMf7rEeCvPoRGOxRobQ")]
    [DisplayName("Repo Call Request Status 5 Choice")]
    public abstract record RepoCallRequestStatus5Choice_ { }
}
