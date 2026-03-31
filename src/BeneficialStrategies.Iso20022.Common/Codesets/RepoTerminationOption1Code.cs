// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the termination option for a repurchase agreement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Dix5sCy0Eea35M2x2c9PXw")]
[Description(@"Indicates the termination option for a repurchase agreement.")]
[DerivedFrom(typeof(RepoTerminationOptionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RepoTerminationOption1Code>))]
#endif
public enum RepoTerminationOption1Code
{
    /// <summary>
    /// Evergreen termination option.
    /// Encoded/decoded by serializers as &quot;EGRN&quot;.
    /// </summary>
    [EnumMember(Value = "EGRN")]
    [IsoId("_JUfZoSy0Eea35M2x2c9PXw")]
    [Description(@"Evergreen termination option.")]
    Evergreen = RepoTerminationOptionCode.Evergreen, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extendable termination option.
    /// Encoded/decoded by serializers as &quot;ETSB&quot;.
    /// </summary>
    [EnumMember(Value = "ETSB")]
    [IsoId("_JmCcoSy0Eea35M2x2c9PXw")]
    [Description(@"Extendable termination option.")]
    Extendable = RepoTerminationOptionCode.Extendable, // same ordinal as derivation source for type conversions
}
