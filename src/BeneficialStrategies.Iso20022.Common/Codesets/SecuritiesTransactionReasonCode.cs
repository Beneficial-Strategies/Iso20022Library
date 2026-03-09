// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the reason why the transaction has a specific status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZGOisNp-Ed-ak6NoX_4Aeg_464976126")]
[Description(@"Identifies the reason why the transaction has a specific status.")]
[Derivations(typeof(SecuritiesTransactionReason1Code))]
public enum SecuritiesTransactionReasonCode
{
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_ZGOisdp-Ed-ak6NoX_4Aeg_-1565978521")]
    [Description(@"Specifies the reason why the instruction is cancelled.")]
    Cancellation,
    
    /// <summary>
    /// Specifies the reason why a cancellation request sent for the related instruction is pending.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_ZGOistp-Ed-ak6NoX_4Aeg_-1538271512")]
    [Description(@"Specifies the reason why a cancellation request sent for the related instruction is pending.")]
    PendingCancellation,
    
    /// <summary>
    /// Specifies the reason why the transaction was generated.
    /// Encoded/decoded by serializers as &quot;CGEN&quot;.
    /// </summary>
    [EnumMember(Value = "CGEN")]
    [IsoId("_ZGOis9p-Ed-ak6NoX_4Aeg_-1537348292")]
    [Description(@"Specifies the reason why the transaction was generated.")]
    Generated,
    
    /// <summary>
    /// Specifies the reason why the instruction has an unmatched status.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_ZGOitNp-Ed-ak6NoX_4Aeg_-1536425172")]
    [Description(@"Specifies the reason why the instruction has an unmatched status.")]
    Unmatched,
    
    /// <summary>
    /// Specifies additional information about the processed instruction.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_ZGOitdp-Ed-ak6NoX_4Aeg_-1535502205")]
    [Description(@"Specifies additional information about the processed instruction.")]
    Acknowledgement,
    
    /// <summary>
    /// Specifies the reason why the instruction has a pending status.
    /// Encoded/decoded by serializers as &quot;PEND&quot;.
    /// </summary>
    [EnumMember(Value = "PEND")]
    [IsoId("_ZGOittp-Ed-ak6NoX_4Aeg_-1534577760")]
    [Description(@"Specifies the reason why the instruction has a pending status.")]
    Pending,
    
    /// <summary>
    /// Specifies the reason why the instruction has a failing settlement status.
    /// Encoded/decoded by serializers as &quot;PENF&quot;.
    /// </summary>
    [EnumMember(Value = "PENF")]
    [IsoId("_ZGOit9p-Ed-ak6NoX_4Aeg_-1526266040")]
    [Description(@"Specifies the reason why the instruction has a failing settlement status.")]
    Failing,
    
    /// <summary>
    /// Specifies the reason why the instruction has a pending processing status.
    /// Encoded/decoded by serializers as &quot;PPRC&quot;.
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_ZGOiuNp-Ed-ak6NoX_4Aeg_-1525342519")]
    [Description(@"Specifies the reason why the instruction has a pending processing status.")]
    PendingProcessing,
    
    /// <summary>
    /// Specifies the reason why the instruction is in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_ZGOiudp-Ed-ak6NoX_4Aeg_-1524418998")]
    [Description(@"Specifies the reason why the instruction is in repair.")]
    Repair,
    
}
