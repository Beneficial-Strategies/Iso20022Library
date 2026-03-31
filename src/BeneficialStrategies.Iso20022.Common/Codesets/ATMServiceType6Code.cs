// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Describes the type of deposit service selected by the customer.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_MhPq4K3_EeWL1uap3dNhCQ")]
[Description(@"Describes the type of deposit service selected by the customer.")]
[DerivedFrom(typeof(ATMServiceTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ATMServiceType6Code>))]
#endif
public enum ATMServiceType6Code
{
    /// <summary>
    /// Making change between media types.
    /// Encoded/decoded by serializers as &quot;MCHG&quot;.
    /// </summary>
    [EnumMember(Value = "MCHG")]
    [IsoId("_P5EiUa3_EeWL1uap3dNhCQ")]
    [Description(@"Making change between media types.")]
    MakingChange = ATMServiceTypeCode.MakingChange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of media items unverified by the ATM, for instance in an envelope.
    /// Encoded/decoded by serializers as &quot;DPSN&quot;.
    /// </summary>
    [EnumMember(Value = "DPSN")]
    [IsoId("_QHYEE63_EeWL1uap3dNhCQ")]
    [Description(@"Deposit of media items unverified by the ATM, for instance in an envelope.")]
    NonVerifiedDeposit = ATMServiceTypeCode.NonVerifiedDeposit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Deposit of media items verified by the ATM.
    /// Encoded/decoded by serializers as &quot;DPSV&quot;.
    /// </summary>
    [EnumMember(Value = "DPSV")]
    [IsoId("_QbvKg63_EeWL1uap3dNhCQ")]
    [Description(@"Deposit of media items verified by the ATM.")]
    VerifiedDeposit = ATMServiceTypeCode.VerifiedDeposit, // same ordinal as derivation source for type conversions
}
