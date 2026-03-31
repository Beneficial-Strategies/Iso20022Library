// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the consolidation type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_3fs5YCDVEeWCLu74WLgP4w")]
[Description(@"Specifies the consolidation type.")]
[DerivedFrom(typeof(ConsolidationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ConsolidationType1Code>))]
#endif
public enum ConsolidationType1Code
{
    /// <summary>
    /// Consolidation is general.
    /// Encoded/decoded by serializers as &quot;GENL&quot;.
    /// </summary>
    [EnumMember(Value = "GENL")]
    [IsoId("_5ZjW8SDVEeWCLu74WLgP4w")]
    [Description(@"Consolidation is general.")]
    General = ConsolidationTypeCode.General, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Consolidation is at the level of the participant.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_5i6uUSDVEeWCLu74WLgP4w")]
    [Description(@"Consolidation is at the level of the participant.")]
    Participation = ConsolidationTypeCode.Participation, // same ordinal as derivation source for type conversions
}
