// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of amount inconsistencies, that the amount type provided matches the reference amount or not.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QjU6UAStEeusZ4O-nsxv_w")]
[Description(
    @"Specifies a type of amount inconsistencies, that the amount type provided matches the reference amount or not."
)]
[DerivedFrom(typeof(AmountConsistencyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AmountConsistencyType1Code>))]
#endif
public enum AmountConsistencyType1Code
{
    /// <summary>
    /// Amount information matches the reference data record.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_TnhrIQStEeusZ4O-nsxv_w")]
    [Description(@"Amount information matches the reference data record.")]
    ConsistentAmount = AmountConsistencyTypeCode.ConsistentAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount information does not match the reference data record.
    /// Encoded/decoded by serializers as &quot;ICNS&quot;.
    /// </summary>
    [EnumMember(Value = "ICNS")]
    [IsoId("_TtTjAQStEeusZ4O-nsxv_w")]
    [Description(@"Amount information does not match the reference data record.")]
    InconsistentAmount = AmountConsistencyTypeCode.InconsistentAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charges amount information does not match the reference data record.
    /// Encoded/decoded by serializers as &quot;ICGA&quot;.
    /// </summary>
    [EnumMember(Value = "ICGA")]
    [IsoId("_TxnbQQStEeusZ4O-nsxv_w")]
    [Description(@"Charges amount information does not match the reference data record.")]
    InconsistentChargesAmount = AmountConsistencyTypeCode.InconsistentChargesAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Amount information confirmed to the creditor does not match the reference data record.
    /// Encoded/decoded by serializers as &quot;ICFA&quot;.
    /// </summary>
    [EnumMember(Value = "ICFA")]
    [IsoId("_T26K8QStEeusZ4O-nsxv_w")]
    [Description(
        @"Amount information confirmed to the creditor does not match the reference data record."
    )]
    InconsistentConfirmedAmount = AmountConsistencyTypeCode.InconsistentConfirmedAmount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interbank settlement amount information does not match the reference data record.
    /// Encoded/decoded by serializers as &quot;IISA&quot;.
    /// </summary>
    [EnumMember(Value = "IISA")]
    [IsoId("_T8DJoQStEeusZ4O-nsxv_w")]
    [Description(
        @"Interbank settlement amount information does not match the reference data record."
    )]
    InconsistentInterbankSettlementAmount =
        AmountConsistencyTypeCode.InconsistentInterbankSettlementAmount, // same ordinal as derivation source for type conversions
}
