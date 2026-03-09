// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Detail of the response to an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qTSKAa2AEeWMg5rOByfExw")]
[Description(@"Detail of the response to an ATM.")]
[DerivedFrom(typeof(ResultDetailCode))]
public enum ResultDetail4Code
{
    /// <summary>
    /// Account of the cardholder or the customer is not found.
    /// Encoded/decoded by serializers as &quot;ACTF&quot;.
    /// </summary>
    [EnumMember(Value = "ACTF")]
    [IsoId("_qedfQa2AEeWMg5rOByfExw")]
    [Description(@"Account of the cardholder or the customer is not found.")]
    AccountNotFound = ResultDetailCode.AccountNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acquirer is not supported.
    /// Encoded/decoded by serializers as &quot;ACQS&quot;.
    /// </summary>
    [EnumMember(Value = "ACQS")]
    [IsoId("_qedfQ62AEeWMg5rOByfExw")]
    [Description(@"Acquirer is not supported.")]
    AcquirerNotSupported = ResultDetailCode.AcquirerNotSupported, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Error on AML (Anti Money Laundering) validation.
    /// Encoded/decoded by serializers as &quot;AMLV&quot;.
    /// </summary>
    [EnumMember(Value = "AMLV")]
    [IsoId("_qedfRa2AEeWMg5rOByfExw")]
    [Description(@"Error on AML (Anti Money Laundering) validation.")]
    AMLValidation = ResultDetailCode.AMLValidation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount not found.
    /// Encoded/decoded by serializers as &quot;AMTA&quot;.
    /// </summary>
    [EnumMember(Value = "AMTA")]
    [IsoId("_qedfR62AEeWMg5rOByfExw")]
    [Description(@"Amount not found.")]
    AmountNotFound = ResultDetailCode.AmountNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder or customer could not be authenticated, for instance due to an incorrect login identification or an incorrect password.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_qedfSa2AEeWMg5rOByfExw")]
    [Description(@"Cardholder or customer could not be authenticated, for instance due to an incorrect login identification or an incorrect password.")]
    AuthenticationFailed = ResultDetailCode.AuthenticationFailed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Bank not found.
    /// Encoded/decoded by serializers as &quot;BANK&quot;.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_qedfS62AEeWMg5rOByfExw")]
    [Description(@"Bank not found.")]
    BankNotFound = ResultDetailCode.BankNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).
    /// Encoded/decoded by serializers as &quot;CRDR&quot;.
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_qedfTa2AEeWMg5rOByfExw")]
    [Description(@"Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).")]
    CardError = ResultDetailCode.CardError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of the card is invalid.
    /// Encoded/decoded by serializers as &quot;CRDF&quot;.
    /// </summary>
    [EnumMember(Value = "CRDF")]
    [IsoId("_qedfT62AEeWMg5rOByfExw")]
    [Description(@"Identification of the card is invalid.")]
    CardVerificationFailed = ResultDetailCode.CardVerificationFailed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account is no more usable for the transaction.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_qedfUa2AEeWMg5rOByfExw")]
    [Description(@"Account is no more usable for the transaction.")]
    ClosedAccount = ResultDetailCode.ClosedAccount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cutover is in progress, transaction could not be processed.
    /// Encoded/decoded by serializers as &quot;CTVG&quot;.
    /// </summary>
    [EnumMember(Value = "CTVG")]
    [IsoId("_qedfU62AEeWMg5rOByfExw")]
    [Description(@"Cutover is in progress, transaction could not be processed.")]
    CutoverInProcess = ResultDetailCode.CutoverInProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Database access error.
    /// Encoded/decoded by serializers as &quot;DBER&quot;.
    /// </summary>
    [EnumMember(Value = "DBER")]
    [IsoId("_qedfVa2AEeWMg5rOByfExw")]
    [Description(@"Database access error.")]
    DatabaseError = ResultDetailCode.DatabaseError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction fees are disputed by the issuer.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_qedfV62AEeWMg5rOByfExw")]
    [Description(@"Transaction fees are disputed by the issuer.")]
    DisputedFees = ResultDetailCode.DisputedFees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Validity period of the transaction is exceeded.
    /// Encoded/decoded by serializers as &quot;TXNL&quot;.
    /// </summary>
    [EnumMember(Value = "TXNL")]
    [IsoId("_qedfWa2AEeWMg5rOByfExw")]
    [Description(@"Validity period of the transaction is exceeded.")]
    ExceededTransactionLifeCycle = ResultDetailCode.ExceededTransactionLifeCycle, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of deposit transactions exceeds the limit.
    /// Encoded/decoded by serializers as &quot;AMTD&quot;.
    /// </summary>
    [EnumMember(Value = "AMTD")]
    [IsoId("_qedfW62AEeWMg5rOByfExw")]
    [Description(@"Amount of deposit transactions exceeds the limit.")]
    DepositAmountLimit = ResultDetailCode.DepositAmountLimit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of deposit transactions or items exceeds the limit.
    /// Encoded/decoded by serializers as &quot;NMBD&quot;.
    /// </summary>
    [EnumMember(Value = "NMBD")]
    [IsoId("_qedfXa2AEeWMg5rOByfExw")]
    [Description(@"Number of deposit transactions or items exceeds the limit.")]
    DepositNumberLimit = ResultDetailCode.DepositNumberLimit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card has expired.
    /// Encoded/decoded by serializers as &quot;CRDX&quot;.
    /// </summary>
    [EnumMember(Value = "CRDX")]
    [IsoId("_qedfX62AEeWMg5rOByfExw")]
    [Description(@"Card has expired.")]
    ExpiredCard = ResultDetailCode.ExpiredCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer declined the fall-back transaction.
    /// Encoded/decoded by serializers as &quot;FDCL&quot;.
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_qedfYa2AEeWMg5rOByfExw")]
    [Description(@"Issuer declined the fall-back transaction.")]
    FallbackDeclined = ResultDetailCode.FallbackDeclined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid format of the message or its content.
    /// Encoded/decoded by serializers as &quot;FMTR&quot;.
    /// </summary>
    [EnumMember(Value = "FMTR")]
    [IsoId("_qedfY62AEeWMg5rOByfExw")]
    [Description(@"Invalid format of the message or its content.")]
    FormatError = ResultDetailCode.FormatError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original request is in progress.
    /// Encoded/decoded by serializers as &quot;TXNG&quot;.
    /// </summary>
    [EnumMember(Value = "TXNG")]
    [IsoId("_qedfZa2AEeWMg5rOByfExw")]
    [Description(@"Original request is in progress.")]
    InProgress = ResultDetailCode.InProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Account balance is not sufficient.
    /// Encoded/decoded by serializers as &quot;FNDI&quot;.
    /// </summary>
    [EnumMember(Value = "FNDI")]
    [IsoId("_qedfZ62AEeWMg5rOByfExw")]
    [Description(@"Account balance is not sufficient.")]
    InsufficientFunds = ResultDetailCode.InsufficientFunds, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer denies the acceptor.
    /// Encoded/decoded by serializers as &quot;ACPI&quot;.
    /// </summary>
    [EnumMember(Value = "ACPI")]
    [IsoId("_qedfaa2AEeWMg5rOByfExw")]
    [Description(@"Issuer denies the acceptor.")]
    InvalidAcceptor = ResultDetailCode.InvalidAcceptor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested amount is outside the card limits, or the currency is invalid.
    /// Encoded/decoded by serializers as &quot;AMTI&quot;.
    /// </summary>
    [EnumMember(Value = "AMTI")]
    [IsoId("_qedfa62AEeWMg5rOByfExw")]
    [Description(@"Requested amount is outside the card limits, or the currency is invalid.")]
    InvalidAmount = ResultDetailCode.InvalidAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Part of the specified address is incorrect.
    /// Encoded/decoded by serializers as &quot;ADDI&quot;.
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_qedfba2AEeWMg5rOByfExw")]
    [Description(@"Part of the specified address is incorrect.")]
    InvalidAddress = ResultDetailCode.InvalidAddress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Invalid branch or bank information.
    /// Encoded/decoded by serializers as &quot;BRHI&quot;.
    /// </summary>
    [EnumMember(Value = "BRHI")]
    [IsoId("_qedfb62AEeWMg5rOByfExw")]
    [Description(@"Invalid branch or bank information.")]
    InvalidBranch = ResultDetailCode.InvalidBranch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of the cardholder or the customer does not match.
    /// Encoded/decoded by serializers as &quot;CHDI&quot;.
    /// </summary>
    [EnumMember(Value = "CHDI")]
    [IsoId("_qedfca2AEeWMg5rOByfExw")]
    [Description(@"Identification of the cardholder or the customer does not match.")]
    InvalidCardholderIdentification = ResultDetailCode.InvalidCardholderIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of the card is invalid.
    /// Encoded/decoded by serializers as &quot;CRDI&quot;.
    /// </summary>
    [EnumMember(Value = "CRDI")]
    [IsoId("_qedfc62AEeWMg5rOByfExw")]
    [Description(@"Identification of the card is invalid.")]
    InvalidCardNumber = ResultDetailCode.InvalidCardNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Digital certificate cannot be authenticated, is expired or revoked.
    /// Encoded/decoded by serializers as &quot;CTFV&quot;.
    /// </summary>
    [EnumMember(Value = "CTFV")]
    [IsoId("_qedfda2AEeWMg5rOByfExw")]
    [Description(@"Digital certificate cannot be authenticated, is expired or revoked.")]
    InvalidCertificate = ResultDetailCode.InvalidCertificate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original amount is invalid.
    /// Encoded/decoded by serializers as &quot;AMTO&quot;.
    /// </summary>
    [EnumMember(Value = "AMTO")]
    [IsoId("_qedfd62AEeWMg5rOByfExw")]
    [Description(@"Original amount is invalid.")]
    InvalidOriginalAmount = ResultDetailCode.InvalidOriginalAmount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN is invalid.
    /// Encoded/decoded by serializers as &quot;PINV&quot;.
    /// </summary>
    [EnumMember(Value = "PINV")]
    [IsoId("_qedfea2AEeWMg5rOByfExw")]
    [Description(@"PIN is invalid.")]
    InvalidPIN = ResultDetailCode.InvalidPIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Token cannot be used to surrogate a PAN (Primary Account Number).
    /// Encoded/decoded by serializers as &quot;TKKO&quot;.
    /// </summary>
    [EnumMember(Value = "TKKO")]
    [IsoId("_qedfe62AEeWMg5rOByfExw")]
    [Description(@"Token cannot be used to surrogate a PAN (Primary Account Number).")]
    InvalidToken = ResultDetailCode.InvalidToken, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Signed message has an invalid signature.
    /// Encoded/decoded by serializers as &quot;SGNI&quot;.
    /// </summary>
    [EnumMember(Value = "SGNI")]
    [IsoId("_qedffa2AEeWMg5rOByfExw")]
    [Description(@"Signed message has an invalid signature.")]
    InvalidSignature = ResultDetailCode.InvalidSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Identification of the token provider or the token requestor is invalid.
    /// Encoded/decoded by serializers as &quot;TKID&quot;.
    /// </summary>
    [EnumMember(Value = "TKID")]
    [IsoId("_qedff62AEeWMg5rOByfExw")]
    [Description(@"Identification of the token provider or the token requestor is invalid.")]
    InvalidTokenIdentification = ResultDetailCode.InvalidTokenIdentification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is invalid.
    /// Encoded/decoded by serializers as &quot;TXNV&quot;.
    /// </summary>
    [EnumMember(Value = "TXNV")]
    [IsoId("_qedfga2AEeWMg5rOByfExw")]
    [Description(@"Transaction is invalid.")]
    InvalidTransaction = ResultDetailCode.InvalidTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Date time of the transaction is invalid.
    /// Encoded/decoded by serializers as &quot;DATI&quot;.
    /// </summary>
    [EnumMember(Value = "DATI")]
    [IsoId("_qedfg62AEeWMg5rOByfExw")]
    [Description(@"Date time of the transaction is invalid.")]
    InvalidTransactionDateTime = ResultDetailCode.InvalidTransactionDateTime, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer is inoperative.
    /// Encoded/decoded by serializers as &quot;ISSP&quot;.
    /// </summary>
    [EnumMember(Value = "ISSP")]
    [IsoId("_qedfha2AEeWMg5rOByfExw")]
    [Description(@"Issuer is inoperative.")]
    IssuerInoperative = ResultDetailCode.IssuerInoperative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Issuer is not found.
    /// Encoded/decoded by serializers as &quot;ISSF&quot;.
    /// </summary>
    [EnumMember(Value = "ISSF")]
    [IsoId("_qedfh62AEeWMg5rOByfExw")]
    [Description(@"Issuer is not found.")]
    IssuerNotFound = ResultDetailCode.IssuerNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction could not be processed as Issuer is signed off.
    /// Encoded/decoded by serializers as &quot;ISSO&quot;.
    /// </summary>
    [EnumMember(Value = "ISSO")]
    [IsoId("_qedfia2AEeWMg5rOByfExw")]
    [Description(@"Transaction could not be processed as Issuer is signed off.")]
    IssuerSignedOff = ResultDetailCode.IssuerSignedOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction could not be processed as Issuer times out.
    /// Encoded/decoded by serializers as &quot;ISST&quot;.
    /// </summary>
    [EnumMember(Value = "ISST")]
    [IsoId("_qedfi62AEeWMg5rOByfExw")]
    [Description(@"Transaction could not be processed as Issuer times out.")]
    IssuerTimeOut = ResultDetailCode.IssuerTimeOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction could not be processed as Issuer is unavailable.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_qedfja2AEeWMg5rOByfExw")]
    [Description(@"Transaction could not be processed as Issuer is unavailable.")]
    IssuerUnavailable = ResultDetailCode.IssuerUnavailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Storage space not available for the key.
    /// Encoded/decoded by serializers as &quot;KEYS&quot;.
    /// </summary>
    [EnumMember(Value = "KEYS")]
    [IsoId("_qedfj62AEeWMg5rOByfExw")]
    [Description(@"Storage space not available for the key.")]
    KeyStorageSaturation = ResultDetailCode.KeyStorageSaturation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is processed and liability is accepted.
    /// Encoded/decoded by serializers as &quot;LBLA&quot;.
    /// </summary>
    [EnumMember(Value = "LBLA")]
    [IsoId("_qedfka2AEeWMg5rOByfExw")]
    [Description(@"Transaction is processed and liability is accepted.")]
    LiabilityAccepted = ResultDetailCode.LiabilityAccepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card has been declared lost.
    /// Encoded/decoded by serializers as &quot;CRDL&quot;.
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_qedfk62AEeWMg5rOByfExw")]
    [Description(@"Card has been declared lost.")]
    LostCard = ResultDetailCode.LostCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// MAC error.
    /// Encoded/decoded by serializers as &quot;MACR&quot;.
    /// </summary>
    [EnumMember(Value = "MACR")]
    [IsoId("_qedfla2AEeWMg5rOByfExw")]
    [Description(@"MAC error.")]
    MACError = ResultDetailCode.MACError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// MAC key error.
    /// Encoded/decoded by serializers as &quot;MACK&quot;.
    /// </summary>
    [EnumMember(Value = "MACK")]
    [IsoId("_qedfl62AEeWMg5rOByfExw")]
    [Description(@"MAC key error.")]
    MACKeyError = ResultDetailCode.MACKeyError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ICC data elements required for processing the ICC transaction were not present in the message.
    /// Encoded/decoded by serializers as &quot;ICCM&quot;.
    /// </summary>
    [EnumMember(Value = "ICCM")]
    [IsoId("_qedfma2AEeWMg5rOByfExw")]
    [Description(@"ICC data elements required for processing the ICC transaction were not present in the message.")]
    MissingICCData = ResultDetailCode.MissingICCData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// New PIN is invalid (PIN change).
    /// Encoded/decoded by serializers as &quot;PINN&quot;.
    /// </summary>
    [EnumMember(Value = "PINN")]
    [IsoId("_qedfm62AEeWMg5rOByfExw")]
    [Description(@"New PIN is invalid (PIN change).")]
    NewPINInvalid = ResultDetailCode.NewPINInvalid, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No card file record.
    /// Encoded/decoded by serializers as &quot;CRDA&quot;.
    /// </summary>
    [EnumMember(Value = "CRDA")]
    [IsoId("_qedfna2AEeWMg5rOByfExw")]
    [Description(@"No card file record.")]
    NoCardRecord = ResultDetailCode.NoCardRecord, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is processed, but liability is not accepted.
    /// Encoded/decoded by serializers as &quot;LBLU&quot;.
    /// </summary>
    [EnumMember(Value = "LBLU")]
    [IsoId("_qedfn62AEeWMg5rOByfExw")]
    [Description(@"Transaction is processed, but liability is not accepted.")]
    NoLiabilityAccepted = ResultDetailCode.NoLiabilityAccepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN could not be validated.
    /// Encoded/decoded by serializers as &quot;PINA&quot;.
    /// </summary>
    [EnumMember(Value = "PINA")]
    [IsoId("_qedfoa2AEeWMg5rOByfExw")]
    [Description(@"PIN could not be validated.")]
    NotAbleToValidatePIN = ResultDetailCode.NotAbleToValidatePIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Process not permitted to the acceptor (for example fall back).
    /// Encoded/decoded by serializers as &quot;NPRA&quot;.
    /// </summary>
    [EnumMember(Value = "NPRA")]
    [IsoId("_qedfo62AEeWMg5rOByfExw")]
    [Description(@"Process not permitted to the acceptor (for example fall back).")]
    NotPermittedToAcceptor = ResultDetailCode.NotPermittedToAcceptor, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been processed offline by the terminal.
    /// Encoded/decoded by serializers as &quot;OFFL&quot;.
    /// </summary>
    [EnumMember(Value = "OFFL")]
    [IsoId("_qedfpa2AEeWMg5rOByfExw")]
    [Description(@"Transaction has been processed offline by the terminal.")]
    OffLineProcess = ResultDetailCode.OffLineProcess, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction has been processed offline after referral.
    /// Encoded/decoded by serializers as &quot;ONLP&quot;.
    /// </summary>
    [EnumMember(Value = "ONLP")]
    [IsoId("_qedfp62AEeWMg5rOByfExw")]
    [Description(@"Transaction has been processed offline after referral.")]
    OffLineProcessAfterReferral = ResultDetailCode.OffLineProcessAfterReferral, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction not permitted to the cardholder or the customer.
    /// Encoded/decoded by serializers as &quot;NPRC&quot;.
    /// </summary>
    [EnumMember(Value = "NPRC")]
    [IsoId("_qedfqa2AEeWMg5rOByfExw")]
    [Description(@"Transaction not permitted to the cardholder or the customer.")]
    NotPermittedToCardholder = ResultDetailCode.NotPermittedToCardholder, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Original is found, but transaction does not match.
    /// Encoded/decoded by serializers as &quot;TXNM&quot;.
    /// </summary>
    [EnumMember(Value = "TXNM")]
    [IsoId("_qedfq62AEeWMg5rOByfExw")]
    [Description(@"Original is found, but transaction does not match.")]
    OriginalDoesNotMatch = ResultDetailCode.OriginalDoesNotMatch, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other error.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_qedfra2AEeWMg5rOByfExw")]
    [Description(@"Other error.")]
    OtherError = ResultDetailCode.OtherError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Out of balance.
    /// Encoded/decoded by serializers as &quot;BALO&quot;.
    /// </summary>
    [EnumMember(Value = "BALO")]
    [IsoId("_qedfr62AEeWMg5rOByfExw")]
    [Description(@"Out of balance.")]
    OutOfBalance = ResultDetailCode.OutOfBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Message is out of sequence.
    /// Encoded/decoded by serializers as &quot;SEQO&quot;.
    /// </summary>
    [EnumMember(Value = "SEQO")]
    [IsoId("_qedfsa2AEeWMg5rOByfExw")]
    [Description(@"Message is out of sequence.")]
    OutOfSequence = ResultDetailCode.OutOfSequence, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder must change the PIN to be able to perform the transaction.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_qedfs62AEeWMg5rOByfExw")]
    [Description(@"Cardholder must change the PIN to be able to perform the transaction.")]
    PINChangeRequired = ResultDetailCode.PINChangeRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Additional information are required to verify the PIN.
    /// Encoded/decoded by serializers as &quot;PIND&quot;.
    /// </summary>
    [EnumMember(Value = "PIND")]
    [IsoId("_qedfta2AEeWMg5rOByfExw")]
    [Description(@"Additional information are required to verify the PIN.")]
    PINDataRequired = ResultDetailCode.PINDataRequired, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PIN length or PIN key is invalid.
    /// Encoded/decoded by serializers as &quot;PINS&quot;.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_qedft62AEeWMg5rOByfExw")]
    [Description(@"PIN length or PIN key is invalid.")]
    PINSecurityError = ResultDetailCode.PINSecurityError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Last attempt of the PIN verification fails.
    /// Encoded/decoded by serializers as &quot;PINX&quot;.
    /// </summary>
    [EnumMember(Value = "PINX")]
    [IsoId("_qedfua2AEeWMg5rOByfExw")]
    [Description(@"Last attempt of the PIN verification fails.")]
    PINTriesExceeded = ResultDetailCode.PINTriesExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Decrypted PIN block is invalid.
    /// Encoded/decoded by serializers as &quot;PINE&quot;.
    /// </summary>
    [EnumMember(Value = "PINE")]
    [IsoId("_qedfu62AEeWMg5rOByfExw")]
    [Description(@"Decrypted PIN block is invalid.")]
    PINEncryptionError = ResultDetailCode.PINEncryptionError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Store and forward queue maximum exceeded.
    /// Encoded/decoded by serializers as &quot;QMAX&quot;.
    /// </summary>
    [EnumMember(Value = "QMAX")]
    [IsoId("_qedfva2AEeWMg5rOByfExw")]
    [Description(@"Store and forward queue maximum exceeded.")]
    QueueMaximumExceeded = ResultDetailCode.QueueMaximumExceeded, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recurring Error on Data.
    /// Encoded/decoded by serializers as &quot;RECD&quot;.
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_qedfv62AEeWMg5rOByfExw")]
    [Description(@"Recurring Error on Data.")]
    RecurringDataError = ResultDetailCode.RecurringDataError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested service not allowed by the card.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_qedfwa2AEeWMg5rOByfExw")]
    [Description(@"Requested service not allowed by the card.")]
    RestrictedCard = ResultDetailCode.RestrictedCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram).
    /// Encoded/decoded by serializers as &quot;SECV&quot;.
    /// </summary>
    [EnumMember(Value = "SECV")]
    [IsoId("_qedfw62AEeWMg5rOByfExw")]
    [Description(@"Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram).")]
    SecurityViolation = ResultDetailCode.SecurityViolation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder or customer has not enabled the service with the service provider.
    /// Encoded/decoded by serializers as &quot;SRVU&quot;.
    /// </summary>
    [EnumMember(Value = "SRVU")]
    [IsoId("_qedfxa2AEeWMg5rOByfExw")]
    [Description(@"Cardholder or customer has not enabled the service with the service provider.")]
    ServiceNotEnabled = ResultDetailCode.ServiceNotEnabled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Security software or hardware error.
    /// Encoded/decoded by serializers as &quot;SFWE&quot;.
    /// </summary>
    [EnumMember(Value = "SFWE")]
    [IsoId("_qedfx62AEeWMg5rOByfExw")]
    [Description(@"Security software or hardware error.")]
    SoftwareOrHardwareError = ResultDetailCode.SoftwareOrHardwareError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Special card conditions not respected.
    /// Encoded/decoded by serializers as &quot;SPCC&quot;.
    /// </summary>
    [EnumMember(Value = "SPCC")]
    [IsoId("_qedfya2AEeWMg5rOByfExw")]
    [Description(@"Special card conditions not respected.")]
    SpecialConditions = ResultDetailCode.SpecialConditions, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card has been declared stolen.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_qedfy62AEeWMg5rOByfExw")]
    [Description(@"Card has been declared stolen.")]
    StolenCard = ResultDetailCode.StolenCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Surcharging is not permitted.
    /// Encoded/decoded by serializers as &quot;SRCH&quot;.
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_qedfza2AEeWMg5rOByfExw")]
    [Description(@"Surcharging is not permitted.")]
    SurchargeNotPermitted = ResultDetailCode.SurchargeNotPermitted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Counterfeit card suspected by the issuer or the processor.
    /// Encoded/decoded by serializers as &quot;CNTC&quot;.
    /// </summary>
    [EnumMember(Value = "CNTC")]
    [IsoId("_qedfz62AEeWMg5rOByfExw")]
    [Description(@"Counterfeit card suspected by the issuer or the processor.")]
    SuspectedCounterfeitCard = ResultDetailCode.SuspectedCounterfeitCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fraudulent transaction is suspected by the issuer or the processor.
    /// Encoded/decoded by serializers as &quot;FRDS&quot;.
    /// </summary>
    [EnumMember(Value = "FRDS")]
    [IsoId("_qedf0a2AEeWMg5rOByfExw")]
    [Description(@"Fraudulent transaction is suspected by the issuer or the processor.")]
    SuspectedFraud = ResultDetailCode.SuspectedFraud, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing temporary not available.
    /// Encoded/decoded by serializers as &quot;SYSP&quot;.
    /// </summary>
    [EnumMember(Value = "SYSP")]
    [IsoId("_qedf062AEeWMg5rOByfExw")]
    [Description(@"Processing temporary not available.")]
    SystemInoperative = ResultDetailCode.SystemInoperative, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// System Malfunction.
    /// Encoded/decoded by serializers as &quot;SYSM&quot;.
    /// </summary>
    [EnumMember(Value = "SYSM")]
    [IsoId("_qedf1a2AEeWMg5rOByfExw")]
    [Description(@"System Malfunction.")]
    SystemMalfunction = ResultDetailCode.SystemMalfunction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Server received a terminal identification that it does not have any knowledge of.
    /// Encoded/decoded by serializers as &quot;TRMI&quot;.
    /// </summary>
    [EnumMember(Value = "TRMI")]
    [IsoId("_qedf162AEeWMg5rOByfExw")]
    [Description(@"Server received a terminal identification that it does not have any knowledge of.")]
    TerminalNotConfigured = ResultDetailCode.TerminalNotConfigured, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To account status error.
    /// Encoded/decoded by serializers as &quot;ACTT&quot;.
    /// </summary>
    [EnumMember(Value = "ACTT")]
    [IsoId("_qedf2a2AEeWMg5rOByfExw")]
    [Description(@"To account status error.")]
    ToAccountError = ResultDetailCode.ToAccountError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Totals are not available.
    /// Encoded/decoded by serializers as &quot;TTLV&quot;.
    /// </summary>
    [EnumMember(Value = "TTLV")]
    [IsoId("_qedf262AEeWMg5rOByfExw")]
    [Description(@"Totals are not available.")]
    TotalsNotAvailable = ResultDetailCode.TotalsNotAvailable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction did not complete at the terminal.
    /// Encoded/decoded by serializers as &quot;TXNU&quot;.
    /// </summary>
    [EnumMember(Value = "TXNU")]
    [IsoId("_qedf3a2AEeWMg5rOByfExw")]
    [Description(@"Transaction did not complete at the terminal.")]
    TransactionDidNotComplete = ResultDetailCode.TransactionDidNotComplete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction identification already used for another transaction.
    /// Encoded/decoded by serializers as &quot;TXND&quot;.
    /// </summary>
    [EnumMember(Value = "TXND")]
    [IsoId("_qedf362AEeWMg5rOByfExw")]
    [Description(@"Transaction identification already used for another transaction.")]
    TransactionDuplicate = ResultDetailCode.TransactionDuplicate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction could not be processed as original is not found.
    /// Encoded/decoded by serializers as &quot;ORGF&quot;.
    /// </summary>
    [EnumMember(Value = "ORGF")]
    [IsoId("_qedf4a2AEeWMg5rOByfExw")]
    [Description(@"Transaction could not be processed as original is not found.")]
    UnableToFindOriginal = ResultDetailCode.UnableToFindOriginal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction cannot be processed online by the terminal.
    /// Encoded/decoded by serializers as &quot;UNBO&quot;.
    /// </summary>
    [EnumMember(Value = "UNBO")]
    [IsoId("_qedf462AEeWMg5rOByfExw")]
    [Description(@"Transaction cannot be processed online by the terminal.")]
    UnableToGoOnLine = ResultDetailCode.UnableToGoOnLine, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction cannot be processed offline.
    /// Encoded/decoded by serializers as &quot;UNBP&quot;.
    /// </summary>
    [EnumMember(Value = "UNBP")]
    [IsoId("_qedf5a2AEeWMg5rOByfExw")]
    [Description(@"Transaction cannot be processed offline.")]
    UnableToProcessOffLine = ResultDetailCode.UnableToProcessOffLine, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Currency is unacceptable for the Issuer or the processor.
    /// Encoded/decoded by serializers as &quot;UNBC&quot;.
    /// </summary>
    [EnumMember(Value = "UNBC")]
    [IsoId("_qedf562AEeWMg5rOByfExw")]
    [Description(@"Currency is unacceptable for the Issuer or the processor.")]
    UnacceptableCurrency = ResultDetailCode.UnacceptableCurrency, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Communication keys are not available.
    /// Encoded/decoded by serializers as &quot;CMKY&quot;.
    /// </summary>
    [EnumMember(Value = "CMKY")]
    [IsoId("_qedf6a2AEeWMg5rOByfExw")]
    [Description(@"Communication keys are not available.")]
    UnavailablecommunicationKey = ResultDetailCode.UnavailablecommunicationKey, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Card is not active yet.
    /// Encoded/decoded by serializers as &quot;CRDU&quot;.
    /// </summary>
    [EnumMember(Value = "CRDU")]
    [IsoId("_qedf662AEeWMg5rOByfExw")]
    [Description(@"Card is not active yet.")]
    UneffectiveCard = ResultDetailCode.UneffectiveCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Requested service not supported.
    /// Encoded/decoded by serializers as &quot;SVSU&quot;.
    /// </summary>
    [EnumMember(Value = "SVSU")]
    [IsoId("_qedf7a2AEeWMg5rOByfExw")]
    [Description(@"Requested service not supported.")]
    UnsupportedService = ResultDetailCode.UnsupportedService, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vendor format has an error.
    /// Encoded/decoded by serializers as &quot;VNDR&quot;.
    /// </summary>
    [EnumMember(Value = "VNDR")]
    [IsoId("_qedf762AEeWMg5rOByfExw")]
    [Description(@"Vendor format has an error.")]
    VendorFormatError = ResultDetailCode.VendorFormatError, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Vendor not found.
    /// Encoded/decoded by serializers as &quot;VNDF&quot;.
    /// </summary>
    [EnumMember(Value = "VNDF")]
    [IsoId("_qedf8a2AEeWMg5rOByfExw")]
    [Description(@"Vendor not found.")]
    VendorNotFound = ResultDetailCode.VendorNotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Amount of withdrawal transactions exceeds card limit.
    /// Encoded/decoded by serializers as &quot;AMTW&quot;.
    /// </summary>
    [EnumMember(Value = "AMTW")]
    [IsoId("_qedf862AEeWMg5rOByfExw")]
    [Description(@"Amount of withdrawal transactions exceeds card limit.")]
    WithdrawalAmountLimit = ResultDetailCode.WithdrawalAmountLimit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number of withdrawal transactions exceeds card limit.
    /// Encoded/decoded by serializers as &quot;NMBW&quot;.
    /// </summary>
    [EnumMember(Value = "NMBW")]
    [IsoId("_qedf9a2AEeWMg5rOByfExw")]
    [Description(@"Number of withdrawal transactions exceeds card limit.")]
    WithdrawalNumberLimit = ResultDetailCode.WithdrawalNumberLimit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other card used for the original transaction.
    /// Encoded/decoded by serializers as &quot;CRDW&quot;.
    /// </summary>
    [EnumMember(Value = "CRDW")]
    [IsoId("_qedf962AEeWMg5rOByfExw")]
    [Description(@"Other card used for the original transaction.")]
    WrongCard = ResultDetailCode.WrongCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The requested media are not allowed for the service.
    /// Encoded/decoded by serializers as &quot;MEDI&quot;.
    /// </summary>
    [EnumMember(Value = "MEDI")]
    [IsoId("_u7PMka2AEeWMg5rOByfExw")]
    [Description(@"The requested media are not allowed for the service.")]
    InvalidMediaType = ResultDetailCode.InvalidMediaType, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The requested service is not allowed.
    /// Encoded/decoded by serializers as &quot;SRVI&quot;.
    /// </summary>
    [EnumMember(Value = "SRVI")]
    [IsoId("_vR4yAa2AEeWMg5rOByfExw")]
    [Description(@"The requested service is not allowed.")]
    InvalidService = ResultDetailCode.InvalidService, // same ordinal as derivation source for type conversions
    
}
