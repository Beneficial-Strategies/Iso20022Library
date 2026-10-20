// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the penalty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_UQ6fAB-LEeuwwezkzufkMw")]
[Description(@"Specifies the status of the penalty.")]
[DerivedFrom(typeof(PenaltyStatusCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PenaltyStatus2Code>))]
public enum PenaltyStatus2Code
{
    /// <summary>
    /// Penalty is active for the party.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ZE4kUR-LEeuwwezkzufkMw")]
    [Description(@"Penalty is active for the party.")]
    Active = PenaltyStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Penalty could not be computed.
    /// Encoded/decoded by serializers as &quot;NCOM&quot;.
    /// </summary>
    [EnumMember(Value = "NCOM")]
    [IsoId("_ZJyScR-LEeuwwezkzufkMw")]
    [Description(@"Penalty could not be computed.")]
    NotComputed = PenaltyStatusCode.NotComputed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Removal of a cash penalty where settlement cannot be performed for reasons that are independent from any of the CSD participants or the CSD.
    /// Encoded/decoded by serializers as &quot;REMO&quot;.
    /// </summary>
    [EnumMember(Value = "REMO")]
    [IsoId("_ZenS8R-LEeuwwezkzufkMw")]
    [Description(
        @"Removal of a cash penalty where settlement cannot be performed for reasons that are independent from any of the CSD participants or the CSD."
    )]
    Removed = PenaltyStatusCode.Removed, // same ordinal as derivation source for type conversions
}
