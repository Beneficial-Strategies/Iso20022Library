// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why the instruction has an allegement status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__0Jx0dojEeC60axPepSq7g_-2133812073")]
[Description(@"Specifies the reason why the instruction has an allegement status.")]
[Derivations(typeof(AllegementReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AllegementReasonCode>))]
#endif
public enum AllegementReasonCode
{
    /// <summary>
    /// Allegement has been received and no match could be found.
    /// Encoded/decoded by serializers as &quot;ALG1&quot;.
    /// </summary>
    [EnumMember(Value = "ALG1")]
    [IsoId("__0Jx0tojEeC60axPepSq7g_1199081548")]
    [Description(@"Allegement has been received and no match could be found.")]
    AllegementReceived,
}
