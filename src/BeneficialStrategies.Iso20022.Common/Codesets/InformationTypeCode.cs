// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the coded type of additional information provided.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aWsFAtp-Ed-ak6NoX_4Aeg_760507288")]
[Description(@"Specifies the coded type of additional information provided.")]
[Derivations(typeof(InformationType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<InformationTypeCode>))]
#endif
public enum InformationTypeCode
{
    /// <summary>
    /// Instructions used to ease automatic request processing.
    /// Encoded/decoded by serializers as &quot;INST&quot;.
    /// </summary>
    [EnumMember(Value = "INST")]
    [IsoId("_aWsFA9p-Ed-ak6NoX_4Aeg_1218573157")]
    [Description(@"Instructions used to ease automatic request processing.")]
    ProcessingInstructions,

    /// <summary>
    /// Instructions used to ease automatic request relay.
    /// Encoded/decoded by serializers as &quot;RELY&quot;.
    /// </summary>
    [EnumMember(Value = "RELY")]
    [IsoId("_aWsFBNp-Ed-ak6NoX_4Aeg_1222266779")]
    [Description(@"Instructions used to ease automatic request relay.")]
    RelayInstructions,
}
