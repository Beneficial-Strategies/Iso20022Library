// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of conversion.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bCWRINp-Ed-ak6NoX_4Aeg_1752905694")]
[Description(@"Specifies the type of conversion.")]
[Derivations(typeof(ConversionType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ConversionTypeCode>))]
#endif
public enum ConversionTypeCode
{
    /// <summary>
    /// This is a final conversion.
    /// Encoded/decoded by serializers as &quot;FINL&quot;.
    /// </summary>
    [EnumMember(Value = "FINL")]
    [IsoId("_bCWRIdp-Ed-ak6NoX_4Aeg_1809241362")]
    [Description(@"This is a final conversion.")]
    Final,

    /// <summary>
    /// This is an interim conversion.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_bCWRItp-Ed-ak6NoX_4Aeg_1809241370")]
    [Description(@"This is an interim conversion.")]
    Interim,
}
