// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase agreement call acknowledgement.
    /// </summary>
    [KnownType(typeof(RepoCallRequestStatus10Choice.Code))]
    [KnownType(typeof(RepoCallRequestStatus10Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus10Choice.Code),
        nameof(RepoCallRequestStatus10Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus10Choice.Proprietary),
        nameof(RepoCallRequestStatus10Choice.Proprietary)
    )]
    [IsoId("_8QboiZNLEeWGlc8L7oPDIg")]
    [DisplayName("Repo Call Request Status 10 Choice")]
    public abstract record RepoCallRequestStatus10Choice_ { }
}
