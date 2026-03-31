// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// TSE/JASDEC extension codes for the specific use of pro ration.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EDgcgDFrEeGKkIZzgd38VA")]
[Description(@"TSE/JASDEC extension codes for the specific use of pro ration.")]
[Derivations(typeof(ProrationType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProrationTypeCode>))]
#endif
public enum ProrationTypeCode
{
    /// <summary>
    /// Pro ration is not decided.
    /// Encoded/decoded by serializers as &quot;PRND&quot;.
    /// </summary>
    [EnumMember(Value = "PRND")]
    [IsoId("_330GQDFrEeGKkIZzgd38VA")]
    [Description(@"Pro ration is not decided.")]
    NotDecided,

    /// <summary>
    /// Pro ration is not established.
    /// Encoded/decoded by serializers as &quot;PRNE&quot;.
    /// </summary>
    [EnumMember(Value = "PRNE")]
    [IsoId("_LGBnkDFsEeGKkIZzgd38VA")]
    [Description(@"Pro ration is not established.")]
    NotEstablished,

    /// <summary>
    /// Pro ration is not used.
    /// Encoded/decoded by serializers as &quot;PRNU&quot;.
    /// </summary>
    [EnumMember(Value = "PRNU")]
    [IsoId("_Xg_9YDVEEeGIoujPqYSZDw")]
    [Description(@"Pro ration is not used.")]
    NotUsed,
}
