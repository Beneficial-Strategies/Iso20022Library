// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the payment instrument used or the underlying financial transaction that resulted in a payment transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Z0Hjd9p-Ed-ak6NoX_4Aeg_382466788")]
[Description(
    @"Specifies the payment instrument used or the underlying financial transaction that resulted in a payment transaction."
)]
[Derivations(typeof(PaymentInstrument1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PaymentInstrumentCode>))]
#endif
public enum PaymentInstrumentCode
{
    /// <summary>
    /// Direct debit instruction in which the debtor and the creditor are financial institutions.
    /// Encoded/decoded by serializers as &quot;BDT&quot;.
    /// </summary>
    [EnumMember(Value = "BDT")]
    [IsoId("_Z0HjeNp-Ed-ak6NoX_4Aeg_-636966190")]
    [Description(
        @"Direct debit instruction in which the debtor and the creditor are financial institutions."
    )]
    BankDebitTransfer,

    /// <summary>
    /// Funds transfer in which the debtor and the creditor are financial institutions.
    /// Encoded/decoded by serializers as &quot;BCT&quot;.
    /// </summary>
    [EnumMember(Value = "BCT")]
    [IsoId("_Z0Hjedp-Ed-ak6NoX_4Aeg_-636966148")]
    [Description(
        @"Funds transfer in which the debtor and the creditor are financial institutions."
    )]
    BankCreditTransfer,

    /// <summary>
    /// Direct debit instruction in which the debtor or the creditor or both are non-financial institutions.
    /// Encoded/decoded by serializers as &quot;CDT&quot;.
    /// </summary>
    [EnumMember(Value = "CDT")]
    [IsoId("_Z0RUcNp-Ed-ak6NoX_4Aeg_-636966130")]
    [Description(
        @"Direct debit instruction in which the debtor or the creditor or both are non-financial institutions."
    )]
    CustomerDebitTransfer,

    /// <summary>
    /// Funds transfer in which the debtor or the creditor or both are non-financial institutions.
    /// Encoded/decoded by serializers as &quot;CCT&quot;.
    /// </summary>
    [EnumMember(Value = "CCT")]
    [IsoId("_Z0RUcdp-Ed-ak6NoX_4Aeg_-636966087")]
    [Description(
        @"Funds transfer in which the debtor or the creditor or both are non-financial institutions."
    )]
    CustomerCreditTransfer,

    /// <summary>
    /// Payment instrument is a cheque. (A written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee)).
    /// Encoded/decoded by serializers as &quot;CHK&quot;.
    /// </summary>
    [EnumMember(Value = "CHK")]
    [IsoId("_Z0RUctp-Ed-ak6NoX_4Aeg_-636966052")]
    [Description(
        @"Payment instrument is a cheque. (A written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee))."
    )]
    Cheque,

    /// <summary>
    /// Transfer that is a movement of cash on the books of the account servicer.
    /// Encoded/decoded by serializers as &quot;BKT&quot;.
    /// </summary>
    [EnumMember(Value = "BKT")]
    [IsoId("_Z0RUc9p-Ed-ak6NoX_4Aeg_-636966034")]
    [Description(@"Transfer that is a movement of cash on the books of the account servicer.")]
    BookTransfer,

    /// <summary>
    /// Payment instrument is a debit card. (The payment originated using a debit card scheme.).
    /// Encoded/decoded by serializers as &quot;DCP&quot;.
    /// </summary>
    [EnumMember(Value = "DCP")]
    [IsoId("_Z0RUdNp-Ed-ak6NoX_4Aeg_-636965992")]
    [Description(
        @"Payment instrument is a debit card. (The payment originated using a debit card scheme.)."
    )]
    DebitCardPayment,

    /// <summary>
    /// Payment instrument is a credit card. (The payment originated using a credit card scheme.).
    /// Encoded/decoded by serializers as &quot;CCP&quot;.
    /// </summary>
    [EnumMember(Value = "CCP")]
    [IsoId("_Z0RUddp-Ed-ak6NoX_4Aeg_-636965732")]
    [Description(
        @"Payment instrument is a credit card. (The payment originated using a credit card scheme.)."
    )]
    CreditCardPayment,

    /// <summary>
    /// Entry related to a returned or unpaid item.
    /// Encoded/decoded by serializers as &quot;RTI&quot;.
    /// </summary>
    [EnumMember(Value = "RTI")]
    [IsoId("_Z0RUdtp-Ed-ak6NoX_4Aeg_-636965697")]
    [Description(@"Entry related to a returned or unpaid item.")]
    Return,

    /// <summary>
    /// Reverse entry that is the result of the cancellation of a previously booked entry.
    /// Encoded/decoded by serializers as &quot;CAN&quot;.
    /// </summary>
    [EnumMember(Value = "CAN")]
    [IsoId("_Z0RUd9p-Ed-ak6NoX_4Aeg_-636965662")]
    [Description(
        @"Reverse entry that is the result of the cancellation of a previously booked entry."
    )]
    CancellationRequest,
}
