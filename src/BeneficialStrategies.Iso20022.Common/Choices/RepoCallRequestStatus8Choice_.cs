// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase agreement call acknowledgement.
    /// </summary>
    [KnownType(typeof(RepoCallRequestStatus8Choice.Code))]
    [KnownType(typeof(RepoCallRequestStatus8Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus8Choice.Code),
        nameof(RepoCallRequestStatus8Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus8Choice.Proprietary),
        nameof(RepoCallRequestStatus8Choice.Proprietary)
    )]
    [IsoId("_Hx5RATqqEeWyoP0PbocV1Q")]
    [DisplayName("Repo Call Request Status 8 Choice")]
    public abstract record RepoCallRequestStatus8Choice_ { }
}
