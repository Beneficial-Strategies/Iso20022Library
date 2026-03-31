// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction operation action type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bf47oT3gEe2uHKhHp3bXyA")]
[Description(@"Specifies the transaction operation action type.")]
[DerivedFrom(typeof(TransactionOperationTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TransactionOperationType10Code>))]
#endif
public enum TransactionOperationType10Code
{
    /// <summary>
    /// Transaction is a compression.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_0MEoAWXhEe22AddXIVGKVA")]
    [Description(@"Transaction is a compression.")]
    Compression = TransactionOperationTypeV2Code.Compression, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_0MEoA2XhEe22AddXIVGKVA")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction = TransactionOperationTypeV2Code.Correction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake or a cancellation of duplicate report.
    /// Encoded/decoded by serializers as &quot;EROR&quot;.
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_0MEoBWXhEe22AddXIVGKVA")]
    [Description(
        @"Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake or a cancellation of duplicate report."
    )]
    Error = TransactionOperationTypeV2Code.Error, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction modifies in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;MODI&quot;.
    /// </summary>
    [EnumMember(Value = "MODI")]
    [IsoId("_0MEoB2XhEe22AddXIVGKVA")]
    [Description(@"Transaction modifies in a previously sent transaction.")]
    Modification = TransactionOperationTypeV2Code.Modification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as &quot;NEWT&quot;.
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_0MEoCWXhEe22AddXIVGKVA")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction = TransactionOperationTypeV2Code.NewTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_0MEoC2XhEe22AddXIVGKVA")]
    [Description(@"Other.")]
    Other = TransactionOperationTypeV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Contract to be reported as a new trade and included in a separate position report on the same day.
    /// Encoded/decoded by serializers as &quot;POSC&quot;.
    /// </summary>
    [EnumMember(Value = "POSC")]
    [IsoId("_0MEoDWXhEe22AddXIVGKVA")]
    [Description(
        @"Contract to be reported as a new trade and included in a separate position report on the same day."
    )]
    PositionComponent = TransactionOperationTypeV2Code.PositionComponent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake.
    /// Encoded/decoded by serializers as &quot;REVI&quot;.
    /// </summary>
    [EnumMember(Value = "REVI")]
    [IsoId("_0MEoD2XhEe22AddXIVGKVA")]
    [Description(
        @"Re-opening of a derivative, at a trade or position level, that was cancelled or terminated by mistake."
    )]
    Revive = TransactionOperationTypeV2Code.Revive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Closing of an existing transaction because of a new event (for example: Compression, Novation). This does not apply to transactions that terminate at contractual maturity date.
    /// Encoded/decoded by serializers as &quot;TERM&quot;.
    /// </summary>
    [EnumMember(Value = "TERM")]
    [IsoId("_0MEoEWXhEe22AddXIVGKVA")]
    [Description(
        @"Closing of an existing transaction because of a new event (for example: Compression, Novation). This does not apply to transactions that terminate at contractual maturity date."
    )]
    Termination = TransactionOperationTypeV2Code.Termination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Update of a contract valuation or collateral.
    /// Encoded/decoded by serializers as &quot;VALU&quot;.
    /// </summary>
    [EnumMember(Value = "VALU")]
    [IsoId("_0MEoE2XhEe22AddXIVGKVA")]
    [Description(@"Update of a contract valuation or collateral.")]
    ValuationUpdate = TransactionOperationTypeV2Code.ValuationUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates the report of the collateral data or of their modifications, but not the corrections of the previously reported collateral details.
    /// Encoded/decoded by serializers as &quot;MARU&quot;.
    /// </summary>
    [EnumMember(Value = "MARU")]
    [IsoId("_0MEoFWXhEe22AddXIVGKVA")]
    [Description(
        @"Indicates the report of the collateral data or of their modifications, but not the corrections of the previously reported collateral details."
    )]
    MarginUpdate = TransactionOperationTypeV2Code.MarginUpdate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates transfers swap transaction from one SDR to another SDR (change of swap data repository).
    /// Encoded/decoded by serializers as &quot;PRTO&quot;.
    /// </summary>
    [EnumMember(Value = "PRTO")]
    [IsoId("_0MEoF2XhEe22AddXIVGKVA")]
    [Description(
        @"Indicates transfers swap transaction from one SDR to another SDR (change of swap data repository)."
    )]
    PortOut = TransactionOperationTypeV2Code.PortOut, // same ordinal as derivation source for type conversions
}
