// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction operation action type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_0_mwii42Eeuxhbw_aW6haw")]
[Description(@"Specifies the transaction operation action type.")]
[DerivedFrom(typeof(TransactionOperationTypeCode))]
public enum TransactionOperationType7Code
{
    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_0_mwjS42Eeuxhbw_aW6haw")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction = TransactionOperationTypeCode.Correction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’.
    /// Encoded/decoded by serializers as &quot;EROR&quot;.
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_0_mwkC42Eeuxhbw_aW6haw")]
    [Description(
        @"Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake, in which case, it will be identified as ‘error’."
    )]
    Error = TransactionOperationTypeCode.Error, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as &quot;NEWT&quot;.
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_0_mwjy42Eeuxhbw_aW6haw")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction = TransactionOperationTypeCode.NewTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract to be reported as a new trade and included in a separate position report on the same day.
    /// Encoded/decoded by serializers as &quot;POSC&quot;.
    /// </summary>
    [EnumMember(Value = "POSC")]
    [IsoId("_0_mwky42Eeuxhbw_aW6haw")]
    [Description(
        @"Contract to be reported as a new trade and included in a separate position report on the same day."
    )]
    PositionComponent = TransactionOperationTypeCode.PositionComponent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Update of a contract valuation or collateral.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_0_mwiy42Eeuxhbw_aW6haw")]
    [Description(@"Update of a contract valuation or collateral.")]
    ValuationUpdate = TransactionOperationTypeCode.ValuationUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a compression.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_0_mwki42Eeuxhbw_aW6haw")]
    [Description(@"Transaction is a compression.")]
    Compression = TransactionOperationTypeCode.Compression, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction modifies in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_0_mwjC42Eeuxhbw_aW6haw")]
    [Description(@"Transaction modifies in a previously sent transaction.")]
    Modification = TransactionOperationTypeCode.Modification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0_mwkS42Eeuxhbw_aW6haw")]
    [Description(@"Other.")]
    Other = TransactionOperationTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.
    /// Encoded/decoded by serializers as &quot;REVI&quot;.
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_4Q7XUS42Eeuxhbw_aW6haw")]
    [Description(
        @"Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake."
    )]
    Revive = TransactionOperationTypeCode.Revive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closing of an existing transaction because of a new event (for example: Compression, Novation). This does not apply to transactions that terminate at contractual maturity date.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_FrnocS_EEeuZ2qWQaQMBMw")]
    [Description(
        @"Closing of an existing transaction because of a new event (for example: Compression, Novation). This does not apply to transactions that terminate at contractual maturity date."
    )]
    Termination = TransactionOperationTypeCode.Termination, // same ordinal as derivation source for type conversions
}
