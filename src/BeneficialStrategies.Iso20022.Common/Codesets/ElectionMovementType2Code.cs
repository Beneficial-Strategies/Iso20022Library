// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the effect on the holdings of electing a Corporate Action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ag-CYNp-Ed-ak6NoX_4Aeg_1842520223")]
[Description(@"Specifies the effect on the holdings of electing a Corporate Action option.")]
[DerivedFrom(typeof(ElectionMovementTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ElectionMovementType2Code>))]
#endif
public enum ElectionMovementType2Code
{
    /// <summary>
    /// Direct movement of resource, that is, cash or security that is directly credited to the paying agent account.
    /// Encoded/decoded by serializers as &quot;DRCT&quot;.
    /// </summary>
    [EnumMember(Value = "DRCT")]
    [IsoId("_ag-CYdp-Ed-ak6NoX_4Aeg_2033254774")]
    [Description(
        @"Direct movement of resource, that is, cash or security that is directly credited to the paying agent account."
    )]
    Direct = ElectionMovementTypeCode.Direct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Election results in a change of balance type that transfers control of the securities rather than the securities themselves.
    /// Encoded/decoded by serializers as &quot;SEQD&quot;.
    /// </summary>
    [EnumMember(Value = "SEQD")]
    [IsoId("_ag-CYtp-Ed-ak6NoX_4Aeg_658329762")]
    [Description(
        @"Election results in a change of balance type that transfers control of the securities rather than the securities themselves."
    )]
    Sequestered = ElectionMovementTypeCode.Sequestered, // same ordinal as derivation source for type conversions
}
