// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Lists the type of the securities account specific for a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_hjxdRmliEeGaMcKyqKNRfQ_-588040654")]
[Description(@"Lists the type of the securities account specific for a system.")]
[DerivedFrom(typeof(SystemSecuritiesAccountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SystemSecuritiesAccountType1Code>))]
#endif
public enum SystemSecuritiesAccountType1Code
{
    /// <summary>
    /// Account owned by a CSD Participant|.
    /// Encoded/decoded by serializers as &quot;CSDP&quot;.
    /// </summary>
    [EnumMember(Value = "CSDP")]
    [IsoId("_hjxdR2liEeGaMcKyqKNRfQ_1173137579")]
    [Description(@"Account owned by a CSD Participant|.")]
    CSDParticipantAccount = SystemSecuritiesAccountTypeCode.CSDParticipantAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account operated by CSD for mirroring positions|.
    /// Encoded/decoded by serializers as &quot;CSDM&quot;.
    /// </summary>
    [EnumMember(Value = "CSDM")]
    [IsoId("_hjxdSGliEeGaMcKyqKNRfQ_1627224848")]
    [Description(@"Account operated by CSD for mirroring positions|.")]
    CSDMirrorAccount = SystemSecuritiesAccountTypeCode.CSDMirrorAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account operated by CSD for settlement of securities legs for instructions involving internal CSD s.
    /// Encoded/decoded by serializers as &quot;ICSA&quot;.
    /// </summary>
    [EnumMember(Value = "ICSA")]
    [IsoId("_hjxdSWliEeGaMcKyqKNRfQ_577417343")]
    [Description(
        @"Account operated by CSD for settlement of securities legs for instructions involving internal CSD s."
    )]
    InterCSDAccount = SystemSecuritiesAccountTypeCode.InterCSDAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account operated by CSDs in a direct holding market context.
    /// Encoded/decoded by serializers as &quot;TOFF&quot;.
    /// </summary>
    [EnumMember(Value = "TOFF")]
    [IsoId("_hjxdSmliEeGaMcKyqKNRfQ_-57614503")]
    [Description(@"Account operated by CSDs in a direct holding market context.")]
    TechnicalOffsetAccount = SystemSecuritiesAccountTypeCode.TechnicalOffsetAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account operated by CSD in cross-CSD settlement context.
    /// Encoded/decoded by serializers as &quot;CSDO&quot;.
    /// </summary>
    [EnumMember(Value = "CSDO")]
    [IsoId("_hjxdS2liEeGaMcKyqKNRfQ_545446579")]
    [Description(@"Account operated by CSD in cross-CSD settlement context.")]
    CSDOmnibusAccount = SystemSecuritiesAccountTypeCode.CSDOmnibusAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account reflecting the holdings of the participants of the issuer CSD for a given financial instrument.
    /// Encoded/decoded by serializers as &quot;ISSA&quot;.
    /// </summary>
    [EnumMember(Value = "ISSA")]
    [IsoId("_hjxdTGliEeGaMcKyqKNRfQ_-1782286940")]
    [Description(
        @"Account reflecting the holdings of the participants of the issuer CSD for a given financial instrument."
    )]
    IssuanceAccount = SystemSecuritiesAccountTypeCode.IssuanceAccount, // same ordinal as derivation source for type conversions
}
