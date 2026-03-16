// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the payment instrument used or the underlying financial transaction that resulted in a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zcHKoA93EeGeV5vP7Mvdig_-1294352289")]
[Description(
    @"Specifies the payment instrument used or the underlying financial transaction that resulted in a payment transaction."
)]
[DerivedFrom(typeof(PaymentInstrumentCode))]
public enum PaymentInstrument1Code
{
    /// <summary>
    /// Direct debit instruction in which the debtor and the creditor are financial institutions.
    /// Encoded/decoded by serializers as &quot;BDT&quot;.
    /// </summary>
    [EnumMember(Value = "BDT")]
    [IsoId("_zcHKoQ93EeGeV5vP7Mvdig_1028186806")]
    [Description(
        @"Direct debit instruction in which the debtor and the creditor are financial institutions."
    )]
    BankDebitTransfer = PaymentInstrumentCode.BankDebitTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds transfer in which the debtor and the creditor are financial institutions.
    /// Encoded/decoded by serializers as &quot;BCT&quot;.
    /// </summary>
    [EnumMember(Value = "BCT")]
    [IsoId("_zcHKog93EeGeV5vP7Mvdig_914347740")]
    [Description(
        @"Funds transfer in which the debtor and the creditor are financial institutions."
    )]
    BankCreditTransfer = PaymentInstrumentCode.BankCreditTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct debit instruction in which the debtor or the creditor or both are non-financial institutions.
    /// Encoded/decoded by serializers as &quot;CDT&quot;.
    /// </summary>
    [EnumMember(Value = "CDT")]
    [IsoId("_zcHKow93EeGeV5vP7Mvdig_1788951959")]
    [Description(
        @"Direct debit instruction in which the debtor or the creditor or both are non-financial institutions."
    )]
    CustomerDebitTransfer = PaymentInstrumentCode.CustomerDebitTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Funds transfer in which the debtor or the creditor or both are non-financial institutions.
    /// Encoded/decoded by serializers as &quot;CCT&quot;.
    /// </summary>
    [EnumMember(Value = "CCT")]
    [IsoId("_zcHKpA93EeGeV5vP7Mvdig_2114069466")]
    [Description(
        @"Funds transfer in which the debtor or the creditor or both are non-financial institutions."
    )]
    CustomerCreditTransfer = PaymentInstrumentCode.CustomerCreditTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment instrument is a cheque. (A written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee)).
    /// Encoded/decoded by serializers as &quot;CHK&quot;.
    /// </summary>
    [EnumMember(Value = "CHK")]
    [IsoId("_zcHKpQ93EeGeV5vP7Mvdig_-221004899")]
    [Description(
        @"Payment instrument is a cheque. (A written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee))."
    )]
    Cheque = PaymentInstrumentCode.Cheque, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transfer that is a movement of cash on the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;BKT&quot;.
    /// </summary>
    [EnumMember(Value = "BKT")]
    [IsoId("_zcHKpg93EeGeV5vP7Mvdig_104112608")]
    [Description(@"Transfer that is a movement of cash on the books of the account servicer.")]
    BookTransfer = PaymentInstrumentCode.BookTransfer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment instrument is a debit card. (The payment originated using a debit card scheme.).
    /// Encoded/decoded by serializers as &quot;DCP&quot;.
    /// </summary>
    [EnumMember(Value = "DCP")]
    [IsoId("_zcQUkA93EeGeV5vP7Mvdig_1182132946")]
    [Description(
        @"Payment instrument is a debit card. (The payment originated using a debit card scheme.)."
    )]
    DebitCardPayment = PaymentInstrumentCode.DebitCardPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment instrument is a credit card. (The payment originated using a credit card scheme.).
    /// Encoded/decoded by serializers as &quot;CCP&quot;.
    /// </summary>
    [EnumMember(Value = "CCP")]
    [IsoId("_zcQUkQ93EeGeV5vP7Mvdig_-2061701278")]
    [Description(
        @"Payment instrument is a credit card. (The payment originated using a credit card scheme.)."
    )]
    CreditCardPayment = PaymentInstrumentCode.CreditCardPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entry related to a returned or unpaid item.
    /// Encoded/decoded by serializers as &quot;RTI&quot;.
    /// </summary>
    [EnumMember(Value = "RTI")]
    [IsoId("_zcQUkg93EeGeV5vP7Mvdig_2119426952")]
    [Description(@"Entry related to a returned or unpaid item.")]
    Return = PaymentInstrumentCode.Return, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Reverse entry that is the result of the cancellation of a previously booked entry.
    /// Encoded/decoded by serializers as &quot;CAN&quot;.
    /// </summary>
    [EnumMember(Value = "CAN")]
    [IsoId("_zcQUkw93EeGeV5vP7Mvdig_389397029")]
    [Description(
        @"Reverse entry that is the result of the cancellation of a previously booked entry."
    )]
    CancellationRequest = PaymentInstrumentCode.CancellationRequest, // same ordinal as derivation source for type conversions
}
