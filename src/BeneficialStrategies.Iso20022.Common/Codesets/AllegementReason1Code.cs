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
[IsoId("__0An5dojEeC60axPepSq7g_-11269067")]
[Description(@"Specifies the reason why the instruction has an allegement status.")]
[DerivedFrom(typeof(AllegementReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AllegementReason1Code>))]
#endif
public enum AllegementReason1Code
{
    /// <summary>
    /// Allegement has been received and no match could be found.
    /// Encoded/decoded by serializers as &quot;ALG1&quot;.
    /// </summary>
    [EnumMember(Value = "ALG1")]
    [IsoId("__0Jx0NojEeC60axPepSq7g_1527696364")]
    [Description(@"Allegement has been received and no match could be found.")]
    AllegementReceived = AllegementReasonCode.AllegementReceived, // same ordinal as derivation source for type conversions
}
