// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the balance type, as published in an external balance type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XihW8IakEeeUws0ZryHQ2w")]
[Description(
    @"Specifies the balance type, as published in an external balance type code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalBalanceTypeCode))]
public enum ExternalBalanceType1Code
{
    /// <summary>
    /// Closing balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;CLAV&quot;.
    /// </summary>
    [EnumMember(Value = "CLAV")]
    [IsoId("_ua6dZfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Closing balance of amount of money that is at the disposal of the account owner on the date specified. "
    )]
    ClosingAvailable = ExternalBalanceTypeCode.ClosingAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period.
    /// Encoded/decoded by serializers as &quot;CLBD&quot;.
    /// </summary>
    [EnumMember(Value = "CLBD")]
    [IsoId("_ua6daPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance of the account at the end of the pre-agreed account reporting period. It is the sum of the opening booked balance at the beginning of the period and all entries booked to the account during the pre-agreed account reporting period. "
    )]
    ClosingBooked = ExternalBalanceTypeCode.ClosingBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Forward available balance of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;FWAV&quot;.
    /// </summary>
    [EnumMember(Value = "FWAV")]
    [IsoId("_ua6da_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Forward available balance of money that is at the disposal of the account owner on the date specified. "
    )]
    ForwardAvailable = ExternalBalanceTypeCode.ForwardAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance for informational purposes.
    /// Encoded/decoded by serializers as &quot;INFO&quot;.
    /// </summary>
    [EnumMember(Value = "INFO")]
    [IsoId("_ua6dbvRYEeuLhpyIdtJzwg")]
    [Description(@"Balance for informational purposes. ")]
    Information = ExternalBalanceTypeCode.Information, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Available balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;ITAV&quot;.
    /// </summary>
    [EnumMember(Value = "ITAV")]
    [IsoId("_ubDnUvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Available balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified. "
    )]
    InterimAvailable = ExternalBalanceTypeCode.InterimAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance calculated in the course of the account servicer&apos;s business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified.
    /// Encoded/decoded by serializers as &quot;ITBD&quot;.
    /// </summary>
    [EnumMember(Value = "ITBD")]
    [IsoId("_ubDnVfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance calculated in the course of the account servicer's business day, at the time specified, and subject to further changes during the business day. The interim balance is calculated on the basis of booked credit and debit items during the calculation time/period specified. "
    )]
    InterimBooked = ExternalBalanceTypeCode.InterimBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Opening balance of amount of money that is at the disposal of the account owner on the date specified.
    /// Encoded/decoded by serializers as &quot;OPAV&quot;.
    /// </summary>
    [EnumMember(Value = "OPAV")]
    [IsoId("_ubDnWPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Opening balance of amount of money that is at the disposal of the account owner on the date specified. "
    )]
    OpeningAvailable = ExternalBalanceTypeCode.OpeningAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report.
    /// Encoded/decoded by serializers as &quot;OPBD&quot;.
    /// </summary>
    [EnumMember(Value = "OPBD")]
    [IsoId("_ubDnW_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Book balance of the account at the beginning of the account reporting period. It always equals the closing book balance from the previous report. "
    )]
    OpeningBooked = ExternalBalanceTypeCode.OpeningBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance.|Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date.
    /// Encoded/decoded by serializers as &quot;PRCD&quot;.
    /// </summary>
    [EnumMember(Value = "PRCD")]
    [IsoId("_ubNYUvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance of the account at the previously closed account reporting period. The opening booked balance for the new period has to be equal to this balance.|Usage: the previously booked closing balance should equal (inclusive date) the booked closing balance of the date it references and equal the actual booked opening balance of the current date."
    )]
    PreviouslyClosedBooked = ExternalBalanceTypeCode.PreviouslyClosedBooked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted.
    /// Encoded/decoded by serializers as &quot;XPCD&quot;.
    /// </summary>
    [EnumMember(Value = "XPCD")]
    [IsoId("_ubNYVfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Balance, composed of booked entries and pending items known at the time of calculation, which projects the end of day balance if everything is booked on the account and no other entry is posted. "
    )]
    Expected = ExternalBalanceTypeCode.Expected, // same ordinal as derivation source for type conversions
}
