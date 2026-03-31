// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Classifies the meeting type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QC-WYK7NEemG7MmivSuE5g")]
[Description(@"Classifies the meeting type.")]
[DerivedFrom(typeof(MeetingTypeClassificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MeetingTypeClassification2Code>))]
#endif
public enum MeetingTypeClassification2Code
{
    /// <summary>
    /// Meeting held periodically to approve the financial statements and to elect the board members and the auditors.
    /// Encoded/decoded by serializers as &quot;AMET&quot;.
    /// </summary>
    [EnumMember(Value = "AMET")]
    [IsoId("_UKTYIa7NEemG7MmivSuE5g")]
    [Description(
        @"Meeting held periodically to approve the financial statements and to elect the board members and the auditors."
    )]
    Annual = MeetingTypeClassificationCode.Annual, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting for holders of a specific type of asset, for example, preferred shares, bonds.
    /// Encoded/decoded by serializers as &quot;CLAS&quot;.
    /// </summary>
    [EnumMember(Value = "CLAS")]
    [IsoId("_UUa9cq7NEemG7MmivSuE5g")]
    [Description(
        @"Meeting for holders of a specific type of asset, for example, preferred shares, bonds."
    )]
    Class = MeetingTypeClassificationCode.Class, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting is the result of an obligation or a decision made by the issuer as opposed to voting rights holder initiated, for example, contested meeting.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_UcdfIq7NEemG7MmivSuE5g")]
    [Description(
        @"Meeting is the result of an obligation or a decision made by the issuer as opposed to voting rights holder initiated, for example, contested meeting."
    )]
    IssuerInitiated = MeetingTypeClassificationCode.IssuerInitiated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting which is planned in the by-laws.
    /// Encoded/decoded by serializers as &quot;OMET&quot;.
    /// </summary>
    [EnumMember(Value = "OMET")]
    [IsoId("_Un6hMq7NEemG7MmivSuE5g")]
    [Description(@"Meeting which is planned in the by-laws.")]
    Ordinary = MeetingTypeClassificationCode.Ordinary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Meeting is the result of a request or an action of a voting right holder(s), for example, contested meeting.
    /// Encoded/decoded by serializers as &quot;VRHI&quot;.
    /// </summary>
    [EnumMember(Value = "VRHI")]
    [IsoId("_UvzR4q7NEemG7MmivSuE5g")]
    [Description(
        @"Meeting is the result of a request or an action of a voting right holder(s), for example, contested meeting."
    )]
    VotingRightsHolderInitiated = MeetingTypeClassificationCode.VotingRightsHolderInitiated, // same ordinal as derivation source for type conversions
}
