// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the type of eligibility.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jBwc4O5NEeCisYr99QEiWA_1266829801")]
[Description(@"Defines the type of eligibility.")]
[DerivedFrom(typeof(EligibilityTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EligibilityType1Code>))]
#endif
public enum EligibilityType1Code
{
    /// <summary>
    /// Eligibility applies at securities level.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_jBwc4e5NEeCisYr99QEiWA_958890440")]
    [Description(@"Eligibility applies at securities level.")]
    Securities = EligibilityTypeCode.Securities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Eligibility applies at the level of issuer CSD.
    /// All of the securities issued by the issuer CSD are eligible.
    /// Encoded/decoded by serializers as &quot;ISCS&quot;.
    /// </summary>
    [EnumMember(Value = "ISCS")]
    [IsoId("_jBwc4u5NEeCisYr99QEiWA_-1194522765")]
    [Description(
        @"Eligibility applies at the level of issuer CSD.|All of the securities issued by the issuer CSD are eligible."
    )]
    IssuerCSD = EligibilityTypeCode.IssuerCSD, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Eligibility applies at country level.
    /// All of the securities issued in that country are eligible.
    /// Encoded/decoded by serializers as &quot;CTRY&quot;.
    /// </summary>
    [EnumMember(Value = "CTRY")]
    [IsoId("_jBwc4-5NEeCisYr99QEiWA_-869405258")]
    [Description(
        @"Eligibility applies at country level.|All of the securities issued in that country are eligible."
    )]
    Country = EligibilityTypeCode.Country, // same ordinal as derivation source for type conversions
}
