// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase agreement call acknowledgement.
    /// </summary>
    [KnownType(typeof(RepoCallRequestStatus7Choice.AcknowledgedAccepted))]
    [KnownType(typeof(RepoCallRequestStatus7Choice.Denied))]
    [KnownType(typeof(RepoCallRequestStatus7Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus7Choice.AcknowledgedAccepted),
        nameof(RepoCallRequestStatus7Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus7Choice.Denied),
        nameof(RepoCallRequestStatus7Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus7Choice.Proprietary),
        nameof(RepoCallRequestStatus7Choice.Proprietary)
    )]
    [IsoId("_3eDsYTp4EeWVrPy0StzzSg")]
    [DisplayName("Repo Call Request Status 7 Choice")]
    public abstract record RepoCallRequestStatus7Choice_ { }
}
