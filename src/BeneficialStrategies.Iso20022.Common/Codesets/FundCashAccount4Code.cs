// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nCKuwCC7EeWPMvNwVtiMsA")]
[Description(@"Specifies the account type.")]
[DerivedFrom(typeof(FundCashAccountCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<FundCashAccount4Code>))]
#endif
public enum FundCashAccount4Code
{
    /// <summary>
    /// Hedge fund account.
    /// Encoded/decoded by serializers as &quot;HEDG&quot;.
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_o_Z3gSC7EeWPMvNwVtiMsA")]
    [Description(@"Hedge fund account.")]
    HedgeFund = FundCashAccountCode.HedgeFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central Provident Fund (CPF) ordinary account.
    /// Encoded/decoded by serializers as &quot;CPFO&quot;.
    /// </summary>
    [EnumMember(Value = "CPFO")]
    [IsoId("_pGldkSC7EeWPMvNwVtiMsA")]
    [Description(@"Central Provident Fund (CPF) ordinary account.")]
    PensionFundOrdinary = FundCashAccountCode.PensionFundOrdinary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central Provident Fund (CPF) special account.
    /// Encoded/decoded by serializers as &quot;CPFS&quot;.
    /// </summary>
    [EnumMember(Value = "CPFS")]
    [IsoId("_pL-T4SC7EeWPMvNwVtiMsA")]
    [Description(@"Central Provident Fund (CPF) special account.")]
    PensionFundSpecial = FundCashAccountCode.PensionFundSpecial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplementary Retirement Scheme (SRS) account.
    /// Encoded/decoded by serializers as &quot;SRSA&quot;.
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_pRzPESC7EeWPMvNwVtiMsA")]
    [Description(@"Supplementary Retirement Scheme (SRS) account.")]
    RetirementScheme = FundCashAccountCode.RetirementScheme, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account operated by a CSD in cross-CSD settlement context.
    /// Encoded/decoded by serializers as &quot;CSDO&quot;.
    /// </summary>
    [EnumMember(Value = "CSDO")]
    [IsoId("_I6ZNcSC8EeWPMvNwVtiMsA")]
    [Description(@"Account operated by a CSD in cross-CSD settlement context.")]
    CSDOmnibusAccount = FundCashAccountCode.CSDOmnibusAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account operated by a CSD in a direct holding market context.
    /// Encoded/decoded by serializers as &quot;TOFF&quot;.
    /// </summary>
    [EnumMember(Value = "TOFF")]
    [IsoId("_JQ7eISC8EeWPMvNwVtiMsA")]
    [Description(@"Account operated by a CSD in a direct holding market context.")]
    TechnicalOffsetAccount = FundCashAccountCode.TechnicalOffsetAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account operated by a CSD for settlement of securities legs for instructions involving internal CSDs.
    /// Encoded/decoded by serializers as &quot;ICSA&quot;.
    /// </summary>
    [EnumMember(Value = "ICSA")]
    [IsoId("_JWmBQSC8EeWPMvNwVtiMsA")]
    [Description(
        @"Account operated by a CSD for settlement of securities legs for instructions involving internal CSDs."
    )]
    InterCSDAccount = FundCashAccountCode.InterCSDAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account operated by a CSD for mirroring positions.
    /// Encoded/decoded by serializers as &quot;CSDM&quot;.
    /// </summary>
    [EnumMember(Value = "CSDM")]
    [IsoId("_JeNFISC8EeWPMvNwVtiMsA")]
    [Description(@"Account operated by a CSD for mirroring positions.")]
    CSDMirrorAccount = FundCashAccountCode.CSDMirrorAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account owned by a CSD participant.
    /// Encoded/decoded by serializers as &quot;CSDP&quot;.
    /// </summary>
    [EnumMember(Value = "CSDP")]
    [IsoId("_JoWfoSC8EeWPMvNwVtiMsA")]
    [Description(@"Account owned by a CSD participant.")]
    CSDParticipantAccount = FundCashAccountCode.CSDParticipantAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Private pension account.
    /// Encoded/decoded by serializers as &quot;PPEN&quot;.
    /// </summary>
    [EnumMember(Value = "PPEN")]
    [IsoId("_JvqokSC8EeWPMvNwVtiMsA")]
    [Description(@"Private pension account.")]
    PrivatePensionScheme = FundCashAccountCode.PrivatePensionScheme, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Workplace or company pension account.
    /// Encoded/decoded by serializers as &quot;CPEN&quot;.
    /// </summary>
    [EnumMember(Value = "CPEN")]
    [IsoId("_J2YUkSC8EeWPMvNwVtiMsA")]
    [Description(@"Workplace or company pension account.")]
    WorkplacePensionSchema = FundCashAccountCode.WorkplacePensionSchema, // same ordinal as derivation source for type conversions
}
