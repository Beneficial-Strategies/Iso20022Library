// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Classifies the meeting type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aVytINp-Ed-ak6NoX_4Aeg_620378610")]
[Description(@"Classifies the meeting type.")]
[DerivedFrom(typeof(MeetingTypeClassificationCode))]
public enum MeetingTypeClassification1Code
{
    /// <summary>
    /// Meeting held periodically to approve the financial statements and to elect the board members and the auditors.
    /// Encoded/decoded by serializers as &quot;AMET&quot;.
    /// </summary>
    [EnumMember(Value = "AMET")]
    [IsoId("_aVytIdp-Ed-ak6NoX_4Aeg_1004565745")]
    [Description(
        @"Meeting held periodically to approve the financial statements and to elect the board members and the auditors."
    )]
    Annual = MeetingTypeClassificationCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting which is planned in the by-laws.
    /// Encoded/decoded by serializers as &quot;OMET&quot;.
    /// </summary>
    [EnumMember(Value = "OMET")]
    [IsoId("_aVytItp-Ed-ak6NoX_4Aeg_1059976450")]
    [Description(@"Meeting which is planned in the by-laws.")]
    Ordinary = MeetingTypeClassificationCode.Ordinary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting for holders of a specific type of asset, for example, preferred shares, bonds.
    /// Encoded/decoded by serializers as &quot;CLAS&quot;.
    /// </summary>
    [EnumMember(Value = "CLAS")]
    [IsoId("_aVytI9p-Ed-ak6NoX_4Aeg_1072904286")]
    [Description(
        @"Meeting for holders of a specific type of asset, for example, preferred shares, bonds."
    )]
    Class = MeetingTypeClassificationCode.Class, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting is the result of an obligation or a decision made by the issuer as opposed to voting rights holder initiated, for example, contested meeting.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_aVytJNp-Ed-ak6NoX_4Aeg_1079369382")]
    [Description(
        @"Meeting is the result of an obligation or a decision made by the issuer as opposed to voting rights holder initiated, for example, contested meeting."
    )]
    IssuerInitiated = MeetingTypeClassificationCode.IssuerInitiated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting is the result of a request or an action of a voting right holder(s), for example, contested meeting.
    /// Encoded/decoded by serializers as &quot;VRHI&quot;.
    /// </summary>
    [EnumMember(Value = "VRHI")]
    [IsoId("_aVytJdp-Ed-ak6NoX_4Aeg_1093220956")]
    [Description(
        @"Meeting is the result of a request or an action of a voting right holder(s), for example, contested meeting."
    )]
    VotingRightsHolderInitiated = MeetingTypeClassificationCode.VotingRightsHolderInitiated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies that the meeting is the result of a legal proceeding.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_aVytJtp-Ed-ak6NoX_4Aeg_1117234257")]
    [Description(@"Specifies that the meeting is the result of a legal proceeding.")]
    Court = MeetingTypeClassificationCode.Court, // same ordinal as derivation source for type conversions
}
