// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction/cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YjUjcKnAEfC5VNwixU6YfQ")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[Derivations(typeof(IssuerAgentRejection1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<IssuerAgentRejectionCode>))]
public enum IssuerAgentRejectionCode
{
    /// <summary>
    /// Accrued interest is not applicable for this type of security.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_uFAt6qnBEfC5VNwixU6YfQ")]
    [Description(@"Accrued interest is not applicable for this type of security.")]
    UnexpectedAccruedInterest,

    /// <summary>
    /// Party is not defined as an agent.
    /// Encoded/decoded by serializers as &quot;AGID&quot;.
    /// </summary>
    [EnumMember(Value = "AGID")]
    [IsoId("_uFAt5qnBEfC5VNwixU6YfQ")]
    [Description(@"Party is not defined as an agent.")]
    NotDefinedAgent,

    /// <summary>
    /// Back end odd lot quantity is missing.
    /// Encoded/decoded by serializers as &quot;BACK&quot;.
    /// </summary>
    [EnumMember(Value = "BACK")]
    [IsoId("_TMRw4KnBEfC5VNwixU6YfQ")]
    [Description(@"Back end odd lot quantity is missing.")]
    MissingBackEndOddLotQuantity,

    /// <summary>
    /// Date is not a business day for the security market.
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_uFAt5anBEfC5VNwixU6YfQ")]
    [Description(@"Date is not a business day for the security market.")]
    NotBusinessDay,

    /// <summary>
    /// Bid interval is missing.
    /// Encoded/decoded by serializers as &quot;BIDI&quot;.
    /// </summary>
    [EnumMember(Value = "BIDI")]
    [IsoId("_TMRw4anBEfC5VNwixU6YfQ")]
    [Description(@"Bid interval is missing.")]
    MissingBidInterval,

    /// <summary>
    /// Certificate Amount must be greater than zero.
    /// Encoded/decoded by serializers as &quot;CER0&quot;.
    /// </summary>
    [EnumMember(Value = "CER0")]
    [IsoId("_rlRqEanDEfC5VNwixU6YfQ")]
    [Description(@"Certificate Amount must be greater than zero.")]
    CertificateAmountGreaterZero,

    /// <summary>
    /// Invalid Amount Total Certificate Amount must be greater than zero and equal to Security Called Amount.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_kZ9S4KnDEfC5VNwixU6YfQ")]
    [Description(@"Invalid Amount Total Certificate Amount must be greater than zero and equal to Security Called Amount.")]
    InvalidTotalCertificateAmount,

    /// <summary>
    /// Cash in lieu price is missing.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_TMSX4KnBEfC5VNwixU6YfQ")]
    [Description(@"Cash in lieu price is missing.")]
    MissingCashInLieuPrice,

    /// <summary>
    /// Conditional tenders accepted flag is missing.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_TMSX46nBEfC5VNwixU6YfQ")]
    [Description(@"Conditional tenders accepted flag is missing.")]
    MissingConditionalTendersAcceptedFlag,

    /// <summary>
    /// Cash rate is missing.
    /// Encoded/decoded by serializers as &quot;CSRT&quot;.
    /// </summary>
    [EnumMember(Value = "CSRT")]
    [IsoId("_TMSX4anBEfC5VNwixU6YfQ")]
    [Description(@"Cash rate is missing.")]
    MissingCashRate,

    /// <summary>
    /// Invalid Defeased Security Identifier.
    /// Encoded/decoded by serializers as &quot;DEFE&quot;.
    /// </summary>
    [EnumMember(Value = "DEFE")]
    [IsoId("_c68joanDEfC5VNwixU6YfQ")]
    [Description(@"Invalid Defeased Security Identifier.")]
    InvalidDefeasedSecurityIdentifier,

    /// <summary>
    /// Depository Called Amount must be greater than zero and must be equal to Security Called Amount.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_wIJ_YqnDEfC5VNwixU6YfQ")]
    [Description(@"Depository Called Amount must be greater than zero and must be equal to Security Called Amount.")]
    DepositoryCalledAmountEqualSecurityCalledAmount,

