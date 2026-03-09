// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction operation action type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_IyMY0A3mEeWc7_0KPiuk6w")]
[Description(@"Specifies the transaction operation action type.")]
[DerivedFrom(typeof(TransactionOperationTypeCode))]
public enum TransactionOperationType3Code
{
    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_ujf94RVlEeWXLoZC9OIRgg")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction = TransactionOperationTypeCode.Correction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is an early termination.
    /// Encoded/decoded by serializers as &quot;ETRM&quot;.
    /// </summary>
    [EnumMember(Value = "ETRM")]
    [IsoId("_u-bmYRVlEeWXLoZC9OIRgg")]
    [Description(@"Transaction is an early termination.")]
    EarlyTermination = TransactionOperationTypeCode.EarlyTermination, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.
    /// Encoded/decoded by serializers as &quot;EROR&quot;.
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_vKyAURVlEeWXLoZC9OIRgg")]
    [Description(@"Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.")]
    Error = TransactionOperationTypeCode.Error, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as &quot;NEWT&quot;.
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_vXRkMRVlEeWXLoZC9OIRgg")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction = TransactionOperationTypeCode.NewTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contract to be reported as a new trade and included in a separate position report on the same day.
    /// Encoded/decoded by serializers as &quot;POSC&quot;.
    /// </summary>
    [EnumMember(Value = "POSC")]
    [IsoId("_0sccoRVmEeWXLoZC9OIRgg")]
    [Description(@"Contract to be reported as a new trade and included in a separate position report on the same day.")]
    PositionComponent = TransactionOperationTypeCode.PositionComponent, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update of a contract valuation or collateral.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_08g48RVmEeWXLoZC9OIRgg")]
    [Description(@"Update of a contract valuation or collateral.")]
    ValuationUpdate = TransactionOperationTypeCode.ValuationUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a compression.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_1EZCkRVmEeWXLoZC9OIRgg")]
    [Description(@"Transaction is a compression.")]
    Compression = TransactionOperationTypeCode.Compression, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction modifies in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_1MRzQRVmEeWXLoZC9OIRgg")]
    [Description(@"Transaction modifies in a previously sent transaction.")]
    Modification = TransactionOperationTypeCode.Modification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_DrttMeleEeWv8d_RPCVG5g")]
    [Description(@"Other.")]
    Other = TransactionOperationTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
