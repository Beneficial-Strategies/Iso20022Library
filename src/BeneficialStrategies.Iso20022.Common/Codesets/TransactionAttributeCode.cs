// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Attribute related to the transaction
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vCRBUBYfEeiXa46FI4OtcQ")]
[Description(@"Attribute related to the transaction")]
[Derivations(typeof(TransactionAttribute1Code),typeof(TransactionAttribute2Code))]
public enum TransactionAttributeCode
{
    /// <summary>
    /// An occurrence of a recurring payment..
    /// Encoded/decoded by serializers as &quot;RCPT&quot;.
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_1wqzABYfEeiXa46FI4OtcQ")]
    [Description(@"An occurrence of a recurring payment..")]
    RecurringPayment,
    
    /// <summary>
    /// Payment is an instalment one.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_8KPkMBYfEeiXa46FI4OtcQ")]
    [Description(@"Payment is an instalment one.")]
    Instalment,
    
    /// <summary>
    /// Payment is an aggregation one.
    /// Encoded/decoded by serializers as &quot;AGGR&quot;.
    /// </summary>
    [EnumMember(Value = "AGGR")]
    [IsoId("_CJVY0BYgEeiXa46FI4OtcQ")]
    [Description(@"Payment is an aggregation one.")]
    Aggregation,
    
    /// <summary>
    /// Payment is a debt repayment one.
    /// Encoded/decoded by serializers as &quot;DBRP&quot;.
    /// </summary>
    [EnumMember(Value = "DBRP")]
    [IsoId("_HUWsMBYgEeiXa46FI4OtcQ")]
    [Description(@"Payment is a debt repayment one.")]
    DebtRepayment,
    
    /// <summary>
    /// Payment is a deferred one.
    /// Encoded/decoded by serializers as &quot;DFRD&quot;.
    /// </summary>
    [EnumMember(Value = "DFRD")]
    [IsoId("_Loy84BYgEeiXa46FI4OtcQ")]
    [Description(@"Payment is a deferred one.")]
    DeferredPayment,
    
    /// <summary>
    /// Attribute defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_PmBAYBYgEeiXa46FI4OtcQ")]
    [Description(@"Attribute defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Withdrawal is a cardless cash disbursement one.
    /// Encoded/decoded by serializers as &quot;CADB&quot;.
    /// </summary>
    [EnumMember(Value = "CADB")]
    [IsoId("_P33lYBYgEeiXa46FI4OtcQ")]
    [Description(@"Withdrawal is a cardless cash disbursement one.")]
    CardlessATMCashDisbursement,
    
    /// <summary>
    /// Attribute defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_u8q6MBYgEeiXa46FI4OtcQ")]
    [Description(@"Attribute defined at private level")]
    OtherPrivate,
    
    /// <summary>
    /// Service to replenish value in an account (for example, mobile account, prepaid account, etc.).
    /// Encoded/decoded by serializers as &quot;TPUP&quot;.
    /// </summary>
    [EnumMember(Value = "TPUP")]
    [IsoId("_KHWFsEJpEeiO-KV5ZjnZnQ")]
    [Description(@"Service to replenish value in an account (for example, mobile account, prepaid account, etc.).")]
    TopUp,
    
    /// <summary>
    /// Payment in advance of receiving goods or services.
    /// Encoded/decoded by serializers as &quot;PPYT&quot;.
    /// </summary>
    [EnumMember(Value = "PPYT")]
    [IsoId("_Cusq4EJuEeiO-KV5ZjnZnQ")]
    [Description(@"Payment in advance of receiving goods or services.")]
    PrePayment,
    
    /// <summary>
    /// Preauthorisation for an amount which is unknown at the time when the transaction is initiated and to be cleared within a specified timeframe.
    /// Encoded/decoded by serializers as &quot;PAUT&quot;.
    /// </summary>
    [EnumMember(Value = "PAUT")]
    [IsoId("_eQWPsEM3Eeiut6dbx3wnBg")]
    [Description(@"Preauthorisation for an amount which is unknown at the time when the transaction is initiated and to be cleared within a specified timeframe.")]
    PreAuthorisation,
    
    /// <summary>
    /// Financial completion of a pre-authorised transaction within a specified timeframe.
    /// Encoded/decoded by serializers as &quot;PACP&quot;.
    /// </summary>
    [EnumMember(Value = "PACP")]
    [IsoId("_KQEi0EM4Eeiut6dbx3wnBg")]
    [Description(@"Financial completion of a pre-authorised transaction within a specified timeframe.")]
    PreAuthorisationCompletion,
    
    /// <summary>
    /// Transaction previously initiated is completed and contains the actual amount.
    /// Encoded/decoded by serializers as &quot;CPLT&quot;.
    /// </summary>
    [EnumMember(Value = "CPLT")]
    [IsoId("_4bxlUEM4Eeiut6dbx3wnBg")]
    [Description(@"Transaction previously initiated is completed and contains the actual amount.")]
    Completion,
    
    /// <summary>
    /// To authorise additional amounts for a previously authorised transaction.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_QRjusEM5Eeiut6dbx3wnBg")]
    [Description(@"To authorise additional amounts for a previously authorised transaction.")]
    Incremental,
    
    /// <summary>
    /// First occurence of a recurring payment.
    /// Encoded/decoded by serializers as &quot;FRCP&quot;.
    /// </summary>
    [EnumMember(Value = "FRCP")]
    [IsoId("_tdju0EM5Eeiut6dbx3wnBg")]
    [Description(@"First occurence of a recurring payment.")]
    FirstRecurring,
    
    /// <summary>
    /// Subsequent occurrence of a recurring payment.
    /// Encoded/decoded by serializers as &quot;SUBR&quot;.
    /// </summary>
    [EnumMember(Value = "SUBR")]
    [IsoId("_6SlfgENEEeiut6dbx3wnBg")]
    [Description(@"Subsequent occurrence of a recurring payment.")]
    SubsequentRecurring,
    
    /// <summary>
    /// Debt Recovery.
    /// Encoded/decoded by serializers as &quot;DBRC&quot;.
    /// </summary>
    [EnumMember(Value = "DBRC")]
    [IsoId("_PmPoIDHWEeyTT91yHXSlSQ")]
    [Description(@"Debt Recovery.|")]
    DebtRecovery,
    
    /// <summary>
    /// Unscheduled Card On File.
    /// Encoded/decoded by serializers as &quot;UCOF&quot;.
    /// </summary>
    [EnumMember(Value = "UCOF")]
    [IsoId("_YGBhsDKjEeyTT91yHXSlSQ")]
    [Description(@"Unscheduled Card On File.|")]
    UnscheduledCardOnFile,
    
}
