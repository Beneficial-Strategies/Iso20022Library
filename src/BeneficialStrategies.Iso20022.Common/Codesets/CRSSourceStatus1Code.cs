// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the source of Common Reporting Standard (CRS) status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-eHCsENsEeaS-NnwLNvMPg")]
[Description(@"Specifies the source of Common Reporting Standard (CRS) status.")]
[DerivedFrom(typeof(CRSSourceStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CRSSourceStatus1Code>))]
#endif
public enum CRSSourceStatus1Code
{
    /// <summary>
    /// Source of the Common Reporting Standard (CRS) status is calculated.
    /// Encoded/decoded by serializers as &quot;CALC&quot;.
    /// </summary>
    [EnumMember(Value = "CALC")]
    [IsoId("_A1tMMUNtEeaS-NnwLNvMPg")]
    [Description(@"Source of the Common Reporting Standard (CRS) status is calculated.")]
    Calculated = CRSSourceStatusCode.Calculated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Source of the Common Reporting Standard (CRS) status is as declared by the investor.
    /// Encoded/decoded by serializers as &quot;DECL&quot;.
    /// </summary>
    [EnumMember(Value = "DECL")]
    [IsoId("_A_-igUNtEeaS-NnwLNvMPg")]
    [Description(
        @"Source of the Common Reporting Standard (CRS) status is as declared by the investor."
    )]
    Declared = CRSSourceStatusCode.Declared, // same ordinal as derivation source for type conversions
}
