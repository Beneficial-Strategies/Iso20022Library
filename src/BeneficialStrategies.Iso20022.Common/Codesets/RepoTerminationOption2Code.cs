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
[IsoId("_2zdHkNX_EeiqhpuDZKadPg")]
[Description(@"Indicates the termination option for a repurchase agreement.")]
[DerivedFrom(typeof(RepoTerminationOptionCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RepoTerminationOption2Code>))]
#endif
public enum RepoTerminationOption2Code
{
    /// <summary>
    /// Evergreen termination option.
    /// Encoded/decoded by serializers as &quot;EGRN&quot;.
    /// </summary>
    [EnumMember(Value = "EGRN")]
    [IsoId("_cqq1Me83EeiYJN4CMdaY8A")]
    [Description(@"Evergreen termination option.")]
    Evergreen = RepoTerminationOptionCode.Evergreen, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Evergreen and extendable termination option.
    /// Encoded/decoded by serializers as &quot;EGAE&quot;.
    /// </summary>
    [EnumMember(Value = "EGAE")]
    [IsoId("_cwfwYe83EeiYJN4CMdaY8A")]
    [Description(@"Evergreen and extendable termination option. ")]
    EvergreenAndExtendable = RepoTerminationOptionCode.EvergreenAndExtendable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Extendable termination option.
    /// Encoded/decoded by serializers as &quot;ETSB&quot;.
    /// </summary>
    [EnumMember(Value = "ETSB")]
    [IsoId("_c7BlYe83EeiYJN4CMdaY8A")]
    [Description(@"Extendable termination option.")]
    Extendable = RepoTerminationOptionCode.Extendable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Search for requested data not complete yet.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_dBKpoO83EeiYJN4CMdaY8A")]
    [Description(@"Search for requested data not complete yet.")]
    NotApplicable = RepoTerminationOptionCode.NotApplicable, // same ordinal as derivation source for type conversions
}
