// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Classifies the meeting type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLXl1dp-Ed-ak6NoX_4Aeg_-1571134896")]
[Description(@"Classifies the meeting type.")]
[Derivations(typeof(MeetingTypeClassification1Code), typeof(MeetingTypeClassification2Code))]
public enum MeetingTypeClassificationCode
{
    /// <summary>
    /// Meeting held periodically to approve the financial statements and to elect the board members and the auditors.
    /// Encoded/decoded by serializers as &quot;AMET&quot;.
    /// </summary>
    [EnumMember(Value = "AMET")]
    [IsoId("_aLXl1tp-Ed-ak6NoX_4Aeg_-742738561")]
    [Description(
        @"Meeting held periodically to approve the financial statements and to elect the board members and the auditors."
    )]
    Annual,

    /// <summary>
    /// Meeting which is planned in the by-laws.
    /// Encoded/decoded by serializers as &quot;OMET&quot;.
    /// </summary>
    [EnumMember(Value = "OMET")]
    [IsoId("_aLXl19p-Ed-ak6NoX_4Aeg_-665159801")]
    [Description(@"Meeting which is planned in the by-laws.")]
    Ordinary,

    /// <summary>
    /// Meeting for holders of a specific type of asset, for example, preferred shares, bonds.
    /// Encoded/decoded by serializers as &quot;CLAS&quot;.
    /// </summary>
    [EnumMember(Value = "CLAS")]
    [IsoId("_aLXl2Np-Ed-ak6NoX_4Aeg_-351166054")]
    [Description(
        @"Meeting for holders of a specific type of asset, for example, preferred shares, bonds."
    )]
    Class,

    /// <summary>
    /// Meeting is the result of an obligation or a decision made by the issuer as opposed to voting rights holder initiated, for example, contested meeting.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_aLXl2dp-Ed-ak6NoX_4Aeg_-296676908")]
    [Description(
        @"Meeting is the result of an obligation or a decision made by the issuer as opposed to voting rights holder initiated, for example, contested meeting."
    )]
    IssuerInitiated,

    /// <summary>
    /// Meeting is the result of a request or an action of a voting right holder(s), for example, contested meeting.
    /// Encoded/decoded by serializers as &quot;VRHI&quot;.
    /// </summary>
    [EnumMember(Value = "VRHI")]
    [IsoId("_aLgvwNp-Ed-ak6NoX_4Aeg_229729735")]
    [Description(
        @"Meeting is the result of a request or an action of a voting right holder(s), for example, contested meeting."
    )]
    VotingRightsHolderInitiated,

    /// <summary>
    /// Specifies that the meeting is the result of a legal proceeding.
    /// Encoded/decoded by serializers as &quot;CORT&quot;.
    /// </summary>
    [EnumMember(Value = "CORT")]
    [IsoId("_aLgvwdp-Ed-ak6NoX_4Aeg_535416168")]
    [Description(@"Specifies that the meeting is the result of a legal proceeding.")]
    Court,
}
