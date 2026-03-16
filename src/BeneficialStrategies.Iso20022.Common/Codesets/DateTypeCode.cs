// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Ongoing basis, which indicates that the date is determined by &quot;ongoing basis&quot; process, for example &quot;au fil de l&apos;eau&quot;.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ayjhp9p-Ed-ak6NoX_4Aeg_-2092185589")]
[Description(
    @"Ongoing basis, which indicates that the date is determined by ""ongoing basis"" process, for example ""au fil de l'eau""."
)]
[Derivations(
    typeof(DateType6Code),
    typeof(DateType9Code),
    typeof(DateType3Code),
    typeof(DateType8Code),
    typeof(DateType7Code),
    typeof(DateType4Code),
    typeof(DateType5Code),
    typeof(DateType10Code),
    typeof(DateType1Code),
    typeof(DateType2Code)
)]
public enum DateTypeCode
{
    /// <summary>
    /// Open-dated, which indicates that the date has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_aytSoNp-Ed-ak6NoX_4Aeg_-1994292043")]
    [Description(@"Open-dated, which indicates that the date has not been established.")]
    Open,

    /// <summary>
    /// Date is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aytSodp-Ed-ak6NoX_4Aeg_-1981362264")]
    [Description(@"Date is unknown by the sender or has not been established.")]
    Unknown,

    /// <summary>
    /// Ongoing basis, which indicates that the date is determined by &quot;ongoing basis&quot; process, for example &quot;au fil de l&apos;eau&quot;.
    /// Encoded/decoded by serializers as &quot;ONGO&quot;.
    /// </summary>
    [EnumMember(Value = "ONGO")]
    [IsoId("_aytSotp-Ed-ak6NoX_4Aeg_-1968434749")]
    [Description(
        @"Ongoing basis, which indicates that the date is determined by ""ongoing basis"" process, for example ""au fil de l'eau""."
    )]
    Ongoing,

    /// <summary>
    /// Partial trades have occurred over a period of two or more days.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_aytSo9p-Ed-ak6NoX_4Aeg_1555566246")]
    [Description(@"Partial trades have occurred over a period of two or more days.")]
    Various,

    /// <summary>
    /// Blocking occurs until and inclusive of the end of the election period of the option.
    /// Encoded/decoded by serializers as &quot;PWAL&quot;.
    /// </summary>
    [EnumMember(Value = "PWAL")]
    [IsoId("_JXKel-4EEeqc-LCjwLsUVg")]
    [Description(
        @"Blocking occurs until and inclusive of the end of the election period of the option."
    )]
    BlockingTillEndOfElectionPeriod,

    /// <summary>
    /// Blocking occurs until and inclusive of the market deadline of the option.
    /// Encoded/decoded by serializers as &quot;MKDT&quot;.
    /// </summary>
    [EnumMember(Value = "MKDT")]
    [IsoId("_JXKemO4EEeqc-LCjwLsUVg")]
    [Description(@"Blocking occurs until and inclusive of the market deadline of the option.")]
    BlockingTillMarketDeadline,

    /// <summary>
    /// Blocking occurs until and inclusive of the meeting date.
    /// Encoded/decoded by serializers as &quot;MEET&quot;.
    /// </summary>
    [EnumMember(Value = "MEET")]
    [IsoId("_JXKeme4EEeqc-LCjwLsUVg")]
    [Description(@"Blocking occurs until and inclusive of the meeting date.")]
    BlockingTillMeetingDate,

    /// <summary>
    /// Unblocking will occur on payment date of the option.
    /// Encoded/decoded by serializers as &quot;PAYD&quot;.
    /// </summary>
    [EnumMember(Value = "PAYD")]
    [IsoId("_JXKemu4EEeqc-LCjwLsUVg")]
    [Description(@"Unblocking will occur on payment date of the option.")]
    BlockingTillPaymentDate,

    /// <summary>
    /// Blocking occurs until and inclusive of the record date of the event.
    /// Encoded/decoded by serializers as &quot;RDTE&quot;.
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("_JXKem-4EEeqc-LCjwLsUVg")]
    [Description(@"Blocking occurs until and inclusive of the record date of the event.")]
    BlockingTillRecordDate,

    /// <summary>
    /// Blocking occurs until and inclusive of the account servicer deadline for the option.
    /// Encoded/decoded by serializers as &quot;RDDT&quot;.
    /// </summary>
    [EnumMember(Value = "RDDT")]
    [IsoId("_JXKenO4EEeqc-LCjwLsUVg")]
    [Description(
        @"Blocking occurs until and inclusive of the account servicer deadline for the option."
    )]
    BlockingTillResponseDeadline,

    /// <summary>
    /// Refer to additional information element for the date until when the securities are blocked.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_JXKene4EEeqc-LCjwLsUVg")]
    [Description(
        @"Refer to additional information element for the date until when the securities are blocked."
    )]
    NarrativeUnblockingDate,

    /// <summary>
    /// Unblocking will occur on payment date of the premium.
    /// Encoded/decoded by serializers as &quot;PPYD&quot;.
    /// </summary>
    [EnumMember(Value = "PPYD")]
    [IsoId("_ctHnEDUJEe2tRf29bleifQ")]
    [Description(@"Unblocking will occur on payment date of the premium.")]
    BlockingTillPremiumPaymentDate,
}
