// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Date is specified as a fixed code value.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sW5NwDUIEe2tRf29bleifQ")]
[Description(@"Date is specified as a fixed code value.")]
[DerivedFrom(typeof(DateTypeCode))]
public enum DateType10Code
{
    /// <summary>
    /// Blocking occurs until and inclusive of the meeting date.
    /// Encoded/decoded by serializers as &quot;MEET&quot;.
    /// </summary>
    [EnumMember(Value = "MEET")]
    [IsoId("_vqyAYTUIEe2tRf29bleifQ")]
    [Description(@"Blocking occurs until and inclusive of the meeting date.")]
    BlockingTillMeetingDate = DateTypeCode.BlockingTillMeetingDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_xUSU0TUIEe2tRf29bleifQ")]
    [Description(@"Date is unknown by the sender or has not been established.")]
    Unknown = DateTypeCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Refer to additional information element for the date until when the securities are blocked.
    /// Encoded/decoded by serializers as &quot;NARR&quot;.
    /// </summary>
    [EnumMember(Value = "NARR")]
    [IsoId("_xjoYYTUIEe2tRf29bleifQ")]
    [Description(@"Refer to additional information element for the date until when the securities are blocked.")]
    NarrativeUnblockingDate = DateTypeCode.NarrativeUnblockingDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Blocking occurs until and inclusive of the record date of the event.
    /// Encoded/decoded by serializers as &quot;RDTE&quot;.
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("_yZbX8TUIEe2tRf29bleifQ")]
    [Description(@"Blocking occurs until and inclusive of the record date of the event.")]
    BlockingTillRecordDate = DateTypeCode.BlockingTillRecordDate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unblocking will occur on payment date of the premium.
    /// Encoded/decoded by serializers as &quot;PPYD&quot;.
    /// </summary>
    [EnumMember(Value = "PPYD")]
    [IsoId("_p3ogkTUJEe2tRf29bleifQ")]
    [Description(@"Unblocking will occur on payment date of the premium.")]
    BlockingTillPremiumPaymentDate = DateTypeCode.BlockingTillPremiumPaymentDate, // same ordinal as derivation source for type conversions
    
}
