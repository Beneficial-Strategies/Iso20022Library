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
    [KnownType(typeof(Vote13Choice.VotePerAgendaResolution))]
    [KnownType(typeof(Vote13Choice.VoteForAllAgendaResolutions))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Vote13Choice.VotePerAgendaResolution),nameof(Vote13Choice.VotePerAgendaResolution))]
    [JsonDerivedType(typeof(Vote13Choice.VoteForAllAgendaResolutions),nameof(Vote13Choice.VoteForAllAgendaResolutions))]
    #endif
    [IsoId("_c7P-kK-4EemJ1NnLPsTFaw")]
    [DisplayName("Vote 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Vote13Choice_
    #else
    public abstract partial class Vote13Choice_
    #endif
    {
    }
}
