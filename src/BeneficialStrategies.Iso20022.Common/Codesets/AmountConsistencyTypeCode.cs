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
[IsoId("_O4iB4ASsEeusZ4O-nsxv_w")]
[Description(
    @"Specifies a type of amount inconsistencies, that the amount type provided matches the reference amount or not."
)]
[Derivations(typeof(AmountConsistencyType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AmountConsistencyTypeCode>))]
#endif
public enum AmountConsistencyTypeCode
{
    /// <summary>
    /// Amount information matches the reference data record.
    /// Encoded/decoded by serializers as &quot;CONS&quot;.
    /// </summary>
    [EnumMember(Value = "CONS")]
    [IsoId("_k5v2UASsEeusZ4O-nsxv_w")]
    [Description(@"Amount information matches the reference data record.")]
    ConsistentAmount,

    /// <summary>
    /// Amount information does not match the reference data record.
    /// Encoded/decoded by serializers as &quot;ICNS&quot;.
    /// </summary>
    [EnumMember(Value = "ICNS")]
    [IsoId("_vMOLsQSsEeusZ4O-nsxv_w")]
    [Description(@"Amount information does not match the reference data record.")]
    InconsistentAmount,

    /// <summary>
    /// Charges amount information does not match the reference data record.
    /// Encoded/decoded by serializers as &quot;ICGA&quot;.
    /// </summary>
    [EnumMember(Value = "ICGA")]
    [IsoId("_3F2aYQSsEeusZ4O-nsxv_w")]
    [Description(@"Charges amount information does not match the reference data record.")]
    InconsistentChargesAmount,

    /// <summary>
    /// Interbank settlement amount information does not match the reference data record.
    /// Encoded/decoded by serializers as &quot;IISA&quot;.
    /// </summary>
    [EnumMember(Value = "IISA")]
    [IsoId("_3bdeAQSsEeusZ4O-nsxv_w")]
    [Description(
        @"Interbank settlement amount information does not match the reference data record."
    )]
    InconsistentInterbankSettlementAmount,

    /// <summary>
    /// Amount information confirmed to the creditor does not match the reference data record.
    /// Encoded/decoded by serializers as &quot;ICFA&quot;.
    /// </summary>
    [EnumMember(Value = "ICFA")]
    [IsoId("_3wpD0QSsEeusZ4O-nsxv_w")]
    [Description(
        @"Amount information confirmed to the creditor does not match the reference data record."
    )]
    InconsistentConfirmedAmount,
}
