// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the reason why the transaction has a specific status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZF7AuNp-Ed-ak6NoX_4Aeg_503817195")]
[Description(@"Identifies the reason why the transaction has a specific status.")]
[DerivedFrom(typeof(SecuritiesTransactionReasonCode))]
public enum SecuritiesTransactionReason1Code
{
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_ZGExsNp-Ed-ak6NoX_4Aeg_503817342")]
    [Description(@"Specifies the reason why the instruction is cancelled.")]
    Cancellation = SecuritiesTransactionReasonCode.Cancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the reason why a cancellation request sent for the related instruction is pending.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_ZGExsdp-Ed-ak6NoX_4Aeg_503817403")]
    [Description(
        @"Specifies the reason why a cancellation request sent for the related instruction is pending."
    )]
    PendingCancellation = SecuritiesTransactionReasonCode.PendingCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// Encoded/decoded by serializers as &quot;CGEN&quot;.
    /// </summary>
    [EnumMember(Value = "CGEN")]
    [IsoId("_ZGExstp-Ed-ak6NoX_4Aeg_503817650")]
    [Description(@"Specifies the reason why the transaction was generated.")]
    Generated = SecuritiesTransactionReasonCode.Generated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_ZGExs9p-Ed-ak6NoX_4Aeg_503817681")]
    [Description(@"Specifies the reason why the instruction has an unmatched status.")]
    Unmatched = SecuritiesTransactionReasonCode.Unmatched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZGExtNp-Ed-ak6NoX_4Aeg_503817742")]
    [Description(@"Specifies additional information about the processed instruction.")]
    Acknowledgement = SecuritiesTransactionReasonCode.Acknowledgement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZGExtdp-Ed-ak6NoX_4Aeg_503817773")]
    [Description(@"Specifies the reason why the instruction has a pending status.")]
    Pending = SecuritiesTransactionReasonCode.Pending, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the reason why the instruction has a failing settlement status.
    /// Encoded/decoded by serializers as &quot;PENF&quot;.
    /// </summary>
    [EnumMember(Value = "PENF")]
    [IsoId("_ZGExttp-Ed-ak6NoX_4Aeg_503818082")]
    [Description(@"Specifies the reason why the instruction has a failing settlement status.")]
    Failing = SecuritiesTransactionReasonCode.Failing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// Encoded/decoded by serializers as &quot;PPRC&quot;.
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_ZGExt9p-Ed-ak6NoX_4Aeg_503818113")]
    [Description(@"Specifies the reason why the instruction has a pending processing status.")]
    PendingProcessing = SecuritiesTransactionReasonCode.PendingProcessing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies the reason why the instruction is in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_ZGExuNp-Ed-ak6NoX_4Aeg_503818143")]
    [Description(@"Specifies the reason why the instruction is in repair.")]
    Repair = SecuritiesTransactionReasonCode.Repair, // same ordinal as derivation source for type conversions
}
