// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of beneficiary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NtVGAFNhEeijdq8ilaxyOA")]
[Description(@"Specifies a type of beneficiary.")]
[DerivedFrom(typeof(BeneficiaryTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<BeneficiaryType1Code>))]
#endif
public enum BeneficiaryType1Code
{
    /// <summary>
    /// Beneficiary is a dependent.
    /// Encoded/decoded by serializers as &quot;DEPE&quot;.
    /// </summary>
    [EnumMember(Value = "DEPE")]
    [IsoId("_Opuc0VNhEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a dependent.")]
    Dependent = BeneficiaryTypeCode.Dependent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Beneficiary is a nominee.
    /// Encoded/decoded by serializers as &quot;NOMI&quot;.
    /// </summary>
    [EnumMember(Value = "NOMI")]
    [IsoId("_OtcfMVNhEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a nominee.")]
    Nominee = BeneficiaryTypeCode.Nominee, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Beneficiary is a successor.
    /// Encoded/decoded by serializers as &quot;SUCC&quot;.
    /// </summary>
    [EnumMember(Value = "SUCC")]
    [IsoId("_OxnNgVNhEeijdq8ilaxyOA")]
    [Description(@"Beneficiary is a successor.")]
    Successor = BeneficiaryTypeCode.Successor, // same ordinal as derivation source for type conversions
}
