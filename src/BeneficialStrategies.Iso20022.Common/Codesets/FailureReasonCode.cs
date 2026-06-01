// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of incidents happening during the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUmCFQEcEeCQm6a_G2yO_w_-1240682578")]
[Description(@"List of incidents happening during the transaction.")]
[Derivations(
    typeof(FailureReason7Code),
    typeof(FailureReason1Code),
    typeof(FailureReason8Code),
    typeof(FailureReason2Code),
    typeof(FailureReason4Code),
    typeof(FailureReason6Code),
    typeof(FailureReason3Code),
    typeof(FailureReason5Code)
)]
[JsonConverter(typeof(Iso20022EnumJsonConverter<FailureReasonCode>))]
public enum FailureReasonCode
{
    /// <summary>
    /// Customer cancellation, for example removing the card before the end of the transaction.
    /// Encoded/decoded by serializers as &quot;CUCL&quot;.
    /// </summary>
    [EnumMember(Value = "CUCL")]
    [IsoId("_TUmCFgEcEeCQm6a_G2yO_w_737172254")]
    [Description(
        @"Customer cancellation, for example removing the card before the end of the transaction."
    )]
    CustomerCancel,

    /// <summary>
    /// Suspected malfunction.
    /// Encoded/decoded by serializers as &quot;MALF&quot;.
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_TUmCFwEcEeCQm6a_G2yO_w_-1726871873")]
    [Description(@"Suspected malfunction.")]
    Malfunction,

    /// <summary>
    /// Completed partially.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_TUmCGAEcEeCQm6a_G2yO_w_-966106720")]
    [Description(@"Completed partially.")]
    Partial,

    /// <summary>
    /// Response to the previous message was received too late.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_TUmCGQEcEeCQm6a_G2yO_w_-512019451")]
    [Description(@"Response to the previous message was received too late.")]
    TooLateResponse,

    /// <summary>
    /// Unable to complete the transaction after the authorisation response.
    /// Encoded/decoded by serializers as &quot;UCMP&quot;.
    /// </summary>
    [EnumMember(Value = "UCMP")]
    [IsoId("_TUmCGgEcEeCQm6a_G2yO_w_2011152748")]
    [Description(@"Unable to complete the transaction after the authorisation response.")]
    UnableToComplete,

    /// <summary>
    /// Unable to deliver the request message to the recipient party.
    /// Encoded/decoded by serializers as &quot;USND&quot;.
    /// </summary>
    [EnumMember(Value = "USND")]
    [IsoId("_TUmCGwEcEeCQm6a_G2yO_w_-2009869983")]
    [Description(@"Unable to deliver the request message to the recipient party.")]
    UnableToSend,

    /// <summary>
    /// Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).
    /// Encoded/decoded by serializers as &quot;TIMO&quot;.
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_TUmCHAEcEeCQm6a_G2yO_w_-2020968760")]
    [Description(
        @"Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response)."
    )]
    TimeOut,

    /// <summary>
    /// Integrated circuit card declines the transaction before or after the authorisation.
    /// Encoded/decoded by serializers as &quot;CDCL&quot;.
    /// </summary>
    [EnumMember(Value = "CDCL")]
    [IsoId("_TUmCHQEcEeCQm6a_G2yO_w_-1695851253")]
    [Description(
        @"Integrated circuit card declines the transaction before or after the authorisation."
    )]
    CardDeclined,

    /// <summary>
    /// Online authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;NDCL&quot;.
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_TUmCHgEcEeCQm6a_G2yO_w_617410472")]
    [Description(@"Online authorisation declined the transaction.")]
    OnLineDeclined,

    /// <summary>
    /// Offline authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;FDCL&quot;.
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_TUmCHwEcEeCQm6a_G2yO_w_606311695")]
    [Description(@"Offline authorisation declined the transaction.")]
    OfflineDeclined,

