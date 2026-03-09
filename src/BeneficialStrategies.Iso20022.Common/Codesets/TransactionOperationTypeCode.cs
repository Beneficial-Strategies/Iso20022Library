// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of process related to a specific transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0tTA3JfpEeSfnc-VXAEapg")]
[Description(@"Specifies the type of process related to a specific transaction.")]
[Derivations(typeof(TransactionOperationType3Code),typeof(TransactionOperationType7Code),typeof(TransactionOperationType6Code),typeof(TransactionOperationType4Code),typeof(TransactionOperationType5Code),typeof(TransactionOperationType1Code))]
[Obsolete("Formally obsoleted in the ISO 20022 specification. No removal date recorded.")]
public enum TransactionOperationTypeCode
{
    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as &quot;NEWT&quot;.
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_0tTn4ZfpEeSfnc-VXAEapg")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction,
    
    /// <summary>
    /// Transaction requests the deletion/cancellation of a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_0tTn6ZfpEeSfnc-VXAEapg")]
    [Description(@"Transaction requests the deletion/cancellation of a previously sent transaction.")]
    Cancellation,
    
    /// <summary>
    /// Transaction amends a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;AMND&quot;.
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_0tTn55fpEeSfnc-VXAEapg")]
    [Description(@"Transaction amends a previously sent transaction.")]
    Amendment,
    
    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_0tTn5ZfpEeSfnc-VXAEapg")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction,
    
    /// <summary>
    /// Transaction is an early termination.
    /// Encoded/decoded by serializers as &quot;ETRM&quot;.
    /// </summary>
    [EnumMember(Value = "ETRM")]
    [IsoId("_Ykx9QA3lEeWc7_0KPiuk6w")]
    [Description(@"Transaction is an early termination.")]
    EarlyTermination,
    
    /// <summary>
    /// Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.
    /// Encoded/decoded by serializers as &quot;EROR&quot;.
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_ladPMA3lEeWc7_0KPiuk6w")]
    [Description(@"Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.")]
    Error,
    
    /// <summary>
    /// Transaction modifies in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_ExfDABVmEeWXLoZC9OIRgg")]
    [Description(@"Transaction modifies in a previously sent transaction.")]
    Modification,
    
    /// <summary>
    /// Transaction is a compression.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_VE-foBVmEeWXLoZC9OIRgg")]
    [Description(@"Transaction is a compression.")]
    Compression,
    
    /// <summary>
    /// Update of a contract valuation or collateral.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_X7FKEBVmEeWXLoZC9OIRgg")]
    [Description(@"Update of a contract valuation or collateral.")]
    ValuationUpdate,
    
    /// <summary>
    /// Contract to be reported as a new trade and included in a separate position report on the same day.
    /// Encoded/decoded by serializers as &quot;POSC&quot;.
    /// </summary>
    [EnumMember(Value = "POSC")]
    [IsoId("_c_QOkBVmEeWXLoZC9OIRgg")]
    [Description(@"Contract to be reported as a new trade and included in a separate position report on the same day.")]
    PositionComponent,
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_za5KEOldEeWv8d_RPCVG5g")]
    [Description(@"Other.")]
    Other,
    
    /// <summary>
    /// Update of a contract collateral.
    /// Encoded/decoded by serializers as &quot;COLU&quot;.
    /// </summary>
    [EnumMember(Value = "COLU")]
    [IsoId("_RpAiYK1UEemkQYpo6COeTA")]
    [Description(@"Update of a contract collateral.")]
    CollateralUpdate,
    
    /// <summary>
    /// Specifies a dedicated report to provide changes in initial and variation margin that a reporting counterparty posts with regards to CCP-cleared SFTs.
    /// Encoded/decoded by serializers as &quot;MARU&quot;.
    /// </summary>
    [EnumMember(Value = "MARU")]
    [IsoId("_aWxM4P_LEemm3skPVSMJQg")]
    [Description(@"Specifies a dedicated report to provide changes in initial and variation margin that a reporting counterparty posts with regards to CCP-cleared SFTs.")]
    MarginUpdate,
    
    /// <summary>
    /// Update in the reuse of collateral, the reinvestment of cash or the margin lending funding sources.
    /// Encoded/decoded by serializers as &quot;REUU&quot;.
    /// </summary>
    [EnumMember(Value = "REUU")]
    [IsoId("_a-tWoP_LEemm3skPVSMJQg")]
    [Description(@"Update in the reuse of collateral, the reinvestment of cash or the margin lending funding sources.")]
    CollateralReuseUpdate,
    
    /// <summary>
    /// Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.
    /// Encoded/decoded by serializers as &quot;REVI&quot;.
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_vwtpwS42Eeuxhbw_aW6haw")]
    [Description(@"Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.")]
    Revive,
    
    /// <summary>
    /// Closing of an existing transaction because of a new event (for example: Compression, Novation). This does not apply to transactions that terminate at contractual maturity date.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_ufv-wS_DEeuZ2qWQaQMBMw")]
    [Description(@"Closing of an existing transaction because of a new event (for example: Compression, Novation). This does not apply to transactions that terminate at contractual maturity date.")]
    Termination,
    
    /// <summary>
    /// Indicates transfers swap transaction from one SDR to another SDR (change of swap data repository).
    /// Encoded/decoded by serializers as &quot;PRTO&quot;.
    /// </summary>
    [EnumMember(Value = "PRTO")]
    [IsoId("_fvz4sD3gEe2uHKhHp3bXyA")]
    [Description(@"Indicates transfers swap transaction from one SDR to another SDR (change of swap data repository).")]
    PortOut,
    
}
