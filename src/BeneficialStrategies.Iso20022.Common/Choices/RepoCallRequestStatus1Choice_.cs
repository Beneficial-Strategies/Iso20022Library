// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase agreement call acknowledgement.
    /// </summary>
    [KnownType(typeof(RepoCallRequestStatus1Choice.Code))]
    [KnownType(typeof(RepoCallRequestStatus1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus1Choice.Code),
        nameof(RepoCallRequestStatus1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(RepoCallRequestStatus1Choice.Proprietary),
        nameof(RepoCallRequestStatus1Choice.Proprietary)
    )]
    [IsoId("_UXIWVdp-Ed-ak6NoX_4Aeg_-695454227")]
    [DisplayName("Repo Call Request Status 1 Choice")]
    public abstract record RepoCallRequestStatus1Choice_ { }
}
