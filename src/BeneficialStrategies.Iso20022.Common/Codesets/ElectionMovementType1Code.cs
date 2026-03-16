// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the effect on the holdings of electing a Corporate Action option.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ag04dtp-Ed-ak6NoX_4Aeg_1964804965")]
[Description(@"Specifies the effect on the holdings of electing a Corporate Action option.")]
[DerivedFrom(typeof(ElectionMovementTypeCode))]
public enum ElectionMovementType1Code
{
    /// <summary>
    /// Election results in a change of balance type that transfers control of the securities rather than the securities themselves.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_ag04d9p-Ed-ak6NoX_4Aeg_1964804967")]
    [Description(
        @"Election results in a change of balance type that transfers control of the securities rather than the securities themselves."
    )]
    Restricted = ElectionMovementTypeCode.Restricted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Direct movement of resource, that is, cash or security that is directly credited to the paying agent account.
    /// Encoded/decoded by serializers as &quot;DRCT&quot;.
    /// </summary>
    [EnumMember(Value = "DRCT")]
    [IsoId("_ag04eNp-Ed-ak6NoX_4Aeg_1964804975")]
    [Description(
        @"Direct movement of resource, that is, cash or security that is directly credited to the paying agent account."
    )]
    Direct = ElectionMovementTypeCode.Direct, // same ordinal as derivation source for type conversions
}
