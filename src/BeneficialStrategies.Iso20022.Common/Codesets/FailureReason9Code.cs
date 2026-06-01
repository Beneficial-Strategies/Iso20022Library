// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Incident occurring during the processing of an ATM transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3AtkwZxHEe-Jl6tBAvMHqA")]
[Description(@"Incident occurring during the processing of an ATM transaction.")]
[DerivedFrom(typeof(FailureReasonCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<FailureReason9Code>))]
public enum FailureReason9Code
{
    /// <summary>
    /// Integrated circuit card declines the transaction before or after the authorisation.
    /// Encoded/decoded by serializers as &quot;CDCL&quot;.
    /// </summary>
    [EnumMember(Value = "CDCL")]
    [IsoId("_3BpY45xHEe-Jl6tBAvMHqA")]
    [Description(@"Integrated circuit card declines the transaction before or after the authorisation.")]
    CardDeclined = FailureReasonCode.CardDeclined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ATM manager has requested to capture the card.
    /// Encoded/decoded by serializers as &quot;CDCP&quot;.
    /// </summary>
    [EnumMember(Value = "CDCP")]
    [IsoId("_3BpY4ZxHEe-Jl6tBAvMHqA")]
    [Description(@"ATM manager has requested to capture the card.")]
    CardCaptured = FailureReasonCode.CardCaptured, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unable to complete transaction with the card.
    /// Encoded/decoded by serializers as &quot;CDER&quot;.
    /// </summary>
    [EnumMember(Value = "CDER")]
    [IsoId("_3BpY5ZxHEe-Jl6tBAvMHqA")]
    [Description(@"Unable to complete transaction with the card.")]
    CardError = FailureReasonCode.CardError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer has left the card in the ATM or a motorised card reader.
    /// Encoded/decoded by serializers as &quot;CDFG&quot;.
    /// </summary>
    [EnumMember(Value = "CDFG")]
    [IsoId("_3BpY65xHEe-Jl6tBAvMHqA")]
    [Description(@"Customer has left the card in the ATM or a motorised card reader.")]
    ForgottenCard = FailureReasonCode.ForgottenCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card has been retained by the ATM or the terminal.
    /// Encoded/decoded by serializers as &quot;CDRT&quot;.
    /// </summary>
    [EnumMember(Value = "CDRT")]
    [IsoId("_3BpZA5xHEe-Jl6tBAvMHqA")]
    [Description(@"Card has been retained by the ATM or the terminal.")]
    CardRetained = FailureReasonCode.CardRetained, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Following a cash dispense operation the consumer forgot to take the returned notes, which have subsequently been retracted following a Present time-out. The number of notes retracted is known as the device was able to count the notes retracted.
    /// Encoded/decoded by serializers as &quot;CFGC&quot;.
    /// </summary>
    [EnumMember(Value = "CFGC")]
    [IsoId("_7FhBIaDgEe-MRKYsaX6JDg")]
    [Description(@"Following a cash dispense operation the consumer forgot to take the returned notes, which have subsequently been retracted following a Present time-out. The number of notes retracted is known as the device was able to count the notes retracted.")]
    CashDispenserRetractCounted = FailureReasonCode.CashDispenserRetractCounted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Following a cash dispense operation the consumer forgot to take the notes, which have subsequently been retracted following a Present time-out. The number of notes retracted is unknown.
    /// Encoded/decoded by serializers as &quot;CHFG&quot;.
    /// </summary>
    [EnumMember(Value = "CHFG")]
    [IsoId("_2lWooaDgEe-MRKYsaX6JDg")]
    [Description(@"Following a cash dispense operation the consumer forgot to take the notes, which have subsequently been retracted following a Present time-out. The number of notes retracted is unknown.")]
    CashDispenserRetract = FailureReasonCode.CashDispenserRetract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Following cheques being returned, on a cheque deposit operation, the consumer forgot to take the returned cheques, causing them to be retracted. The number of cheques retracted is unknown.
    /// Encoded/decoded by serializers as &quot;CQFG&quot;.
    /// </summary>
    [EnumMember(Value = "CQFG")]
    [IsoId("_4CqUIaDgEe-MRKYsaX6JDg")]
    [Description(@"Following cheques being returned, on a cheque deposit operation, the consumer forgot to take the returned cheques, causing them to be retracted. The number of cheques retracted is unknown.")]
    ChequeDepositRetract = FailureReasonCode.ChequeDepositRetract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cheques have been retained by the terminal since it has been unable to return them.
    /// Encoded/decoded by serializers as &quot;CQRT&quot;.
    /// </summary>
    [EnumMember(Value = "CQRT")]
    [IsoId("_8fUssaDgEe-MRKYsaX6JDg")]
    [Description(@"Cheques have been retained by the terminal since it has been unable to return them.")]
    ChequesRetained = FailureReasonCode.ChequesRetained, // same ordinal as derivation source for type conversions

