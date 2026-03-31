// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the proposal is an initial or a counter proposal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YdGGJtp-Ed-ak6NoX_4Aeg_1195947295")]
[Description(@"Specifies whether the proposal is an initial or a counter proposal.")]
[Derivations(typeof(ProposalType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ProposalTypeCode>))]
#endif
public enum ProposalTypeCode
{
    /// <summary>
    /// Specifies this is an initial proposal.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_YdGGJ9p-Ed-ak6NoX_4Aeg_1552099762")]
    [Description(@"Specifies this is an initial proposal.")]
    Initial,

    /// <summary>
    /// Specifies this is a counter proposal.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_YdGGKNp-Ed-ak6NoX_4Aeg_917818427")]
    [Description(@"Specifies this is a counter proposal.")]
    Counter,
}