    /// <summary>
    /// One option must be marked as the default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_uFAG6qnBEfC5VNwixU6YfQ")]
    [Description(@"One option must be marked as the default.")]
    MissingDefaultOption,

    /// <summary>
    /// Disperse security is not eligible in the (ICSD) service provider owner.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_uFAt56nBEfC5VNwixU6YfQ")]
    [Description(@"Disperse security is not eligible in the (ICSD) service provider owner.")]
    NotEligibleDisperseSecurity,

    /// <summary>
    /// Duplicate event exists.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_0oyR8KnDEfC5VNwixU6YfQ")]
    [Description(@"Duplicate event exists.")]
    DuplicateEvent,

    /// <summary>
    /// Security is not eligible.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_uFAt5KnBEfC5VNwixU6YfQ")]
    [Description(@"Security is not eligible.")]
    NonEligibleSecurity,

    /// <summary>
    /// Period ending date or code is missing.
    /// Encoded/decoded by serializers as &quot;ENDP&quot;.
    /// </summary>
    [EnumMember(Value = "ENDP")]
    [IsoId("_uFAt06nBEfC5VNwixU6YfQ")]
    [Description(@"Period ending date or code is missing.")]
    MissingPeriodEndDate,

    /// <summary>
    /// Invalid Event Type.
    /// Encoded/decoded by serializers as &quot;EVNT&quot;.
    /// </summary>
    [EnumMember(Value = "EVNT")]
    [IsoId("_9c7oIKnDEfC5VNwixU6YfQ")]
    [Description(@"Invalid Event Type.")]
    InvalidEventType,

    /// <summary>
    /// Validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_TMRw3KnBEfC5VNwixU6YfQ")]
    [Description(@"Validation of the advice/instruction/request failed.")]
    FailedValidation,

    /// <summary>
    /// Depository Called Amount must be greater than zero.
    /// Encoded/decoded by serializers as &quot;FAS0&quot;.
    /// </summary>
    [EnumMember(Value = "FAS0")]
    [IsoId("_wIJ_Y6nDEfC5VNwixU6YfQ")]
    [Description(@"Depository Called Amount must be greater than zero.")]
    DepositoryCalledAmountGreaterZero,

    /// <summary>
    /// First bid increment is missing.
    /// Encoded/decoded by serializers as &quot;FIRS&quot;.
    /// </summary>
    [EnumMember(Value = "FIRS")]
    [IsoId("_uFAG7anBEfC5VNwixU6YfQ")]
    [Description(@"First bid increment is missing.")]
    MissingFirstBidIncrement,

    /// <summary>
    /// Fractional Underlying Security cannot be announced.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_uFAG7qnBEfC5VNwixU6YfQ")]
    [Description(@"Fractional Underlying Security cannot be announced.")]
    MissingFractionalDisposition,

    /// <summary>
    /// Gross amount is less than net amount.
    /// Encoded/decoded by serializers as &quot;GAMN&quot;.
    /// </summary>
    [EnumMember(Value = "GAMN")]
    [IsoId("_TMRw3anBEfC5VNwixU6YfQ")]
    [Description(@"Gross amount is less than net amount.")]
    GrossAmountLessThanNetAmount,

    /// <summary>
    /// Disbursed security identification is missing.
    /// Encoded/decoded by serializers as &quot;IDIS&quot;.
    /// </summary>
    [EnumMember(Value = "IDIS")]
    [IsoId("_TMRw3qnBEfC5VNwixU6YfQ")]
    [Description(@"Disbursed security identification is missing.")]
    InvalidDisbursedSecurityIdentification,

    /// <summary>
    /// Issuer agent contact information is invalid or missing.
    /// Encoded/decoded by serializers as &quot;ISSC&quot;.
    /// </summary>
    [EnumMember(Value = "ISSC")]
    [IsoId("_TMRw36nBEfC5VNwixU6YfQ")]
    [Description(@"Issuer agent contact information is invalid or missing.")]
    InvalidOrMissingIssuerAgentContactInformation,

    /// <summary>
    /// Issuer agent is missing.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_uFAG8KnBEfC5VNwixU6YfQ")]
    [Description(@"Issuer agent is missing.")]
    MissingIssuerAgent,

