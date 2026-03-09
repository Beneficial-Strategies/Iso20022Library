// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between voting directly to issuers or voting via alternate network channels.
    /// </summary>
    [KnownType(typeof(VoteThroughNetwork1Choice.VoteChannel))]
    [KnownType(typeof(VoteThroughNetwork1Choice.VoteDirectlyToIssuer))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(VoteThroughNetwork1Choice.VoteChannel),nameof(VoteThroughNetwork1Choice.VoteChannel))]
    [JsonDerivedType(typeof(VoteThroughNetwork1Choice.VoteDirectlyToIssuer),nameof(VoteThroughNetwork1Choice.VoteDirectlyToIssuer))]
    #endif
    [IsoId("_qNpVMDT7Ee2tRf29bleifQ")]
    [DisplayName("Vote Through Network 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record VoteThroughNetwork1Choice_
    #else
    public abstract partial class VoteThroughNetwork1Choice_
    #endif
    {
    }
}
