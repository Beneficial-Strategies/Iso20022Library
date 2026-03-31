// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies, for a date, when the event or operation is to take place, for example at the beginning or end of the day.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NR5vEFuREeSmO6RkXg92Lg")]
[Description(
    @"Specifies, for a date, when the event or operation is to take place, for example at the beginning or end of the day."
)]
[Derivations(typeof(DateMode1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<DateModeCode>))]
#endif
public enum DateModeCode
{
    /// <summary>
    /// Beginning of day.
    /// Encoded/decoded by serializers as &quot;BODY&quot;.
    /// </summary>
    [EnumMember(Value = "BODY")]
    [IsoId("_rQlwYFuREeSmO6RkXg92Lg")]
    [Description(@"Beginning of day.")]
    BODY,

    /// <summary>
    /// End of day.
    /// Encoded/decoded by serializers as &quot;EODY&quot;.
    /// </summary>
    [EnumMember(Value = "EODY")]
    [IsoId("_1HlDoFuREeSmO6RkXg92Lg")]
    [Description(@"End of day.")]
    EODY,
}
