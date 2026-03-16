// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reporting source, as published in an external reporting source code list.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_229eQLf8Eee9KIDjEHK7ZQ")]
[Description(
    @"Specifies the reporting source, as published in an external reporting source code list.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalReportingSource1Code))]
public enum ExternalReportingSourceCode
{
    /// <summary>
    /// Statement or Report is based on accounting data.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_t4fFxvRYEeuLhpyIdtJzwg")]
    [Description(@"Statement or Report is based on accounting data.")]
    Accounting,

    /// <summary>
    /// An account reconciliation system that provides full reconciliation that usually addresses checks
    /// Encoded/decoded by serializers as &quot;ARPF&quot;.
    /// </summary>
    [EnumMember(Value = "ARPF")]
    [IsoId("_t4o2wPRYEeuLhpyIdtJzwg")]
    [Description(
        @"An account reconciliation system that provides full reconciliation that usually addresses checks"
    )]
    AccountReconciliationSystemFull,

    /// <summary>
    /// An account reconciliation system that provides partial reconciliation that usually addresses checks
    /// Encoded/decoded by serializers as &quot;ARPP&quot;.
    /// </summary>
    [EnumMember(Value = "ARPP")]
    [IsoId("_t4o2w_RYEeuLhpyIdtJzwg")]
    [Description(
        @"An account reconciliation system that provides partial reconciliation that usually addresses checks"
    )]
    AccountReconciliationSystemPartial,

    /// <summary>
    /// A sub-application that reports presentment totals
    /// Encoded/decoded by serializers as &quot;CTDB&quot;.
    /// </summary>
    [EnumMember(Value = "CTDB")]
    [IsoId("_t4o2xvRYEeuLhpyIdtJzwg")]
    [Description(@"A sub-application that reports presentment totals")]
    ControlledDisbursementSystem,

    /// <summary>
    /// Statement or Report is based on custody data.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_t4o2yfRYEeuLhpyIdtJzwg")]
    [Description(@"Statement or Report is based on custody data.")]
    Custody,

    /// <summary>
    /// Cash or deposit accounting system
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_t4o2zPRYEeuLhpyIdtJzwg")]
    [Description(@"Cash or deposit accounting system")]
    DepositSystem,

    /// <summary>
    /// Deposit system that reports what has been collected from various financial institutions
    /// Encoded/decoded by serializers as &quot;DPCS&quot;.
    /// </summary>
    [EnumMember(Value = "DPCS")]
    [IsoId("_t4yAsPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Deposit system that reports what has been collected from various financial institutions"
    )]
    DepositConcentrationSystem,

    /// <summary>
    /// Processing system that captures and reports check data in a lockbox environment.
    /// Encoded/decoded by serializers as &quot;LKBX&quot;.
    /// </summary>
    [EnumMember(Value = "LKBX")]
    [IsoId("_t4yAs_RYEeuLhpyIdtJzwg")]
    [Description(
        @"Processing system that captures and reports check data in a lockbox environment."
    )]
    Lockbox,

    /// <summary>
    /// A system that reports consolidated remittance information obtained from various , i.e., ACH, wires, lockbox, etc.
    /// Encoded/decoded by serializers as &quot;RCPT&quot;.
    /// </summary>
    [EnumMember(Value = "RCPT")]
    [IsoId("_t4yAtvRYEeuLhpyIdtJzwg")]
    [Description(
        @"A system that reports consolidated remittance information obtained from various , i.e., ACH, wires, lockbox, etc."
    )]
    Receipts,

    /// <summary>
    /// Transactions submitted directly from participant / PSO (Payment System Operator) applications.
    /// Encoded/decoded by serializers as &quot;PFRE&quot;.
    /// </summary>
    [EnumMember(Value = "PFRE")]
    [IsoId("_zcu9MI5CEeyANo-d7JlQ1A")]
    [Description(
        @"Transactions submitted directly from participant / PSO (Payment System Operator) applications."
    )]
    ParticipantFrontEnd,

    /// <summary>
    /// Transaction submitted directly from PMI (Payment Market Infrastructure back-office system.
    /// Encoded/decoded by serializers as &quot;MIBO&quot;.
    /// </summary>
    [EnumMember(Value = "MIBO")]
    [IsoId("_7_JqMI5CEeyANo-d7JlQ1A")]
    [Description(
        @"Transaction submitted directly from PMI (Payment Market Infrastructure back-office system."
    )]
    MIBackOffice,
}
