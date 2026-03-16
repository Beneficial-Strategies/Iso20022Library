// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction operation action type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uaoFUP_iEemm3skPVSMJQg")]
[Description(@"Specifies the transaction operation action type.")]
[DerivedFrom(typeof(TransactionOperationTypeCode))]
public enum TransactionOperationType6Code
{
    /// <summary>
    /// Update in the reuse of collateral, the reinvestment of cash or the margin lending funding sources.
    /// Encoded/decoded by serializers as &quot;REUU&quot;.
    /// </summary>
    [EnumMember(Value = "REUU")]
    [IsoId("_tfgO8__kEemm3skPVSMJQg")]
    [Description(
        @"Update in the reuse of collateral, the reinvestment of cash or the margin lending funding sources."
    )]
    CollateralReuseUpdate = TransactionOperationTypeCode.CollateralReuseUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Update of a contract collateral.
    /// Encoded/decoded by serializers as &quot;COLU&quot;.
    /// </summary>
    [EnumMember(Value = "COLU")]
    [IsoId("_t1HSkf_kEemm3skPVSMJQg")]
    [Description(@"Update of a contract collateral.")]
    CollateralUpdate = TransactionOperationTypeCode.CollateralUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_uLd9E__kEemm3skPVSMJQg")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction = TransactionOperationTypeCode.Correction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is an early termination.
    /// Encoded/decoded by serializers as &quot;ETRM&quot;.
    /// </summary>
    [EnumMember(Value = "ETRM")]
    [IsoId("_uLd9Ff_kEemm3skPVSMJQg")]
    [Description(@"Transaction is an early termination.")]
    EarlyTermination = TransactionOperationTypeCode.EarlyTermination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Update of a contract valuation or collateral.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_ul2L8f_kEemm3skPVSMJQg")]
    [Description(@"Update of a contract valuation or collateral.")]
    ValuationUpdate = TransactionOperationTypeCode.ValuationUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract to be reported as a new trade and included in a separate position report on the same day.
    /// Encoded/decoded by serializers as &quot;POSC&quot;.
    /// </summary>
    [EnumMember(Value = "POSC")]
    [IsoId("_vBRjsf_kEemm3skPVSMJQg")]
    [Description(
        @"Contract to be reported as a new trade and included in a separate position report on the same day."
    )]
    PositionComponent = TransactionOperationTypeCode.PositionComponent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as &quot;NEWT&quot;.
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_vBato__kEemm3skPVSMJQg")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction = TransactionOperationTypeCode.NewTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction modifies in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_vBkeof_kEemm3skPVSMJQg")]
    [Description(@"Transaction modifies in a previously sent transaction.")]
    Modification = TransactionOperationTypeCode.Modification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies a dedicated report to provide changes in initial and variation margin that a reporting counterparty posts with regards to CCP-cleared SFTs.
    /// Encoded/decoded by serializers as &quot;MARU&quot;.
    /// </summary>
    [EnumMember(Value = "MARU")]
    [IsoId("_vEjhMf_kEemm3skPVSMJQg")]
    [Description(
        @"Specifies a dedicated report to provide changes in initial and variation margin that a reporting counterparty posts with regards to CCP-cleared SFTs."
    )]
    MarginUpdate = TransactionOperationTypeCode.MarginUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.
    /// Encoded/decoded by serializers as &quot;EROR&quot;.
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_vIRjkf_kEemm3skPVSMJQg")]
    [Description(
        @"Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’."
    )]
    Error = TransactionOperationTypeCode.Error, // same ordinal as derivation source for type conversions
}
