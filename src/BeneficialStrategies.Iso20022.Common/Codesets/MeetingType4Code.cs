// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of security holders meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ccCwYK7DEemG7MmivSuE5g")]
[Description(@"Specifies a type of security holders meeting.")]
[DerivedFrom(typeof(MeetingTypeV2Code))]
public enum MeetingType4Code
{
    /// <summary>
    /// Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example, approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.
    /// Encoded/decoded by serializers as &quot;XMET&quot;.
    /// </summary>
    [EnumMember(Value = "XMET")]
    [IsoId("_iaPNIa7DEemG7MmivSuE5g")]
    [Description(@"Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example, approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.")]
    Extraordinary = MeetingTypeV2Code.Extraordinary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Includes annual and ordinary meetings. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example, approval of dividends and directors. These meetings are always issuer initiated.
    /// Encoded/decoded by serializers as &quot;GMET&quot;.
    /// </summary>
    [EnumMember(Value = "GMET")]
    [IsoId("_izrn4q7DEemG7MmivSuE5g")]
    [Description(@"Includes annual and ordinary meetings. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example, approval of dividends and directors. These meetings are always issuer initiated.")]
    General = MeetingTypeV2Code.General, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting which contains both ordinary and extraordinary resolutions.
    /// Encoded/decoded by serializers as &quot;MIXD&quot;.
    /// </summary>
    [EnumMember(Value = "MIXD")]
    [IsoId("_jAxosq7DEemG7MmivSuE5g")]
    [Description(@"Meeting which contains both ordinary and extraordinary resolutions.")]
    Mixed = MeetingTypeV2Code.Mixed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting that takes place as needed that is neither ordinary nor extraordinary.
    /// Encoded/decoded by serializers as &quot;SPCL&quot;.
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("_jYIYwq7DEemG7MmivSuE5g")]
    [Description(@"Meeting that takes place as needed that is neither ordinary nor extraordinary.")]
    Special = MeetingTypeV2Code.Special, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Physical meeting of bond holders.
    /// Encoded/decoded by serializers as &quot;BMET&quot;.
    /// </summary>
    [EnumMember(Value = "BMET")]
    [IsoId("_j02J8q7DEemG7MmivSuE5g")]
    [Description(@"Physical meeting of bond holders.")]
    BondHolderMeeting = MeetingTypeV2Code.BondHolderMeeting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting is the result of a legal proceeding.
    /// Encoded/decoded by serializers as &quot;CMET&quot;.
    /// </summary>
    [EnumMember(Value = "CMET")]
    [IsoId("_kb-bYq7DEemG7MmivSuE5g")]
    [Description(@"Meeting is the result of a legal proceeding.")]
    CourtMeeting = MeetingTypeV2Code.CourtMeeting, // same ordinal as derivation source for type conversions
    
}
