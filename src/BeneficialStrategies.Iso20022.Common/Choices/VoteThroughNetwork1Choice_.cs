// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between voting directly to issuers or voting via alternate network channels.
    /// </summary>
    [KnownType(typeof(VoteThroughNetwork1Choice.VoteChannel))]
    [KnownType(typeof(VoteThroughNetwork1Choice.VoteDirectlyToIssuer))]
    [JsonDerivedType(
        typeof(VoteThroughNetwork1Choice.VoteChannel),
        nameof(VoteThroughNetwork1Choice.VoteChannel)
    )]
    [JsonDerivedType(
        typeof(VoteThroughNetwork1Choice.VoteDirectlyToIssuer),
        nameof(VoteThroughNetwork1Choice.VoteDirectlyToIssuer)
    )]
    [IsoId("_qNpVMDT7Ee2tRf29bleifQ")]
    [DisplayName("Vote Through Network 1 Choice")]
    public abstract record VoteThroughNetwork1Choice_ { }
}
