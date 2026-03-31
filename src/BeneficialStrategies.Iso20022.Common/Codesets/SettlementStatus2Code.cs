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
[IsoId("_waKzmKMOEeCojJW5vEuTEQ_895697870")]
[Description(
    @"Specifies the status of the settlement of a trade in a central matching and settlement system."
)]
[DerivedFrom(typeof(SettlementStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SettlementStatus2Code>))]
#endif
public enum SettlementStatus2Code
{
    /// <summary>
    /// Settlement is awaiting authorisation.
    /// Encoded/decoded by serializers as &quot;AAUT&quot;.
    /// </summary>
    [EnumMember(Value = "AAUT")]
    [IsoId("_waKzmaMOEeCojJW5vEuTEQ_147220499")]
    [Description(@"Settlement is awaiting authorisation.")]
    AwaitingAuthorisation = SettlementStatusCode.AwaitingAuthorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is accepted for settlement.
    /// Encoded/decoded by serializers as &quot;ASTL&quot;.
    /// </summary>
    [EnumMember(Value = "ASTL")]
    [IsoId("_waKzmqMOEeCojJW5vEuTEQ_1225240837")]
    [Description(@"Settlement is accepted for settlement.")]
    AcceptedForSettlement = SettlementStatusCode.AcceptedForSettlement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement has been created.
    /// Encoded/decoded by serializers as &quot;STCR&quot;.
    /// </summary>
    [EnumMember(Value = "STCR")]
    [IsoId("_waKzm6MOEeCojJW5vEuTEQ_342007550")]
    [Description(@"Settlement has been created.")]
    SettlementTransactionCreated = SettlementStatusCode.SettlementTransactionCreated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is complete.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_waKznKMOEeCojJW5vEuTEQ_-795814798")]
    [Description(@"Settlement is complete.")]
    Settled = SettlementStatusCode.Settled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is awaiting confirmation of creation.
    /// Encoded/decoded by serializers as &quot;ACCF&quot;.
    /// </summary>
    [EnumMember(Value = "ACCF")]
    [IsoId("_waUkkKMOEeCojJW5vEuTEQ_-1679048085")]
    [Description(@"Settlement is awaiting confirmation of creation.")]
    AwaitingCreationConfirmation = SettlementStatusCode.AwaitingCreationConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement is awaiting confirmation of rescind.
    /// Encoded/decoded by serializers as &quot;ARCF&quot;.
    /// </summary>
    [EnumMember(Value = "ARCF")]
    [IsoId("_waUkkaMOEeCojJW5vEuTEQ_-341727529")]
    [Description(@"Settlement is awaiting confirmation of rescind.")]
    AwaitingRescindConfirmation = SettlementStatusCode.AwaitingRescindConfirmation, // same ordinal as derivation source for type conversions
}
