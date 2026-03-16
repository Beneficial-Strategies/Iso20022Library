// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Define specific rights that the shareholder has (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bmjxdtp-Ed-ak6NoX_4Aeg_1174072380")]
[Description(
    @"Define specific rights that the shareholder has (for example, the right to ask questions, the right to add items to the agenda or table draft resolutions)."
)]
[DerivedFrom(typeof(AdditionalRightCode))]
public enum AdditionalRight1Code
{
    /// <summary>
    /// Defines a written question proposal.
    /// Encoded/decoded by serializers as &quot;WQPS&quot;.
    /// </summary>
    [EnumMember(Value = "WQPS")]
    [IsoId("_bmjxd9p-Ed-ak6NoX_4Aeg_1593352605")]
    [Description(@"Defines a written question proposal.")]
    WrittenQuestionProposal = AdditionalRightCode.WrittenQuestionProposal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Defines a resolution proposal.
    /// Encoded/decoded by serializers as &quot;RSPS&quot;.
    /// </summary>
    [EnumMember(Value = "RSPS")]
    [IsoId("_bmjxeNp-Ed-ak6NoX_4Aeg_1593352636")]
    [Description(@"Defines a resolution proposal.")]
    ResolutionProposal = AdditionalRightCode.ResolutionProposal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Defines a resolution proposal.
    /// Encoded/decoded by serializers as &quot;AIPS&quot;.
    /// </summary>
    [EnumMember(Value = "AIPS")]
    [IsoId("_bmticNp-Ed-ak6NoX_4Aeg_1593352666")]
    [Description(@"Defines a resolution proposal.")]
    AgendaItemProposal = AdditionalRightCode.AgendaItemProposal, // same ordinal as derivation source for type conversions
}
