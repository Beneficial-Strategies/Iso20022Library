// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of disclosure request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2Py7kEV2EemRx7jyevcLwg")]
[Description(@"Type of disclosure request.")]
[Derivations(typeof(DisclosureRequestType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DisclosureRequestTypeCode>))]
#endif
public enum DisclosureRequestTypeCode
{
    /// <summary>
    /// New disclosure request.
    /// Encoded/decoded by serializers as &quot;NEWM&quot;.
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_-p6BIEV2EemRx7jyevcLwg")]
    [Description(@"New disclosure request.")]
    New,

    /// <summary>
    /// Disclosure request replacing a previously sent request.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_FetVwEV3EemRx7jyevcLwg")]
    [Description(@"Disclosure request replacing a previously sent request.")]
    Replacement,
}