    /// <summary>
    /// Card payment transaction fails because the merchant suspect a fraud.
    /// Encoded/decoded by serializers as &quot;SFRD&quot;.
    /// </summary>
    [EnumMember(Value = "SFRD")]
    [IsoId("_sPZjEL4pEeKkGaJ0UrThyA_-1482930014")]
    [Description(@"Card payment transaction fails because the merchant suspect a fraud.")]
    SuspectedFraud,

    /// <summary>
    /// Security error has occurred in the authorisation response message sent by the acquirer.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_KurLEDG8EeOH78pE3LSlGw")]
    [Description(
        @"Security error has occurred in the authorisation response message sent by the acquirer."
    )]
    SecurityError,

    /// <summary>
    /// ATM manager has requested to capture the card.
    /// Encoded/decoded by serializers as &quot;CDCP&quot;.
    /// </summary>
    [EnumMember(Value = "CDCP")]
    [IsoId("_Yn_dUIqTEeSRT5rEzcAHEw")]
    [Description(@"ATM manager has requested to capture the card.")]
    CardCaptured,

    /// <summary>
    /// Unable to complete transaction with the card.
    /// Encoded/decoded by serializers as &quot;CDER&quot;.
    /// </summary>
    [EnumMember(Value = "CDER")]
    [IsoId("_cmzcQIqTEeSRT5rEzcAHEw")]
    [Description(@"Unable to complete transaction with the card.")]
    CardError,

    /// <summary>
    /// Customer has declined additional fees or a lower amount, transaction fails.
    /// Encoded/decoded by serializers as &quot;CUDC&quot;.
    /// </summary>
    [EnumMember(Value = "CUDC")]
    [IsoId("_gQT5kIqTEeSRT5rEzcAHEw")]
    [Description(@"Customer has declined additional fees or a lower amount, transaction fails.")]
    CustomerDecline,

    /// <summary>
    /// Customer has left the card in the ATM or a motorised card reader.
    /// Encoded/decoded by serializers as &quot;CDFG&quot;.
    /// </summary>
    [EnumMember(Value = "CDFG")]
    [IsoId("_jtJM0IqTEeSRT5rEzcAHEw")]
    [Description(@"Customer has left the card in the ATM or a motorised card reader.")]
    ForgottenCard,

    /// <summary>
    /// Unable to fulfil, for instance dispensing the cash.
    /// Encoded/decoded by serializers as &quot;FILL&quot;.
    /// </summary>
    [EnumMember(Value = "FILL")]
    [IsoId("_lvYxYIqTEeSRT5rEzcAHEw")]
    [Description(@"Unable to fulfil, for instance dispensing the cash.")]
    FullfilmentError,

    /// <summary>
    /// ATM manager has requested to the ATM to stop customer services.
    /// Encoded/decoded by serializers as &quot;CSRV&quot;.
    /// </summary>
    [EnumMember(Value = "CSRV")]
    [IsoId("_o1m7cIqTEeSRT5rEzcAHEw")]
    [Description(@"ATM manager has requested to the ATM to stop customer services.")]
    OutOfCustomerService,

    /// <summary>
    /// Unable to capture the card as requested.
    /// Encoded/decoded by serializers as &quot;UCPT&quot;.
    /// </summary>
    [EnumMember(Value = "UCPT")]
    [IsoId("_rKquUIqTEeSRT5rEzcAHEw")]
    [Description(@"Unable to capture the card as requested.")]
    UnableToCapture,

    /// <summary>
    /// General security error.
    /// Encoded/decoded by serializers as &quot;SECR&quot;.
    /// </summary>
    [EnumMember(Value = "SECR")]
    [IsoId("_t-sSgIr-EeSvuOJS0mmL0g")]
    [Description(@"General security error.")]
    Security,

    /// <summary>
    /// Hardware error on the device.
    /// Encoded/decoded by serializers as &quot;HRDW&quot;.
    /// </summary>
    [EnumMember(Value = "HRDW")]
    [IsoId("_6uC6AIr-EeSvuOJS0mmL0g")]
    [Description(@"Hardware error on the device.")]
    Hardware,

