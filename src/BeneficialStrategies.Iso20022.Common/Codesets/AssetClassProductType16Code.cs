// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Commodity derivative base product code list for Index.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ON6osU7KEe2PGo0mhYCh1g")]
[Description(@"Commodity derivative base product code list for Index.")]
[DerivedFrom(typeof(AssetClassProductTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AssetClassProductType16Code>))]
#endif
public enum AssetClassProductType16Code
{
    /// <summary>
    /// Index type of commodities.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_aDo5gU7KEe2PGo0mhYCh1g")]
    [Description(@"Index type of commodities.")]
    Index = AssetClassProductTypeCode.Index, // same ordinal as derivation source for type conversions
}
