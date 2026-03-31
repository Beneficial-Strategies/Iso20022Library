// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of security holders meeting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVpjNdp-Ed-ak6NoX_4Aeg_1624182418")]
[Description(@"Specifies the type of security holders meeting.")]
[DerivedFrom(typeof(MeetingTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MeetingType2Code>))]
#endif
public enum MeetingType2Code
{
    /// <summary>
    /// Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated.
    /// Encoded/decoded by serializers as &quot;XMET&quot;.
    /// </summary>
    [EnumMember(Value = "XMET")]
    [IsoId("_aVpjNtp-Ed-ak6NoX_4Aeg_1624182678")]
    [Description(
        @"Meeting that takes place as needed, in addition to the general meetings, is extraordinary as per the bylaws. The resolutions are related to the unusual business of the company, for example approval of takeovers or mergers or spin-offs. These meetings are always issuer initiated."
    )]
    Extraordinary = MeetingTypeCode.Extraordinary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Includes annual and ordinary meeting. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example approval of dividends, directors, etc. These meetings are always issuer initiated.
    /// Encoded/decoded by serializers as &quot;GMET&quot;.
    /// </summary>
    [EnumMember(Value = "GMET")]
    [IsoId("_aVpjN9p-Ed-ak6NoX_4Aeg_-1757420749")]
    [Description(
        @"Includes annual and ordinary meeting. Statutory meeting(s) usually held at least once a year. The resolutions are related to the usual business of the company, for example approval of dividends, directors, etc. These meetings are always issuer initiated."
    )]
    General = MeetingTypeCode.General, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies a meeting which contains both ordinary and extraordinary resolutions.
    /// Encoded/decoded by serializers as &quot;MIXD&quot;.
    /// </summary>
    [EnumMember(Value = "MIXD")]
    [IsoId("_aVpjONp-Ed-ak6NoX_4Aeg_1624182695")]
    [Description(
        @"Specifies a meeting which contains both ordinary and extraordinary resolutions."
    )]
    Mixed = MeetingTypeCode.Mixed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting that takes place as needed that is neither ordinary nor extraordinary.
    /// Encoded/decoded by serializers as &quot;SPCL&quot;.
    /// </summary>
    [EnumMember(Value = "SPCL")]
    [IsoId("_aVpjOdp-Ed-ak6NoX_4Aeg_1624182720")]
    [Description(@"Meeting that takes place as needed that is neither ordinary nor extraordinary.")]
    Special = MeetingTypeCode.Special, // same ordinal as derivation source for type conversions
}