    /// <summary>
    /// Last bid increment is missing.
    /// Encoded/decoded by serializers as &quot;LAST&quot;.
    /// </summary>
    [EnumMember(Value = "LAST")]
    [IsoId("_uFAG8anBEfC5VNwixU6YfQ")]
    [Description(@"Last bid increment is missing.")]
    MissingLastBidIncrement,

    /// <summary>
    /// Underlying Security has a global lock.
    /// Encoded/decoded by serializers as &quot;LOCK&quot;.
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("_M_8DAanEEfC5VNwixU6YfQ")]
    [Description(@"Underlying Security has a global lock.")]
    GlobalLock,

    /// <summary>
    /// Maximum price is missing.
    /// Encoded/decoded by serializers as &quot;MAXP&quot;.
    /// </summary>
    [EnumMember(Value = "MAXP")]
    [IsoId("_uFAG8qnBEfC5VNwixU6YfQ")]
    [Description(@"Maximum price is missing.")]
    MissingMaximumPrice,

    /// <summary>
    /// Certification has not been filled in.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_TMSX4qnBEfC5VNwixU6YfQ")]
    [Description(@"Certification has not been filled in.")]
    MissingCertification,

    /// <summary>
    /// Disbursed security identification is missing.
    /// Encoded/decoded by serializers as &quot;MDIS&quot;.
    /// </summary>
    [EnumMember(Value = "MDIS")]
    [IsoId("_uFAG66nBEfC5VNwixU6YfQ")]
    [Description(@"Disbursed security identification is missing.")]
    MissingDisbursedSecurityIdentification,

    /// <summary>
    /// Full conditional flag is missing.
    /// Encoded/decoded by serializers as &quot;MFCF&quot;.
    /// </summary>
    [EnumMember(Value = "MFCF")]
    [IsoId("_uFAG76nBEfC5VNwixU6YfQ")]
    [Description(@"Full conditional flag is missing.")]
    MissingFullConditionalFlag,

    /// <summary>
    /// Minimum price is missing.
    /// Encoded/decoded by serializers as &quot;MINP&quot;.
    /// </summary>
    [EnumMember(Value = "MINP")]
    [IsoId("_uFAG86nBEfC5VNwixU6YfQ")]
    [Description(@"Minimum price is missing.")]
    MissingMinimumPrice,

    /// <summary>
    /// Proration rounding indicator is missing.
    /// Encoded/decoded by serializers as &quot;MPRI&quot;.
    /// </summary>
    [EnumMember(Value = "MPRI")]
    [IsoId("_uFAt16nBEfC5VNwixU6YfQ")]
    [Description(@"Proration rounding indicator is missing.")]
    MissingProrationRoundingIndicator,

    /// <summary>
    /// Convertible Security Not Supported.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_VKFZ8qnEEfC5VNwixU6YfQ")]
    [Description(@"Convertible Security Not Supported.")]
    ConvertibleSecurityNotSupported,

    /// <summary>
    /// Invalid Non-Defeased Security Identifier.
    /// Encoded/decoded by serializers as &quot;NDEF&quot;.
    /// </summary>
    [EnumMember(Value = "NDEF")]
    [IsoId("_VKFZ86nEEfC5VNwixU6YfQ")]
    [Description(@"Invalid Non-Defeased Security Identifier.")]
    InvalidNonDefeasedSecurityIdentifier,

    /// <summary>
    /// Cancelled event cannot be modified.
    /// Encoded/decoded by serializers as &quot;NMOD&quot;.
    /// </summary>
    [EnumMember(Value = "NMOD")]
    [IsoId("_itq6wanEEfC5VNwixU6YfQ")]
    [Description(@"Cancelled event cannot be modified.")]
    CancelledEvent,

    /// <summary>
    /// Agent has no access to the service.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_uFAt4qnBEfC5VNwixU6YfQ")]
    [Description(@"Agent has no access to the service.")]
    NoAccessToService,

    /// <summary>
    /// Party is not active.
    /// Encoded/decoded by serializers as &quot;NPAT&quot;.
    /// </summary>
    [EnumMember(Value = "NPAT")]
    [IsoId("_uFAt46nBEfC5VNwixU6YfQ")]
    [Description(@"Party is not active.")]
    NonActiveParty,

    /// <summary>
    /// Invalid Non-Refunded Security Identifier
    /// Encoded/decoded by serializers as &quot;NREF&quot;.
    /// </summary>
    [EnumMember(Value = "NREF")]
    [IsoId("_lDeUganEEfC5VNwixU6YfQ")]
    [Description(@"Invalid Non-Refunded Security Identifier")]
    InvalidNonRefundedSecurityIdentifier,

    /// <summary>
    /// Odd lot priority flag is missing.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("_uFAG9KnBEfC5VNwixU6YfQ")]
    [Description(@"Odd lot priority flag is missing.")]
    MissingOddLotPriorityFlag,

    /// <summary>
    /// Ongoing Conversion Event Exists
    /// Encoded/decoded by serializers as &quot;ONCV&quot;.
    /// </summary>
    [EnumMember(Value = "ONCV")]
    [IsoId("_4VYqEanEEfC5VNwixU6YfQ")]
    [Description(@"Ongoing Conversion Event Exists")]
    OngoingConversionEventExists,

    /// <summary>
    /// Oversubscription charge flag is missing.
    /// Encoded/decoded by serializers as &quot;OVCH&quot;.
    /// </summary>
    [EnumMember(Value = "OVCH")]
    [IsoId("_uFAG9qnBEfC5VNwixU6YfQ")]
    [Description(@"Oversubscription charge flag is missing.")]
    MissingOversubscriptionChargeFlag,

    /// <summary>
    /// Oversubscription flag is missing.
    /// Encoded/decoded by serializers as &quot;OVFL&quot;.
    /// </summary>
    [EnumMember(Value = "OVFL")]
    [IsoId("_uFAt0KnBEfC5VNwixU6YfQ")]
    [Description(@"Oversubscription flag is missing.")]
    MissingOversubscriptionFlag,

    /// <summary>
    /// Oversubscription price is missing.
    /// Encoded/decoded by serializers as &quot;OVPR&quot;.
    /// </summary>
    [EnumMember(Value = "OVPR")]
    [IsoId("_uFAt0anBEfC5VNwixU6YfQ")]
    [Description(@"Oversubscription price is missing.")]
    MissingOversubscriptionPrice,

    /// <summary>
    /// Price basis is missing.
    /// Encoded/decoded by serializers as &quot;PBAS&quot;.
    /// </summary>
    [EnumMember(Value = "PBAS")]
    [IsoId("_uFAt1anBEfC5VNwixU6YfQ")]
    [Description(@"Price basis is missing.")]
    MissingPriceBasis,

    /// <summary>
    /// Effective date is after the payment date.
    /// Encoded/decoded by serializers as &quot;PDAY&quot;.
    /// </summary>
    [EnumMember(Value = "PDAY")]
    [IsoId("_TMRw26nBEfC5VNwixU6YfQ")]
    [Description(@"Effective date is after the payment date.")]
    EffectiveDayAfterPaymentDate,

    /// <summary>
    /// Period ending date is before period starting date.
    /// Encoded/decoded by serializers as &quot;PERI&quot;.
    /// </summary>
    [EnumMember(Value = "PERI")]
    [IsoId("_uFAt6KnBEfC5VNwixU6YfQ")]
    [Description(@"Period ending date is before period starting date.")]
    PeriodEndDateBeforeStartDate,

    /// <summary>
    /// Zero Coupon Bond, Principal / Cash rate must be less than USD 1,000.00.
    /// Encoded/decoded by serializers as &quot;PR1K&quot;.
    /// </summary>
    [EnumMember(Value = "PR1K")]
    [IsoId("_4VYDB6nEEfC5VNwixU6YfQ")]
    [Description(@"Zero Coupon Bond, Principal / Cash rate must be less than USD 1,000.00.")]
    CashRateLessThanThousand,

    /// <summary>
    /// Protect charge indicator is missing.
    /// Encoded/decoded by serializers as &quot;PRCH&quot;.
    /// </summary>
    [EnumMember(Value = "PRCH")]
    [IsoId("_uFAt2KnBEfC5VNwixU6YfQ")]
    [Description(@"Protect charge indicator is missing.")]
    MissingProtectChargeIndicator,

    /// <summary>
    /// Invalid Principal Cash Rate.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_4VYDCqnEEfC5VNwixU6YfQ")]
    [Description(@"Invalid Principal Cash Rate.")]
    InvalidPrincipalCashRate,

    /// <summary>
    /// Proration rate is missing.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_uFAt1qnBEfC5VNwixU6YfQ")]
    [Description(@"Proration rate is missing.")]
    MissingProrationRate,

    /// <summary>
    /// Payout type is missing.
    /// Encoded/decoded by serializers as &quot;PTYP&quot;.
    /// </summary>
    [EnumMember(Value = "PTYP")]
    [IsoId("_uFAt0qnBEfC5VNwixU6YfQ")]
    [Description(@"Payout type is missing.")]
    MissingPayoutType,

    /// <summary>
    /// Publication date must be earlier than payable date.
    /// Encoded/decoded by serializers as &quot;PUBD&quot;.
    /// </summary>
    [EnumMember(Value = "PUBD")]
    [IsoId("_4VYqEqnEEfC5VNwixU6YfQ")]
    [Description(@"Publication date must be earlier than payable date.")]
    PublicationDate,

    /// <summary>
    /// Record date is after payment date.
    /// Encoded/decoded by serializers as &quot;RDTE&quot;.
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("_uFAt6anBEfC5VNwixU6YfQ")]
    [Description(@"Record date is after payment date.")]
    RecordDateAfterPaymentDate,

    /// <summary>
    /// Invalid Redemption Date.
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("_8znI4KnEEfC5VNwixU6YfQ")]
    [Description(@"Invalid Redemption Date.")]
    InvalidRedemptionDate,

    /// <summary>
    /// Invalid Notification Identification.
    /// Encoded/decoded by serializers as &quot;REFR&quot;.
    /// </summary>
    [EnumMember(Value = "REFR")]
    [IsoId("_4VYDCanEEfC5VNwixU6YfQ")]
    [Description(@"Invalid Notification Identification.")]
    InvalidNotificationIdentification,

    /// <summary>
    /// Invalid Refunded Security Identifier.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_4VYqEKnEEfC5VNwixU6YfQ")]
    [Description(@"Invalid Refunded Security Identifier.")]
    InvalidRefundedSecurityIdentifier,

    /// <summary>
    /// Resulting amount must be filled in as exchange rate is present.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_uFAt2qnBEfC5VNwixU6YfQ")]
    [Description(@"Resulting amount must be filled in as exchange rate is present.")]
    MissingResultingAmount,

    /// <summary>
    /// Rights transferrable flag is missing.
    /// Encoded/decoded by serializers as &quot;RITR&quot;.
    /// </summary>
    [EnumMember(Value = "RITR")]
    [IsoId("_uFAt26nBEfC5VNwixU6YfQ")]
    [Description(@"Rights transferrable flag is missing.")]
    MissingRightsTransferrableFlag,

    /// <summary>
    /// Rounding factor is missing.
    /// Encoded/decoded by serializers as &quot;ROUN&quot;.
    /// </summary>
    [EnumMember(Value = "ROUN")]
    [IsoId("_uFAt3KnBEfC5VNwixU6YfQ")]
    [Description(@"Rounding factor is missing.")]
    MissingRoudingFactor,

    /// <summary>
    /// Second option is mandatory.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_uFAG9anBEfC5VNwixU6YfQ")]
    [Description(@"Second option is mandatory.")]
    MissingOption,

    /// <summary>
    /// Security type does not match with the type of corporate action.
    /// Encoded/decoded by serializers as &quot;SECT&quot;.
    /// </summary>
    [EnumMember(Value = "SECT")]
    [IsoId("_uFAt7KnBEfC5VNwixU6YfQ")]
    [Description(@"Security type does not match with the type of corporate action.")]
    WrongSecurityType,

    /// <summary>
    /// Invalid Equity Security Type.
    /// Encoded/decoded by serializers as &quot;SEEQ&quot;.
    /// </summary>
    [EnumMember(Value = "SEEQ")]
    [IsoId("_4VYDCKnEEfC5VNwixU6YfQ")]
    [Description(@"Invalid Equity Security Type.")]
    InvalidEquitySecurityType,

    /// <summary>
    /// Securities rate is missing.
    /// Encoded/decoded by serializers as &quot;SERT&quot;.
    /// </summary>
    [EnumMember(Value = "SERT")]
    [IsoId("_uFAt3anBEfC5VNwixU6YfQ")]
    [Description(@"Securities rate is missing.")]
    MissingSecuritiesRate,

    /// <summary>
    /// Solicitation dealer fee flag is missing.
    /// Encoded/decoded by serializers as &quot;SFEE&quot;.
    /// </summary>
    [EnumMember(Value = "SFEE")]
    [IsoId("_uFAt3qnBEfC5VNwixU6YfQ")]
    [Description(@"Solicitation dealer fee flag is missing.")]
    MissingSolicitationDealerFeeFlag,

    /// <summary>
    /// Period starting date or code is missing.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_uFAt1KnBEfC5VNwixU6YfQ")]
    [Description(@"Period starting date or code is missing.")]
    MissingPeriodStartDate,

    /// <summary>
    /// Subscription charge flag is missing.
    /// Encoded/decoded by serializers as &quot;SUCH&quot;.
    /// </summary>
    [EnumMember(Value = "SUCH")]
    [IsoId("_uFAt36nBEfC5VNwixU6YfQ")]
    [Description(@"Subscription charge flag is missing.")]
    MissingSubscriptionChargeFlag,

    /// <summary>
    /// Subscription price is missing.
    /// Encoded/decoded by serializers as &quot;SUPR&quot;.
    /// </summary>
    [EnumMember(Value = "SUPR")]
    [IsoId("_uFAt4KnBEfC5VNwixU6YfQ")]
    [Description(@"Subscription price is missing.")]
    MissingSubscriptionPrice,

    /// <summary>
    /// Inactive Underlying Security.
    /// Encoded/decoded by serializers as &quot;UNDI&quot;.
    /// </summary>
    [EnumMember(Value = "UNDI")]
    [IsoId("_MlyTEanDEfC5VNwixU6YfQ")]
    [Description(@"Inactive Underlying Security.")]
    InactiveUnderlyingSecurity,

    /// <summary>
    /// Underlying Security is not eligible at Depository.
    /// Encoded/decoded by serializers as &quot;UNDM&quot;.
    /// </summary>
    [EnumMember(Value = "UNDM")]
    [IsoId("_fIEtEanEEfC5VNwixU6YfQ")]
    [Description(@"Underlying Security is not eligible at Depository.")]
    UnderlyingSecurityNotEligible,

    /// <summary>
    /// Invalid Underlying Security.
    /// Encoded/decoded by serializers as &quot;UNDV&quot;.
    /// </summary>
    [EnumMember(Value = "UNDV")]
    [IsoId("_QYM0wanDEfC5VNwixU6YfQ")]
    [Description(@"Invalid Underlying Security.")]
    InvalidUnderlyingSecurity,

    /// <summary>
    /// Unspecified price allowed is missing.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_uFAt4anBEfC5VNwixU6YfQ")]
    [Description(@"Unspecified price allowed is missing.")]
    MissingUnspecifiedPriceAllowed,

    /// <summary>
    /// Value date is before payment date.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_uFAt66nBEfC5VNwixU6YfQ")]
    [Description(@"Value date is before payment date.")]
    ValueDateBeforePaymentDate,

    /// <summary>
    /// Resulting amount is not allowed without an exchange rate.
    /// Encoded/decoded by serializers as &quot;XRAT&quot;.
    /// </summary>
    [EnumMember(Value = "XRAT")]
    [IsoId("_uFAG7KnBEfC5VNwixU6YfQ")]
    [Description(@"Resulting amount is not allowed without an exchange rate.")]
    MissingExchangeRate,
}
