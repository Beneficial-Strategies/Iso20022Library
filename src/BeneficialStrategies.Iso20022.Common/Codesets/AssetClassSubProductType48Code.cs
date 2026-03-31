// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the sub-product types for specific asset classes.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_nBb6IPwhEeW4Wthd0Ze_kA")]
[Description(@"Defines the sub-product types for specific asset classes.")]
[DerivedFrom(typeof(AssetClassSubProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassSubProductType48Code>))]
#endif
public enum AssetClassSubProductType48Code
{
    /// <summary>
    /// Commodity of type non deliverable.
    /// Encoded/decoded by serializers as &quot;NDLV&quot;.
    /// </summary>
    [EnumMember(Value = "NDLV")]
    [IsoId("_oS0CcfwhEeW4Wthd0Ze_kA")]
    [Description(@"Commodity of type non deliverable.")]
    NonDeliverable = AssetClassSubProductTypeCode.NonDeliverable, // same ordinal as derivation source for type conversions
}
