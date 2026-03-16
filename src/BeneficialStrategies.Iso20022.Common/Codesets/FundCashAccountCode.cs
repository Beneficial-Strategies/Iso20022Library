// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the cash account type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_asv0ktp-Ed-ak6NoX_4Aeg_1756152528")]
[Description(@"Specifies the cash account type.")]
[Derivations(
    typeof(FundCashAccount2Code),
    typeof(FundCashAccount3Code),
    typeof(FundCashAccount1Code),
    typeof(FundCashAccount4Code)
)]
public enum FundCashAccountCode
{
    /// <summary>
    /// Cash account.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_asv0k9p-Ed-ak6NoX_4Aeg_1873437246")]
    [Description(@"Cash account.")]
    CashAccount,

    /// <summary>
    /// Central Provident Fund (CPF) ordinary account.
    /// Encoded/decoded by serializers as &quot;CPFO&quot;.
    /// </summary>
    [EnumMember(Value = "CPFO")]
    [IsoId("_asv0lNp-Ed-ak6NoX_4Aeg_1873437264")]
    [Description(@"Central Provident Fund (CPF) ordinary account.")]
    PensionFundOrdinary,

    /// <summary>
    /// Central Provident Fund (CPF) special account.
    /// Encoded/decoded by serializers as &quot;CPFS&quot;.
    /// </summary>
    [EnumMember(Value = "CPFS")]
    [IsoId("_asv0ldp-Ed-ak6NoX_4Aeg_1873437281")]
    [Description(@"Central Provident Fund (CPF) special account.")]
    PensionFundSpecial,

    /// <summary>
    /// Supplementary Retirement Scheme (SRS) account.
    /// Encoded/decoded by serializers as &quot;SRSA&quot;.
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_asv0ltp-Ed-ak6NoX_4Aeg_1873437290")]
    [Description(@"Supplementary Retirement Scheme (SRS) account.")]
    RetirementScheme,

    /// <summary>
    /// Another type cash account.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_asv0l9p-Ed-ak6NoX_4Aeg_1927926012")]
    [Description(@"Another type cash account.")]
    Other,

    /// <summary>
    /// Hedge fund account.
    /// Encoded/decoded by serializers as &quot;HEDG&quot;.
    /// </summary>
    [EnumMember(Value = "HEDG")]
    [IsoId("_asv0mNp-Ed-ak6NoX_4Aeg_263585161")]
    [Description(@"Hedge fund account.")]
    HedgeFund,

    /// <summary>
    /// Workplace or company pension account.
    /// Encoded/decoded by serializers as &quot;CPEN&quot;.
    /// </summary>
    [EnumMember(Value = "CPEN")]
    [IsoId("_zwbKECC7EeWPMvNwVtiMsA")]
    [Description(@"Workplace or company pension account.")]
    WorkplacePensionSchema,

    /// <summary>
    /// Private pension account.
    /// Encoded/decoded by serializers as &quot;PPEN&quot;.
    /// </summary>
    [EnumMember(Value = "PPEN")]
    [IsoId("_2fBeUCC7EeWPMvNwVtiMsA")]
    [Description(@"Private pension account.")]
    PrivatePensionScheme,

    /// <summary>
    /// Account owned by a CSD participant.
    /// Encoded/decoded by serializers as &quot;CSDP&quot;.
    /// </summary>
    [EnumMember(Value = "CSDP")]
    [IsoId("_5XoDICC7EeWPMvNwVtiMsA")]
    [Description(@"Account owned by a CSD participant.")]
    CSDParticipantAccount,

    /// <summary>
    /// Account operated by a CSD for mirroring positions.
    /// Encoded/decoded by serializers as &quot;CSDM&quot;.
    /// </summary>
    [EnumMember(Value = "CSDM")]
    [IsoId("_8a0HUCC7EeWPMvNwVtiMsA")]
    [Description(@"Account operated by a CSD for mirroring positions.")]
    CSDMirrorAccount,

    /// <summary>
    /// Account operated by a CSD for settlement of securities legs for instructions involving internal CSDs.
    /// Encoded/decoded by serializers as &quot;ICSA&quot;.
    /// </summary>
    [EnumMember(Value = "ICSA")]
    [IsoId("_AHf0cCC8EeWPMvNwVtiMsA")]
    [Description(
        @"Account operated by a CSD for settlement of securities legs for instructions involving internal CSDs."
    )]
    InterCSDAccount,

    /// <summary>
    /// Account operated by a CSD in a direct holding market context.
    /// Encoded/decoded by serializers as &quot;TOFF&quot;.
    /// </summary>
    [EnumMember(Value = "TOFF")]
    [IsoId("_DWVH8CC8EeWPMvNwVtiMsA")]
    [Description(@"Account operated by a CSD in a direct holding market context.")]
    TechnicalOffsetAccount,

    /// <summary>
    /// Account operated by a CSD in cross-CSD settlement context.
    /// Encoded/decoded by serializers as &quot;CSDO&quot;.
    /// </summary>
    [EnumMember(Value = "CSDO")]
    [IsoId("_FsJv0CC8EeWPMvNwVtiMsA")]
    [Description(@"Account operated by a CSD in cross-CSD settlement context.")]
    CSDOmnibusAccount,
}
