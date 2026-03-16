// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason the transaction, transfer or settlement instruction is unmatched.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qfeCYJM5EemKz5EOjv82iQ")]
[Description(
    @"Specifies the reason the transaction, transfer or settlement instruction is unmatched."
)]
[DerivedFrom(typeof(TransferUnmatchedReasonCode))]
public enum TransferUnmatchedReason3Code
{
    /// <summary>
    /// No potential match has been found.
    /// Encoded/decoded by serializers as &quot;CMIS&quot;.
    /// </summary>
    [EnumMember(Value = "CMIS")]
    [IsoId("_zc_XAZM5EemKz5EOjv82iQ")]
    [Description(@"No potential match has been found.")]
    NoMatch = TransferUnmatchedReasonCode.NoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Counterparty has cancelled the transaction/instruction.
    /// Encoded/decoded by serializers as &quot;CPCA&quot;.
    /// </summary>
    [EnumMember(Value = "CPCA")]
    [IsoId("_zzADQZM5EemKz5EOjv82iQ")]
    [Description(@"Counterparty has cancelled the transaction/instruction.")]
    CounterpartyCancelled = TransferUnmatchedReasonCode.CounterpartyCancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direction of transaction does not match: delivery instead of receipt or vice versa.
    /// Encoded/decoded by serializers as &quot;DELN&quot;.
    /// </summary>
    [EnumMember(Value = "DELN")]
    [IsoId("_0v_3AZM5EemKz5EOjv82iQ")]
    [Description(
        @"Direction of transaction does not match: delivery instead of receipt or vice versa."
    )]
    TransactionDirection = TransferUnmatchedReasonCode.TransactionDirection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument identification does not match or a financial instrument attribute differs.
    /// Encoded/decoded by serializers as &quot;DSEC&quot;.
    /// </summary>
    [EnumMember(Value = "DSEC")]
    [IsoId("_3bFkQZM5EemKz5EOjv82iQ")]
    [Description(
        @"Financial instrument identification does not match or a financial instrument attribute differs."
    )]
    FinancialInstrument = TransferUnmatchedReasonCode.FinancialInstrument, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement does not match: counterparty&apos;s instruction is for physical settlement, your instruction is not, or vice versa.
    /// Encoded/decoded by serializers as &quot;PHYS&quot;.
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_4uZmQZM5EemKz5EOjv82iQ")]
    [Description(
        @"Settlement does not match: counterparty's instruction is for physical settlement, your instruction is not, or vice versa."
    )]
    PhysicalSettlement = TransferUnmatchedReasonCode.PhysicalSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has not been matched: it is a possible duplicate instruction.
    /// Encoded/decoded by serializers as &quot;PODU&quot;.
    /// </summary>
    [EnumMember(Value = "PODU")]
    [IsoId("_5qgpMZM5EemKz5EOjv82iQ")]
    [Description(@"Instruction has not been matched: it is a possible duplicate instruction.")]
    Duplicate = TransferUnmatchedReasonCode.Duplicate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Place of settlement does not match.
    /// Encoded/decoded by serializers as &quot;DEPT&quot;.
    /// </summary>
    [EnumMember(Value = "DEPT")]
    [IsoId("_7KUPEZM5EemKz5EOjv82iQ")]
    [Description(@"Place of settlement does not match.")]
    SettlementPlace = TransferUnmatchedReasonCode.SettlementPlace, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement date or transfer date does not match.
    /// Encoded/decoded by serializers as &quot;DDAT&quot;.
    /// </summary>
    [EnumMember(Value = "DDAT")]
    [IsoId("_8xavwZM5EemKz5EOjv82iQ")]
    [Description(@"Settlement date or transfer date does not match.")]
    SettlementDate = TransferUnmatchedReasonCode.SettlementDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Financial instrument quantity does not match.
    /// Encoded/decoded by serializers as &quot;DQUA&quot;.
    /// </summary>
    [EnumMember(Value = "DQUA")]
    [IsoId("_-ZaBQZM5EemKz5EOjv82iQ")]
    [Description(@"Financial instrument quantity does not match.")]
    FinancialInstrumentQuantity = TransferUnmatchedReasonCode.FinancialInstrumentQuantity, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Delivering or receiving custodian does not match.
    /// Encoded/decoded by serializers as &quot;ICUS&quot;.
    /// </summary>
    [EnumMember(Value = "ICUS")]
    [IsoId("_Aa_egZM6EemKz5EOjv82iQ")]
    [Description(@"Delivering or receiving custodian does not match.")]
    ReceivingOrDeliveringCustodian = TransferUnmatchedReasonCode.ReceivingOrDeliveringCustodian, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Safekeeping account used as a matching criteria on the market concerned does not match.
    /// Encoded/decoded by serializers as &quot;SAFE&quot;.
    /// </summary>
    [EnumMember(Value = "SAFE")]
    [IsoId("_BePEMZM6EemKz5EOjv82iQ")]
    [Description(
        @"Safekeeping account used as a matching criteria on the market concerned does not match."
    )]
    SafekeepingAccount = TransferUnmatchedReasonCode.SafekeepingAccount, // same ordinal as derivation source for type conversions
}
