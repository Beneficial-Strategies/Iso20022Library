// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a method for participating to the voting of agenda resolutions in a general meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Id1hIK31EemG7MmivSuE5g")]
[Description(
    @"Specifies a method for participating to the voting of agenda resolutions in a general meeting."
)]
[DerivedFrom(typeof(VotingParticipationMethodCode))]
public enum VotingParticipationMethod1Code
{
    /// <summary>
    /// Vote participation is via documents sent through physical post / mail.
    /// Encoded/decoded by serializers as &quot;MAIL&quot;.
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_gdrTga33EemG7MmivSuE5g")]
    [Description(@"Vote participation is via documents sent through physical post / mail.")]
    Correspondence = VotingParticipationMethodCode.Correspondence, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote participation is through physical attendance.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_givZsa33EemG7MmivSuE5g")]
    [Description(@"Vote participation is through physical attendance.")]
    InPerson = VotingParticipationMethodCode.InPerson, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Participation to the meeting is in person but the person is not voting.
    /// Encoded/decoded by serializers as &quot;PHNV&quot;.
    /// </summary>
    [EnumMember(Value = "PHNV")]
    [IsoId("_gqxUUq33EemG7MmivSuE5g")]
    [Description(@"Participation to the meeting is in person but the person is not voting.")]
    NotVoting = VotingParticipationMethodCode.NotVoting, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote participation is through a proxy person.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_gvh4ga33EemG7MmivSuE5g")]
    [Description(@"Vote participation is through a proxy person.")]
    Proxy = VotingParticipationMethodCode.Proxy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote participation is through virtual meeting attendance method like multimedia and web based video or audio conferencing.
    /// Encoded/decoded by serializers as &quot;VIRT&quot;.
    /// </summary>
    [EnumMember(Value = "VIRT")]
    [IsoId("_g5Dn8q33EemG7MmivSuE5g")]
    [Description(
        @"Vote participation is through virtual meeting attendance method like multimedia and web based video or audio conferencing. "
    )]
    Virtual = VotingParticipationMethodCode.Virtual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vote participation is through electronic means like email or dedicated standards messaging or web based voting applications.
    /// Encoded/decoded by serializers as &quot;EVOT&quot;.
    /// </summary>
    [EnumMember(Value = "EVOT")]
    [IsoId("__atT0bISEemux5trsZcCpw")]
    [Description(
        @"Vote participation is through electronic means like email or dedicated standards messaging or web based voting applications."
    )]
    ElectronicVoting = VotingParticipationMethodCode.ElectronicVoting, // same ordinal as derivation source for type conversions
}
