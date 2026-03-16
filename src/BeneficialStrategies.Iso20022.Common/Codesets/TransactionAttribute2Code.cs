// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Attribute related to the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XcqKwDHWEeyTT91yHXSlSQ")]
[Description(@"Attribute related to the transaction.")]
[DerivedFrom(typeof(TransactionAttributeCode))]
public enum TransactionAttribute2Code
{
    /// <summary>
    /// Payment is an aggregation one.
    /// Encoded/decoded by serializers as &quot;AGGR&quot;.
    /// </summary>
    [EnumMember(Value = "AGGR")]
    [IsoId("_Z_c3oDHWEeyTT91yHXSlSQ")]
    [Description(@"Payment is an aggregation one.")]
    Aggregation = TransactionAttributeCode.Aggregation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Withdrawal is a cardless cash disbursement one.
    /// Encoded/decoded by serializers as &quot;CADB&quot;.
    /// </summary>
    [EnumMember(Value = "CADB")]
    [IsoId("_aFAGATHWEeyTT91yHXSlSQ")]
    [Description(@"Withdrawal is a cardless cash disbursement one.")]
    CardlessATMCashDisbursement = TransactionAttributeCode.CardlessATMCashDisbursement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction previously initiated is completed and contains the actual amount.
    /// Encoded/decoded by serializers as &quot;CPLT&quot;.
    /// </summary>
    [EnumMember(Value = "CPLT")]
    [IsoId("_aMLsETHWEeyTT91yHXSlSQ")]
    [Description(@"Transaction previously initiated is completed and contains the actual amount.")]
    Completion = TransactionAttributeCode.Completion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Debt Recovery.
    /// Encoded/decoded by serializers as &quot;DBRC&quot;.
    /// </summary>
    [EnumMember(Value = "DBRC")]
    [IsoId("_aQ07gTHWEeyTT91yHXSlSQ")]
    [Description(@"Debt Recovery.|")]
    DebtRecovery = TransactionAttributeCode.DebtRecovery, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is a debt repayment one.
    /// Encoded/decoded by serializers as &quot;DBRP&quot;.
    /// </summary>
    [EnumMember(Value = "DBRP")]
    [IsoId("_aVLQATHWEeyTT91yHXSlSQ")]
    [Description(@"Payment is a debt repayment one.")]
    DebtRepayment = TransactionAttributeCode.DebtRepayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is a deferred one.
    /// Encoded/decoded by serializers as &quot;DFRD&quot;.
    /// </summary>
    [EnumMember(Value = "DFRD")]
    [IsoId("_aZhkgTHWEeyTT91yHXSlSQ")]
    [Description(@"Payment is a deferred one.")]
    DeferredPayment = TransactionAttributeCode.DeferredPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// To authorise additional amounts for a previously authorised transaction.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_aeBqATHWEeyTT91yHXSlSQ")]
    [Description(@"To authorise additional amounts for a previously authorised transaction.")]
    Incremental = TransactionAttributeCode.Incremental, // same ordinal as derivation source for type conversions

    /// <summary>
    /// First occurence of a recurring payment.
    /// Encoded/decoded by serializers as &quot;FRCP&quot;.
    /// </summary>
    [EnumMember(Value = "FRCP")]
    [IsoId("_amCWgTHWEeyTT91yHXSlSQ")]
    [Description(@"First occurence of a recurring payment.")]
    FirstRecurring = TransactionAttributeCode.FirstRecurring, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment is an instalment one.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_attEwTHWEeyTT91yHXSlSQ")]
    [Description(@"Payment is an instalment one.")]
    Instalment = TransactionAttributeCode.Instalment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attribute defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_a0XGYTHWEeyTT91yHXSlSQ")]
    [Description(@"Attribute defined at national level.")]
    OtherNational = TransactionAttributeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Attribute defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_a4af8THWEeyTT91yHXSlSQ")]
    [Description(@"Attribute defined at private level")]
    OtherPrivate = TransactionAttributeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Preauthorisation for an amount which is unknown at the time when the transaction is initiated and to be cleared within a specified timeframe.
    /// Encoded/decoded by serializers as &quot;PAUT&quot;.
    /// </summary>
    [EnumMember(Value = "PAUT")]
    [IsoId("_a9cw8THWEeyTT91yHXSlSQ")]
    [Description(
        @"Preauthorisation for an amount which is unknown at the time when the transaction is initiated and to be cleared within a specified timeframe."
    )]
    PreAuthorisation = TransactionAttributeCode.PreAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial completion of a pre-authorised transaction within a specified timeframe.
    /// Encoded/decoded by serializers as &quot;PACP&quot;.
    /// </summary>
    [EnumMember(Value = "PACP")]
    [IsoId("_bEi3cTHWEeyTT91yHXSlSQ")]
    [Description(
        @"Financial completion of a pre-authorised transaction within a specified timeframe."
    )]
    PreAuthorisationCompletion = TransactionAttributeCode.PreAuthorisationCompletion, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment in advance of receiving goods or services.
    /// Encoded/decoded by serializers as &quot;PPYT&quot;.
    /// </summary>
    [EnumMember(Value = "PPYT")]
    [IsoId("_bJWe8THWEeyTT91yHXSlSQ")]
    [Description(@"Payment in advance of receiving goods or services.")]
    PrePayment = TransactionAttributeCode.PrePayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// An occurrence of a recurring payment..
    /// Encoded/decoded by serializers as &quot;RCPT&quot;.
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_bOF1ATHWEeyTT91yHXSlSQ")]
    [Description(@"An occurrence of a recurring payment..")]
    RecurringPayment = TransactionAttributeCode.RecurringPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subsequent occurrence of a recurring payment.
    /// Encoded/decoded by serializers as &quot;SUBR&quot;.
    /// </summary>
    [EnumMember(Value = "SUBR")]
    [IsoId("_bSudYTHWEeyTT91yHXSlSQ")]
    [Description(@"Subsequent occurrence of a recurring payment.")]
    SubsequentRecurring = TransactionAttributeCode.SubsequentRecurring, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Service to replenish value in an account (for example, mobile account, prepaid account, etc.).
    /// Encoded/decoded by serializers as &quot;TPUP&quot;.
    /// </summary>
    [EnumMember(Value = "TPUP")]
    [IsoId("_bWyeATHWEeyTT91yHXSlSQ")]
    [Description(
        @"Service to replenish value in an account (for example, mobile account, prepaid account, etc.)."
    )]
    TopUp = TransactionAttributeCode.TopUp, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unscheduled Card On File.
    /// Encoded/decoded by serializers as &quot;UCOF&quot;.
    /// </summary>
    [EnumMember(Value = "UCOF")]
    [IsoId("_hreZATKjEeyTT91yHXSlSQ")]
    [Description(@"Unscheduled Card On File.|")]
    UnscheduledCardOnFile = TransactionAttributeCode.UnscheduledCardOnFile, // same ordinal as derivation source for type conversions
}
