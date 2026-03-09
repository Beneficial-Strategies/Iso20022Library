// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of process related to a specific transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TxnhUE2XEe2bQ-Ksk8mwQg")]
[Description(@"Specifies the type of process related to a specific transaction.")]
[Derivations(typeof(TransactionOperationType8Code),typeof(TransactionOperationType10Code),typeof(TransactionOperationType11Code))]
public enum TransactionOperationTypeV2Code
{
    /// <summary>
    /// Transaction amends a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;AMND&quot;.
    /// </summary>
    [EnumMember(Value = "AMND")]
    [IsoId("_Z2LEwE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Transaction amends a previously sent transaction.")]
    Amendment,
    
    /// <summary>
    /// Transaction requests the deletion/cancellation of a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_bq3VgE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Transaction requests the deletion/cancellation of a previously sent transaction.")]
    Cancellation,
    
    /// <summary>
    /// Update in the reuse of collateral, the reinvestment of cash or the margin lending funding sources.
    /// Encoded/decoded by serializers as &quot;REUU&quot;.
    /// </summary>
    [EnumMember(Value = "REUU")]
    [IsoId("_dkqvwE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Update in the reuse of collateral, the reinvestment of cash or the margin lending funding sources.")]
    CollateralReuseUpdate,
    
    /// <summary>
    /// Update of a contract collateral.
    /// Encoded/decoded by serializers as &quot;COLU&quot;.
    /// </summary>
    [EnumMember(Value = "COLU")]
    [IsoId("_fa7t0E2XEe2bQ-Ksk8mwQg")]
    [Description(@"Update of a contract collateral.")]
    CollateralUpdate,
    
    /// <summary>
    /// Transaction is a compression.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_hKWdAE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Transaction is a compression.")]
    Compression,
    
    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_i8GugE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction,
    
    /// <summary>
    /// Transaction is an early termination.
    /// Encoded/decoded by serializers as &quot;ETRM&quot;.
    /// </summary>
    [EnumMember(Value = "ETRM")]
    [IsoId("_k-dAwE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Transaction is an early termination.")]
    EarlyTermination,
    
    /// <summary>
    /// Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake or a cancellation of duplicate report.
    /// Encoded/decoded by serializers as &quot;EROR&quot;.
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_muHAgE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake or a cancellation of duplicate report.")]
    Error,
    
    /// <summary>
    /// Indicates the report of the collateral data or of their modifications, but not the corrections of the previously reported collateral details.
    /// Encoded/decoded by serializers as &quot;MARU&quot;.
    /// </summary>
    [EnumMember(Value = "MARU")]
    [IsoId("_oba24E2XEe2bQ-Ksk8mwQg")]
    [Description(@"Indicates the report of the collateral data or of their modifications, but not the corrections of the previously reported collateral details.")]
    MarginUpdate,
    
    /// <summary>
    /// Transaction modifies in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_sJYWYE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Transaction modifies in a previously sent transaction.")]
    Modification,
    
    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as &quot;NEWT&quot;.
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_tsvmkE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction,
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_vmLNYE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Other.")]
    Other,
    
    /// <summary>
    /// Indicates transfers swap transaction from one SDR to another SDR (change of swap data repository).
    /// Encoded/decoded by serializers as &quot;PRTO&quot;.
    /// </summary>
    [EnumMember(Value = "PRTO")]
    [IsoId("_xciSEE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Indicates transfers swap transaction from one SDR to another SDR (change of swap data repository).")]
    PortOut,
    
    /// <summary>
    /// Contract to be reported as a new trade and included in a separate position report on the same day.
    /// Encoded/decoded by serializers as &quot;POSC&quot;.
    /// </summary>
    [EnumMember(Value = "POSC")]
    [IsoId("_zPWTgE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Contract to be reported as a new trade and included in a separate position report on the same day.")]
    PositionComponent,
    
    /// <summary>
    /// Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.
    /// Encoded/decoded by serializers as &quot;REVI&quot;.
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_09G10E2XEe2bQ-Ksk8mwQg")]
    [Description(@"Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.")]
    Revive,
    
    /// <summary>
    /// Closing of an existing transaction because of a new event (for example: Compression, Novation). This does not apply to transactions that terminate at contractual maturity date.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_23NyEE2XEe2bQ-Ksk8mwQg")]
    [Description(@"Closing of an existing transaction because of a new event (for example: Compression, Novation). This does not apply to transactions that terminate at contractual maturity date.")]
    Termination,
    
    /// <summary>
    /// Update of a contract valuation or collateral.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_40JY0E2XEe2bQ-Ksk8mwQg")]
    [Description(@"Update of a contract valuation or collateral.")]
    ValuationUpdate,
    
}
