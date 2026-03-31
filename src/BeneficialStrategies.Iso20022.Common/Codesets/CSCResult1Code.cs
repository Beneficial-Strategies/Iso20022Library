// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the printed CSC (Card Security Code) validation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TS9qZgEcEeCQm6a_G2yO_w_2096541332")]
[Description(@"Result of the printed CSC (Card Security Code) validation.")]
[DerivedFrom(typeof(CSCResultCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CSCResult1Code>))]
#endif
public enum CSCResult1Code
{
    /// <summary>
    /// Card security code match.
    /// Encoded/decoded by serializers as &quot;CMCH&quot;.
    /// </summary>
    [EnumMember(Value = "CMCH")]
    [IsoId("_TS9qZwEcEeCQm6a_G2yO_w_153972600")]
    [Description(@"Card security code match.")]
    CSCMatch = CSCResultCode.CSCMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No card security code match.
    /// Encoded/decoded by serializers as &quot;CNMH&quot;.
    /// </summary>
    [EnumMember(Value = "CNMH")]
    [IsoId("_TS9qaAEcEeCQm6a_G2yO_w_-1576057323")]
    [Description(@"No card security code match.")]
    CSCNoMatch = CSCResultCode.CSCNoMatch, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card security code not processed for technical reason.
    /// Encoded/decoded by serializers as &quot;CNMT&quot;.
    /// </summary>
    [EnumMember(Value = "CNMT")]
    [IsoId("_TS9qaQEcEeCQm6a_G2yO_w_-1689896389")]
    [Description(@"Card security code not processed for technical reason.")]
    CSCTechnical = CSCResultCode.CSCTechnical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card security code not processed for non-technical reason.
    /// Encoded/decoded by serializers as &quot;CNMO&quot;.
    /// </summary>
    [EnumMember(Value = "CNMO")]
    [IsoId("_TS9qagEcEeCQm6a_G2yO_w_-1542897554")]
    [Description(@"Card security code not processed for non-technical reason.")]
    CSCNotTechnical = CSCResultCode.CSCNotTechnical, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card security code missing in request.
    /// Encoded/decoded by serializers as &quot;CMSS&quot;.
    /// </summary>
    [EnumMember(Value = "CMSS")]
    [IsoId("_TS9qawEcEeCQm6a_G2yO_w_394327619")]
    [Description(@"Card security code missing in request.")]
    CSCMissing = CSCResultCode.CSCMissing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card security code not used by issuer.
    /// Encoded/decoded by serializers as &quot;CNUS&quot;.
    /// </summary>
    [EnumMember(Value = "CNUS")]
    [IsoId("_TS9qbAEcEeCQm6a_G2yO_w_-1425026569")]
    [Description(@"Card security code not used by issuer.")]
    CSCNotUsed = CSCResultCode.CSCNotUsed, // same ordinal as derivation source for type conversions
}
