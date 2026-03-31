// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Detail of the result.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ohy7IHuLEeSZrqGdHyoIrw")]
[Description(@"Detail of the result.")]
[DerivedFrom(typeof(ResultDetailCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ResultDetail1Code>))]
#endif
public enum ResultDetail1Code
{
    /// <summary>
    /// Account of the cardholder or the customer is not found.
    /// Encoded/decoded by serializers as &quot;ACTF&quot;.
    /// </summary>
    [EnumMember(Value = "ACTF")]
    [IsoId("_xHmTUXuLEeSZrqGdHyoIrw")]
    [Description(@"Account of the cardholder or the customer is not found.")]
    AccountNotFound = ResultDetailCode.AccountNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acquirer is not supported.
    /// Encoded/decoded by serializers as &quot;ACQS&quot;.
    /// </summary>
    [EnumMember(Value = "ACQS")]
    [IsoId("_xNHFcXuLEeSZrqGdHyoIrw")]
    [Description(@"Acquirer is not supported.")]
    AcquirerNotSupported = ResultDetailCode.AcquirerNotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Error on AML (Anti Money Laundering) validation.
    /// Encoded/decoded by serializers as &quot;AMLV&quot;.
    /// </summary>
    [EnumMember(Value = "AMLV")]
    [IsoId("_xSeGkXuLEeSZrqGdHyoIrw")]
    [Description(@"Error on AML (Anti Money Laundering) validation.")]
    AMLValidation = ResultDetailCode.AMLValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount not found.
    /// Encoded/decoded by serializers as &quot;AMTA&quot;.
    /// </summary>
    [EnumMember(Value = "AMTA")]
    [IsoId("_xX1uwXuLEeSZrqGdHyoIrw")]
    [Description(@"Amount not found.")]
    AmountNotFound = ResultDetailCode.AmountNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank not found.
    /// Encoded/decoded by serializers as &quot;BANK&quot;.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_xdWg4XuLEeSZrqGdHyoIrw")]
    [Description(@"Bank not found.")]
    BankNotFound = ResultDetailCode.BankNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).
    /// Encoded/decoded by serializers as &quot;CRDR&quot;.
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_xitiAXuLEeSZrqGdHyoIrw")]
    [Description(@"Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).")]
    CardError = ResultDetailCode.CardError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the card is invalid.
    /// Encoded/decoded by serializers as &quot;CRDF&quot;.
    /// </summary>
    [EnumMember(Value = "CRDF")]
    [IsoId("_xpHsAXuLEeSZrqGdHyoIrw")]
    [Description(@"Identification of the card is invalid.")]
    CardVerificationFailed = ResultDetailCode.CardVerificationFailed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cashback is not permitted.
    /// Encoded/decoded by serializers as &quot;CSHI&quot;.
    /// </summary>
    [EnumMember(Value = "CSHI")]
    [IsoId("_xufUMXuLEeSZrqGdHyoIrw")]
    [Description(@"Cashback is not permitted.")]
    CasbackNotAllowed = ResultDetailCode.CasbackNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cashback amount is higher than permitted.
    /// Encoded/decoded by serializers as &quot;CSHE&quot;.
    /// </summary>
    [EnumMember(Value = "CSHE")]
    [IsoId("_x1VjEXuLEeSZrqGdHyoIrw")]
    [Description(@"Cashback amount is higher than permitted.")]
    CashbackAmountExceeded = ResultDetailCode.CashbackAmountExceeded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is no more usable for the transaction.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_x6tLQXuLEeSZrqGdHyoIrw")]
    [Description(@"Account is no more usable for the transaction.")]
    ClosedAccount = ResultDetailCode.ClosedAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cutover is in progress, transaction could not be processed.
    /// Encoded/decoded by serializers as &quot;CTVG&quot;.
    /// </summary>
    [EnumMember(Value = "CTVG")]
    [IsoId("_yAN9YXuLEeSZrqGdHyoIrw")]
    [Description(@"Cutover is in progress, transaction could not be processed.")]
    CutoverInProcess = ResultDetailCode.CutoverInProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Database access error.
    /// Encoded/decoded by serializers as &quot;DBER&quot;.
    /// </summary>
    [EnumMember(Value = "DBER")]
    [IsoId("_yFuvgXuLEeSZrqGdHyoIrw")]
    [Description(@"Database access error.")]
    DatabaseError = ResultDetailCode.DatabaseError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction fees are disputed by the issuer.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_yLGXsXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction fees are disputed by the issuer.")]
    DisputedFees = ResultDetailCode.DisputedFees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validity period of the transaction is exceeded.
    /// Encoded/decoded by serializers as &quot;TXNL&quot;.
    /// </summary>
    [EnumMember(Value = "TXNL")]
    [IsoId("_yQnJ0XuLEeSZrqGdHyoIrw")]
    [Description(@"Validity period of the transaction is exceeded.")]
    ExceededTransactionLifeCycle = ResultDetailCode.ExceededTransactionLifeCycle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card has expired.
    /// Encoded/decoded by serializers as &quot;CRDX&quot;.
    /// </summary>
    [EnumMember(Value = "CRDX")]
    [IsoId("_yZG-gXuLEeSZrqGdHyoIrw")]
    [Description(@"Card has expired.")]
    ExpiredCard = ResultDetailCode.ExpiredCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid format of the message or its content.
    /// Encoded/decoded by serializers as &quot;FMTR&quot;.
    /// </summary>
    [EnumMember(Value = "FMTR")]
    [IsoId("_yg2lQXuLEeSZrqGdHyoIrw")]
    [Description(@"Invalid format of the message or its content.")]
    FormatError = ResultDetailCode.FormatError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// From account status error.
    /// Encoded/decoded by serializers as &quot;ACEF&quot;.
    /// </summary>
    [EnumMember(Value = "ACEF")]
    [IsoId("_ynagQXuLEeSZrqGdHyoIrw")]
    [Description(@"From account status error.")]
    FromAccountError = ResultDetailCode.FromAccountError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original request is in progress.
    /// Encoded/decoded by serializers as &quot;TXNG&quot;.
    /// </summary>
    [EnumMember(Value = "TXNG")]
    [IsoId("_yuHlMXuLEeSZrqGdHyoIrw")]
    [Description(@"Original request is in progress.")]
    InProgress = ResultDetailCode.InProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account balance is not sufficient.
    /// Encoded/decoded by serializers as &quot;FNDI&quot;.
    /// </summary>
    [EnumMember(Value = "FNDI")]
    [IsoId("_yzoXUXuLEeSZrqGdHyoIrw")]
    [Description(@"Account balance is not sufficient.")]
    InsufficientFunds = ResultDetailCode.InsufficientFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer denies the acceptor.
    /// Encoded/decoded by serializers as &quot;ACPI&quot;.
    /// </summary>
    [EnumMember(Value = "ACPI")]
    [IsoId("_y6ChUXuLEeSZrqGdHyoIrw")]
    [Description(@"Issuer denies the acceptor.")]
    InvalidAcceptor = ResultDetailCode.InvalidAcceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested amount is outside the card limits, or the currency is invalid.
    /// Encoded/decoded by serializers as &quot;AMTI&quot;.
    /// </summary>
    [EnumMember(Value = "AMTI")]
    [IsoId("_zAJJUXuLEeSZrqGdHyoIrw")]
    [Description(@"Requested amount is outside the card limits, or the currency is invalid.")]
    InvalidAmount = ResultDetailCode.InvalidAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the cardholder or the customer does not match.
    /// Encoded/decoded by serializers as &quot;CHDI&quot;.
    /// </summary>
    [EnumMember(Value = "CHDI")]
    [IsoId("_zGQYYXuLEeSZrqGdHyoIrw")]
    [Description(@"Identification of the cardholder or the customer does not match.")]
    InvalidCardholderIdentification = ResultDetailCode.InvalidCardholderIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the card is invalid.
    /// Encoded/decoded by serializers as &quot;CRDI&quot;.
    /// </summary>
    [EnumMember(Value = "CRDI")]
    [IsoId("_zNQYQXuLEeSZrqGdHyoIrw")]
    [Description(@"Identification of the card is invalid.")]
    InvalidCardNumber = ResultDetailCode.InvalidCardNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Digital certificate cannot be authenticated, is expired or revoked.
    /// Encoded/decoded by serializers as &quot;CTFV&quot;.
    /// </summary>
    [EnumMember(Value = "CTFV")]
    [IsoId("_zZCKcXuLEeSZrqGdHyoIrw")]
    [Description(@"Digital certificate cannot be authenticated, is expired or revoked.")]
    InvalidCertificate = ResultDetailCode.InvalidCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Process not permitted to the acceptor (for example fall back).
    /// Encoded/decoded by serializers as &quot;NPRA&quot;.
    /// </summary>
    [EnumMember(Value = "NPRA")]
    [IsoId("_0LZbgXuLEeSZrqGdHyoIrw")]
    [Description(@"Process not permitted to the acceptor (for example fall back).")]
    NotPermittedToAcceptor = ResultDetailCode.NotPermittedToAcceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN could not be validated.
    /// Encoded/decoded by serializers as &quot;PINA&quot;.
    /// </summary>
    [EnumMember(Value = "PINA")]
    [IsoId("_0UCaIXuLEeSZrqGdHyoIrw")]
    [Description(@"PIN could not be validated.")]
    NotAbleToValidatePIN = ResultDetailCode.NotAbleToValidatePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is processed, but liability is not accepted.
    /// Encoded/decoded by serializers as &quot;LBLU&quot;.
    /// </summary>
    [EnumMember(Value = "LBLU")]
    [IsoId("_0Z_4MXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction is processed, but liability is not accepted.")]
    NoLiabilityAccepted = ResultDetailCode.NoLiabilityAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No card file record.
    /// Encoded/decoded by serializers as &quot;CRDA&quot;.
    /// </summary>
    [EnumMember(Value = "CRDA")]
    [IsoId("_0fXgYXuLEeSZrqGdHyoIrw")]
    [Description(@"No card file record.")]
    NoCardRecord = ResultDetailCode.NoCardRecord, // same ordinal as derivation source for type conversions

    /// <summary>
    /// New PIN is invalid (PIN change).
    /// Encoded/decoded by serializers as &quot;PINN&quot;.
    /// </summary>
    [EnumMember(Value = "PINN")]
    [IsoId("_0lLNcXuLEeSZrqGdHyoIrw")]
    [Description(@"New PIN is invalid (PIN change).")]
    NewPINInvalid = ResultDetailCode.NewPINInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MAC key error.
    /// Encoded/decoded by serializers as &quot;MACK&quot;.
    /// </summary>
    [EnumMember(Value = "MACK")]
    [IsoId("_0qr_kXuLEeSZrqGdHyoIrw")]
    [Description(@"MAC key error.")]
    MACKeyError = ResultDetailCode.MACKeyError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MAC error.
    /// Encoded/decoded by serializers as &quot;MACR&quot;.
    /// </summary>
    [EnumMember(Value = "MACR")]
    [IsoId("_0wDnwXuLEeSZrqGdHyoIrw")]
    [Description(@"MAC error.")]
    MACError = ResultDetailCode.MACError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card has been declared lost.
    /// Encoded/decoded by serializers as &quot;CRDL&quot;.
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_01uK4XuLEeSZrqGdHyoIrw")]
    [Description(@"Card has been declared lost.")]
    LostCard = ResultDetailCode.LostCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is processed and liability is accepted.
    /// Encoded/decoded by serializers as &quot;LBLA&quot;.
    /// </summary>
    [EnumMember(Value = "LBLA")]
    [IsoId("_096dkXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction is processed and liability is accepted.")]
    LiabilityAccepted = ResultDetailCode.LiabilityAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction could not be processed as Issuer is unavailable.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_1EK2kXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as Issuer is unavailable.")]
    IssuerUnavailable = ResultDetailCode.IssuerUnavailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction could not be processed as Issuer times out.
    /// Encoded/decoded by serializers as &quot;ISST&quot;.
    /// </summary>
    [EnumMember(Value = "ISST")]
    [IsoId("_1JiewXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as Issuer times out.")]
    IssuerTimeOut = ResultDetailCode.IssuerTimeOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction could not be processed as Issuer is signed off.
    /// Encoded/decoded by serializers as &quot;ISSO&quot;.
    /// </summary>
    [EnumMember(Value = "ISSO")]
    [IsoId("_1PDQ4XuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as Issuer is signed off.")]
    IssuerSignedOff = ResultDetailCode.IssuerSignedOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer is not found.
    /// Encoded/decoded by serializers as &quot;ISSF&quot;.
    /// </summary>
    [EnumMember(Value = "ISSF")]
    [IsoId("_1UkDAXuLEeSZrqGdHyoIrw")]
    [Description(@"Issuer is not found.")]
    IssuerNotFound = ResultDetailCode.IssuerNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer is inoperative.
    /// Encoded/decoded by serializers as &quot;ISSP&quot;.
    /// </summary>
    [EnumMember(Value = "ISSP")]
    [IsoId("_1btz4XuLEeSZrqGdHyoIrw")]
    [Description(@"Issuer is inoperative.")]
    IssuerInoperative = ResultDetailCode.IssuerInoperative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date time of the transaction is invalid.
    /// Encoded/decoded by serializers as &quot;DATI&quot;.
    /// </summary>
    [EnumMember(Value = "DATI")]
    [IsoId("_1h-M4XuLEeSZrqGdHyoIrw")]
    [Description(@"Date time of the transaction is invalid.")]
    InvalidTransactionDateTime = ResultDetailCode.InvalidTransactionDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is invalid.
    /// Encoded/decoded by serializers as &quot;TXNV&quot;.
    /// </summary>
    [EnumMember(Value = "TXNV")]
    [IsoId("_1nV1EXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction is invalid.")]
    InvalidTransaction = ResultDetailCode.InvalidTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the token provider or the token requestor is invalid.
    /// Encoded/decoded by serializers as &quot;TKID&quot;.
    /// </summary>
    [EnumMember(Value = "TKID")]
    [IsoId("_1s2nMXuLEeSZrqGdHyoIrw")]
    [Description(@"Identification of the token provider or the token requestor is invalid.")]
    InvalidTokenIdentification = ResultDetailCode.InvalidTokenIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Token cannot be used to surrogate a PAN (Primary Account Number).
    /// Encoded/decoded by serializers as &quot;TKKO&quot;.
    /// </summary>
    [EnumMember(Value = "TKKO")]
    [IsoId("_1yhKUXuLEeSZrqGdHyoIrw")]
    [Description(@"Token cannot be used to surrogate a PAN (Primary Account Number).")]
    InvalidToken = ResultDetailCode.InvalidToken, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security code validation fails.
    /// Encoded/decoded by serializers as &quot;CSCV&quot;.
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_134LcXuLEeSZrqGdHyoIrw")]
    [Description(@"Security code validation fails.")]
    InvalidSecurityCode = ResultDetailCode.InvalidSecurityCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN is invalid.
    /// Encoded/decoded by serializers as &quot;PINV&quot;.
    /// </summary>
    [EnumMember(Value = "PINV")]
    [IsoId("_19Y9kXuLEeSZrqGdHyoIrw")]
    [Description(@"PIN is invalid.")]
    InvalidPIN = ResultDetailCode.InvalidPIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original amount is invalid.
    /// Encoded/decoded by serializers as &quot;AMTO&quot;.
    /// </summary>
    [EnumMember(Value = "AMTO")]
    [IsoId("_2C5vsXuLEeSZrqGdHyoIrw")]
    [Description(@"Original amount is invalid.")]
    InvalidOriginalAmount = ResultDetailCode.InvalidOriginalAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction not permitted to the cardholder or the customer.
    /// Encoded/decoded by serializers as &quot;NPRC&quot;.
    /// </summary>
    [EnumMember(Value = "NPRC")]
    [IsoId("_2qsIcXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction not permitted to the cardholder or the customer.")]
    NotPermittedToCardholder = ResultDetailCode.NotPermittedToCardholder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been processed offline by the terminal.
    /// Encoded/decoded by serializers as &quot;OFFL&quot;.
    /// </summary>
    [EnumMember(Value = "OFFL")]
    [IsoId("_2w9IgXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction has been processed offline by the terminal.")]
    OffLineProcess = ResultDetailCode.OffLineProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been processed offline after referral.
    /// Encoded/decoded by serializers as &quot;ONLP&quot;.
    /// </summary>
    [EnumMember(Value = "ONLP")]
    [IsoId("_22w1kXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction has been processed offline after referral.")]
    OffLineProcessAfterReferral = ResultDetailCode.OffLineProcessAfterReferral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original is found, but transaction does not match.
    /// Encoded/decoded by serializers as &quot;TXNM&quot;.
    /// </summary>
    [EnumMember(Value = "TXNM")]
    [IsoId("_28RnsXuLEeSZrqGdHyoIrw")]
    [Description(@"Original is found, but transaction does not match.")]
    OriginalDoesNotMatch = ResultDetailCode.OriginalDoesNotMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other error.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_3BpP4XuLEeSZrqGdHyoIrw")]
    [Description(@"Other error.")]
    OtherError = ResultDetailCode.OtherError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Out of balance.
    /// Encoded/decoded by serializers as &quot;BALO&quot;.
    /// </summary>
    [EnumMember(Value = "BALO")]
    [IsoId("_3HKCAXuLEeSZrqGdHyoIrw")]
    [Description(@"Out of balance.")]
    OutOfBalance = ResultDetailCode.OutOfBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message is out of sequence.
    /// Encoded/decoded by serializers as &quot;SEQO&quot;.
    /// </summary>
    [EnumMember(Value = "SEQO")]
    [IsoId("_3MhDIXuLEeSZrqGdHyoIrw")]
    [Description(@"Message is out of sequence.")]
    OutOfSequence = ResultDetailCode.OutOfSequence, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of payment transactions exceeds card limit.
    /// Encoded/decoded by serializers as &quot;AMTL&quot;.
    /// </summary>
    [EnumMember(Value = "AMTL")]
    [IsoId("_3R4rUXuLEeSZrqGdHyoIrw")]
    [Description(@"Amount of payment transactions exceeds card limit.")]
    PaymentAmountLimit = ResultDetailCode.PaymentAmountLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number of payment transactions exceeds card limit.
    /// Encoded/decoded by serializers as &quot;NMBL&quot;.
    /// </summary>
    [EnumMember(Value = "NMBL")]
    [IsoId("_3XsYYXuLEeSZrqGdHyoIrw")]
    [Description(@"Number of payment transactions exceeds card limit.")]
    PaymentNumberLimit = ResultDetailCode.PaymentNumberLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder must change the PIN to be able to perform the transaction.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_3f5SIXuLEeSZrqGdHyoIrw")]
    [Description(@"Cardholder must change the PIN to be able to perform the transaction.")]
    PINChangeRequired = ResultDetailCode.PINChangeRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional information are required to verify the PIN.
    /// Encoded/decoded by serializers as &quot;PIND&quot;.
    /// </summary>
    [EnumMember(Value = "PIND")]
    [IsoId("_3lQTQXuLEeSZrqGdHyoIrw")]
    [Description(@"Additional information are required to verify the PIN.")]
    PINDataRequired = ResultDetailCode.PINDataRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Decrypted PIN block is invalid.
    /// Encoded/decoded by serializers as &quot;PINE&quot;.
    /// </summary>
    [EnumMember(Value = "PINE")]
    [IsoId("_3qxFYXuLEeSZrqGdHyoIrw")]
    [Description(@"Decrypted PIN block is invalid.")]
    PINEncryptionError = ResultDetailCode.PINEncryptionError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN length or PIN key is invalid.
    /// Encoded/decoded by serializers as &quot;PINS&quot;.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_3wujcXuLEeSZrqGdHyoIrw")]
    [Description(@"PIN length or PIN key is invalid.")]
    PINSecurityError = ResultDetailCode.PINSecurityError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Last attempt of the PIN verification fails.
    /// Encoded/decoded by serializers as &quot;PINX&quot;.
    /// </summary>
    [EnumMember(Value = "PINX")]
    [IsoId("_32sBgXuLEeSZrqGdHyoIrw")]
    [Description(@"Last attempt of the PIN verification fails.")]
    PINTriesExceeded = ResultDetailCode.PINTriesExceeded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Store and forward queue maximum exceeded.
    /// Encoded/decoded by serializers as &quot;QMAX&quot;.
    /// </summary>
    [EnumMember(Value = "QMAX")]
    [IsoId("_38DpsXuLEeSZrqGdHyoIrw")]
    [Description(@"Store and forward queue maximum exceeded.")]
    QueueMaximumExceeded = ResultDetailCode.QueueMaximumExceeded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Recurring Error on Data.
    /// Encoded/decoded by serializers as &quot;RECD&quot;.
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_4Bkb0XuLEeSZrqGdHyoIrw")]
    [Description(@"Recurring Error on Data.")]
    RecurringDataError = ResultDetailCode.RecurringDataError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested service not allowed by the card.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_4Hrq4XuLEeSZrqGdHyoIrw")]
    [Description(@"Requested service not allowed by the card.")]
    RestrictedCard = ResultDetailCode.RestrictedCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram).
    /// Encoded/decoded by serializers as &quot;SECV&quot;.
    /// </summary>
    [EnumMember(Value = "SECV")]
    [IsoId("_4OO-0XuLEeSZrqGdHyoIrw")]
    [Description(
        @"Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram)."
    )]
    SecurityViolation = ResultDetailCode.SecurityViolation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security software or hardware error.
    /// Encoded/decoded by serializers as &quot;SFWE&quot;.
    /// </summary>
    [EnumMember(Value = "SFWE")]
    [IsoId("_4TmnAXuLEeSZrqGdHyoIrw")]
    [Description(@"Security software or hardware error.")]
    SoftwareOrHardwareError = ResultDetailCode.SoftwareOrHardwareError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Special card conditions not respected.
    /// Encoded/decoded by serializers as &quot;SPCC&quot;.
    /// </summary>
    [EnumMember(Value = "SPCC")]
    [IsoId("_4aAJ8XuLEeSZrqGdHyoIrw")]
    [Description(@"Special card conditions not respected.")]
    SpecialConditions = ResultDetailCode.SpecialConditions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card used for the original transaction.
    /// Encoded/decoded by serializers as &quot;CRDW&quot;.
    /// </summary>
    [EnumMember(Value = "CRDW")]
    [IsoId("_5LeqMXuLEeSZrqGdHyoIrw")]
    [Description(@"Other card used for the original transaction.")]
    WrongCard = ResultDetailCode.WrongCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number of withdrawal transactions exceeds card limit.
    /// Encoded/decoded by serializers as &quot;NMBW&quot;.
    /// </summary>
    [EnumMember(Value = "NMBW")]
    [IsoId("_5SVgIXuLEeSZrqGdHyoIrw")]
    [Description(@"Number of withdrawal transactions exceeds card limit.")]
    WithdrawalNumberLimit = ResultDetailCode.WithdrawalNumberLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of withdrawal transactions exceeds card limit.
    /// Encoded/decoded by serializers as &quot;AMTW&quot;.
    /// </summary>
    [EnumMember(Value = "AMTW")]
    [IsoId("_5XshQXuLEeSZrqGdHyoIrw")]
    [Description(@"Amount of withdrawal transactions exceeds card limit.")]
    WithdrawalAmountLimit = ResultDetailCode.WithdrawalAmountLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vendor not found.
    /// Encoded/decoded by serializers as &quot;VNDF&quot;.
    /// </summary>
    [EnumMember(Value = "VNDF")]
    [IsoId("_5dNTYXuLEeSZrqGdHyoIrw")]
    [Description(@"Vendor not found.")]
    VendorNotFound = ResultDetailCode.VendorNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vendor format has an error.
    /// Encoded/decoded by serializers as &quot;VNDR&quot;.
    /// </summary>
    [EnumMember(Value = "VNDR")]
    [IsoId("_5ik7kXuLEeSZrqGdHyoIrw")]
    [Description(@"Vendor format has an error.")]
    VendorFormatError = ResultDetailCode.VendorFormatError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested service not supported.
    /// Encoded/decoded by serializers as &quot;SVSU&quot;.
    /// </summary>
    [EnumMember(Value = "SVSU")]
    [IsoId("_5oFtsXuLEeSZrqGdHyoIrw")]
    [Description(@"Requested service not supported.")]
    UnsupportedService = ResultDetailCode.UnsupportedService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card is not active yet.
    /// Encoded/decoded by serializers as &quot;CRDU&quot;.
    /// </summary>
    [EnumMember(Value = "CRDU")]
    [IsoId("_5tdV4XuLEeSZrqGdHyoIrw")]
    [Description(@"Card is not active yet.")]
    UneffectiveCard = ResultDetailCode.UneffectiveCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Communication keys are not available.
    /// Encoded/decoded by serializers as &quot;CMKY&quot;.
    /// </summary>
    [EnumMember(Value = "CMKY")]
    [IsoId("_5y-IAXuLEeSZrqGdHyoIrw")]
    [Description(@"Communication keys are not available.")]
    UnavailablecommunicationKey = ResultDetailCode.UnavailablecommunicationKey, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency is unacceptable for the Issuer or the processor.
    /// Encoded/decoded by serializers as &quot;UNBC&quot;.
    /// </summary>
    [EnumMember(Value = "UNBC")]
    [IsoId("_54VJIXuLEeSZrqGdHyoIrw")]
    [Description(@"Currency is unacceptable for the Issuer or the processor.")]
    UnacceptableCurrency = ResultDetailCode.UnacceptableCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction cannot be processed offline.
    /// Encoded/decoded by serializers as &quot;UNBP&quot;.
    /// </summary>
    [EnumMember(Value = "UNBP")]
    [IsoId("_5917QXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction cannot be processed offline.")]
    UnableToProcessOffLine = ResultDetailCode.UnableToProcessOffLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction cannot be processed online by the terminal.
    /// Encoded/decoded by serializers as &quot;UNBO&quot;.
    /// </summary>
    [EnumMember(Value = "UNBO")]
    [IsoId("_6DWtYXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction cannot be processed online by the terminal.")]
    UnableToGoOnLine = ResultDetailCode.UnableToGoOnLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction could not be processed as original is not found.
    /// Encoded/decoded by serializers as &quot;ORGF&quot;.
    /// </summary>
    [EnumMember(Value = "ORGF")]
    [IsoId("_6IuVkXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction could not be processed as original is not found.")]
    UnableToFindOriginal = ResultDetailCode.UnableToFindOriginal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction identification already used for another transaction.
    /// Encoded/decoded by serializers as &quot;TXND&quot;.
    /// </summary>
    [EnumMember(Value = "TXND")]
    [IsoId("_6OFWsXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction identification already used for another transaction.")]
    TransactionDuplicate = ResultDetailCode.TransactionDuplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction did not complete at the terminal.
    /// Encoded/decoded by serializers as &quot;TXNU&quot;.
    /// </summary>
    [EnumMember(Value = "TXNU")]
    [IsoId("_6U8MoXuLEeSZrqGdHyoIrw")]
    [Description(@"Transaction did not complete at the terminal.")]
    TransactionDidNotComplete = ResultDetailCode.TransactionDidNotComplete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Totals are not available.
    /// Encoded/decoded by serializers as &quot;TTLV&quot;.
    /// </summary>
    [EnumMember(Value = "TTLV")]
    [IsoId("_6ac-wXuLEeSZrqGdHyoIrw")]
    [Description(@"Totals are not available.")]
    TotalsNotAvailable = ResultDetailCode.TotalsNotAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To account status error.
    /// Encoded/decoded by serializers as &quot;ACTT&quot;.
    /// </summary>
    [EnumMember(Value = "ACTT")]
    [IsoId("_6f0m8XuLEeSZrqGdHyoIrw")]
    [Description(@"To account status error.")]
    ToAccountError = ResultDetailCode.ToAccountError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// System Malfunction.
    /// Encoded/decoded by serializers as &quot;SYSM&quot;.
    /// </summary>
    [EnumMember(Value = "SYSM")]
    [IsoId("_6lVZEXuLEeSZrqGdHyoIrw")]
    [Description(@"System Malfunction.")]
    SystemMalfunction = ResultDetailCode.SystemMalfunction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing temporary not available.
    /// Encoded/decoded by serializers as &quot;SYSP&quot;.
    /// </summary>
    [EnumMember(Value = "SYSP")]
    [IsoId("_6rS3IXuLEeSZrqGdHyoIrw")]
    [Description(@"Processing temporary not available.")]
    SystemInoperative = ResultDetailCode.SystemInoperative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraudulent transaction is suspected by the issuer or the processor.
    /// Encoded/decoded by serializers as &quot;FRDS&quot;.
    /// </summary>
    [EnumMember(Value = "FRDS")]
    [IsoId("_6yJtEXuLEeSZrqGdHyoIrw")]
    [Description(@"Fraudulent transaction is suspected by the issuer or the processor.")]
    SuspectedFraud = ResultDetailCode.SuspectedFraud, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterfeit card suspected by the issuer or the processor.
    /// Encoded/decoded by serializers as &quot;CNTC&quot;.
    /// </summary>
    [EnumMember(Value = "CNTC")]
    [IsoId("_65AjAXuLEeSZrqGdHyoIrw")]
    [Description(@"Counterfeit card suspected by the issuer or the processor.")]
    SuspectedCounterfeitCard = ResultDetailCode.SuspectedCounterfeitCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Surcharging is not permitted.
    /// Encoded/decoded by serializers as &quot;SRCH&quot;.
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_6_aF8XuLEeSZrqGdHyoIrw")]
    [Description(@"Surcharging is not permitted.")]
    SurchargeNotPermitted = ResultDetailCode.SurchargeNotPermitted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card has been declared stolen.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_7ExuIXuLEeSZrqGdHyoIrw")]
    [Description(@"Card has been declared stolen.")]
    StolenCard = ResultDetailCode.StolenCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message is acknowledged only without processing the service, for instance the reconciliation is not performed, acknowledged only.
    /// Encoded/decoded by serializers as &quot;ACKO&quot;.
    /// </summary>
    [EnumMember(Value = "ACKO")]
    [IsoId("_Nev6wYO-EeSWSLYdc10LRg")]
    [Description(
        @"Message is acknowledged only without processing the service, for instance the reconciliation is not performed, acknowledged only."
    )]
    AcknowledgementOnly = ResultDetailCode.AcknowledgementOnly, // same ordinal as derivation source for type conversions
}
