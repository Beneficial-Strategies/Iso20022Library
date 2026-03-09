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
    /// Choice of cash premium paid to the security holder when voting.
    /// </summary>
    [KnownType(typeof(IncentivePremiumType2Choice.PerSecurity))]
    [KnownType(typeof(IncentivePremiumType2Choice.PerVote))]
    [KnownType(typeof(IncentivePremiumType2Choice.PerAttendee))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IncentivePremiumType2Choice.PerSecurity),nameof(IncentivePremiumType2Choice.PerSecurity))]
    [JsonDerivedType(typeof(IncentivePremiumType2Choice.PerVote),nameof(IncentivePremiumType2Choice.PerVote))]
    [JsonDerivedType(typeof(IncentivePremiumType2Choice.PerAttendee),nameof(IncentivePremiumType2Choice.PerAttendee))]
    #endif
    [IsoId("_ui4e-_NBEeqRfth943bvEA")]
    [DisplayName("Incentive Premium Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IncentivePremiumType2Choice_
    #else
    public abstract partial class IncentivePremiumType2Choice_
    #endif
    {
    }
}