    /// <summary>
    /// ATM manager has requested to the ATM to stop customer services.
    /// Encoded/decoded by serializers as &quot;CSRV&quot;.
    /// </summary>
    [EnumMember(Value = "CSRV")]
    [IsoId("_3BpZAZxHEe-Jl6tBAvMHqA")]
    [Description(@"ATM manager has requested to the ATM to stop customer services.")]
    OutOfCustomerService = FailureReasonCode.OutOfCustomerService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer cancellation, for example removing the card before the end of the transaction.
    /// Encoded/decoded by serializers as &quot;CUCL&quot;.
    /// </summary>
    [EnumMember(Value = "CUCL")]
    [IsoId("_3BpY55xHEe-Jl6tBAvMHqA")]
    [Description(@"Customer cancellation, for example removing the card before the end of the transaction.")]
    CustomerCancel = FailureReasonCode.CustomerCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer has declined additional fees or a lower amount, transaction fails.
    /// Encoded/decoded by serializers as &quot;CUDC&quot;.
    /// </summary>
    [EnumMember(Value = "CUDC")]
    [IsoId("_3BpY6ZxHEe-Jl6tBAvMHqA")]
    [Description(@"Customer has declined additional fees or a lower amount, transaction fails.")]
    CustomerDecline = FailureReasonCode.CustomerDecline, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer has not been performed in time an action.
    /// Encoded/decoded by serializers as &quot;CUTO&quot;.
    /// </summary>
    [EnumMember(Value = "CUTO")]
    [IsoId("_3BpZBZxHEe-Jl6tBAvMHqA")]
    [Description(@"Customer has not been performed in time an action.")]
    CustomerTimeOut = FailureReasonCode.CustomerTimeOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Following a cash return, on a deposit operation, the consumer forgot to take the returned notes, causing them to be retracted. The number of notes retracted is unknown.
    /// Encoded/decoded by serializers as &quot;DCFG&quot;.
    /// </summary>
    [EnumMember(Value = "DCFG")]
    [IsoId("_3UzvoaDgEe-MRKYsaX6JDg")]
    [Description(@"Following a cash return, on a deposit operation, the consumer forgot to take the returned notes, causing them to be retracted. The number of notes retracted is unknown.")]
    CashDepositRetract = FailureReasonCode.CashDepositRetract, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash has been retained by the terminal since it has been unable to return it.
    /// Encoded/decoded by serializers as &quot;DCRT&quot;.
    /// </summary>
    [EnumMember(Value = "DCRT")]
    [IsoId("_8yYyoaDgEe-MRKYsaX6JDg")]
    [Description(@"Cash has been retained by the terminal since it has been unable to return it.")]
    DepositsRetained = FailureReasonCode.DepositsRetained, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Following a cash return, on a deposit operation, the consumer forgot to take the returned notes, causing them to be retracted. The number of notes retracted is known as the device was able to count the notes retracted.
    /// Encoded/decoded by serializers as &quot;DFGC&quot;.
    /// </summary>
    [EnumMember(Value = "DFGC")]
    [IsoId("_6MfucaDgEe-MRKYsaX6JDg")]
    [Description(@"Following a cash return, on a deposit operation, the consumer forgot to take the returned notes, causing them to be retracted. The number of notes retracted is known as the device was able to count the notes retracted.")]
    CashDepositRetractCounted = FailureReasonCode.CashDepositRetractCounted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unable to fulfil, for instance dispensing the cash.
    /// Encoded/decoded by serializers as &quot;FILL&quot;.
    /// </summary>
    [EnumMember(Value = "FILL")]
    [IsoId("_3BpY7ZxHEe-Jl6tBAvMHqA")]
    [Description(@"Unable to fulfil, for instance dispensing the cash.")]
    FullfilmentError = FailureReasonCode.FullfilmentError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The ATM Manager has sent a response message in response to an authorisation request where some of its required elements were badly formatted (for example an integer value where a dateTime value was expected).
    /// Encoded/decoded by serializers as &quot;FMTE&quot;.
    /// </summary>
    [EnumMember(Value = "FMTE")]
    [IsoId("_1A060aDgEe-MRKYsaX6JDg")]
    [Description(@"The ATM Manager has sent a response message in response to an authorisation request where some of its required elements were badly formatted (for example an integer value where a dateTime value was expected).")]
    FormatError = FailureReasonCode.FormatError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response to the previous message was received too late.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_3BpY-ZxHEe-Jl6tBAvMHqA")]
    [Description(@"Response to the previous message was received too late.")]
    TooLateResponse = FailureReasonCode.TooLateResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Suspected malfunction.
    /// Encoded/decoded by serializers as &quot;MALF&quot;.
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_3BpY75xHEe-Jl6tBAvMHqA")]
    [Description(@"Suspected malfunction.")]
    Malfunction = FailureReasonCode.Malfunction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Online authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;NDCL&quot;.
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_3BpY8ZxHEe-Jl6tBAvMHqA")]
    [Description(@"Online authorisation declined the transaction.")]
    OnLineDeclined = FailureReasonCode.OnLineDeclined, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Following cheques being returned, on a cheque deposit operation, the consumer forgot to take the returned cheques, causing them to be retracted. The number of cheques retracted is known as the device was able to count the cheques retracted.
    /// Encoded/decoded by serializers as &quot;QFGC&quot;.
    /// </summary>
    [EnumMember(Value = "QFGC")]
    [IsoId("_7iOLQaDgEe-MRKYsaX6JDg")]
    [Description(@"Following cheques being returned, on a cheque deposit operation, the consumer forgot to take the returned cheques, causing them to be retracted. The number of cheques retracted is known as the device was able to count the cheques retracted.")]
    ChequeDepositRetractCounted = FailureReasonCode.ChequeDepositRetractCounted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The ATM Manager has sent an ATMReject message in response to an authorisation request.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_0flO8aDgEe-MRKYsaX6JDg")]
    [Description(@"The ATM Manager has sent an ATMReject message in response to an authorisation request.")]
    Reject = FailureReasonCode.Reject, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The ATM has restarted.
    /// Encoded/decoded by serializers as &quot;RSTR&quot;.
    /// </summary>
    [EnumMember(Value = "RSTR")]
    [IsoId("_9x79UajyEe--FqfI7l8ySw")]
    [Description(@"The ATM has restarted.")]
    Restart = FailureReasonCode.Restart, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Security error has occurred in the authorisation response message sent by the acquirer.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_3BpY85xHEe-Jl6tBAvMHqA")]
    [Description(@"Security error has occurred in the authorisation response message sent by the acquirer.")]
    SecurityError = FailureReasonCode.SecurityError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card payment transaction fails because the merchant suspect a fraud.
    /// Encoded/decoded by serializers as &quot;SFRD&quot;.
    /// </summary>
    [EnumMember(Value = "SFRD")]
    [IsoId("_3BpY9ZxHEe-Jl6tBAvMHqA")]
    [Description(@"Card payment transaction fails because the merchant suspect a fraud.")]
    SuspectedFraud = FailureReasonCode.SuspectedFraud, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).
    /// Encoded/decoded by serializers as &quot;TIMO&quot;.
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_3BpY95xHEe-Jl6tBAvMHqA")]
    [Description(@"Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).")]
    TimeOut = FailureReasonCode.TimeOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unable to complete the transaction after the authorisation response.
    /// Encoded/decoded by serializers as &quot;UCMP&quot;.
    /// </summary>
    [EnumMember(Value = "UCMP")]
    [IsoId("_3BpY_ZxHEe-Jl6tBAvMHqA")]
    [Description(@"Unable to complete the transaction after the authorisation response.")]
    UnableToComplete = FailureReasonCode.UnableToComplete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unable to capture the card as requested.
    /// Encoded/decoded by serializers as &quot;UCPT&quot;.
    /// </summary>
    [EnumMember(Value = "UCPT")]
    [IsoId("_3BpY-5xHEe-Jl6tBAvMHqA")]
    [Description(@"Unable to capture the card as requested.")]
    UnableToCapture = FailureReasonCode.UnableToCapture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unable to deliver the request message to the recipient party.
    /// Encoded/decoded by serializers as &quot;USND&quot;.
    /// </summary>
    [EnumMember(Value = "USND")]
    [IsoId("_3BpY_5xHEe-Jl6tBAvMHqA")]
    [Description(@"Unable to deliver the request message to the recipient party.")]
    UnableToSend = FailureReasonCode.UnableToSend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The ATM Manager has sent a response message in response to an authorisation request where some of its required elements were invalid (for example an incorrect ExchangeIdentifier).
    /// Encoded/decoded by serializers as &quot;VLTE&quot;.
    /// </summary>
    [EnumMember(Value = "VLTE")]
    [IsoId("_1mvEQaDgEe-MRKYsaX6JDg")]
    [Description(@"The ATM Manager has sent a response message in response to an authorisation request where some of its required elements were invalid (for example an incorrect ExchangeIdentifier).")]
    ValidationError = FailureReasonCode.ValidationError, // same ordinal as derivation source for type conversions
}
