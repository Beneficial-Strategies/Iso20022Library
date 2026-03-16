// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of entity which has been assigned a MIC code.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t5NoYC6mEeiLE6ldFr13hQ")]
[Description(@"Specifies the type of entity which has been assigned a MIC code.")]
[DerivedFrom(typeof(TradingVenueCode))]
public enum MICEntityType1Code
{
    /// <summary>
    /// Person authorised under the provisions established in the regulation to provide the service of publishing trade reports on behalf of investment firms.
    /// Encoded/decoded by serializers as &quot;APPA&quot;.
    /// </summary>
    [EnumMember(Value = "APPA")]
    [IsoId("_vs3-YS6mEeiLE6ldFr13hQ")]
    [Description(
        @"Person authorised under the provisions established in the regulation to provide the service of publishing trade reports on behalf of investment firms."
    )]
    ApprovedPublicationArrangement = TradingVenueCode.ApprovedPublicationArrangement, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Provider which will consolidate post-trade information into a continuous electronic data stream and make it publicly available as close to real time as technologically possible on a reasonable commercial basis and free of charge after 15 minutes.
    /// Encoded/decoded by serializers as &quot;CTPS&quot;.
    /// </summary>
    [EnumMember(Value = "CTPS")]
    [IsoId("_vzI-cS6mEeiLE6ldFr13hQ")]
    [Description(
        @"Provider which will consolidate post-trade information into a continuous electronic data stream and make it publicly available as close to real time as technologically possible on a reasonable commercial basis and free of charge after 15 minutes."
    )]
    ConsolidatedTapeProvider = TradingVenueCode.ConsolidatedTapeProvider, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract.
    /// Encoded/decoded by serializers as &quot;MLTF&quot;.
    /// </summary>
    [EnumMember(Value = "MLTF")]
    [IsoId("_v6SvUS6mEeiLE6ldFr13hQ")]
    [Description(
        @"Multilateral system which brings together multiple third-party buying and selling interests in financial instruments in a way that results in a contract."
    )]
    MultilateralTradingFacility = TradingVenueCode.MultilateralTradingFacility, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Multilateral system which is not a regulated market or multilateral trading facility in which multiple third-party buying and selling interests in bonds, structured finance products, emission allowances or derivatives are able to interact in a way that results in a contract.
    /// Encoded/decoded by serializers as &quot;OTFS&quot;.
    /// </summary>
    [EnumMember(Value = "OTFS")]
    [IsoId("_wNgmQS6mEeiLE6ldFr13hQ")]
    [Description(
        @"Multilateral system which is not a regulated market or multilateral trading facility in which multiple third-party buying and selling interests in bonds, structured finance products, emission allowances or derivatives are able to interact in a way that results in a contract."
    )]
    OrganisedTradingFacility = TradingVenueCode.OrganisedTradingFacility, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Market on which financial instruments can be traded according to rules defined by the stock exchange.
    /// Encoded/decoded by serializers as &quot;RMKT&quot;.
    /// </summary>
    [EnumMember(Value = "RMKT")]
    [IsoId("_wTU6YS6mEeiLE6ldFr13hQ")]
    [Description(
        @"Market on which financial instruments can be traded according to rules defined by the stock exchange."
    )]
    RegulatedMarket = TradingVenueCode.RegulatedMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Investment firm which, on an organised, frequent systematic and substantial basis, deals on own account when executing client orders outside a regulated market, an multilateral trading facility or an organised trading facility without operating a multilateral system.
    /// Encoded/decoded by serializers as &quot;SINT&quot;.
    /// </summary>
    [EnumMember(Value = "SINT")]
    [IsoId("_wcju4S6mEeiLE6ldFr13hQ")]
    [Description(
        @"Investment firm which, on an organised, frequent systematic and substantial basis, deals on own account when executing client orders outside a regulated market, an multilateral trading facility or an organised trading facility without operating a multilateral system."
    )]
    SystematicInternaliser = TradingVenueCode.SystematicInternaliser, // same ordinal as derivation source for type conversions
}
