// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of cash premium paid to the security holder when voting.
    /// </summary>
    [KnownType(typeof(IncentivePremiumType2Choice.PerSecurity))]
    [KnownType(typeof(IncentivePremiumType2Choice.PerVote))]
    [KnownType(typeof(IncentivePremiumType2Choice.PerAttendee))]
    [JsonDerivedType(typeof(IncentivePremiumType2Choice.PerSecurity),nameof(IncentivePremiumType2Choice.PerSecurity))]
    [JsonDerivedType(typeof(IncentivePremiumType2Choice.PerVote),nameof(IncentivePremiumType2Choice.PerVote))]
    [JsonDerivedType(typeof(IncentivePremiumType2Choice.PerAttendee),nameof(IncentivePremiumType2Choice.PerAttendee))]
    [IsoId("_ui4e-_NBEeqRfth943bvEA")]
    [DisplayName("Incentive Premium Type 2 Choice")]
    public abstract partial record IncentivePremiumType2Choice_
    {
    }
}