    /// <summary>
    /// Key is compromised.
    /// Encoded/decoded by serializers as &quot;CMPR&quot;.
    /// </summary>
    [EnumMember(Value = "CMPR")]
    [IsoId("_brHAEItDEeSxlKlAGYErFg")]
    [Description(@"Key is compromised.")]
    Compromised,

    /// <summary>
    /// Key has expired.
    /// Encoded/decoded by serializers as &quot;EXPR&quot;.
    /// </summary>
    [EnumMember(Value = "EXPR")]
    [IsoId("_jBjCIItDEeSxlKlAGYErFg")]
    [Description(@"Key has expired.")]
    Expired,

    /// <summary>
    /// Key check value is incorrect.
    /// Encoded/decoded by serializers as &quot;KCVE&quot;.
    /// </summary>
    [EnumMember(Value = "KCVE")]
    [IsoId("_nP21oItDEeSxlKlAGYErFg")]
    [Description(@"Key check value is incorrect.")]
    InvalidKCV,

    /// <summary>
    /// Error during the key download in the security device.
    /// Encoded/decoded by serializers as &quot;KLOD&quot;.
    /// </summary>
    [EnumMember(Value = "KLOD")]
    [IsoId("_s-4N8ItDEeSxlKlAGYErFg")]
    [Description(@"Error during the key download in the security device.")]
    KeyLoadError,

    /// <summary>
    /// Card has been retained by the ATM or the terminal.
    /// Encoded/decoded by serializers as &quot;CDRT&quot;.
    /// </summary>
    [EnumMember(Value = "CDRT")]
    [IsoId("_gjrA8K4LEeWZgJQOa6iKCQ")]
    [Description(@"Card has been retained by the ATM or the terminal.")]
    CardRetained,

    /// <summary>
    /// Customer has not been performed in time an action.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_l1L94K4LEeWZgJQOa6iKCQ")]
    [Description(@"Customer has not been performed in time an action.")]
    CustomerTimeOut,

    /// <summary>
    /// Following a cash dispense operation the consumer forgot to take the returned notes, which have subsequently been retracted following a Present time-out. The number of notes retracted is known as the device was able to count the notes retracted.
    /// Encoded/decoded by serializers as &quot;CFGC&quot;.
    /// </summary>
    [EnumMember(Value = "CFGC")]
    [IsoId("_AxkK4Jw0Ee--557UVrMuSQ")]
    [Description(@"Following a cash dispense operation the consumer forgot to take the returned notes, which have subsequently been retracted following a Present time-out. The number of notes retracted is known as the device was able to count the notes retracted.")]
    CashDispenserRetractCounted,

    /// <summary>
    /// Following a cash dispense operation the consumer forgot to take the notes, which have subsequently been retracted following a Present time-out. The number of notes retracted is unknown.
    /// Encoded/decoded by serializers as &quot;CHFG&quot;.
    /// </summary>
    [EnumMember(Value = "CHFG")]
    [IsoId("_0EOVkJwzEe--557UVrMuSQ")]
    [Description(@"Following a cash dispense operation the consumer forgot to take the notes, which have subsequently been retracted following a Present time-out. The number of notes retracted is unknown.")]
    CashDispenserRetract,

    /// <summary>
    /// Following cheques being returned, on a cheque deposit operation, the consumer forgot to take the returned cheques, causing them to be retracted. The number of cheques retracted is unknown.
    /// Encoded/decoded by serializers as &quot;CQFG&quot;.
    /// </summary>
    [EnumMember(Value = "CQFG")]
    [IsoId("_8hI3gJwzEe--557UVrMuSQ")]
    [Description(@"Following cheques being returned, on a cheque deposit operation, the consumer forgot to take the returned cheques, causing them to be retracted. The number of cheques retracted is unknown.")]
    ChequeDepositRetract,

    /// <summary>
    /// Cheques have been retained by the terminal since it has been unable to return them.
    /// Encoded/decoded by serializers as &quot;CQRT&quot;.
    /// </summary>
    [EnumMember(Value = "CQRT")]
    [IsoId("_RpaRwJw0Ee--557UVrMuSQ")]
    [Description(@"Cheques have been retained by the terminal since it has been unable to return them.")]
    ChequesRetained,

