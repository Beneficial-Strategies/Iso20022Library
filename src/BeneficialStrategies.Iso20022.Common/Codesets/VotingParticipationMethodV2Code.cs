// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JD_2QBrkEeyhRdHRjakS2w")]
[Description(@"Specifies the different methods allowed for participating to the vote of agenda resolutions in a general meeting.")]
[Derivations(typeof(VotingParticipationMethod3Code))]
public enum VotingParticipationMethodV2Code
{
    /// <summary>
    /// Vote participation is via documents sent through physical post / mail.
    /// Encoded/decoded by serializers as &quot;MAIL&quot;.
    /// </summary>
    [EnumMember(Value = "MAIL")]
    [IsoId("_VmIhJhrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is via documents sent through physical post / mail.")]
    Correspondence,
    
    /// <summary>
    /// Vote participation is through electronic means like dedicated standards messaging or web based voting applications.
    /// Encoded/decoded by serializers as &quot;EVOT&quot;.
    /// </summary>
    [EnumMember(Value = "EVOT")]
    [IsoId("_VmIhJxrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through electronic means like dedicated standards messaging or web based voting applications.")]
    ElectronicVoting,
    
    /// <summary>
    /// Vote participation is through physical attendance.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_VmIhKBrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through physical attendance.")]
    InPerson,
    
    /// <summary>
    /// Participation to the meeting is in person but the person is not voting.
    /// Encoded/decoded by serializers as &quot;PHNV&quot;.
    /// </summary>
    [EnumMember(Value = "PHNV")]
    [IsoId("_VmIhKRrkEeyhRdHRjakS2w")]
    [Description(@"Participation to the meeting is in person but the person is not voting.")]
    NotVoting,
    
    /// <summary>
    /// Vote participation is through a proxy person.
    /// Encoded/decoded by serializers as &quot;PRXY&quot;.
    /// </summary>
    [EnumMember(Value = "PRXY")]
    [IsoId("_VmIhKhrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through a proxy person.")]
    Proxy,
    
    /// <summary>
    /// Vote participation is through virtual meeting attendance method like multimedia and web based video or audio conferencing. 
    /// Encoded/decoded by serializers as &quot;VIRT&quot;.
    /// </summary>
    [EnumMember(Value = "VIRT")]
    [IsoId("_VmIhKxrkEeyhRdHRjakS2w")]
    [Description(@"Vote participation is through virtual meeting attendance method like multimedia and web based video or audio conferencing. ")]
    Virtual,
    
}
