// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of cash premium paid to the security holder when voting.
    /// </summary>
    [KnownType(typeof(IncentivePremiumType1Choice.PerSecurity))]
    [KnownType(typeof(IncentivePremiumType1Choice.PerVote))]
    [KnownType(typeof(IncentivePremiumType1Choice.PerAttendee))]
    [JsonDerivedType(
        typeof(IncentivePremiumType1Choice.PerSecurity),
        nameof(IncentivePremiumType1Choice.PerSecurity)
    )]
    [JsonDerivedType(
        typeof(IncentivePremiumType1Choice.PerVote),
        nameof(IncentivePremiumType1Choice.PerVote)
    )]
    [JsonDerivedType(
        typeof(IncentivePremiumType1Choice.PerAttendee),
        nameof(IncentivePremiumType1Choice.PerAttendee)
    )]
    [IsoId("_RDieodp-Ed-ak6NoX_4Aeg_1038160776")]
    [DisplayName("Incentive Premium Type 1 Choice")]
    public abstract record IncentivePremiumType1Choice_ { }
}
