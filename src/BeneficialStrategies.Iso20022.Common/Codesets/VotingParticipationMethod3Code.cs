// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eR8asBrkEeyhRdHRjakS2w")]
[Description(@"Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.")]
[DerivedFrom(typeof(VotingParticipationMethodV2Code))]
public enum VotingParticipationMethod3Code
{
    /// <summary>
    /// Vote participation is via documents sent through physical post / mail.
    /// Encoded/decoded by serializers as &quot;MAIL&quot;.
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_lwIDgRrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is via documents sent through physical post / mail.")]
    Correspondence = VotingParticipationMethodV2Code.Correspondence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote participation is through electronic means like dedicated standards messaging or web based voting applications.
    /// Encoded/decoded by serializers as &quot;EVOT&quot;.
    /// </summary>
    [EnumMember(Value = "EVOT")]
    [IsoId("_l1o1oRrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through electronic means like dedicated standards messaging or web based voting applications.")]
    ElectronicVoting = VotingParticipationMethodV2Code.ElectronicVoting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote participation is through physical attendance.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_l6s70RrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through physical attendance.")]
    InPerson = VotingParticipationMethodV2Code.InPerson, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Participation to the meeting is in person but the person is not voting.
    /// Encoded/decoded by serializers as &quot;PHNV&quot;.
    /// </summary>
    [EnumMember(Value = "PHNV")]
    [IsoId("_l_xpERrkEeyhRdHRjakS2w")]
    [Description(@"Participation to the meeting is in person but the person is not voting.")]
    NotVoting = VotingParticipationMethodV2Code.NotVoting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote participation is through a proxy person.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_mFIqMRrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through a proxy person.")]
    Proxy = VotingParticipationMethodV2Code.Proxy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vote participation is through virtual meeting attendance method like multimedia and web based video or audio conferencing. 
    /// Encoded/decoded by serializers as &quot;VIRT&quot;.
    /// </summary>
    [EnumMember(Value = "VIRT")]
    [IsoId("_mKgSYRrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through virtual meeting attendance method like multimedia and web based video or audio conferencing. ")]
    Virtual = VotingParticipationMethodV2Code.Virtual, // same ordinal as derivation source for type conversions
    
}
