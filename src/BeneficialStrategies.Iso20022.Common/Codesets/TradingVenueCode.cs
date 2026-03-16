// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of a trading venue.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8UfE0F0fEeWErPfQ7BYx8A")]
[Description(@"Specifies the type of a trading venue.")]
[Derivations(typeof(TradingVenue2Code), typeof(TradingVenue1Code), typeof(MICEntityType1Code))]
public enum TradingVenueCode
{
    /// <summary>
    /// Organization that has the legally delegated or invested authority, capacity, or power to perform a designated function.
    /// Encoded/decoded by serializers as &quot;NACA&quot;.
    /// </summary>
    [EnumMember(Value = "NACA")]
    [IsoId("_CuUUsF0gEeWErPfQ7BYx8A")]
    [Description(
        @"Organization that has the legally delegated or invested authority, capacity, or power to perform a designated function."
    )]
    NationalCompetentAuthority,

    /// <summary>
    /// Person authorised under the provisions established in the regulation to provide the service of publishing trade reports on behalf of investment firms.
    /// Encoded/decoded by serializers as &quot;APPA&quot;.
    /// </summary>
    [EnumMember(Value = "APPA")]
    [IsoId("_Grk0cF0gEeWErPfQ7BYx8A")]
    [Description(
        @"Person authorised under the provisions established in the regulation to provide the service of publishing trade reports on behalf of investment firms."
    )]
    ApprovedPublicationArrangement,

    /// <summary>
    /// Investment firm which, on an organised, frequent systematic and substantial basis, deals on own account when executing client orders outside a regulated market, an multilateral trading facility or an organised trading facility without operating a multilateral system.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_N8YIkF0gEeWErPfQ7BYx8A")]
    [Description(
        @"Investment firm which, on an organised, frequent systematic and substantial basis, deals on own account when executing client orders outside a regulated market, an multilateral trading facility or an organised trading facility without operating a multilateral system."
    )]
    SystematicInternaliser,

    /// <summary>
    /// Multilateral system in which multiple third-party buying and selling trading interests in financial instruments.
    /// Encoded/decoded by serializers as &quot;TMIC&quot;.
    /// </summary>
    [EnumMember(Value = "TMIC")]
    [IsoId("_P_gd8F0gEeWErPfQ7BYx8A")]
    [Description(
        @"Multilateral system in which multiple third-party buying and selling trading interests in financial instruments."
    )]
    TradingVenue,

    /// <summary>
    /// Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.
    /// Encoded/decoded by serializers as &quot;MLTF&quot;.
    /// </summary>
    [EnumMember(Value = "MLTF")]
    [IsoId("_zKS-gHweEeWa36CuR-uOCw")]
    [Description(
        @"Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract."
    )]
    MultilateralTradingFacility,

    /// <summary>
    /// Multilateral system which is not a regulated market or multilateral trading facility in which multiple third-party buying and selling interests in bonds, structured finance products, emission allowances or derivatives are able to interact in a way that results in a contract.
    /// Encoded/decoded by serializers as &quot;OTFS&quot;.
    /// </summary>
    [EnumMember(Value = "OTFS")]
    [IsoId("_5mY4MHweEeWa36CuR-uOCw")]
    [Description(
        @"Multilateral system which is not a regulated market or multilateral trading facility in which multiple third-party buying and selling interests in bonds, structured finance products, emission allowances or derivatives are able to interact in a way that results in a contract."
    )]
    OrganisedTradingFacility,

    /// <summary>
    /// Provider which will consolidate post-trade information into a continuous electronic data stream and make it publicly available as close to real time as technologically possible on a reasonable commercial basis and free of charge after 15 minutes.
    /// Encoded/decoded by serializers as &quot;CTPS&quot;.
    /// </summary>
    [EnumMember(Value = "CTPS")]
    [IsoId("_GkRD4HwfEeWa36CuR-uOCw")]
    [Description(
        @"Provider which will consolidate post-trade information into a continuous electronic data stream and make it publicly available as close to real time as technologically possible on a reasonable commercial basis and free of charge after 15 minutes."
    )]
    ConsolidatedTapeProvider,

    /// <summary>
    /// Market on which financial instruments can be traded according to rules defined by the stock exchange.
    /// Encoded/decoded by serializers as &quot;RMKT&quot;.
    /// </summary>
    [EnumMember(Value = "RMKT")]
    [IsoId("_cdvSYcUtEeWuycXh3snGrg")]
    [Description(
        @"Market on which financial instruments can be traded according to rules defined by the stock exchange."
    )]
    RegulatedMarket,

    /// <summary>
    /// Market on which financial instruments can be traded according to rules defined by the stock exchange but accessible to qualified participant according to the current regulation.
    /// Encoded/decoded by serializers as &quot;RMQI&quot;.
    /// </summary>
    [EnumMember(Value = "RMQI")]
    [IsoId("_PdwPMH5WEemTJKg7hOVtNQ")]
    [Description(
        @"Market on which financial instruments can be traded according to rules defined by the stock exchange but accessible to qualified participant according to the current regulation."
    )]
    RegulatedMarketOrSegmentLimitedToQualifiedInvestors,

    /// <summary>
    /// Specific multilateral system which is a smaller and medium-sized enterprises Growth market and which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.
    /// Encoded/decoded by serializers as &quot;MSGM&quot;.
    /// </summary>
    [EnumMember(Value = "MSGM")]
    [IsoId("_bk180H5WEemTJKg7hOVtNQ")]
    [Description(
        @"Specific multilateral system which is a smaller and medium-sized enterprises Growth market and which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract."
    )]
    SMEGrowthMarketMultilateralTradingFacility,
}
