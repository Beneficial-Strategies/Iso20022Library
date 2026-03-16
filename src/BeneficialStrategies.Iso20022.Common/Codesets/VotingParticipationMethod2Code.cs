// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Blwy0PNqEeqRfth943bvEA")]
[Description(
    @"Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting."
)]
[DerivedFrom(typeof(VotingParticipationMethodCode))]
public enum VotingParticipationMethod2Code
{
    /// <summary>
    /// Participation to the meeting is in person but the person is not voting.
    /// Encoded/decoded by serializers as &quot;PHNV&quot;.
    /// </summary>
    [EnumMember(Value = "PHNV")]
    [IsoId("_F2nkAfNqEeqRfth943bvEA")]
    [Description(@"Participation to the meeting is in person but the person is not voting.")]
    NotVoting = VotingParticipationMethodCode.NotVoting, // same ordinal as derivation source for type conversions
}
