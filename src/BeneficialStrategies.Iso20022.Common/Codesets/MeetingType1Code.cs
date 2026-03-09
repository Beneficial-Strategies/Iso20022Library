// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of security holders meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VpsKYdp-Ed-ak6NoX_4Aeg_-13714408")]
[Description(@"Specifies the type of security holders meeting.")]
[DerivedFrom(typeof(MeetingTypeCode))]
public enum MeetingType1Code
{
    /// <summary>
    /// Specifies a meeting held periodically to approve the financial statements and elect the board members and the auditors.
    /// Encoded/decoded by serializers as &quot;AMET&quot;.
    /// </summary>
    [EnumMember(Value = "AMET")]
    [IsoId("_VpsKYtp-Ed-ak6NoX_4Aeg_151975556")]
    [Description(@"Specifies a meeting held periodically to approve the financial statements and elect the board members and the auditors.")]
    AnnualGeneralMeeting = MeetingTypeCode.AnnualGeneralMeeting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies a meeting that is not planned in the by laws.
    /// Encoded/decoded by serializers as &quot;OMET&quot;.
    /// </summary>
    [EnumMember(Value = "OMET")]
    [IsoId("_VpsKY9p-Ed-ak6NoX_4Aeg_19531418")]
    [Description(@"Specifies a meeting that is not planned in the by laws.")]
    Ordinary = MeetingTypeCode.Ordinary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.
    /// Encoded/decoded by serializers as &quot;XMET&quot;.
    /// </summary>
    [EnumMember(Value = "XMET")]
    [IsoId("_VpsKZNp-Ed-ak6NoX_4Aeg_1495102587")]
    [Description(@"Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.")]
    Extraordinary = MeetingTypeCode.Extraordinary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies a meeting which contains both ordinary and extraordinary resolutions.
    /// Encoded/decoded by serializers as &quot;MIXD&quot;.
    /// </summary>
    [EnumMember(Value = "MIXD")]
    [IsoId("_VpsKZdp-Ed-ak6NoX_4Aeg_19531443")]
    [Description(@"Specifies a meeting which contains both ordinary and extraordinary resolutions.")]
    Mixed = MeetingTypeCode.Mixed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting for a class of assets.
    /// Encoded/decoded by serializers as &quot;CLAS&quot;.
    /// </summary>
    [EnumMember(Value = "CLAS")]
    [IsoId("_VpsKZtp-Ed-ak6NoX_4Aeg_179678337")]
    [Description(@"Meeting for a class of assets.")]
    ClassMeeting = MeetingTypeCode.ClassMeeting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Specifies that the meeting is the result of a legal proceeding.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_VpsKZ9p-Ed-ak6NoX_4Aeg_202766392")]
    [Description(@"Specifies that the meeting is the result of a legal proceeding.")]
    CourtMeeting = MeetingTypeCode.CourtMeeting, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Meeting that takes place as needed that is neither ordinary nor extraordinary.
    /// Encoded/decoded by serializers as &quot;SPCL&quot;.
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("_VpsKaNp-Ed-ak6NoX_4Aeg_371401191")]
    [Description(@"Meeting that takes place as needed that is neither ordinary nor extraordinary.")]
    Special = MeetingTypeCode.Special, // same ordinal as derivation source for type conversions
    
}
