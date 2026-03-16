// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a trading venue which must use the market identification code (MIC).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_miosoF0gEeWErPfQ7BYx8A")]
[Description(
    @"Specifies the type of a trading venue which must use the market identification code (MIC)."
)]
[DerivedFrom(typeof(TradingVenueCode))]
public enum TradingVenue1Code
{
    /// <summary>
    /// Investment firm which, on an organised, frequent systematic and substantial basis, deals on own account when executing client orders outside a regulated market, an multilateral trading facility or an organised trading facility without operating a multilateral system.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_n5ZEMV0gEeWErPfQ7BYx8A")]
    [Description(
        @"Investment firm which, on an organised, frequent systematic and substantial basis, deals on own account when executing client orders outside a regulated market, an multilateral trading facility or an organised trading facility without operating a multilateral system."
    )]
    SystematicInternaliser = TradingVenueCode.SystematicInternaliser, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.
    /// Encoded/decoded by serializers as &quot;MLTF&quot;.
    /// </summary>
    [EnumMember(Value = "MLTF")]
    [IsoId("_akwoseRUEeW25oRYRCmhTA")]
    [Description(
        @"Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract."
    )]
    MultilateralTradingFacility = TradingVenueCode.MultilateralTradingFacility, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Multilateral system which is not a regulated market or multilateral trading facility in which multiple third-party buying and selling interests in bonds, structured finance products, emission allowances or derivatives are able to interact in a way that results in a contract.
    /// Encoded/decoded by serializers as &quot;OTFS&quot;.
    /// </summary>
    [EnumMember(Value = "OTFS")]
    [IsoId("_a_tfUeRUEeW25oRYRCmhTA")]
    [Description(
        @"Multilateral system which is not a regulated market or multilateral trading facility in which multiple third-party buying and selling interests in bonds, structured finance products, emission allowances or derivatives are able to interact in a way that results in a contract."
    )]
    OrganisedTradingFacility = TradingVenueCode.OrganisedTradingFacility, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Market on which financial instruments can be traded according to rules defined by the stock exchange.
    /// Encoded/decoded by serializers as &quot;RMKT&quot;.
    /// </summary>
    [EnumMember(Value = "RMKT")]
    [IsoId("_bKnHweRUEeW25oRYRCmhTA")]
    [Description(
        @"Market on which financial instruments can be traded according to rules defined by the stock exchange."
    )]
    RegulatedMarket = TradingVenueCode.RegulatedMarket, // same ordinal as derivation source for type conversions
}
