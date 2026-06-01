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
[IsoId("_Qrn9YLAhEfCVt6rBUi-YSg")]
[Description(@"Specifies the reason why the instruction/cancellation request has a rejected status.")]
[DerivedFrom(typeof(IssuerAgentRejectionCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<IssuerAgentRejection1Code>))]
public enum IssuerAgentRejection1Code
{
    /// <summary>
    /// Accrued interest is not applicable for this type of security.
    /// Encoded/decoded by serializers as &quot;ACRU&quot;.
    /// </summary>
    [EnumMember(Value = "ACRU")]
    [IsoId("_YPD5obAhEfCVt6rBUi-YSg")]
    [Description(@"Accrued interest is not applicable for this type of security.")]
    UnexpectedAccruedInterest = IssuerAgentRejectionCode.UnexpectedAccruedInterest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party is not defined as an agent.
    /// Encoded/decoded by serializers as &quot;AGID&quot;.
    /// </summary>
    [EnumMember(Value = "AGID")]
    [IsoId("_XsRVobAhEfCVt6rBUi-YSg")]
    [Description(@"Party is not defined as an agent.")]
    NotDefinedAgent = IssuerAgentRejectionCode.NotDefinedAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Back end odd lot quantity is missing.
    /// Encoded/decoded by serializers as &quot;BACK&quot;.
    /// </summary>
    [EnumMember(Value = "BACK")]
    [IsoId("_UK6HsbAhEfCVt6rBUi-YSg")]
    [Description(@"Back end odd lot quantity is missing.")]
    MissingBackEndOddLotQuantity = IssuerAgentRejectionCode.MissingBackEndOddLotQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date is not a business day for the security market.
    /// Encoded/decoded by serializers as &quot;BDAY&quot;.
    /// </summary>
    [EnumMember(Value = "BDAY")]
    [IsoId("_Xi1FwbAhEfCVt6rBUi-YSg")]
    [Description(@"Date is not a business day for the security market.")]
    NotBusinessDay = IssuerAgentRejectionCode.NotBusinessDay, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bid interval is missing.
    /// Encoded/decoded by serializers as &quot;BIDI&quot;.
    /// </summary>
    [EnumMember(Value = "BIDI")]
    [IsoId("_UOTZ8bAhEfCVt6rBUi-YSg")]
    [Description(@"Bid interval is missing.")]
    MissingBidInterval = IssuerAgentRejectionCode.MissingBidInterval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate Amount must be greater than zero.
    /// Encoded/decoded by serializers as &quot;CER0&quot;.
    /// </summary>
    [EnumMember(Value = "CER0")]
    [IsoId("_SR1GMbAhEfCVt6rBUi-YSg")]
    [Description(@"Certificate Amount must be greater than zero.")]
    CertificateAmountGreaterZero = IssuerAgentRejectionCode.CertificateAmountGreaterZero, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Amount Total Certificate Amount must be greater than zero and equal to Security Called Amount.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_UER7QbAhEfCVt6rBUi-YSg")]
    [Description(@"Invalid Amount Total Certificate Amount must be greater than zero and equal to Security Called Amount.")]
    InvalidTotalCertificateAmount = IssuerAgentRejectionCode.InvalidTotalCertificateAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash in lieu price is missing.
    /// Encoded/decoded by serializers as &quot;CINL&quot;.
    /// </summary>
    [EnumMember(Value = "CINL")]
    [IsoId("_URQAQbAhEfCVt6rBUi-YSg")]
    [Description(@"Cash in lieu price is missing.")]
    MissingCashInLieuPrice = IssuerAgentRejectionCode.MissingCashInLieuPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Conditional tenders accepted flag is missing.
    /// Encoded/decoded by serializers as &quot;COND&quot;.
    /// </summary>
    [EnumMember(Value = "COND")]
    [IsoId("_UlTksbAhEfCVt6rBUi-YSg")]
    [Description(@"Conditional tenders accepted flag is missing.")]
    MissingConditionalTendersAcceptedFlag = IssuerAgentRejectionCode.MissingConditionalTendersAcceptedFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash rate is missing.
    /// Encoded/decoded by serializers as &quot;CSRT&quot;.
    /// </summary>
    [EnumMember(Value = "CSRT")]
    [IsoId("_UgLNEbAhEfCVt6rBUi-YSg")]
    [Description(@"Cash rate is missing.")]
    MissingCashRate = IssuerAgentRejectionCode.MissingCashRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Defeased Security Identifier.
    /// Encoded/decoded by serializers as &quot;DEFE&quot;.
    /// </summary>
    [EnumMember(Value = "DEFE")]
    [IsoId("_S97XMbAhEfCVt6rBUi-YSg")]
    [Description(@"Invalid Defeased Security Identifier.")]
    InvalidDefeasedSecurityIdentifier = IssuerAgentRejectionCode.InvalidDefeasedSecurityIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Depository Called Amount must be greater than zero and must be equal to Security Called Amount.
    /// Encoded/decoded by serializers as &quot;DEPO&quot;.
    /// </summary>
    [EnumMember(Value = "DEPO")]
    [IsoId("_SaMYAbAhEfCVt6rBUi-YSg")]
    [Description(@"Depository Called Amount must be greater than zero and must be equal to Security Called Amount.")]
    DepositoryCalledAmountEqualSecurityCalledAmount = IssuerAgentRejectionCode.DepositoryCalledAmountEqualSecurityCalledAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// One option must be marked as the default.
    /// Encoded/decoded by serializers as &quot;DFLT&quot;.
    /// </summary>
    [EnumMember(Value = "DFLT")]
    [IsoId("_UpC1MbAhEfCVt6rBUi-YSg")]
    [Description(@"One option must be marked as the default.")]
    MissingDefaultOption = IssuerAgentRejectionCode.MissingDefaultOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disperse security is not eligible in the (ICSD) service provider owner.
    /// Encoded/decoded by serializers as &quot;DISP&quot;.
    /// </summary>
    [EnumMember(Value = "DISP")]
    [IsoId("_XwOokbAhEfCVt6rBUi-YSg")]
    [Description(@"Disperse security is not eligible in the (ICSD) service provider owner.")]
    NotEligibleDisperseSecurity = IssuerAgentRejectionCode.NotEligibleDisperseSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Duplicate event exists.
    /// Encoded/decoded by serializers as &quot;DUPL&quot;.
    /// </summary>
    [EnumMember(Value = "DUPL")]
    [IsoId("_ShjkQbAhEfCVt6rBUi-YSg")]
    [Description(@"Duplicate event exists.")]
    DuplicateEvent = IssuerAgentRejectionCode.DuplicateEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security is not eligible.
    /// Encoded/decoded by serializers as &quot;ELIG&quot;.
    /// </summary>
    [EnumMember(Value = "ELIG")]
    [IsoId("_Xe0IcbAhEfCVt6rBUi-YSg")]
    [Description(@"Security is not eligible.")]
    NonEligibleSecurity = IssuerAgentRejectionCode.NonEligibleSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period ending date or code is missing.
    /// Encoded/decoded by serializers as &quot;ENDP&quot;.
    /// </summary>
    [EnumMember(Value = "ENDP")]
    [IsoId("_WN0aobAhEfCVt6rBUi-YSg")]
    [Description(@"Period ending date or code is missing.")]
    MissingPeriodEndDate = IssuerAgentRejectionCode.MissingPeriodEndDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Event Type.
    /// Encoded/decoded by serializers as &quot;EVNT&quot;.
    /// </summary>
    [EnumMember(Value = "EVNT")]
    [IsoId("_TNGbobAhEfCVt6rBUi-YSg")]
    [Description(@"Invalid Event Type.")]
    InvalidEventType = IssuerAgentRejectionCode.InvalidEventType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validation of the advice/instruction/request failed.
    /// Encoded/decoded by serializers as &quot;FAIL&quot;.
    /// </summary>
    [EnumMember(Value = "FAIL")]
    [IsoId("_Ss1nMbAhEfCVt6rBUi-YSg")]
    [Description(@"Validation of the advice/instruction/request failed.")]
    FailedValidation = IssuerAgentRejectionCode.FailedValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Depository Called Amount must be greater than zero.
    /// Encoded/decoded by serializers as &quot;FAS0&quot;.
    /// </summary>
    [EnumMember(Value = "FAS0")]
    [IsoId("_SeBIEbAhEfCVt6rBUi-YSg")]
    [Description(@"Depository Called Amount must be greater than zero.")]
    DepositoryCalledAmountGreaterZero = IssuerAgentRejectionCode.DepositoryCalledAmountGreaterZero, // same ordinal as derivation source for type conversions