    /// <summary>
    /// Following a cash return, on a deposit operation, the consumer forgot to take the returned notes, causing them to be retracted. The number of notes retracted is unknown.
    /// Encoded/decoded by serializers as &quot;DCFG&quot;.
    /// </summary>
    [EnumMember(Value = "DCFG")]
    [IsoId("_4Sqr8JwzEe--557UVrMuSQ")]
    [Description(@"Following a cash return, on a deposit operation, the consumer forgot to take the returned notes, causing them to be retracted. The number of notes retracted is unknown.")]
    CashDepositRetract,

    /// <summary>
    /// Cash has been retained by the terminal since it has been unable to return it.
    /// Encoded/decoded by serializers as &quot;DCRT&quot;.
    /// </summary>
    [EnumMember(Value = "DCRT")]
    [IsoId("_Na8tQJw0Ee--557UVrMuSQ")]
    [Description(@"Cash has been retained by the terminal since it has been unable to return it.")]
    DepositsRetained,

    /// <summary>
    /// Following a cash return, on a deposit operation, the consumer forgot to take the returned notes, causing them to be retracted. The number of notes retracted is known as the device was able to count the notes retracted.
    /// Encoded/decoded by serializers as &quot;DFGC&quot;.
    /// </summary>
    [EnumMember(Value = "DFGC")]
    [IsoId("_E-CyYJw0Ee--557UVrMuSQ")]
    [Description(@"Following a cash return, on a deposit operation, the consumer forgot to take the returned notes, causing them to be retracted. The number of notes retracted is known as the device was able to count the notes retracted.")]
    CashDepositRetractCounted,

    /// <summary>
    /// The ATM Manager has sent a response message in response to an authorisation request where some of its required elements were badly formatted (for example an integer value where a dateTime value was expected).
    /// Encoded/decoded by serializers as &quot;FMTE&quot;.
    /// </summary>
    [EnumMember(Value = "FMTE")]
    [IsoId("_rnR-cJwzEe--557UVrMuSQ")]
    [Description(@"The ATM Manager has sent a response message in response to an authorisation request where some of its required elements were badly formatted (for example an integer value where a dateTime value was expected).")]
    FormatError,

    /// <summary>
    /// Following cheques being returned, on a cheque deposit operation, the consumer forgot to take the returned cheques, causing them to be retracted. The number of cheques retracted is known as the device was able to count the cheques retracted.
    /// Encoded/decoded by serializers as &quot;QFGC&quot;.
    /// </summary>
    [EnumMember(Value = "QFGC")]
    [IsoId("_JMgW4Jw0Ee--557UVrMuSQ")]
    [Description(@"Following cheques being returned, on a cheque deposit operation, the consumer forgot to take the returned cheques, causing them to be retracted. The number of cheques retracted is known as the device was able to count the cheques retracted.")]
    ChequeDepositRetractCounted,

    /// <summary>
    /// The ATM Manager has sent an ATMReject message in response to an authorisation request.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_nY2PIJwzEe--557UVrMuSQ")]
    [Description(@"The ATM Manager has sent an ATMReject message in response to an authorisation request.")]
    Reject,

    /// <summary>
    /// The ATM has restarted.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_6l7UUKjyEe--FqfI7l8ySw")]
    [Description(@"The ATM has restarted.")]
    Restart,

    /// <summary>
    /// The ATM Manager has sent a response message in response to an authorisation request where some of its required elements were invalid (for example an incorrect ExchangeIdentifier).
    /// Encoded/decoded by serializers as &quot;VLTE&quot;.
    /// </summary>
    [EnumMember(Value = "VLTE")]
    [IsoId("_v1vi8JwzEe--557UVrMuSQ")]
    [Description(@"The ATM Manager has sent a response message in response to an authorisation request where some of its required elements were invalid (for example an incorrect ExchangeIdentifier).")]
    ValidationError,
}
