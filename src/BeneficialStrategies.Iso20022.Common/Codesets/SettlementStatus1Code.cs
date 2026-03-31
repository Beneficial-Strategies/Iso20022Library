// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the settlement of a trade in a central matching and settlement system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZMVKttp-Ed-ak6NoX_4Aeg_-1382213179")]
[Description(
    @"Specifies the status of the settlement of a trade in a central matching and settlement system."
)]
[DerivedFrom(typeof(SettlementStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementStatus1Code>))]
#endif
public enum SettlementStatus1Code
{
    /// <summary>
    /// Settlement is awaiting authorisation.
    /// Encoded/decoded by serializers as &quot;AAUT&quot;.
    /// </summary>
    [EnumMember(Value = "AAUT")]
    [IsoId("_ZMe7sNp-Ed-ak6NoX_4Aeg_-1312946614")]
    [Description(@"Settlement is awaiting authorisation.")]
    AwaitingAuthorisation = SettlementStatusCode.AwaitingAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is accepted for settlement.
    /// Encoded/decoded by serializers as &quot;ASTL&quot;.
    /// </summary>
    [EnumMember(Value = "ASTL")]
    [IsoId("_ZMe7sdp-Ed-ak6NoX_4Aeg_-1312946613")]
    [Description(@"Settlement is accepted for settlement.")]
    AcceptedForSettlement = SettlementStatusCode.AcceptedForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement has been created.
    /// Encoded/decoded by serializers as &quot;STCR&quot;.
    /// </summary>
    [EnumMember(Value = "STCR")]
    [IsoId("_ZMe7stp-Ed-ak6NoX_4Aeg_-1312946596")]
    [Description(@"Settlement has been created.")]
    SettlementTransactionCreated = SettlementStatusCode.SettlementTransactionCreated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is rejected.
    /// Encoded/decoded by serializers as &quot;RJCT&quot;.
    /// </summary>
    [EnumMember(Value = "RJCT")]
    [IsoId("_ZMe7s9p-Ed-ak6NoX_4Aeg_-1312946579")]
    [Description(@"Settlement is rejected.")]
    Rejected = SettlementStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is split.
    /// Encoded/decoded by serializers as &quot;SPLT&quot;.
    /// </summary>
    [EnumMember(Value = "SPLT")]
    [IsoId("_ZMe7tNp-Ed-ak6NoX_4Aeg_-1312946553")]
    [Description(@"Settlement is split.")]
    Split = SettlementStatusCode.Split, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Part, but not all, of a Trade&apos;s value has settled, and no further elements of the Trade&apos;s value are expected to be settled.
    /// Encoded/decoded by serializers as &quot;PSTL&quot;.
    /// </summary>
    [EnumMember(Value = "PSTL")]
    [IsoId("_ZMe7tdp-Ed-ak6NoX_4Aeg_-1312946552")]
    [Description(
        @"Part, but not all, of a Trade's value has settled, and no further elements of the Trade's value are expected to be settled."
    )]
    PartiallySettled = SettlementStatusCode.PartiallySettled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_ZMe7ttp-Ed-ak6NoX_4Aeg_-1312946535")]
    [Description(@"Settlement is complete.")]
    Settled = SettlementStatusCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is awaiting confirmation of creation.
    /// Encoded/decoded by serializers as &quot;ACCF&quot;.
    /// </summary>
    [EnumMember(Value = "ACCF")]
    [IsoId("_ZMe7t9p-Ed-ak6NoX_4Aeg_-1312946518")]
    [Description(@"Settlement is awaiting confirmation of creation.")]
    AwaitingCreationConfirmation = SettlementStatusCode.AwaitingCreationConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is awaiting confirmation of rescind.
    /// Encoded/decoded by serializers as &quot;ARCF&quot;.
    /// </summary>
    [EnumMember(Value = "ARCF")]
    [IsoId("_ZMe7uNp-Ed-ak6NoX_4Aeg_-1312946500")]
    [Description(@"Settlement is awaiting confirmation of rescind.")]
    AwaitingRescindConfirmation = SettlementStatusCode.AwaitingRescindConfirmation, // same ordinal as derivation source for type conversions
}
