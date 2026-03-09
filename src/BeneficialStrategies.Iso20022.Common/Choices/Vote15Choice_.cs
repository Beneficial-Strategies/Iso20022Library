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
    /// Choice between a vote per agenda resolution and vote for all agenda resolutions.
    /// </summary>
    [KnownType(typeof(Vote15Choice.VotePerAgendaResolution))]
    [KnownType(typeof(Vote15Choice.VoteForAllAgendaResolutions))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Vote15Choice.VotePerAgendaResolution),nameof(Vote15Choice.VotePerAgendaResolution))]
    [JsonDerivedType(typeof(Vote15Choice.VoteForAllAgendaResolutions),nameof(Vote15Choice.VoteForAllAgendaResolutions))]
    #endif
    [IsoId("_9DJBZ_NXEeqRfth943bvEA")]
    [DisplayName("Vote 15 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Vote15Choice_
    #else
    public abstract partial class Vote15Choice_
    #endif
    {
    }
}
