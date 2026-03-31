// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason of a rejection of the notification advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZlhGxdp-Ed-ak6NoX_4Aeg_1403470007")]
[Description(@"Specifies the reason of a rejection of the notification advice.")]
[DerivedFrom(typeof(RejectionReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason6Code>))]
#endif
public enum RejectionReason6Code
{
    /// <summary>
    /// The validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_ZlhGxtp-Ed-ak6NoX_4Aeg_-394875620")]
    [Description(@"The validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonCode.FailedValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A second option is mandatory.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_ZlhGx9p-Ed-ak6NoX_4Aeg_-394875589")]
    [Description(@"A second option is mandatory.")]
    MissingOption = RejectionReasonCode.MissingOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party is not defined as an agent.
    /// Encoded/decoded by serializers as &quot;AGID&quot;.
    /// </summary>
    [EnumMember(Value = "AGID")]
    [IsoId("_ZlhGyNp-Ed-ak6NoX_4Aeg_-394875558")]
    [Description(@"Party is not defined as an agent.")]
    NotDefinedAgent = RejectionReasonCode.NotDefinedAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period Ending Date or Code is missing.
    /// Encoded/decoded by serializers as &quot;ENDP&quot;.
    /// </summary>
    [EnumMember(Value = "ENDP")]
    [IsoId("_ZlqQsNp-Ed-ak6NoX_4Aeg_-394875557")]
    [Description(@"Period Ending Date or Code is missing.")]
    MissingPeriodEndDate = RejectionReasonCode.MissingPeriodEndDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period Starting Date or Code is missing.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_ZlqQsdp-Ed-ak6NoX_4Aeg_-394875527")]
    [Description(@"Period Starting Date or Code is missing.")]
    MissingPeriodStartDate = RejectionReasonCode.MissingPeriodStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resulting amount must be filled in as Exchange rate is present.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_ZlqQstp-Ed-ak6NoX_4Aeg_-394875497")]
    [Description(@"Resulting amount must be filled in as Exchange rate is present.")]
    MissingResultingAmount = RejectionReasonCode.MissingResultingAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security type does not match with the type of corporate action.
    /// Encoded/decoded by serializers as &quot;SECT&quot;.
    /// </summary>
    [EnumMember(Value = "SECT")]
    [IsoId("_ZlqQs9p-Ed-ak6NoX_4Aeg_-394875466")]
    [Description(@"Security type does not match with the type of corporate action.")]
    WrongSecurityType = RejectionReasonCode.WrongSecurityType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The disperse security is not eligible in the I(CSD) Service Provider Owner.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_ZlqQtNp-Ed-ak6NoX_4Aeg_-394875435")]
    [Description(@"The disperse security is not eligible in the I(CSD) Service Provider Owner.")]
    NotEligibleDisperseSecurity = RejectionReasonCode.NotEligibleDisperseSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The security is not eligible.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_ZlqQtdp-Ed-ak6NoX_4Aeg_-394875404")]
    [Description(@"The security is not eligible.")]
    NonEligibleSecurity = RejectionReasonCode.NonEligibleSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There cannot be a resulting amount without an exchange rate.
    /// Encoded/decoded by serializers as &quot;XRAT&quot;.
    /// </summary>
    [EnumMember(Value = "XRAT")]
    [IsoId("_ZlqQttp-Ed-ak6NoX_4Aeg_-394875157")]
    [Description(@"There cannot be a resulting amount without an exchange rate.")]
    MissingExchangeRate = RejectionReasonCode.MissingExchangeRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value date is before payment date.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_ZlqQt9p-Ed-ak6NoX_4Aeg_-394875126")]
    [Description(@"Value date is before payment date.")]
    ValueDateBeforePaymentDate = RejectionReasonCode.ValueDateBeforePaymentDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Accrued interest is not applicable for this type of security.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_ZlqQuNp-Ed-ak6NoX_4Aeg_-394875064")]
    [Description(@"Accrued interest is not applicable for this type of security.")]
    UnexpectedAccruedInterest = RejectionReasonCode.UnexpectedAccruedInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent has no access to the service.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_ZlqQudp-Ed-ak6NoX_4Aeg_-393955062")]
    [Description(@"Agent has no access to the service.")]
    NoAccessToService = RejectionReasonCode.NoAccessToService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certification Indicator is not filled in.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_Zl0BsNp-Ed-ak6NoX_4Aeg_-393955031")]
    [Description(@"Certification Indicator is not filled in.")]
    MissingCertification = RejectionReasonCode.MissingCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date is not a business day for the security market.
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_Zl0Bsdp-Ed-ak6NoX_4Aeg_-393955000")]
    [Description(@"Date is not a business day for the security market.")]
    NotBusinessDay = RejectionReasonCode.NotBusinessDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Effective date is after the payment date.
    /// Encoded/decoded by serializers as &quot;PDAY&quot;.
    /// </summary>
    [EnumMember(Value = "PDAY")]
    [IsoId("_Zl0Bstp-Ed-ak6NoX_4Aeg_-393954908")]
    [Description(@"Effective date is after the payment date.")]
    EffectiveDayAfterPaymentDate = RejectionReasonCode.EffectiveDayAfterPaymentDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gross amount is less than net amount.
    /// Encoded/decoded by serializers as &quot;GAMN&quot;.
    /// </summary>
    [EnumMember(Value = "GAMN")]
    [IsoId("_Zl0Bs9p-Ed-ak6NoX_4Aeg_-393954877")]
    [Description(@"Gross amount is less than net amount.")]
    GrossAmountLessThanNetAmount = RejectionReasonCode.GrossAmountLessThanNetAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One option must be marked as the default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_Zl0BtNp-Ed-ak6NoX_4Aeg_-393954816")]
    [Description(@"One option must be marked as the default.")]
    MissingDefaultOption = RejectionReasonCode.MissingDefaultOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party is not active.
    /// Encoded/decoded by serializers as &quot;NPAT&quot;.
    /// </summary>
    [EnumMember(Value = "NPAT")]
    [IsoId("_Zl0Btdp-Ed-ak6NoX_4Aeg_-393954785")]
    [Description(@"Party is not active.")]
    NonActiveParty = RejectionReasonCode.NonActiveParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period Ending date is before Period Starting date.
    /// Encoded/decoded by serializers as &quot;PERI&quot;.
    /// </summary>
    [EnumMember(Value = "PERI")]
    [IsoId("_Zl0Bttp-Ed-ak6NoX_4Aeg_-393954507")]
    [Description(@"Period Ending date is before Period Starting date.")]
    PeriodEndDateBeforeStartDate = RejectionReasonCode.PeriodEndDateBeforeStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Record date is after payment date.
    /// Encoded/decoded by serializers as &quot;RDTE&quot;.
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("_Zl0Bt9p-Ed-ak6NoX_4Aeg_-393954476")]
    [Description(@"Record date is after payment date.")]
    RecordDateAfterPaymentDate = RejectionReasonCode.RecordDateAfterPaymentDate, // same ordinal as derivation source for type conversions
}
