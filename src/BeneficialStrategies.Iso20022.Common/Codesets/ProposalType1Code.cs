// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the proposal is an initial or a counter proposal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YdGGI9p-Ed-ak6NoX_4Aeg_1323819587")]
[Description(@"Specifies whether the proposal is an initial or a counter proposal.")]
[DerivedFrom(typeof(ProposalTypeCode))]
public enum ProposalType1Code
{
    /// <summary>
    /// Specifies this is an initial proposal.
    /// Encoded/decoded by serializers as &quot;INIT&quot;.
    /// </summary>
    [EnumMember(Value = "INIT")]
    [IsoId("_YdGGJNp-Ed-ak6NoX_4Aeg_-733247113")]
    [Description(@"Specifies this is an initial proposal.")]
    Initial = ProposalTypeCode.Initial, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specifies this is a counter proposal.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_YdGGJdp-Ed-ak6NoX_4Aeg_698103565")]
    [Description(@"Specifies this is a counter proposal.")]
    Counter = ProposalTypeCode.Counter, // same ordinal as derivation source for type conversions
}
