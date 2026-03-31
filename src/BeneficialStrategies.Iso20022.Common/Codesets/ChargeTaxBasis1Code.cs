// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Define the Charges/tax basis for the trade being allocated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__05YtdojEeC60axPepSq7g_-2079175489")]
[Description(@"Define the Charges/tax basis for the trade being allocated.")]
[DerivedFrom(typeof(ChargeTaxBasisCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ChargeTaxBasis1Code>))]
#endif
public enum ChargeTaxBasis1Code
{
    /// <summary>
    /// Charges/tax basis is flat or absolute for the trade being allocated.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("__05YttojEeC60axPepSq7g_2090853964")]
    [Description(@"Charges/tax basis is flat or absolute for the trade being allocated.")]
    FlatOrAbsolute = ChargeTaxBasisCode.FlatOrAbsolute, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Charge/tax basis is per unit of financial instrument.
    /// Encoded/decoded by serializers as &quot;PERU&quot;.
    /// </summary>
    [EnumMember(Value = "PERU")]
    [IsoId("__1DJsNojEeC60axPepSq7g_203767408")]
    [Description(@"Charge/tax basis is per unit of financial instrument.")]
    PerUnit = ChargeTaxBasisCode.PerUnit, // same ordinal as derivation source for type conversions
}
