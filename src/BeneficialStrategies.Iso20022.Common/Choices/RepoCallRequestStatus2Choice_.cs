// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase agreement call acknowledgement.
    /// </summary>
    [KnownType(typeof(RepoCallRequestStatus2Choice.AcknowledgedAccepted))]
    [KnownType(typeof(RepoCallRequestStatus2Choice.Denied))]
    [KnownType(typeof(RepoCallRequestStatus2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus2Choice.AcknowledgedAccepted),
        nameof(RepoCallRequestStatus2Choice.AcknowledgedAccepted)
    )]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus2Choice.Denied),
        nameof(RepoCallRequestStatus2Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus2Choice.Proprietary),
        nameof(RepoCallRequestStatus2Choice.Proprietary)
    )]
    [IsoId("_UWYvc9p-Ed-ak6NoX_4Aeg_-1943927387")]
    [DisplayName("Repo Call Request Status 2 Choice")]
    public abstract record RepoCallRequestStatus2Choice_ { }
}
