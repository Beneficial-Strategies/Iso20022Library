// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax identification number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RXCbQQhJEeSUPbC7DbLJpQ")]
[Description(@"Specifies the type of tax identification number.")]
[Derivations(typeof(TaxIdentificationNumberType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TaxIdentificationNumberTypeCode>))]
#endif
public enum TaxIdentificationNumberTypeCode
{
    /// <summary>
    /// Tax identification number.
    /// Encoded/decoded by serializers as &quot;GTIN&quot;.
    /// </summary>
    [EnumMember(Value = "GTIN")]
    [IsoId("_WVR24AhJEeSUPbC7DbLJpQ")]
    [Description(@"Tax identification number.")]
    TaxIdentificationNumber,

    /// <summary>
    /// Global intermediary tax identification number.
    /// Encoded/decoded by serializers as &quot;GIIN&quot;.
    /// </summary>
    [EnumMember(Value = "GIIN")]
    [IsoId("_abk94AhJEeSUPbC7DbLJpQ")]
    [Description(@"Global intermediary tax identification number.")]
    GlobalIntermediaryIdentificationNumber,
}
