// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Define specific rights that the shareholder has (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bmticdp-Ed-ak6NoX_4Aeg_-456866775")]
[Description(
    @"Define specific rights that the shareholder has (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions)."
)]
[Derivations(typeof(AdditionalRight1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AdditionalRightCode>))]
#endif
public enum AdditionalRightCode
{
    /// <summary>
    /// Defines a written question proposal.
    /// Encoded/decoded by serializers as &quot;WQPS&quot;.
    /// </summary>
    [EnumMember(Value = "WQPS")]
    [IsoId("_bmtictp-Ed-ak6NoX_4Aeg_49222869")]
    [Description(@"Defines a written question proposal.")]
    WrittenQuestionProposal,

    /// <summary>
    /// Defines a resolution proposal.
    /// Encoded/decoded by serializers as &quot;RSPS&quot;.
    /// </summary>
    [EnumMember(Value = "RSPS")]
    [IsoId("_bmtic9p-Ed-ak6NoX_4Aeg_392774918")]
    [Description(@"Defines a resolution proposal.")]
    ResolutionProposal,

    /// <summary>
    /// Defines a resolution proposal.
    /// Encoded/decoded by serializers as &quot;AIPS&quot;.
    /// </summary>
    [EnumMember(Value = "AIPS")]
    [IsoId("_bmtidNp-Ed-ak6NoX_4Aeg_792659885")]
    [Description(@"Defines a resolution proposal.")]
    AgendaItemProposal,
}
