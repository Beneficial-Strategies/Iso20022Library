// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of the balance, eg, opening balance.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bao1UNp-Ed-ak6NoX_4Aeg_1033663849")]
[Description(@"Specifies the nature of the balance, eg, opening balance.")]
[DerivedFrom(typeof(BalanceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BalanceType9Code>))]
#endif
public enum BalanceType9Code
{
    /// <summary>
    /// Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;OPBD&quot;.
    /// </summary>
    [EnumMember(Value = "OPBD")]
    [IsoId("_bao1Udp-Ed-ak6NoX_4Aeg_1033663891")]
    [Description(
        @"Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report."
    )]
    OpeningBooked = BalanceTypeCode.OpeningBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;ITBD&quot;.
    /// </summary>
    [EnumMember(Value = "ITBD")]
    [IsoId("_bao1Utp-Ed-ak6NoX_4Aeg_1033663909")]
    [Description(
        @"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InterimBooked = BalanceTypeCode.InterimBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;CLBD&quot;.
    /// </summary>
    [EnumMember(Value = "CLBD")]
    [IsoId("_bao1U9p-Ed-ak6NoX_4Aeg_1033663934")]
    [Description(
        @"Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    ClosingBooked = BalanceTypeCode.ClosingBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;OPAV&quot;.
    /// </summary>
    [EnumMember(Value = "OPAV")]
    [IsoId("_bao1VNp-Ed-ak6NoX_4Aeg_1033664004")]
    [Description(
        @"Opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    OpeningAvailable = BalanceTypeCode.OpeningAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Available balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;ITAV&quot;.
    /// </summary>
    [EnumMember(Value = "ITAV")]
    [IsoId("_bao1Vdp-Ed-ak6NoX_4Aeg_1033664029")]
    [Description(
        @"Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InterimAvailable = BalanceTypeCode.InterimAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;CLAV&quot;.
    /// </summary>
    [EnumMember(Value = "CLAV")]
    [IsoId("_bao1Vtp-Ed-ak6NoX_4Aeg_1033664064")]
    [Description(
        @"Closing balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    ClosingAvailable = BalanceTypeCode.ClosingAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;FWAV&quot;.
    /// </summary>
    [EnumMember(Value = "FWAV")]
    [IsoId("_bao1V9p-Ed-ak6NoX_4Aeg_1033664089")]
    [Description(
        @"Forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    ForwardAvailable = BalanceTypeCode.ForwardAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance. ||Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.
    /// Encoded/decoded by serializers as &quot;PRCD&quot;.
    /// </summary>
    [EnumMember(Value = "PRCD")]
    [IsoId("_bao1WNp-Ed-ak6NoX_4Aeg_138035634")]
    [Description(
        @"Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance. ||Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date."
    )]
    PreviouslyClosedBooked = BalanceTypeCode.PreviouslyClosedBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;IOPA&quot;.
    /// </summary>
    [EnumMember(Value = "IOPA")]
    [IsoId("_bao1Wdp-Ed-ak6NoX_4Aeg_138035656")]
    [Description(
        @"Investment opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    InvestmentOpeningAvailable = BalanceTypeCode.InvestmentOpeningAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment available balance for calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;IITA&quot;.
    /// </summary>
    [EnumMember(Value = "IITA")]
    [IsoId("_baymUNp-Ed-ak6NoX_4Aeg_138035882")]
    [Description(
        @"Investment available balance for calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InvestmentInterimAvailable = BalanceTypeCode.InvestmentInterimAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment closing balance of an amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;ICLA&quot;.
    /// </summary>
    [EnumMember(Value = "ICLA")]
    [IsoId("_baymUdp-Ed-ak6NoX_4Aeg_138035904")]
    [Description(
        @"Investment closing balance of an amount of money that is at the disposal of the account owner on the date specified."
    )]
    InvestmentClosingAvailable = BalanceTypeCode.InvestmentClosingAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;IFWA&quot;.
    /// </summary>
    [EnumMember(Value = "IFWA")]
    [IsoId("_baymUtp-Ed-ak6NoX_4Aeg_138035913")]
    [Description(
        @"Investment forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    InvestmentForwardAvailable = BalanceTypeCode.InvestmentForwardAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment (mutual funds) balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;ICLB&quot;.
    /// </summary>
    [EnumMember(Value = "ICLB")]
    [IsoId("_baymU9p-Ed-ak6NoX_4Aeg_138035935")]
    [Description(
        @"Investment (mutual funds) balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    InvestmentClosingBooked = BalanceTypeCode.InvestmentClosingBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;IITB&quot;.
    /// </summary>
    [EnumMember(Value = "IITB")]
    [IsoId("_baymVNp-Ed-ak6NoX_4Aeg_138035944")]
    [Description(
        @"Investment balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    InvestmentInterimBooked = BalanceTypeCode.InvestmentInterimBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;IOPB&quot;.
    /// </summary>
    [EnumMember(Value = "IOPB")]
    [IsoId("_baymVdp-Ed-ak6NoX_4Aeg_138035965")]
    [Description(
        @"Investment book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report."
    )]
    InvestmentOpeningBooked = BalanceTypeCode.InvestmentOpeningBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disbursement opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;DOPA&quot;.
    /// </summary>
    [EnumMember(Value = "DOPA")]
    [IsoId("_baymVtp-Ed-ak6NoX_4Aeg_138035996")]
    [Description(
        @"Disbursement opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    DisbursementOpeningAvailable = BalanceTypeCode.DisbursementOpeningAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disbursement available balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;DITA&quot;.
    /// </summary>
    [EnumMember(Value = "DITA")]
    [IsoId("_baymV9p-Ed-ak6NoX_4Aeg_138035997")]
    [Description(
        @"Disbursement available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    DisbursementInterimAvailable = BalanceTypeCode.DisbursementInterimAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disbursement closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;DCLA&quot;.
    /// </summary>
    [EnumMember(Value = "DCLA")]
    [IsoId("_baymWNp-Ed-ak6NoX_4Aeg_138036006")]
    [Description(
        @"Disbursement closing balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    DisbursementClosingAvailable = BalanceTypeCode.DisbursementClosingAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disbursement forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;DFWA&quot;.
    /// </summary>
    [EnumMember(Value = "DFWA")]
    [IsoId("_baymWdp-Ed-ak6NoX_4Aeg_138036027")]
    [Description(
        @"Disbursement forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    DisbursementForwardAvailable = BalanceTypeCode.DisbursementForwardAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disbursement balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;DCLB&quot;.
    /// </summary>
    [EnumMember(Value = "DCLB")]
    [IsoId("_ba7wQNp-Ed-ak6NoX_4Aeg_138036028")]
    [Description(
        @"Disbursement balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    DisbursementClosingBooked = BalanceTypeCode.DisbursementClosingBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disbursement balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;DITB&quot;.
    /// </summary>
    [EnumMember(Value = "DITB")]
    [IsoId("_ba7wQdp-Ed-ak6NoX_4Aeg_138036057")]
    [Description(
        @"Disbursement balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    DisbursementInterimBooked = BalanceTypeCode.DisbursementInterimBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disbursement book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;DOPB&quot;.
    /// </summary>
    [EnumMember(Value = "DOPB")]
    [IsoId("_ba7wQtp-Ed-ak6NoX_4Aeg_138036058")]
    [Description(
        @"Disbursement book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report."
    )]
    DisbursementOpeningBooked = BalanceTypeCode.DisbursementOpeningBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collection opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;COPA&quot;.
    /// </summary>
    [EnumMember(Value = "COPA")]
    [IsoId("_ba7wQ9p-Ed-ak6NoX_4Aeg_138036337")]
    [Description(
        @"Collection opening balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    CollectionOpeningAvailable = BalanceTypeCode.CollectionOpeningAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collection available balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;CITA&quot;.
    /// </summary>
    [EnumMember(Value = "CITA")]
    [IsoId("_ba7wRNp-Ed-ak6NoX_4Aeg_138036366")]
    [Description(
        @"Collection available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    CollectionInterimAvailable = BalanceTypeCode.CollectionInterimAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collection closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;CCLA&quot;.
    /// </summary>
    [EnumMember(Value = "CCLA")]
    [IsoId("_ba7wRdp-Ed-ak6NoX_4Aeg_138036367")]
    [Description(
        @"Collection closing balance of amount of money that is at the disposal of the account owner on the date specified."
    )]
    CollectionClosingAvailable = BalanceTypeCode.CollectionClosingAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collection forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;CFWA&quot;.
    /// </summary>
    [EnumMember(Value = "CFWA")]
    [IsoId("_ba7wRtp-Ed-ak6NoX_4Aeg_138036397")]
    [Description(
        @"Collection forward available balance of money that is at the disposal of the account owner on the date specified."
    )]
    CollectionForwardAvailable = BalanceTypeCode.CollectionForwardAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collection balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;CCLB&quot;.
    /// </summary>
    [EnumMember(Value = "CCLB")]
    [IsoId("_ba7wR9p-Ed-ak6NoX_4Aeg_138036428")]
    [Description(
        @"Collection balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period."
    )]
    CollectionClosingBooked = BalanceTypeCode.CollectionClosingBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collection balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;CITB&quot;.
    /// </summary>
    [EnumMember(Value = "CITB")]
    [IsoId("_ba7wSNp-Ed-ak6NoX_4Aeg_138036429")]
    [Description(
        @"Collection balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified."
    )]
    CollectionInterimBooked = BalanceTypeCode.CollectionInterimBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collection book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;COPB&quot;.
    /// </summary>
    [EnumMember(Value = "COPB")]
    [IsoId("_ba7wSdp-Ed-ak6NoX_4Aeg_138036458")]
    [Description(
        @"Collection book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report."
    )]
    CollectionOpeningBooked = BalanceTypeCode.CollectionOpeningBooked, // same ordinal as derivation source for type conversions
}
