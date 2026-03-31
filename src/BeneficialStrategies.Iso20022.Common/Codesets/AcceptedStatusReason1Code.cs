// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for an accepted status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RiGKQGBnEeaR1OOiVxm3Gg")]
[Description(@"Specifies the reason for an accepted status.")]
[DerivedFrom(typeof(AcceptedStatusReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AcceptedStatusReason1Code>))]
#endif
public enum AcceptedStatusReason1Code
{
    /// <summary>
    /// Status of the account modification instruction is accepted but modification of the account data will not be carried out for the place.
    /// Encoded/decoded by serializers as &quot;PLAC&quot;.
    /// </summary>
    [EnumMember(Value = "PLAC")]
    [IsoId("_T391cWBnEeaR1OOiVxm3Gg")]
    [Description(
        @"Status of the account modification instruction is accepted but modification of the account data will not be carried out for the place."
    )]
    PlaceNotAllowed = AcceptedStatusReasonCode.PlaceNotAllowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of the account modification instruction is accepted but modification of the account data will not be carried out for the sector code.
    /// Encoded/decoded by serializers as &quot;SECT&quot;.
    /// </summary>
    [EnumMember(Value = "SECT")]
    [IsoId("_UBVz4WBnEeaR1OOiVxm3Gg")]
    [Description(
        @"Status of the account modification instruction is accepted but modification of the account data will not be carried out for the sector code."
    )]
    SectorNotAllowed = AcceptedStatusReasonCode.SectorNotAllowed, // same ordinal as derivation source for type conversions
}
