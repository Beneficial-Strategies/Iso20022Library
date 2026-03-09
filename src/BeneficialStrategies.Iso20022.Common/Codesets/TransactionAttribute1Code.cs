// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Attribute of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_43e9gBYgEeiXa46FI4OtcQ")]
[Description(@"Attribute of the transaction.")]
[DerivedFrom(typeof(TransactionAttributeCode))]
public enum TransactionAttribute1Code
{
    /// <summary>
    /// Payment is an aggregation one.
    /// Encoded/decoded by serializers as &quot;AGGR&quot;.
    /// </summary>
    [EnumMember(Value = "AGGR")]
    [IsoId("_9DuUcRYgEeiXa46FI4OtcQ")]
    [Description(@"Payment is an aggregation one.")]
    Aggregation = TransactionAttributeCode.Aggregation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Withdrawal is a cardless cash disbursement one.
    /// Encoded/decoded by serializers as &quot;CADB&quot;.
    /// </summary>
    [EnumMember(Value = "CADB")]
    [IsoId("_9PCMkhYgEeiXa46FI4OtcQ")]
    [Description(@"Withdrawal is a cardless cash disbursement one.")]
    CardlessATMCashDisbursement = TransactionAttributeCode.CardlessATMCashDisbursement, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is a debt repayment one.
    /// Encoded/decoded by serializers as &quot;DBRP&quot;.
    /// </summary>
    [EnumMember(Value = "DBRP")]
    [IsoId("_9aoYkhYgEeiXa46FI4OtcQ")]
    [Description(@"Payment is a debt repayment one.")]
    DebtRepayment = TransactionAttributeCode.DebtRepayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is a deferred one.
    /// Encoded/decoded by serializers as &quot;DFRD&quot;.
    /// </summary>
    [EnumMember(Value = "DFRD")]
    [IsoId("_9kmz8hYgEeiXa46FI4OtcQ")]
    [Description(@"Payment is a deferred one.")]
    DeferredPayment = TransactionAttributeCode.DeferredPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment is an instalment one.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_9ySqohYgEeiXa46FI4OtcQ")]
    [Description(@"Payment is an instalment one.")]
    Instalment = TransactionAttributeCode.Instalment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Attribute defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_99vsshYgEeiXa46FI4OtcQ")]
    [Description(@"Attribute defined at national level.")]
    OtherNational = TransactionAttributeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Attribute defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_-Ojv4hYgEeiXa46FI4OtcQ")]
    [Description(@"Attribute defined at private level")]
    OtherPrivate = TransactionAttributeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// An occurrence of a recurring payment..
    /// Encoded/decoded by serializers as &quot;RCPT&quot;.
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_-du0UhYgEeiXa46FI4OtcQ")]
    [Description(@"An occurrence of a recurring payment..")]
    RecurringPayment = TransactionAttributeCode.RecurringPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service to replenish value in an account (for example, mobile account, prepaid account, etc.).
    /// Encoded/decoded by serializers as &quot;TPUP&quot;.
    /// </summary>
    [EnumMember(Value = "TPUP")]
    [IsoId("_kgXn4UJpEeiO-KV5ZjnZnQ")]
    [Description(@"Service to replenish value in an account (for example, mobile account, prepaid account, etc.).")]
    TopUp = TransactionAttributeCode.TopUp, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Payment in advance of receiving goods or services.
    /// Encoded/decoded by serializers as &quot;PPYT&quot;.
    /// </summary>
    [EnumMember(Value = "PPYT")]
    [IsoId("_kVqacUJuEeiO-KV5ZjnZnQ")]
    [Description(@"Payment in advance of receiving goods or services.")]
    PrePayment = TransactionAttributeCode.PrePayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// To authorise additional amounts for a previously authorised transaction.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_r1TngUNNEeiut6dbx3wnBg")]
    [Description(@"To authorise additional amounts for a previously authorised transaction.")]
    Incremental = TransactionAttributeCode.Incremental, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Preauthorisation for an amount which is unknown at the time when the transaction is initiated and to be cleared within a specified timeframe.
    /// Encoded/decoded by serializers as &quot;PAUT&quot;.
    /// </summary>
    [EnumMember(Value = "PAUT")]
    [IsoId("_sAduoUNNEeiut6dbx3wnBg")]
    [Description(@"Preauthorisation for an amount which is unknown at the time when the transaction is initiated and to be cleared within a specified timeframe.")]
    PreAuthorisation = TransactionAttributeCode.PreAuthorisation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Financial completion of a pre-authorised transaction within a specified timeframe.
    /// Encoded/decoded by serializers as &quot;PACP&quot;.
    /// </summary>
    [EnumMember(Value = "PACP")]
    [IsoId("_sMNroUNNEeiut6dbx3wnBg")]
    [Description(@"Financial completion of a pre-authorised transaction within a specified timeframe.")]
    PreAuthorisationCompletion = TransactionAttributeCode.PreAuthorisationCompletion, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Subsequent occurrence of a recurring payment.
    /// Encoded/decoded by serializers as &quot;SUBR&quot;.
    /// </summary>
    [EnumMember(Value = "SUBR")]
    [IsoId("_YJdO4dFeEeiOQebAIFZZCQ")]
    [Description(@"Subsequent occurrence of a recurring payment.")]
    SubsequentRecurring = TransactionAttributeCode.SubsequentRecurring, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// First occurence of a recurring payment.
    /// Encoded/decoded by serializers as &quot;FRCP&quot;.
    /// </summary>
    [EnumMember(Value = "FRCP")]
    [IsoId("_ZBnl8dFeEeiOQebAIFZZCQ")]
    [Description(@"First occurence of a recurring payment.")]
    FirstRecurring = TransactionAttributeCode.FirstRecurring, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction previously initiated is completed and contains the actual amount.
    /// Encoded/decoded by serializers as &quot;CPLT&quot;.
    /// </summary>
    [EnumMember(Value = "CPLT")]
    [IsoId("_AmAxEdagEeigmZxKhkzTEg")]
    [Description(@"Transaction previously initiated is completed and contains the actual amount.")]
    Completion = TransactionAttributeCode.Completion, // same ordinal as derivation source for type conversions
    
}
