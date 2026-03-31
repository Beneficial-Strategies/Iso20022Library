// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of movement preliminary advice.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bR2FsNp-Ed-ak6NoX_4Aeg_570400157")]
[Description(@"Type of movement preliminary advice.")]
[Derivations(typeof(CorporateActionPreliminaryAdviceType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CorporateActionPreliminaryAdviceTypeCode>))]
#endif
public enum CorporateActionPreliminaryAdviceTypeCode
{
    /// <summary>
    /// New movement preliminary advice.
    /// Encoded/decoded by serializers as &quot;NEWM&quot;.
    /// </summary>
    [EnumMember(Value = "NEWM")]
    [IsoId("_bR2Fsdp-Ed-ak6NoX_4Aeg_456561091")]
    [Description(@"New movement preliminary advice.")]
    New,

    /// <summary>
    /// Movement preliminary advice replacing a previously sent preliminary advice.
    /// Encoded/decoded by serializers as &quot;REPL&quot;.
    /// </summary>
    [EnumMember(Value = "REPL")]
    [IsoId("_bR2Fstp-Ed-ak6NoX_4Aeg_-248553524")]
    [Description(@"Movement preliminary advice replacing a previously sent preliminary advice.")]
    Replacement,
}
