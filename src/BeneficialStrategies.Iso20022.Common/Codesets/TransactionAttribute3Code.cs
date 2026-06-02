// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Attribute related to the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_DqpwAR7aEfCkq6-p7S3J1Q")]
[Description(@"Attribute related to the transaction.")]
[DerivedFrom(typeof(TransactionAttributeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<TransactionAttribute3Code>))]
public enum TransactionAttribute3Code
{
    /// <summary>
    /// Payment is an aggregation one.
    /// Encoded/decoded by serializers as &quot;AGGR&quot;.
    /// </summary>
    [EnumMember(Value = "AGGR")]
    [IsoId("_DxcUgR7aEfCkq6-p7S3J1Q")]
    [Description(@"Payment is an aggregation one.")]
    Aggregation = TransactionAttributeCode.Aggregation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal is a cardless cash disbursement one.
    /// Encoded/decoded by serializers as &quot;CADB&quot;.
    /// </summary>
    [EnumMember(Value = "CADB")]
    [IsoId("_DxcUgx7aEfCkq6-p7S3J1Q")]
    [Description(@"Withdrawal is a cardless cash disbursement one.")]
    CardlessATMCashDisbursement = TransactionAttributeCode.CardlessATMCashDisbursement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction previously initiated is completed and contains the actual amount.
    /// Encoded/decoded by serializers as &quot;CPLT&quot;.
    /// </summary>
    [EnumMember(Value = "CPLT")]
    [IsoId("_DxcUhR7aEfCkq6-p7S3J1Q")]
    [Description(@"Transaction previously initiated is completed and contains the actual amount.")]
    Completion = TransactionAttributeCode.Completion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debt Recovery.
    /// Encoded/decoded by serializers as &quot;DBRC&quot;.
    /// </summary>
    [EnumMember(Value = "DBRC")]
    [IsoId("_DxcUhx7aEfCkq6-p7S3J1Q")]
    [Description(@"Debt Recovery.")]
    DebtRecovery = TransactionAttributeCode.DebtRecovery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is a debt repayment one.
    /// Encoded/decoded by serializers as &quot;DBRP&quot;.
    /// </summary>
    [EnumMember(Value = "DBRP")]
    [IsoId("_DxcUiR7aEfCkq6-p7S3J1Q")]
    [Description(@"Payment is a debt repayment one.")]
    DebtRepayment = TransactionAttributeCode.DebtRepayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is a deferred one.
    /// Encoded/decoded by serializers as &quot;DFRD&quot;.
    /// </summary>
    [EnumMember(Value = "DFRD")]
    [IsoId("_DxcUix7aEfCkq6-p7S3J1Q")]
    [Description(@"Payment is a deferred one.")]
    DeferredPayment = TransactionAttributeCode.DeferredPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// First occurence of a recurring payment.
    /// Encoded/decoded by serializers as &quot;FRCP&quot;.
    /// </summary>
    [EnumMember(Value = "FRCP")]
    [IsoId("_DxcUjx7aEfCkq6-p7S3J1Q")]
    [Description(@"First occurence of a recurring payment.")]
    FirstRecurring = TransactionAttributeCode.FirstRecurring, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To authorise additional amounts for a previously authorised transaction.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_DxcUjR7aEfCkq6-p7S3J1Q")]
    [Description(@"To authorise additional amounts for a previously authorised transaction.")]
    Incremental = TransactionAttributeCode.Incremental, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is an instalment one.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_DxcUkR7aEfCkq6-p7S3J1Q")]
    [Description(@"Payment is an instalment one.")]
    Instalment = TransactionAttributeCode.Instalment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial completion of a pre-authorised transaction within a specified timeframe.
    /// Encoded/decoded by serializers as &quot;PACP&quot;.
    /// </summary>
    [EnumMember(Value = "PACP")]
    [IsoId("_DxcUmR7aEfCkq6-p7S3J1Q")]
    [Description(@"Financial completion of a pre-authorised transaction within a specified timeframe.")]
    PreAuthorisationCompletion = TransactionAttributeCode.PreAuthorisationCompletion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preauthorisation for an amount which is unknown at the time when the transaction is initiated and to be cleared within a specified timeframe.
    /// Encoded/decoded by serializers as &quot;PAUT&quot;.
    /// </summary>
    [EnumMember(Value = "PAUT")]
    [IsoId("_DxcUlx7aEfCkq6-p7S3J1Q")]
    [Description(@"Preauthorisation for an amount which is unknown at the time when the transaction is initiated and to be cleared within a specified timeframe.")]
    PreAuthorisation = TransactionAttributeCode.PreAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment in advance of receiving goods or services.
    /// Encoded/decoded by serializers as &quot;PPYT&quot;.
    /// </summary>
    [EnumMember(Value = "PPYT")]
    [IsoId("_DxcUmx7aEfCkq6-p7S3J1Q")]
    [Description(@"Payment in advance of receiving goods or services.")]
    PrePayment = TransactionAttributeCode.PrePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An occurrence of a recurring payment.
    /// Encoded/decoded by serializers as &quot;RCPT&quot;.
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_DxcUnR7aEfCkq6-p7S3J1Q")]
    [Description(@"An occurrence of a recurring payment.")]
    RecurringPayment = TransactionAttributeCode.RecurringPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subsequent occurrence of a recurring payment.
    /// Encoded/decoded by serializers as &quot;SUBR&quot;.
    /// </summary>
    [EnumMember(Value = "SUBR")]
    [IsoId("_DxcUnx7aEfCkq6-p7S3J1Q")]
    [Description(@"Subsequent occurrence of a recurring payment.")]
    SubsequentRecurring = TransactionAttributeCode.SubsequentRecurring, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service to replenish value in an account (for example, mobile account, prepaid account, etc.).
    /// Encoded/decoded by serializers as &quot;TPUP&quot;.
    /// </summary>
    [EnumMember(Value = "TPUP")]
    [IsoId("_DxcUoR7aEfCkq6-p7S3J1Q")]
    [Description(@"Service to replenish value in an account (for example, mobile account, prepaid account, etc.).")]
    TopUp = TransactionAttributeCode.TopUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unscheduled Card On File.
    /// Encoded/decoded by serializers as &quot;UCOF&quot;.
    /// </summary>
    [EnumMember(Value = "UCOF")]
    [IsoId("_DxcUox7aEfCkq6-p7S3J1Q")]
    [Description(@"Unscheduled Card On File.")]
    UnscheduledCardOnFile = TransactionAttributeCode.UnscheduledCardOnFile, // same ordinal as derivation source for type conversions
}
