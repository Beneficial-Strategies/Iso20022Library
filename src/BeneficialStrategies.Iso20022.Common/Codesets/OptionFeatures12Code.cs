// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the features that may apply to a corporate action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j1UbQLaSEeiN--kDwanlkA")]
[Description(@"Specifies the features that may apply to a corporate action option.")]
[DerivedFrom(typeof(OptionFeaturesCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<OptionFeatures12Code>))]
#endif
public enum OptionFeatures12Code
{
    /// <summary>
    /// Tender or exchange with the odd lot preference.
    /// Encoded/decoded by serializers as &quot;OPLF&quot;.
    /// </summary>
    [EnumMember(Value = "OPLF")]
    [IsoId("_m4sssbaSEeiN--kDwanlkA")]
    [Description(@"Tender or exchange with the odd lot preference.")]
    OddLotPreference = OptionFeaturesCode.OddLotPreference, // same ordinal as derivation source for type conversions
}
