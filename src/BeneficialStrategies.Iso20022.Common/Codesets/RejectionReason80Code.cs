// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the corporate actio notification advice has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4aB4cFvBEe6gDOpEK7Q4ig")]
[Description(@"Specifies the reason why the corporate actio notification advice has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonV3Code))]
public enum RejectionReason80Code
{
    /// <summary>
    /// Accrued interest is not applicable for this type of security.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("")]
    [Description(@"Accrued interest is not applicable for this type of security.")]
    UnexpectedAccruedInterest = RejectionReasonV3Code.UnexpectedAccruedInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party is not defined as an agent.
    /// Encoded/decoded by serializers as &quot;AGID&quot;.
    /// </summary>
    [EnumMember(Value = "AGID")]
    [IsoId("")]
    [Description(@"Party is not defined as an agent.")]
    NotDefinedAgent = RejectionReasonV3Code.NotDefinedAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Back end odd lot quantity is missing.
    /// Encoded/decoded by serializers as &quot;BACK&quot;.
    /// </summary>
    [EnumMember(Value = "BACK")]
    [IsoId("")]
    [Description(@"Back end odd lot quantity is missing.")]
    MissingBackEndOddLotQuantity = RejectionReasonV3Code.MissingBackEndOddLotQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date is not a business day for the security market.
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("")]
    [Description(@"Date is not a business day for the security market.")]
    NotBusinessDay = RejectionReasonV3Code.NotBusinessDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bid interval is missing.
    /// Encoded/decoded by serializers as &quot;BIDI&quot;.
    /// </summary>
    [EnumMember(Value = "BIDI")]
    [IsoId("")]
    [Description(@"Bid interval is missing.")]
    MissingBidInterval = RejectionReasonV3Code.MissingBidInterval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash in lieu price is missing.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("")]
    [Description(@"Cash in lieu price is missing.")]
    MissingCashInLieuPrice = RejectionReasonV3Code.MissingCashInLieuPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Conditional tenders accepted flag is missing.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("")]
    [Description(@"Conditional tenders accepted flag is missing.")]
    MissingConditionalTendersAcceptedFlag = RejectionReasonV3Code.MissingConditionalTendersAcceptedFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash rate is missing.
    /// Encoded/decoded by serializers as &quot;CSRT&quot;.
    /// </summary>
    [EnumMember(Value = "CSRT")]
    [IsoId("")]
    [Description(@"Cash rate is missing.")]
    MissingCashRate = RejectionReasonV3Code.MissingCashRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One option must be marked as the default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("")]
    [Description(@"One option must be marked as the default.")]
    MissingDefaultOption = RejectionReasonV3Code.MissingDefaultOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disperse security is not eligible in the (ICSD) service provider owner.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("")]
    [Description(@"Disperse security is not eligible in the (ICSD) service provider owner.")]
    NotEligibleDisperseSecurity = RejectionReasonV3Code.NotEligibleDisperseSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security is not eligible.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("")]
    [Description(@"Security is not eligible.")]
    NonEligibleSecurity = RejectionReasonV3Code.NonEligibleSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period ending date or code is missing.
    /// Encoded/decoded by serializers as &quot;ENDP&quot;.
    /// </summary>
    [EnumMember(Value = "ENDP")]
    [IsoId("")]
    [Description(@"Period ending date or code is missing.")]
    MissingPeriodEndDate = RejectionReasonV3Code.MissingPeriodEndDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("")]
    [Description(@"Validation of the advice/instruction/request failed.")]
    FailedValidation = RejectionReasonV3Code.FailedValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// First bid increment is missing.
    /// Encoded/decoded by serializers as &quot;FIRS&quot;.
    /// </summary>
    [EnumMember(Value = "FIRS")]
    [IsoId("")]
    [Description(@"First bid increment is missing.")]
    MissingFirstBidIncrement = RejectionReasonV3Code.MissingFirstBidIncrement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fractional disposition is missing.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("")]
    [Description(@"Fractional disposition is missing.")]
    MissingFractionalDisposition = RejectionReasonV3Code.MissingFractionalDisposition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gross amount is less than net amount.
    /// Encoded/decoded by serializers as &quot;GAMN&quot;.
    /// </summary>
    [EnumMember(Value = "GAMN")]
    [IsoId("")]
    [Description(@"Gross amount is less than net amount.")]
    GrossAmountLessThanNetAmount = RejectionReasonV3Code.GrossAmountLessThanNetAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disbursed security identification is missing.
    /// Encoded/decoded by serializers as &quot;IDIS&quot;.
    /// </summary>
    [EnumMember(Value = "IDIS")]
    [IsoId("")]
    [Description(@"Disbursed security identification is missing.")]
    InvalidDisbursedSecurityIdentification = RejectionReasonV3Code.InvalidDisbursedSecurityIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer agent contact information is invalid or missing.
    /// Encoded/decoded by serializers as &quot;ISSC&quot;.
    /// </summary>
    [EnumMember(Value = "ISSC")]
    [IsoId("")]
    [Description(@"Issuer agent contact information is invalid or missing.")]
    InvalidOrMissingIssuerAgentContactInformation = RejectionReasonV3Code.InvalidOrMissingIssuerAgentContactInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer agent is missing.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("")]
    [Description(@"Issuer agent is missing.")]
    MissingIssuerAgent = RejectionReasonV3Code.MissingIssuerAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Last bid increment is missing.
    /// Encoded/decoded by serializers as &quot;LAST&quot;.
    /// </summary>
    [EnumMember(Value = "LAST")]
    [IsoId("")]
    [Description(@"Last bid increment is missing.")]
    MissingLastBidIncrement = RejectionReasonV3Code.MissingLastBidIncrement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum price is missing.
    /// Encoded/decoded by serializers as &quot;MAXP&quot;.
    /// </summary>
    [EnumMember(Value = "MAXP")]
    [IsoId("")]
    [Description(@"Maximum price is missing.")]
    MissingMaximumPrice = RejectionReasonV3Code.MissingMaximumPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certification has not been filled in.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("")]
    [Description(@"Certification has not been filled in.")]
    MissingCertification = RejectionReasonV3Code.MissingCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disbursed security identification is missing.
    /// Encoded/decoded by serializers as &quot;MDIS&quot;.
    /// </summary>
    [EnumMember(Value = "MDIS")]
    [IsoId("")]
    [Description(@"Disbursed security identification is missing.")]
    MissingDisbursedSecurityIdentification = RejectionReasonV3Code.MissingDisbursedSecurityIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Full conditional flag is missing.
    /// Encoded/decoded by serializers as &quot;MFCF&quot;.
    /// </summary>
    [EnumMember(Value = "MFCF")]
    [IsoId("")]
    [Description(@"Full conditional flag is missing.")]
    MissingFullConditionalFlag = RejectionReasonV3Code.MissingFullConditionalFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Minimum price is missing.
    /// Encoded/decoded by serializers as &quot;MINP&quot;.
    /// </summary>
    [EnumMember(Value = "MINP")]
    [IsoId("")]
    [Description(@"Minimum price is missing.")]
    MissingMinimumPrice = RejectionReasonV3Code.MissingMinimumPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proration rounding indicator is missing.
    /// Encoded/decoded by serializers as &quot;MPRI&quot;.
    /// </summary>
    [EnumMember(Value = "MPRI")]
    [IsoId("")]
    [Description(@"Proration rounding indicator is missing.")]
    MissingProrationRoundingIndicator = RejectionReasonV3Code.MissingProrationRoundingIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent has no access to the service.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("")]
    [Description(@"Agent has no access to the service.")]
    NoAccessToService = RejectionReasonV3Code.NoAccessToService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party is not active.
    /// Encoded/decoded by serializers as &quot;NPAT&quot;.
    /// </summary>
    [EnumMember(Value = "NPAT")]
    [IsoId("")]
    [Description(@"Party is not active.")]
    NonActiveParty = RejectionReasonV3Code.NonActiveParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Odd lot priority flag is missing.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("")]
    [Description(@"Odd lot priority flag is missing.")]
    MissingOddLotPriorityFlag = RejectionReasonV3Code.MissingOddLotPriorityFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Oversubscription charge flag is missing.
    /// Encoded/decoded by serializers as &quot;OVCH&quot;.
    /// </summary>
    [EnumMember(Value = "OVCH")]
    [IsoId("")]
    [Description(@"Oversubscription charge flag is missing.")]
    MissingOversubscriptionChargeFlag = RejectionReasonV3Code.MissingOversubscriptionChargeFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Oversubscription flag is missing.
    /// Encoded/decoded by serializers as &quot;OVFL&quot;.
    /// </summary>
    [EnumMember(Value = "OVFL")]
    [IsoId("")]
    [Description(@"Oversubscription flag is missing.")]
    MissingOversubscriptionFlag = RejectionReasonV3Code.MissingOversubscriptionFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Oversubscription price is missing.
    /// Encoded/decoded by serializers as &quot;OVPR&quot;.
    /// </summary>
    [EnumMember(Value = "OVPR")]
    [IsoId("")]
    [Description(@"Oversubscription price is missing.")]
    MissingOversubscriptionPrice = RejectionReasonV3Code.MissingOversubscriptionPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price basis is missing.
    /// Encoded/decoded by serializers as &quot;PBAS&quot;.
    /// </summary>
    [EnumMember(Value = "PBAS")]
    [IsoId("")]
    [Description(@"Price basis is missing.")]
    MissingPriceBasis = RejectionReasonV3Code.MissingPriceBasis, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Effective date is after the payment date.
    /// Encoded/decoded by serializers as &quot;PDAY&quot;.
    /// </summary>
    [EnumMember(Value = "PDAY")]
    [IsoId("")]
    [Description(@"Effective date is after the payment date.")]
    EffectiveDayAfterPaymentDate = RejectionReasonV3Code.EffectiveDayAfterPaymentDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period ending date is before period starting date.
    /// Encoded/decoded by serializers as &quot;PERI&quot;.
    /// </summary>
    [EnumMember(Value = "PERI")]
    [IsoId("")]
    [Description(@"Period ending date is before period starting date.")]
    PeriodEndDateBeforeStartDate = RejectionReasonV3Code.PeriodEndDateBeforeStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protect charge indicator is missing.
    /// Encoded/decoded by serializers as &quot;PRCH&quot;.
    /// </summary>
    [EnumMember(Value = "PRCH")]
    [IsoId("")]
    [Description(@"Protect charge indicator is missing.")]
    MissingProtectChargeIndicator = RejectionReasonV3Code.MissingProtectChargeIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proration rate is missing.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("")]
    [Description(@"Proration rate is missing.")]
    MissingProrationRate = RejectionReasonV3Code.MissingProrationRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payout type is missing.
    /// Encoded/decoded by serializers as &quot;PTYP&quot;.
    /// </summary>
    [EnumMember(Value = "PTYP")]
    [IsoId("")]
    [Description(@"Payout type is missing.")]
    MissingPayoutType = RejectionReasonV3Code.MissingPayoutType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Record date is after payment date.
    /// Encoded/decoded by serializers as &quot;RDTE&quot;.
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("")]
    [Description(@"Record date is after payment date.")]
    RecordDateAfterPaymentDate = RejectionReasonV3Code.RecordDateAfterPaymentDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resulting amount must be filled in as exchange rate is present.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("")]
    [Description(@"Resulting amount must be filled in as exchange rate is present.")]
    MissingResultingAmount = RejectionReasonV3Code.MissingResultingAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights transferrable flag is missing.
    /// Encoded/decoded by serializers as &quot;RITR&quot;.
    /// </summary>
    [EnumMember(Value = "RITR")]
    [IsoId("")]
    [Description(@"Rights transferrable flag is missing.")]
    MissingRightsTransferrableFlag = RejectionReasonV3Code.MissingRightsTransferrableFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rounding factor is missing.
    /// Encoded/decoded by serializers as &quot;ROUN&quot;.
    /// </summary>
    [EnumMember(Value = "ROUN")]
    [IsoId("")]
    [Description(@"Rounding factor is missing.")]
    MissingRoudingFactor = RejectionReasonV3Code.MissingRoudingFactor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Second option is mandatory.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("")]
    [Description(@"Second option is mandatory.")]
    MissingOption = RejectionReasonV3Code.MissingOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security type does not match with the type of corporate action.
    /// Encoded/decoded by serializers as &quot;SECT&quot;.
    /// </summary>
    [EnumMember(Value = "SECT")]
    [IsoId("")]
    [Description(@"Security type does not match with the type of corporate action.")]
    WrongSecurityType = RejectionReasonV3Code.WrongSecurityType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities rate is missing.
    /// Encoded/decoded by serializers as &quot;SERT&quot;.
    /// </summary>
    [EnumMember(Value = "SERT")]
    [IsoId("")]
    [Description(@"Securities rate is missing.")]
    MissingSecuritiesRate = RejectionReasonV3Code.MissingSecuritiesRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Solicitation dealer fee flag is missing.
    /// Encoded/decoded by serializers as &quot;SFEE&quot;.
    /// </summary>
    [EnumMember(Value = "SFEE")]
    [IsoId("")]
    [Description(@"Solicitation dealer fee flag is missing.")]
    MissingSolicitationDealerFeeFlag = RejectionReasonV3Code.MissingSolicitationDealerFeeFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period starting date or code is missing.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("")]
    [Description(@"Period starting date or code is missing.")]
    MissingPeriodStartDate = RejectionReasonV3Code.MissingPeriodStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subscription charge flag is missing.
    /// Encoded/decoded by serializers as &quot;SUCH&quot;.
    /// </summary>
    [EnumMember(Value = "SUCH")]
    [IsoId("")]
    [Description(@"Subscription charge flag is missing.")]
    MissingSubscriptionChargeFlag = RejectionReasonV3Code.MissingSubscriptionChargeFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subscription price is missing.
    /// Encoded/decoded by serializers as &quot;SUPR&quot;.
    /// </summary>
    [EnumMember(Value = "SUPR")]
    [IsoId("")]
    [Description(@"Subscription price is missing.")]
    MissingSubscriptionPrice = RejectionReasonV3Code.MissingSubscriptionPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unspecified price allowed is missing.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("")]
    [Description(@"Unspecified price allowed is missing.")]
    MissingUnspecifiedPriceAllowed = RejectionReasonV3Code.MissingUnspecifiedPriceAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value date is before payment date.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("")]
    [Description(@"Value date is before payment date.")]
    ValueDateBeforePaymentDate = RejectionReasonV3Code.ValueDateBeforePaymentDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resulting amount is not allowed without an exchange rate.
    /// Encoded/decoded by serializers as &quot;XRAT&quot;.
    /// </summary>
    [EnumMember(Value = "XRAT")]
    [IsoId("")]
    [Description(@"Resulting amount is not allowed without an exchange rate.")]
    MissingExchangeRate = RejectionReasonV3Code.MissingExchangeRate, // same ordinal as derivation source for type conversions

}
