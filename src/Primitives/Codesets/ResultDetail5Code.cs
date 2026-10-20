// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Detail of the response to an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_o2XekZxKEe-Jl6tBAvMHqA")]
[Description(@"Detail of the response to an ATM.")]
[DerivedFrom(typeof(ResultDetailCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ResultDetail5Code>))]
public enum ResultDetail5Code
{
    /// <summary>
    /// Issuer denies the acceptor.
    /// Encoded/decoded by serializers as &quot;ACPI&quot;.
    /// </summary>
    [EnumMember(Value = "ACPI")]
    [IsoId("_o3PoeZxKEe-Jl6tBAvMHqA")]
    [Description(@"Issuer denies the acceptor.")]
    InvalidAcceptor = ResultDetailCode.InvalidAcceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acquirer is not supported.
    /// Encoded/decoded by serializers as &quot;ACQS&quot;.
    /// </summary>
    [EnumMember(Value = "ACQS")]
    [IsoId("_o3PoU5xKEe-Jl6tBAvMHqA")]
    [Description(@"Acquirer is not supported.")]
    AcquirerNotSupported = ResultDetailCode.AcquirerNotSupported, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is no more usable for the transaction.
    /// Encoded/decoded by serializers as &quot;ACTC&quot;.
    /// </summary>
    [EnumMember(Value = "ACTC")]
    [IsoId("_o3PoYZxKEe-Jl6tBAvMHqA")]
    [Description(@"Account is no more usable for the transaction.")]
    ClosedAccount = ResultDetailCode.ClosedAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account of the cardholder or the customer is not found.
    /// Encoded/decoded by serializers as &quot;ACTF&quot;.
    /// </summary>
    [EnumMember(Value = "ACTF")]
    [IsoId("_o3PoUZxKEe-Jl6tBAvMHqA")]
    [Description(@"Account of the cardholder or the customer is not found.")]
    AccountNotFound = ResultDetailCode.AccountNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To account status error.
    /// Encoded/decoded by serializers as &quot;ACTT&quot;.
    /// </summary>
    [EnumMember(Value = "ACTT")]
    [IsoId("_o3Po6ZxKEe-Jl6tBAvMHqA")]
    [Description(@"To account status error.")]
    ToAccountError = ResultDetailCode.ToAccountError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Consumer must choose whether to accept DCC offer provided to authorise the transaction. See &lt;Tx&gt;&lt;CcyConvsElgblty&gt;.
    /// Encoded/decoded by serializers as &quot;ADCC&quot;.
    /// </summary>
    [EnumMember(Value = "ADCC")]
    [IsoId("_aTvFwaDjEe-MRKYsaX6JDg")]
    [Description(@"Consumer must choose whether to accept DCC offer provided to authorise the transaction. See <Tx><CcyConvsElgblty>.")]
    AgreeDCC = ResultDetailCode.AgreeDCC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Part of the specified address is incorrect.
    /// Encoded/decoded by serializers as &quot;ADDI&quot;.
    /// </summary>
    [EnumMember(Value = "ADDI")]
    [IsoId("_o3PofZxKEe-Jl6tBAvMHqA")]
    [Description(@"Part of the specified address is incorrect.")]
    InvalidAddress = ResultDetailCode.InvalidAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Consumer must agree fee from those provided to authorise the transaction. See &lt;Tx&gt;&lt;AuthstnRslt&gt;&lt;FeeToAdd&gt;.
    /// Encoded/decoded by serializers as &quot;AGFE&quot;.
    /// </summary>
    [EnumMember(Value = "AGFE")]
    [IsoId("_YzroQaDjEe-MRKYsaX6JDg")]
    [Description(@"Consumer must agree fee from those provided to authorise the transaction. See <Tx><AuthstnRslt><FeeToAdd>.")]
    AgreeFee = ResultDetailCode.AgreeFee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Error on AML (Anti Money Laundering) validation.
    /// Encoded/decoded by serializers as &quot;AMLV&quot;.
    /// </summary>
    [EnumMember(Value = "AMLV")]
    [IsoId("_o3PoVZxKEe-Jl6tBAvMHqA")]
    [Description(@"Error on AML (Anti Money Laundering) validation.")]
    AMLValidation = ResultDetailCode.AMLValidation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The account details provided in the request message matches multiple accounts.
    /// Encoded/decoded by serializers as &quot;AMMA&quot;.
    /// </summary>
    [EnumMember(Value = "AMMA")]
    [IsoId("_YOvvMaDjEe-MRKYsaX6JDg")]
    [Description(@"The account details provided in the request message matches multiple accounts.")]
    AccountMatchesMultipleAccounts = ResultDetailCode.AccountMatchesMultipleAccounts, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount not found.
    /// Encoded/decoded by serializers as &quot;AMTA&quot;.
    /// </summary>
    [EnumMember(Value = "AMTA")]
    [IsoId("_o3PoV5xKEe-Jl6tBAvMHqA")]
    [Description(@"Amount not found.")]
    AmountNotFound = ResultDetailCode.AmountNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of deposit transactions exceeds the limit.
    /// Encoded/decoded by serializers as &quot;AMTD&quot;.
    /// </summary>
    [EnumMember(Value = "AMTD")]
    [IsoId("_o3Poa5xKEe-Jl6tBAvMHqA")]
    [Description(@"Amount of deposit transactions exceeds the limit.")]
    DepositAmountLimit = ResultDetailCode.DepositAmountLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested amount is outside the card limits, or the currency is invalid.
    /// Encoded/decoded by serializers as &quot;AMTI&quot;.
    /// </summary>
    [EnumMember(Value = "AMTI")]
    [IsoId("_o3Poe5xKEe-Jl6tBAvMHqA")]
    [Description(@"Requested amount is outside the card limits, or the currency is invalid.")]
    InvalidAmount = ResultDetailCode.InvalidAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original amount is invalid.
    /// Encoded/decoded by serializers as &quot;AMTO&quot;.
    /// </summary>
    [EnumMember(Value = "AMTO")]
    [IsoId("_o3Poh5xKEe-Jl6tBAvMHqA")]
    [Description(@"Original amount is invalid.")]
    InvalidOriginalAmount = ResultDetailCode.InvalidOriginalAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount of withdrawal transactions exceeds card limit.
    /// Encoded/decoded by serializers as &quot;AMTW&quot;.
    /// </summary>
    [EnumMember(Value = "AMTW")]
    [IsoId("_o3PpA5xKEe-Jl6tBAvMHqA")]
    [Description(@"Amount of withdrawal transactions exceeds card limit.")]
    WithdrawalAmountLimit = ResultDetailCode.WithdrawalAmountLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder or customer could not be authenticated, for instance due to an incorrect login identification or an incorrect password.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_o3PoWZxKEe-Jl6tBAvMHqA")]
    [Description(@"Cardholder or customer could not be authenticated, for instance due to an incorrect login identification or an incorrect password.")]
    AuthenticationFailed = ResultDetailCode.AuthenticationFailed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Out of balance.
    /// Encoded/decoded by serializers as &quot;BALO&quot;.
    /// </summary>
    [EnumMember(Value = "BALO")]
    [IsoId("_o3Pov5xKEe-Jl6tBAvMHqA")]
    [Description(@"Out of balance.")]
    OutOfBalance = ResultDetailCode.OutOfBalance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank not found.
    /// Encoded/decoded by serializers as &quot;BANK&quot;.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("_o3PoW5xKEe-Jl6tBAvMHqA")]
    [Description(@"Bank not found.")]
    BankNotFound = ResultDetailCode.BankNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid branch or bank information.
    /// Encoded/decoded by serializers as &quot;BRHI&quot;.
    /// </summary>
    [EnumMember(Value = "BRHI")]
    [IsoId("_o3Pof5xKEe-Jl6tBAvMHqA")]
    [Description(@"Invalid branch or bank information.")]
    InvalidBranch = ResultDetailCode.InvalidBranch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the cardholder or the customer does not match.
    /// Encoded/decoded by serializers as &quot;CHDI&quot;.
    /// </summary>
    [EnumMember(Value = "CHDI")]
    [IsoId("_o3PogZxKEe-Jl6tBAvMHqA")]
    [Description(@"Identification of the cardholder or the customer does not match.")]
    InvalidCardholderIdentification = ResultDetailCode.InvalidCardholderIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Communication keys are not available.
    /// Encoded/decoded by serializers as &quot;CMKY&quot;.
    /// </summary>
    [EnumMember(Value = "CMKY")]
    [IsoId("_o3Po-ZxKEe-Jl6tBAvMHqA")]
    [Description(@"Communication keys are not available.")]
    UnavailablecommunicationKey = ResultDetailCode.UnavailablecommunicationKey, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterfeit card suspected by the issuer or the processor.
    /// Encoded/decoded by serializers as &quot;CNTC&quot;.
    /// </summary>
    [EnumMember(Value = "CNTC")]
    [IsoId("_o3Po35xKEe-Jl6tBAvMHqA")]
    [Description(@"Counterfeit card suspected by the issuer or the processor.")]
    SuspectedCounterfeitCard = ResultDetailCode.SuspectedCounterfeitCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No card file record.
    /// Encoded/decoded by serializers as &quot;CRDA&quot;.
    /// </summary>
    [EnumMember(Value = "CRDA")]
    [IsoId("_o3PorZxKEe-Jl6tBAvMHqA")]
    [Description(@"No card file record.")]
    NoCardRecord = ResultDetailCode.NoCardRecord, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the card is invalid.
    /// Encoded/decoded by serializers as &quot;CRDF&quot;.
    /// </summary>
    [EnumMember(Value = "CRDF")]
    [IsoId("_o3PoX5xKEe-Jl6tBAvMHqA")]
    [Description(@"Identification of the card is invalid.")]
    CardVerificationFailed = ResultDetailCode.CardVerificationFailed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the card is invalid.
    /// Encoded/decoded by serializers as &quot;CRDI&quot;.
    /// </summary>
    [EnumMember(Value = "CRDI")]
    [IsoId("_o3Pog5xKEe-Jl6tBAvMHqA")]
    [Description(@"Identification of the card is invalid.")]
    InvalidCardNumber = ResultDetailCode.InvalidCardNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card has been declared lost.
    /// Encoded/decoded by serializers as &quot;CRDL&quot;.
    /// </summary>
    [EnumMember(Value = "CRDL")]
    [IsoId("_o3Poo5xKEe-Jl6tBAvMHqA")]
    [Description(@"Card has been declared lost.")]
    LostCard = ResultDetailCode.LostCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).
    /// Encoded/decoded by serializers as &quot;CRDR&quot;.
    /// </summary>
    [EnumMember(Value = "CRDR")]
    [IsoId("_o3PoXZxKEe-Jl6tBAvMHqA")]
    [Description(@"Card error, for instance invalid ARQC (Authorisation ReQuest Cryptogram).")]
    CardError = ResultDetailCode.CardError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card has been declared stolen.
    /// Encoded/decoded by serializers as &quot;CRDS&quot;.
    /// </summary>
    [EnumMember(Value = "CRDS")]
    [IsoId("_o3Po25xKEe-Jl6tBAvMHqA")]
    [Description(@"Card has been declared stolen.")]
    StolenCard = ResultDetailCode.StolenCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested service not allowed by the card.
    /// Encoded/decoded by serializers as &quot;CRDT&quot;.
    /// </summary>
    [EnumMember(Value = "CRDT")]
    [IsoId("_o3Po0ZxKEe-Jl6tBAvMHqA")]
    [Description(@"Requested service not allowed by the card.")]
    RestrictedCard = ResultDetailCode.RestrictedCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card is not active yet.
    /// Encoded/decoded by serializers as &quot;CRDU&quot;.
    /// </summary>
    [EnumMember(Value = "CRDU")]
    [IsoId("_o3Po-5xKEe-Jl6tBAvMHqA")]
    [Description(@"Card is not active yet.")]
    UneffectiveCard = ResultDetailCode.UneffectiveCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other card used for the original transaction.
    /// Encoded/decoded by serializers as &quot;CRDW&quot;.
    /// </summary>
    [EnumMember(Value = "CRDW")]
    [IsoId("_o3PpB5xKEe-Jl6tBAvMHqA")]
    [Description(@"Other card used for the original transaction.")]
    WrongCard = ResultDetailCode.WrongCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card has expired.
    /// Encoded/decoded by serializers as &quot;CRDX&quot;.
    /// </summary>
    [EnumMember(Value = "CRDX")]
    [IsoId("_o3Pob5xKEe-Jl6tBAvMHqA")]
    [Description(@"Card has expired.")]
    ExpiredCard = ResultDetailCode.ExpiredCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Digital certificate cannot be authenticated, is expired or revoked.
    /// Encoded/decoded by serializers as &quot;CTFV&quot;.
    /// </summary>
    [EnumMember(Value = "CTFV")]
    [IsoId("_o3PohZxKEe-Jl6tBAvMHqA")]
    [Description(@"Digital certificate cannot be authenticated, is expired or revoked.")]
    InvalidCertificate = ResultDetailCode.InvalidCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cutover is in progress, transaction could not be processed.
    /// Encoded/decoded by serializers as &quot;CTVG&quot;.
    /// </summary>
    [EnumMember(Value = "CTVG")]
    [IsoId("_o3PoY5xKEe-Jl6tBAvMHqA")]
    [Description(@"Cutover is in progress, transaction could not be processed.")]
    CutoverInProcess = ResultDetailCode.CutoverInProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date time of the transaction is invalid.
    /// Encoded/decoded by serializers as &quot;DATI&quot;.
    /// </summary>
    [EnumMember(Value = "DATI")]
    [IsoId("_o3Pok5xKEe-Jl6tBAvMHqA")]
    [Description(@"Date time of the transaction is invalid.")]
    InvalidTransactionDateTime = ResultDetailCode.InvalidTransactionDateTime, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Database access error.
    /// Encoded/decoded by serializers as &quot;DBER&quot;.
    /// </summary>
    [EnumMember(Value = "DBER")]
    [IsoId("_o3PoZZxKEe-Jl6tBAvMHqA")]
    [Description(@"Database access error.")]
    DatabaseError = ResultDetailCode.DatabaseError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer declined the fall-back transaction.
    /// Encoded/decoded by serializers as &quot;FDCL&quot;.
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_o3PocZxKEe-Jl6tBAvMHqA")]
    [Description(@"Issuer declined the fall-back transaction.")]
    FallbackDeclined = ResultDetailCode.FallbackDeclined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction fee is missing from the request.
    /// Encoded/decoded by serializers as &quot;FEEM&quot;.
    /// </summary>
    [EnumMember(Value = "FEEM")]
    [IsoId("_W4-IoajyEe--FqfI7l8ySw")]
    [Description(@"Transaction fee is missing from the request.")]
    FeeMissing = ResultDetailCode.FeeMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction fees are disputed by the issuer.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_o3PoZ5xKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction fees are disputed by the issuer.")]
    DisputedFees = ResultDetailCode.DisputedFees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Invalid format of the message or its content.
    /// Encoded/decoded by serializers as &quot;FMTR&quot;.
    /// </summary>
    [EnumMember(Value = "FMTR")]
    [IsoId("_o3Poc5xKEe-Jl6tBAvMHqA")]
    [Description(@"Invalid format of the message or its content.")]
    FormatError = ResultDetailCode.FormatError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account balance is not sufficient.
    /// Encoded/decoded by serializers as &quot;FNDI&quot;.
    /// </summary>
    [EnumMember(Value = "FNDI")]
    [IsoId("_o3Pod5xKEe-Jl6tBAvMHqA")]
    [Description(@"Account balance is not sufficient.")]
    InsufficientFunds = ResultDetailCode.InsufficientFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Fraudulent transaction is suspected by the issuer or the processor.
    /// Encoded/decoded by serializers as &quot;FRDS&quot;.
    /// </summary>
    [EnumMember(Value = "FRDS")]
    [IsoId("_o3Po4ZxKEe-Jl6tBAvMHqA")]
    [Description(@"Fraudulent transaction is suspected by the issuer or the processor.")]
    SuspectedFraud = ResultDetailCode.SuspectedFraud, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ICC data elements required for processing the ICC transaction were not present in the message.
    /// Encoded/decoded by serializers as &quot;ICCM&quot;.
    /// </summary>
    [EnumMember(Value = "ICCM")]
    [IsoId("_o3PoqZxKEe-Jl6tBAvMHqA")]
    [Description(@"ICC data elements required for processing the ICC transaction were not present in the message.")]
    MissingICCData = ResultDetailCode.MissingICCData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer is not found.
    /// Encoded/decoded by serializers as &quot;ISSF&quot;.
    /// </summary>
    [EnumMember(Value = "ISSF")]
    [IsoId("_o3Pol5xKEe-Jl6tBAvMHqA")]
    [Description(@"Issuer is not found.")]
    IssuerNotFound = ResultDetailCode.IssuerNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction could not be processed as Issuer is signed off.
    /// Encoded/decoded by serializers as &quot;ISSO&quot;.
    /// </summary>
    [EnumMember(Value = "ISSO")]
    [IsoId("_o3PomZxKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction could not be processed as Issuer is signed off.")]
    IssuerSignedOff = ResultDetailCode.IssuerSignedOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer is inoperative.
    /// Encoded/decoded by serializers as &quot;ISSP&quot;.
    /// </summary>
    [EnumMember(Value = "ISSP")]
    [IsoId("_o3PolZxKEe-Jl6tBAvMHqA")]
    [Description(@"Issuer is inoperative.")]
    IssuerInoperative = ResultDetailCode.IssuerInoperative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction could not be processed as Issuer times out.
    /// Encoded/decoded by serializers as &quot;ISST&quot;.
    /// </summary>
    [EnumMember(Value = "ISST")]
    [IsoId("_o3Pom5xKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction could not be processed as Issuer times out.")]
    IssuerTimeOut = ResultDetailCode.IssuerTimeOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction could not be processed as Issuer is unavailable.
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_o3PonZxKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction could not be processed as Issuer is unavailable.")]
    IssuerUnavailable = ResultDetailCode.IssuerUnavailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Storage space not available for the key.
    /// Encoded/decoded by serializers as &quot;KEYS&quot;.
    /// </summary>
    [EnumMember(Value = "KEYS")]
    [IsoId("_o3Pon5xKEe-Jl6tBAvMHqA")]
    [Description(@"Storage space not available for the key.")]
    KeyStorageSaturation = ResultDetailCode.KeyStorageSaturation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is processed and liability is accepted.
    /// Encoded/decoded by serializers as &quot;LBLA&quot;.
    /// </summary>
    [EnumMember(Value = "LBLA")]
    [IsoId("_o3PooZxKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction is processed and liability is accepted.")]
    LiabilityAccepted = ResultDetailCode.LiabilityAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is processed, but liability is not accepted.
    /// Encoded/decoded by serializers as &quot;LBLU&quot;.
    /// </summary>
    [EnumMember(Value = "LBLU")]
    [IsoId("_o3Por5xKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction is processed, but liability is not accepted.")]
    NoLiabilityAccepted = ResultDetailCode.NoLiabilityAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MAC key error.
    /// Encoded/decoded by serializers as &quot;MACK&quot;.
    /// </summary>
    [EnumMember(Value = "MACK")]
    [IsoId("_o3Pop5xKEe-Jl6tBAvMHqA")]
    [Description(@"MAC key error.")]
    MACKeyError = ResultDetailCode.MACKeyError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// MAC error.
    /// Encoded/decoded by serializers as &quot;MACR&quot;.
    /// </summary>
    [EnumMember(Value = "MACR")]
    [IsoId("_o3PopZxKEe-Jl6tBAvMHqA")]
    [Description(@"MAC error.")]
    MACError = ResultDetailCode.MACError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The requested media are not allowed for the service.
    /// Encoded/decoded by serializers as &quot;MEDI&quot;.
    /// </summary>
    [EnumMember(Value = "MEDI")]
    [IsoId("_o3PpCZxKEe-Jl6tBAvMHqA")]
    [Description(@"The requested media are not allowed for the service.")]
    InvalidMediaType = ResultDetailCode.InvalidMediaType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number of deposit transactions or items exceeds the limit.
    /// Encoded/decoded by serializers as &quot;NMBD&quot;.
    /// </summary>
    [EnumMember(Value = "NMBD")]
    [IsoId("_o3PobZxKEe-Jl6tBAvMHqA")]
    [Description(@"Number of deposit transactions or items exceeds the limit.")]
    DepositNumberLimit = ResultDetailCode.DepositNumberLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number of withdrawal transactions exceeds card limit.
    /// Encoded/decoded by serializers as &quot;NMBW&quot;.
    /// </summary>
    [EnumMember(Value = "NMBW")]
    [IsoId("_o3PpBZxKEe-Jl6tBAvMHqA")]
    [Description(@"Number of withdrawal transactions exceeds card limit.")]
    WithdrawalNumberLimit = ResultDetailCode.WithdrawalNumberLimit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Process not permitted to the acceptor (for example fall back).
    /// Encoded/decoded by serializers as &quot;NPRA&quot;.
    /// </summary>
    [EnumMember(Value = "NPRA")]
    [IsoId("_o3Pos5xKEe-Jl6tBAvMHqA")]
    [Description(@"Process not permitted to the acceptor (for example fall back).")]
    NotPermittedToAcceptor = ResultDetailCode.NotPermittedToAcceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction not permitted to the cardholder or the customer.
    /// Encoded/decoded by serializers as &quot;NPRC&quot;.
    /// </summary>
    [EnumMember(Value = "NPRC")]
    [IsoId("_o3PouZxKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction not permitted to the cardholder or the customer.")]
    NotPermittedToCardholder = ResultDetailCode.NotPermittedToCardholder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been processed offline by the terminal.
    /// Encoded/decoded by serializers as &quot;OFFL&quot;.
    /// </summary>
    [EnumMember(Value = "OFFL")]
    [IsoId("_o3PotZxKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction has been processed offline by the terminal.")]
    OffLineProcess = ResultDetailCode.OffLineProcess, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been processed offline after referral.
    /// Encoded/decoded by serializers as &quot;ONLP&quot;.
    /// </summary>
    [EnumMember(Value = "ONLP")]
    [IsoId("_o3Pot5xKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction has been processed offline after referral.")]
    OffLineProcessAfterReferral = ResultDetailCode.OffLineProcessAfterReferral, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction could not be processed as original is not found.
    /// Encoded/decoded by serializers as &quot;ORGF&quot;.
    /// </summary>
    [EnumMember(Value = "ORGF")]
    [IsoId("_o3Po8ZxKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction could not be processed as original is not found.")]
    UnableToFindOriginal = ResultDetailCode.UnableToFindOriginal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other error.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_o3PovZxKEe-Jl6tBAvMHqA")]
    [Description(@"Other error.")]
    OtherError = ResultDetailCode.OtherError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN could not be validated.
    /// Encoded/decoded by serializers as &quot;PINA&quot;.
    /// </summary>
    [EnumMember(Value = "PINA")]
    [IsoId("_o3PosZxKEe-Jl6tBAvMHqA")]
    [Description(@"PIN could not be validated.")]
    NotAbleToValidatePIN = ResultDetailCode.NotAbleToValidatePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder must change the PIN to be able to perform the transaction.
    /// Encoded/decoded by serializers as &quot;PINC&quot;.
    /// </summary>
    [EnumMember(Value = "PINC")]
    [IsoId("_o3Pow5xKEe-Jl6tBAvMHqA")]
    [Description(@"Cardholder must change the PIN to be able to perform the transaction.")]
    PINChangeRequired = ResultDetailCode.PINChangeRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Additional information are required to verify the PIN.
    /// Encoded/decoded by serializers as &quot;PIND&quot;.
    /// </summary>
    [EnumMember(Value = "PIND")]
    [IsoId("_o3PoxZxKEe-Jl6tBAvMHqA")]
    [Description(@"Additional information are required to verify the PIN.")]
    PINDataRequired = ResultDetailCode.PINDataRequired, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Decrypted PIN block is invalid.
    /// Encoded/decoded by serializers as &quot;PINE&quot;.
    /// </summary>
    [EnumMember(Value = "PINE")]
    [IsoId("_o3Poy5xKEe-Jl6tBAvMHqA")]
    [Description(@"Decrypted PIN block is invalid.")]
    PINEncryptionError = ResultDetailCode.PINEncryptionError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// New PIN is invalid (PIN change).
    /// Encoded/decoded by serializers as &quot;PINN&quot;.
    /// </summary>
    [EnumMember(Value = "PINN")]
    [IsoId("_o3Poq5xKEe-Jl6tBAvMHqA")]
    [Description(@"New PIN is invalid (PIN change).")]
    NewPINInvalid = ResultDetailCode.NewPINInvalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN length or PIN key is invalid.
    /// Encoded/decoded by serializers as &quot;PINS&quot;.
    /// </summary>
    [EnumMember(Value = "PINS")]
    [IsoId("_o3Pox5xKEe-Jl6tBAvMHqA")]
    [Description(@"PIN length or PIN key is invalid.")]
    PINSecurityError = ResultDetailCode.PINSecurityError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN is invalid.
    /// Encoded/decoded by serializers as &quot;PINV&quot;.
    /// </summary>
    [EnumMember(Value = "PINV")]
    [IsoId("_o3PoiZxKEe-Jl6tBAvMHqA")]
    [Description(@"PIN is invalid.")]
    InvalidPIN = ResultDetailCode.InvalidPIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Last attempt of the PIN verification fails.
    /// Encoded/decoded by serializers as &quot;PINX&quot;.
    /// </summary>
    [EnumMember(Value = "PINX")]
    [IsoId("_o3PoyZxKEe-Jl6tBAvMHqA")]
    [Description(@"Last attempt of the PIN verification fails.")]
    PINTriesExceeded = ResultDetailCode.PINTriesExceeded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Store and forward queue maximum exceeded.
    /// Encoded/decoded by serializers as &quot;QMAX&quot;.
    /// </summary>
    [EnumMember(Value = "QMAX")]
    [IsoId("_o3PozZxKEe-Jl6tBAvMHqA")]
    [Description(@"Store and forward queue maximum exceeded.")]
    QueueMaximumExceeded = ResultDetailCode.QueueMaximumExceeded, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Recurring Error on Data.
    /// Encoded/decoded by serializers as &quot;RECD&quot;.
    /// </summary>
    [EnumMember(Value = "RECD")]
    [IsoId("_o3Poz5xKEe-Jl6tBAvMHqA")]
    [Description(@"Recurring Error on Data.")]
    RecurringDataError = ResultDetailCode.RecurringDataError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Consumer must select an account from those provided to authorise the transaction. See &lt;Tx&gt;&lt;AcctInf&gt;.
    /// Encoded/decoded by serializers as &quot;SACT&quot;.
    /// </summary>
    [EnumMember(Value = "SACT")]
    [IsoId("_ZfF8waDjEe-MRKYsaX6JDg")]
    [Description(@"Consumer must select an account from those provided to authorise the transaction. See <Tx><AcctInf>.")]
    SelectAccount = ResultDetailCode.SelectAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram).
    /// Encoded/decoded by serializers as &quot;SECV&quot;.
    /// </summary>
    [EnumMember(Value = "SECV")]
    [IsoId("_o3Po05xKEe-Jl6tBAvMHqA")]
    [Description(@"Security violation, for instance invalid ARPC (Authorisation ResPonse Cryptogram).")]
    SecurityViolation = ResultDetailCode.SecurityViolation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message is out of sequence.
    /// Encoded/decoded by serializers as &quot;SEQO&quot;.
    /// </summary>
    [EnumMember(Value = "SEQO")]
    [IsoId("_o3PowZxKEe-Jl6tBAvMHqA")]
    [Description(@"Message is out of sequence.")]
    OutOfSequence = ResultDetailCode.OutOfSequence, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security software or hardware error.
    /// Encoded/decoded by serializers as &quot;SFWE&quot;.
    /// </summary>
    [EnumMember(Value = "SFWE")]
    [IsoId("_o3Po15xKEe-Jl6tBAvMHqA")]
    [Description(@"Security software or hardware error.")]
    SoftwareOrHardwareError = ResultDetailCode.SoftwareOrHardwareError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Signed message has an invalid signature.
    /// Encoded/decoded by serializers as &quot;SGNI&quot;.
    /// </summary>
    [EnumMember(Value = "SGNI")]
    [IsoId("_o3PojZxKEe-Jl6tBAvMHqA")]
    [Description(@"Signed message has an invalid signature.")]
    InvalidSignature = ResultDetailCode.InvalidSignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Special card conditions not respected.
    /// Encoded/decoded by serializers as &quot;SPCC&quot;.
    /// </summary>
    [EnumMember(Value = "SPCC")]
    [IsoId("_o3Po2ZxKEe-Jl6tBAvMHqA")]
    [Description(@"Special card conditions not respected.")]
    SpecialConditions = ResultDetailCode.SpecialConditions, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Surcharging is not permitted.
    /// Encoded/decoded by serializers as &quot;SRCH&quot;.
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_o3Po3ZxKEe-Jl6tBAvMHqA")]
    [Description(@"Surcharging is not permitted.")]
    SurchargeNotPermitted = ResultDetailCode.SurchargeNotPermitted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The requested service is not allowed.
    /// Encoded/decoded by serializers as &quot;SRVI&quot;.
    /// </summary>
    [EnumMember(Value = "SRVI")]
    [IsoId("_o3PpC5xKEe-Jl6tBAvMHqA")]
    [Description(@"The requested service is not allowed.")]
    InvalidService = ResultDetailCode.InvalidService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder or customer has not enabled the service with the service provider.
    /// Encoded/decoded by serializers as &quot;SRVU&quot;.
    /// </summary>
    [EnumMember(Value = "SRVU")]
    [IsoId("_o3Po1ZxKEe-Jl6tBAvMHqA")]
    [Description(@"Cardholder or customer has not enabled the service with the service provider.")]
    ServiceNotEnabled = ResultDetailCode.ServiceNotEnabled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Requested service not supported.
    /// Encoded/decoded by serializers as &quot;SVSU&quot;.
    /// </summary>
    [EnumMember(Value = "SVSU")]
    [IsoId("_o3Po_ZxKEe-Jl6tBAvMHqA")]
    [Description(@"Requested service not supported.")]
    UnsupportedService = ResultDetailCode.UnsupportedService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// System Malfunction.
    /// Encoded/decoded by serializers as &quot;SYSM&quot;.
    /// </summary>
    [EnumMember(Value = "SYSM")]
    [IsoId("_o3Po5ZxKEe-Jl6tBAvMHqA")]
    [Description(@"System Malfunction.")]
    SystemMalfunction = ResultDetailCode.SystemMalfunction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing temporary not available.
    /// Encoded/decoded by serializers as &quot;SYSP&quot;.
    /// </summary>
    [EnumMember(Value = "SYSP")]
    [IsoId("_o3Po45xKEe-Jl6tBAvMHqA")]
    [Description(@"Processing temporary not available.")]
    SystemInoperative = ResultDetailCode.SystemInoperative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification of the token provider or the token requestor is invalid.
    /// Encoded/decoded by serializers as &quot;TKID&quot;.
    /// </summary>
    [EnumMember(Value = "TKID")]
    [IsoId("_o3Poj5xKEe-Jl6tBAvMHqA")]
    [Description(@"Identification of the token provider or the token requestor is invalid.")]
    InvalidTokenIdentification = ResultDetailCode.InvalidTokenIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Token cannot be used to surrogate a PAN (Primary Account Number).
    /// Encoded/decoded by serializers as &quot;TKKO&quot;.
    /// </summary>
    [EnumMember(Value = "TKKO")]
    [IsoId("_o3Poi5xKEe-Jl6tBAvMHqA")]
    [Description(@"Token cannot be used to surrogate a PAN (Primary Account Number).")]
    InvalidToken = ResultDetailCode.InvalidToken, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Server received a terminal identification that it does not have any knowledge of.
    /// Encoded/decoded by serializers as &quot;TRMI&quot;.
    /// </summary>
    [EnumMember(Value = "TRMI")]
    [IsoId("_o3Po55xKEe-Jl6tBAvMHqA")]
    [Description(@"Server received a terminal identification that it does not have any knowledge of.")]
    TerminalNotConfigured = ResultDetailCode.TerminalNotConfigured, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Totals are not available.
    /// Encoded/decoded by serializers as &quot;TTLV&quot;.
    /// </summary>
    [EnumMember(Value = "TTLV")]
    [IsoId("_o3Po65xKEe-Jl6tBAvMHqA")]
    [Description(@"Totals are not available.")]
    TotalsNotAvailable = ResultDetailCode.TotalsNotAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction identification already used for another transaction.
    /// Encoded/decoded by serializers as &quot;TXND&quot;.
    /// </summary>
    [EnumMember(Value = "TXND")]
    [IsoId("_o3Po75xKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction identification already used for another transaction.")]
    TransactionDuplicate = ResultDetailCode.TransactionDuplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original request is in progress.
    /// Encoded/decoded by serializers as &quot;TXNG&quot;.
    /// </summary>
    [EnumMember(Value = "TXNG")]
    [IsoId("_o3PodZxKEe-Jl6tBAvMHqA")]
    [Description(@"Original request is in progress.")]
    InProgress = ResultDetailCode.InProgress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Validity period of the transaction is exceeded.
    /// Encoded/decoded by serializers as &quot;TXNL&quot;.
    /// </summary>
    [EnumMember(Value = "TXNL")]
    [IsoId("_o3PoaZxKEe-Jl6tBAvMHqA")]
    [Description(@"Validity period of the transaction is exceeded.")]
    ExceededTransactionLifeCycle = ResultDetailCode.ExceededTransactionLifeCycle, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Original is found, but transaction does not match.
    /// Encoded/decoded by serializers as &quot;TXNM&quot;.
    /// </summary>
    [EnumMember(Value = "TXNM")]
    [IsoId("_o3Pou5xKEe-Jl6tBAvMHqA")]
    [Description(@"Original is found, but transaction does not match.")]
    OriginalDoesNotMatch = ResultDetailCode.OriginalDoesNotMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction did not complete at the terminal.
    /// Encoded/decoded by serializers as &quot;TXNU&quot;.
    /// </summary>
    [EnumMember(Value = "TXNU")]
    [IsoId("_o3Po7ZxKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction did not complete at the terminal.")]
    TransactionDidNotComplete = ResultDetailCode.TransactionDidNotComplete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is invalid.
    /// Encoded/decoded by serializers as &quot;TXNV&quot;.
    /// </summary>
    [EnumMember(Value = "TXNV")]
    [IsoId("_o3PokZxKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction is invalid.")]
    InvalidTransaction = ResultDetailCode.InvalidTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Currency is unacceptable for the Issuer or the processor.
    /// Encoded/decoded by serializers as &quot;UNBC&quot;.
    /// </summary>
    [EnumMember(Value = "UNBC")]
    [IsoId("_o3Po95xKEe-Jl6tBAvMHqA")]
    [Description(@"Currency is unacceptable for the Issuer or the processor.")]
    UnacceptableCurrency = ResultDetailCode.UnacceptableCurrency, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction cannot be processed online by the terminal.
    /// Encoded/decoded by serializers as &quot;UNBO&quot;.
    /// </summary>
    [EnumMember(Value = "UNBO")]
    [IsoId("_o3Po85xKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction cannot be processed online by the terminal.")]
    UnableToGoOnLine = ResultDetailCode.UnableToGoOnLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction cannot be processed offline.
    /// Encoded/decoded by serializers as &quot;UNBP&quot;.
    /// </summary>
    [EnumMember(Value = "UNBP")]
    [IsoId("_o3Po9ZxKEe-Jl6tBAvMHqA")]
    [Description(@"Transaction cannot be processed offline.")]
    UnableToProcessOffLine = ResultDetailCode.UnableToProcessOffLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vendor not found.
    /// Encoded/decoded by serializers as &quot;VNDF&quot;.
    /// </summary>
    [EnumMember(Value = "VNDF")]
    [IsoId("_o3PpAZxKEe-Jl6tBAvMHqA")]
    [Description(@"Vendor not found.")]
    VendorNotFound = ResultDetailCode.VendorNotFound, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vendor format has an error.
    /// Encoded/decoded by serializers as &quot;VNDR&quot;.
    /// </summary>
    [EnumMember(Value = "VNDR")]
    [IsoId("_o3Po_5xKEe-Jl6tBAvMHqA")]
    [Description(@"Vendor format has an error.")]
    VendorFormatError = ResultDetailCode.VendorFormatError, // same ordinal as derivation source for type conversions
}