    /// <summary>
    /// First bid increment is missing.
    /// Encoded/decoded by serializers as &quot;FIRS&quot;.
    /// </summary>
    [EnumMember(Value = "FIRS")]
    [IsoId("_U_3ZwbAhEfCVt6rBUi-YSg")]
    [Description(@"First bid increment is missing.")]
    MissingFirstBidIncrement = IssuerAgentRejectionCode.MissingFirstBidIncrement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fractional Underlying Security cannot be announced.
    /// Encoded/decoded by serializers as &quot;FRAC&quot;.
    /// </summary>
    [EnumMember(Value = "FRAC")]
    [IsoId("_VGC6QbAhEfCVt6rBUi-YSg")]
    [Description(@"Fractional Underlying Security cannot be announced.")]
    MissingFractionalDisposition = IssuerAgentRejectionCode.MissingFractionalDisposition, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gross amount is less than net amount.
    /// Encoded/decoded by serializers as &quot;GAMN&quot;.
    /// </summary>
    [EnumMember(Value = "GAMN")]
    [IsoId("_S2TsQbAhEfCVt6rBUi-YSg")]
    [Description(@"Gross amount is less than net amount.")]
    GrossAmountLessThanNetAmount = IssuerAgentRejectionCode.GrossAmountLessThanNetAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disbursed security identification is missing.
    /// Encoded/decoded by serializers as &quot;IDIS&quot;.
    /// </summary>
    [EnumMember(Value = "IDIS")]
    [IsoId("_TC0eQbAhEfCVt6rBUi-YSg")]
    [Description(@"Disbursed security identification is missing.")]
    InvalidDisbursedSecurityIdentification = IssuerAgentRejectionCode.InvalidDisbursedSecurityIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer agent contact information is invalid or missing.
    /// Encoded/decoded by serializers as &quot;ISSC&quot;.
    /// </summary>
    [EnumMember(Value = "ISSC")]
    [IsoId("_ToglQbAhEfCVt6rBUi-YSg")]
    [Description(@"Issuer agent contact information is invalid or missing.")]
    InvalidOrMissingIssuerAgentContactInformation = IssuerAgentRejectionCode.InvalidOrMissingIssuerAgentContactInformation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer agent is missing.
    /// Encoded/decoded by serializers as &quot;ISSR&quot;.
    /// </summary>
    [EnumMember(Value = "ISSR")]
    [IsoId("_VNAd4bAhEfCVt6rBUi-YSg")]
    [Description(@"Issuer agent is missing.")]
    MissingIssuerAgent = IssuerAgentRejectionCode.MissingIssuerAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Last bid increment is missing.
    /// Encoded/decoded by serializers as &quot;LAST&quot;.
    /// </summary>
    [EnumMember(Value = "LAST")]
    [IsoId("_VQ9w0bAhEfCVt6rBUi-YSg")]
    [Description(@"Last bid increment is missing.")]
    MissingLastBidIncrement = IssuerAgentRejectionCode.MissingLastBidIncrement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying Security has a global lock.
    /// Encoded/decoded by serializers as &quot;LOCK&quot;.
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("_Swf_MbAhEfCVt6rBUi-YSg")]
    [Description(@"Underlying Security has a global lock.")]
    GlobalLock = IssuerAgentRejectionCode.GlobalLock, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Maximum price is missing.
    /// Encoded/decoded by serializers as &quot;MAXP&quot;.
    /// </summary>
    [EnumMember(Value = "MAXP")]
    [IsoId("_Ve5fIbAhEfCVt6rBUi-YSg")]
    [Description(@"Maximum price is missing.")]
    MissingMaximumPrice = IssuerAgentRejectionCode.MissingMaximumPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certification has not been filled in.
    /// Encoded/decoded by serializers as &quot;MCER&quot;.
    /// </summary>
    [EnumMember(Value = "MCER")]
    [IsoId("_UbMmcbAhEfCVt6rBUi-YSg")]
    [Description(@"Certification has not been filled in.")]
    MissingCertification = IssuerAgentRejectionCode.MissingCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Disbursed security identification is missing.
    /// Encoded/decoded by serializers as &quot;MDIS&quot;.
    /// </summary>
    [EnumMember(Value = "MDIS")]
    [IsoId("_U20ygbAhEfCVt6rBUi-YSg")]
    [Description(@"Disbursed security identification is missing.")]
    MissingDisbursedSecurityIdentification = IssuerAgentRejectionCode.MissingDisbursedSecurityIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Full conditional flag is missing.
    /// Encoded/decoded by serializers as &quot;MFCF&quot;.
    /// </summary>
    [EnumMember(Value = "MFCF")]
    [IsoId("_VJblcbAhEfCVt6rBUi-YSg")]
    [Description(@"Full conditional flag is missing.")]
    MissingFullConditionalFlag = IssuerAgentRejectionCode.MissingFullConditionalFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Minimum price is missing.
    /// Encoded/decoded by serializers as &quot;MINP&quot;.
    /// </summary>
    [EnumMember(Value = "MINP")]
    [IsoId("_VozpEbAhEfCVt6rBUi-YSg")]
    [Description(@"Minimum price is missing.")]
    MissingMinimumPrice = IssuerAgentRejectionCode.MissingMinimumPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proration rounding indicator is missing.
    /// Encoded/decoded by serializers as &quot;MPRI&quot;.
    /// </summary>
    [EnumMember(Value = "MPRI")]
    [IsoId("_WeZNQbAhEfCVt6rBUi-YSg")]
    [Description(@"Proration rounding indicator is missing.")]
    MissingProrationRoundingIndicator = IssuerAgentRejectionCode.MissingProrationRoundingIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Convertible Security Not Supported.
    /// Encoded/decoded by serializers as &quot;NCON&quot;.
    /// </summary>
    [EnumMember(Value = "NCON")]
    [IsoId("_SVrrcbAhEfCVt6rBUi-YSg")]
    [Description(@"Convertible Security Not Supported.")]
    ConvertibleSecurityNotSupported = IssuerAgentRejectionCode.ConvertibleSecurityNotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Non-Defeased Security Identifier.
    /// Encoded/decoded by serializers as &quot;NDEF&quot;.
    /// </summary>
    [EnumMember(Value = "NDEF")]
    [IsoId("_TTCEgbAhEfCVt6rBUi-YSg")]
    [Description(@"Invalid Non-Defeased Security Identifier.")]
    InvalidNonDefeasedSecurityIdentifier = IssuerAgentRejectionCode.InvalidNonDefeasedSecurityIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancelled event cannot be modified.
    /// Encoded/decoded by serializers as &quot;NMOD&quot;.
    /// </summary>
    [EnumMember(Value = "NMOD")]
    [IsoId("_SIKM0bAhEfCVt6rBUi-YSg")]
    [Description(@"Cancelled event cannot be modified.")]
    CancelledEvent = IssuerAgentRejectionCode.CancelledEvent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Agent has no access to the service.
    /// Encoded/decoded by serializers as &quot;NOAC&quot;.
    /// </summary>
    [EnumMember(Value = "NOAC")]
    [IsoId("_XWghAbAhEfCVt6rBUi-YSg")]
    [Description(@"Agent has no access to the service.")]
    NoAccessToService = IssuerAgentRejectionCode.NoAccessToService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party is not active.
    /// Encoded/decoded by serializers as &quot;NPAT&quot;.
    /// </summary>
    [EnumMember(Value = "NPAT")]
    [IsoId("_XaFZcbAhEfCVt6rBUi-YSg")]
    [Description(@"Party is not active.")]
    NonActiveParty = IssuerAgentRejectionCode.NonActiveParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Non-Refunded Security Identifier
    /// Encoded/decoded by serializers as &quot;NREF&quot;.
    /// </summary>
    [EnumMember(Value = "NREF")]
    [IsoId("_TXXx8bAhEfCVt6rBUi-YSg")]
    [Description(@"Invalid Non-Refunded Security Identifier")]
    InvalidNonRefundedSecurityIdentifier = IssuerAgentRejectionCode.InvalidNonRefundedSecurityIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Odd lot priority flag is missing.
    /// Encoded/decoded by serializers as &quot;ODLT&quot;.
    /// </summary>
    [EnumMember(Value = "ODLT")]
    [IsoId("_Vtzd0bAhEfCVt6rBUi-YSg")]
    [Description(@"Odd lot priority flag is missing.")]
    MissingOddLotPriorityFlag = IssuerAgentRejectionCode.MissingOddLotPriorityFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ongoing Conversion Event Exists
    /// Encoded/decoded by serializers as &quot;ONCV&quot;.
    /// </summary>
    [EnumMember(Value = "ONCV")]
    [IsoId("_Xzk3gbAhEfCVt6rBUi-YSg")]
    [Description(@"Ongoing Conversion Event Exists")]
    OngoingConversionEventExists = IssuerAgentRejectionCode.OngoingConversionEventExists, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Oversubscription charge flag is missing.
    /// Encoded/decoded by serializers as &quot;OVCH&quot;.
    /// </summary>
    [EnumMember(Value = "OVCH")]
    [IsoId("_V18GIbAhEfCVt6rBUi-YSg")]
    [Description(@"Oversubscription charge flag is missing.")]
    MissingOversubscriptionChargeFlag = IssuerAgentRejectionCode.MissingOversubscriptionChargeFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Oversubscription flag is missing.
    /// Encoded/decoded by serializers as &quot;OVFL&quot;.
    /// </summary>
    [EnumMember(Value = "OVFL")]
    [IsoId("_V6yw8bAhEfCVt6rBUi-YSg")]
    [Description(@"Oversubscription flag is missing.")]
    MissingOversubscriptionFlag = IssuerAgentRejectionCode.MissingOversubscriptionFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Oversubscription price is missing.
    /// Encoded/decoded by serializers as &quot;OVPR&quot;.
    /// </summary>
    [EnumMember(Value = "OVPR")]
    [IsoId("_V-_7gbAhEfCVt6rBUi-YSg")]
    [Description(@"Oversubscription price is missing.")]
    MissingOversubscriptionPrice = IssuerAgentRejectionCode.MissingOversubscriptionPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price basis is missing.
    /// Encoded/decoded by serializers as &quot;PBAS&quot;.
    /// </summary>
    [EnumMember(Value = "PBAS")]
    [IsoId("_WW6sQbAhEfCVt6rBUi-YSg")]
    [Description(@"Price basis is missing.")]
    MissingPriceBasis = IssuerAgentRejectionCode.MissingPriceBasis, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Effective date is after the payment date.
    /// Encoded/decoded by serializers as &quot;PDAY&quot;.
    /// </summary>
    [EnumMember(Value = "PDAY")]
    [IsoId("_Sk0TobAhEfCVt6rBUi-YSg")]
    [Description(@"Effective date is after the payment date.")]
    EffectiveDayAfterPaymentDate = IssuerAgentRejectionCode.EffectiveDayAfterPaymentDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period ending date is before period starting date.
    /// Encoded/decoded by serializers as &quot;PERI&quot;.
    /// </summary>
    [EnumMember(Value = "PERI")]
    [IsoId("_X4M40bAhEfCVt6rBUi-YSg")]
    [Description(@"Period ending date is before period starting date.")]
    PeriodEndDateBeforeStartDate = IssuerAgentRejectionCode.PeriodEndDateBeforeStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Zero Coupon Bond, Principal / Cash rate must be less than USD 1,000.00.
    /// Encoded/decoded by serializers as &quot;PR1K&quot;.
    /// </summary>
    [EnumMember(Value = "PR1K")]
    [IsoId("_SMc28bAhEfCVt6rBUi-YSg")]
    [Description(@"Zero Coupon Bond, Principal / Cash rate must be less than USD 1,000.00.")]
    CashRateLessThanThousand = IssuerAgentRejectionCode.CashRateLessThanThousand, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Protect charge indicator is missing.
    /// Encoded/decoded by serializers as &quot;PRCH&quot;.
    /// </summary>
    [EnumMember(Value = "PRCH")]
    [IsoId("_WigRMbAhEfCVt6rBUi-YSg")]
    [Description(@"Protect charge indicator is missing.")]
    MissingProtectChargeIndicator = IssuerAgentRejectionCode.MissingProtectChargeIndicator, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Principal Cash Rate.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_TuHeAbAhEfCVt6rBUi-YSg")]
    [Description(@"Invalid Principal Cash Rate.")]
    InvalidPrincipalCashRate = IssuerAgentRejectionCode.InvalidPrincipalCashRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Proration rate is missing.
    /// Encoded/decoded by serializers as &quot;PROR&quot;.
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_WaEt8bAhEfCVt6rBUi-YSg")]
    [Description(@"Proration rate is missing.")]
    MissingProrationRate = IssuerAgentRejectionCode.MissingProrationRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payout type is missing.
    /// Encoded/decoded by serializers as &quot;PTYP&quot;.
    /// </summary>
    [EnumMember(Value = "PTYP")]
    [IsoId("_WDFKQbAhEfCVt6rBUi-YSg")]
    [Description(@"Payout type is missing.")]
    MissingPayoutType = IssuerAgentRejectionCode.MissingPayoutType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Publication date must be earlier than payable date.
    /// Encoded/decoded by serializers as &quot;PUBD&quot;.
    /// </summary>
    [EnumMember(Value = "PUBD")]
    [IsoId("_YC_zkbAhEfCVt6rBUi-YSg")]
    [Description(@"Publication date must be earlier than payable date.")]
    PublicationDate = IssuerAgentRejectionCode.PublicationDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Record date is after payment date.
    /// Encoded/decoded by serializers as &quot;RDTE&quot;.
    /// </summary>
    [EnumMember(Value = "RDTE")]
    [IsoId("_YIFH4bAhEfCVt6rBUi-YSg")]
    [Description(@"Record date is after payment date.")]
    RecordDateAfterPaymentDate = IssuerAgentRejectionCode.RecordDateAfterPaymentDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Redemption Date.
    /// Encoded/decoded by serializers as &quot;REDT&quot;.
    /// </summary>
    [EnumMember(Value = "REDT")]
    [IsoId("_TxVKEbAhEfCVt6rBUi-YSg")]
    [Description(@"Invalid Redemption Date.")]
    InvalidRedemptionDate = IssuerAgentRejectionCode.InvalidRedemptionDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Notification Identification.
    /// Encoded/decoded by serializers as &quot;REFR&quot;.
    /// </summary>
    [EnumMember(Value = "REFR")]
    [IsoId("_Tc4kEbAhEfCVt6rBUi-YSg")]
    [Description(@"Invalid Notification Identification.")]
    InvalidNotificationIdentification = IssuerAgentRejectionCode.InvalidNotificationIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Refunded Security Identifier.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_T0snIbAhEfCVt6rBUi-YSg")]
    [Description(@"Invalid Refunded Security Identifier.")]
    InvalidRefundedSecurityIdentifier = IssuerAgentRejectionCode.InvalidRefundedSecurityIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resulting amount must be filled in as exchange rate is present.
    /// Encoded/decoded by serializers as &quot;RESU&quot;.
    /// </summary>
    [EnumMember(Value = "RESU")]
    [IsoId("_WuAWkbAhEfCVt6rBUi-YSg")]
    [Description(@"Resulting amount must be filled in as exchange rate is present.")]
    MissingResultingAmount = IssuerAgentRejectionCode.MissingResultingAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rights transferrable flag is missing.
    /// Encoded/decoded by serializers as &quot;RITR&quot;.
    /// </summary>
    [EnumMember(Value = "RITR")]
    [IsoId("_WxdTMbAhEfCVt6rBUi-YSg")]
    [Description(@"Rights transferrable flag is missing.")]
    MissingRightsTransferrableFlag = IssuerAgentRejectionCode.MissingRightsTransferrableFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Rounding factor is missing.
    /// Encoded/decoded by serializers as &quot;ROUN&quot;.
    /// </summary>
    [EnumMember(Value = "ROUN")]
    [IsoId("_W0sNYbAhEfCVt6rBUi-YSg")]
    [Description(@"Rounding factor is missing.")]
    MissingRoudingFactor = IssuerAgentRejectionCode.MissingRoudingFactor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Second option is mandatory.
    /// Encoded/decoded by serializers as &quot;SECO&quot;.
    /// </summary>
    [EnumMember(Value = "SECO")]
    [IsoId("_VxLh8bAhEfCVt6rBUi-YSg")]
    [Description(@"Second option is mandatory.")]
    MissingOption = IssuerAgentRejectionCode.MissingOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security type does not match with the type of corporate action.
    /// Encoded/decoded by serializers as &quot;SECT&quot;.
    /// </summary>
    [EnumMember(Value = "SECT")]
    [IsoId("_YVvwcbAhEfCVt6rBUi-YSg")]
    [Description(@"Security type does not match with the type of corporate action.")]
    WrongSecurityType = IssuerAgentRejectionCode.WrongSecurityType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Equity Security Type.
    /// Encoded/decoded by serializers as &quot;SEEQ&quot;.
    /// </summary>
    [EnumMember(Value = "SEEQ")]
    [IsoId("_TJYZQbAhEfCVt6rBUi-YSg")]
    [Description(@"Invalid Equity Security Type.")]
    InvalidEquitySecurityType = IssuerAgentRejectionCode.InvalidEquitySecurityType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Securities rate is missing.
    /// Encoded/decoded by serializers as &quot;SERT&quot;.
    /// </summary>
    [EnumMember(Value = "SERT")]
    [IsoId("_W3ozsbAhEfCVt6rBUi-YSg")]
    [Description(@"Securities rate is missing.")]
    MissingSecuritiesRate = IssuerAgentRejectionCode.MissingSecuritiesRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Solicitation dealer fee flag is missing.
    /// Encoded/decoded by serializers as &quot;SFEE&quot;.
    /// </summary>
    [EnumMember(Value = "SFEE")]
    [IsoId("_W-Y78bAhEfCVt6rBUi-YSg")]
    [Description(@"Solicitation dealer fee flag is missing.")]
    MissingSolicitationDealerFeeFlag = IssuerAgentRejectionCode.MissingSolicitationDealerFeeFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Period starting date or code is missing.
    /// Encoded/decoded by serializers as &quot;STAR&quot;.
    /// </summary>
    [EnumMember(Value = "STAR")]
    [IsoId("_WRdkgbAhEfCVt6rBUi-YSg")]
    [Description(@"Period starting date or code is missing.")]
    MissingPeriodStartDate = IssuerAgentRejectionCode.MissingPeriodStartDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subscription charge flag is missing.
    /// Encoded/decoded by serializers as &quot;SUCH&quot;.
    /// </summary>
    [EnumMember(Value = "SUCH")]
    [IsoId("_XC2lMbAhEfCVt6rBUi-YSg")]
    [Description(@"Subscription charge flag is missing.")]
    MissingSubscriptionChargeFlag = IssuerAgentRejectionCode.MissingSubscriptionChargeFlag, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subscription price is missing.
    /// Encoded/decoded by serializers as &quot;SUPR&quot;.
    /// </summary>
    [EnumMember(Value = "SUPR")]
    [IsoId("_XOt28bAhEfCVt6rBUi-YSg")]
    [Description(@"Subscription price is missing.")]
    MissingSubscriptionPrice = IssuerAgentRejectionCode.MissingSubscriptionPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Inactive Underlying Security.
    /// Encoded/decoded by serializers as &quot;UNDI&quot;.
    /// </summary>
    [EnumMember(Value = "UNDI")]
    [IsoId("_S6BHkbAhEfCVt6rBUi-YSg")]
    [Description(@"Inactive Underlying Security.")]
    InactiveUnderlyingSecurity = IssuerAgentRejectionCode.InactiveUnderlyingSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying Security is not eligible at Depository.
    /// Encoded/decoded by serializers as &quot;UNDM&quot;.
    /// </summary>
    [EnumMember(Value = "UNDM")]
    [IsoId("_YLCVQbAhEfCVt6rBUi-YSg")]
    [Description(@"Underlying Security is not eligible at Depository.")]
    UnderlyingSecurityNotEligible = IssuerAgentRejectionCode.UnderlyingSecurityNotEligible, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid Underlying Security.
    /// Encoded/decoded by serializers as &quot;UNDV&quot;.
    /// </summary>
    [EnumMember(Value = "UNDV")]
    [IsoId("_UHY5obAhEfCVt6rBUi-YSg")]
    [Description(@"Invalid Underlying Security.")]
    InvalidUnderlyingSecurity = IssuerAgentRejectionCode.InvalidUnderlyingSecurity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unspecified price allowed is missing.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_XS_S8bAhEfCVt6rBUi-YSg")]
    [Description(@"Unspecified price allowed is missing.")]
    MissingUnspecifiedPriceAllowed = IssuerAgentRejectionCode.MissingUnspecifiedPriceAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Value date is before payment date.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_YSF_gbAhEfCVt6rBUi-YSg")]
    [Description(@"Value date is before payment date.")]
    ValueDateBeforePaymentDate = IssuerAgentRejectionCode.ValueDateBeforePaymentDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Resulting amount is not allowed without an exchange rate.
    /// Encoded/decoded by serializers as &quot;XRAT&quot;.
    /// </summary>
    [EnumMember(Value = "XRAT")]
    [IsoId("_U7SbwbAhEfCVt6rBUi-YSg")]
    [Description(@"Resulting amount is not allowed without an exchange rate.")]
    MissingExchangeRate = IssuerAgentRejectionCode.MissingExchangeRate, // same ordinal as derivation source for type conversions
}
