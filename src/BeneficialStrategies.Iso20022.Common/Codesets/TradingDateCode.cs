// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates if the Trading Date is various.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__ztF4dojEeC60axPepSq7g_723432947")]
[Description(@"Indicates if the Trading Date is various.")]
[Derivations(typeof(TradingDate1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TradingDateCode>))]
#endif
public enum TradingDateCode
{
    /// <summary>
    /// Partial trades have occurred over a period of two or more days.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("__ztF4tojEeC60axPepSq7g_-94040938")]
    [Description(@"Partial trades have occurred over a period of two or more days.")]
    Various,
}
