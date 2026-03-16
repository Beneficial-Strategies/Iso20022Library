// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral agreement between two parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_dUlFoPP5EeS_qLctCs2aRQ")]
[Description(@"Specifies the type of collateral agreement between two parties.")]
[Derivations(
    typeof(CollateralisationType1Code),
    typeof(CollateralisationType2Code),
    typeof(CollateralisationType3Code)
)]
public enum CollateralisationTypeCode
{
    /// <summary>
    /// There is no collateral agreement between the counterparties or the collateral agreement between the counterparties stipulates that no collateral (neither initial margin nor variation margin) has to be posted with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;UNCL&quot;.
    /// </summary>
    [EnumMember(Value = "UNCL")]
    [IsoId("_nE-osPP5EeS_qLctCs2aRQ")]
    [Description(
        @"There is no collateral agreement between the counterparties or the collateral agreement between the counterparties stipulates that no collateral (neither initial margin nor variation margin) has to be posted with respect to the derivative transaction."
    )]
    Uncollateralised,

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that both counterparties regularly post only variation margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;PRCL&quot;.
    /// </summary>
    [EnumMember(Value = "PRCL")]
    [IsoId("_sW2K8PP5EeS_qLctCs2aRQ")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that both counterparties regularly post only variation margin with respect to the derivative transaction."
    )]
    PartiallyCollateralised,

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that one counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;OWCL&quot;.
    /// </summary>
    [EnumMember(Value = "OWCL")]
    [IsoId("_siASEPP5EeS_qLctCs2aRQ")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that one counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction."
    )]
    OneWayCollateralised,

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that both counterparties post initial margin and regularly post variation margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;FLCL&quot;.
    /// </summary>
    [EnumMember(Value = "FLCL")]
    [IsoId("_sl4FcPP5EeS_qLctCs2aRQ")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that both counterparties post initial margin and regularly post variation margin with respect to the derivative transaction."
    )]
    FullyCollateralised,

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the reporting counterparty regularly  posts only variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;PRC1&quot;.
    /// </summary>
    [EnumMember(Value = "PRC1")]
    [IsoId("_5xzksFfhEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the reporting counterparty regularly  posts only variation margin and that the other counterparty does not post any margin with respect to the derivative transaction."
    )]
    PartiallyCollateralisedCounterparty1,

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the other counterparty regularly posts only variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;PRC2&quot;.
    /// </summary>
    [EnumMember(Value = "PRC2")]
    [IsoId("_HZxPMFfiEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the other counterparty regularly posts only variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction."
    )]
    PartiallyCollateralisedCounterparty2,

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;OWC1&quot;.
    /// </summary>
    [EnumMember(Value = "OWC1")]
    [IsoId("_Zp8a8FfiEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction."
    )]
    OneWayCollateralisedCounterparty1,

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;OWC2&quot;.
    /// </summary>
    [EnumMember(Value = "OWC2")]
    [IsoId("_lmV7gFfiEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction."
    )]
    OneWayCollateralisedCounterparty2,

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty regularly posts only variation margin.
    /// Encoded/decoded by serializers as &quot;OWP1&quot;.
    /// </summary>
    [EnumMember(Value = "OWP1")]
    [IsoId("_sTQfcFfiEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty regularly posts only variation margin. "
    )]
    OneWayPartiallyCollateralisedCounterparty1,

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty regularly posts only variation margin.
    /// Encoded/decoded by serializers as &quot;OWP2&quot;.
    /// </summary>
    [EnumMember(Value = "OWP2")]
    [IsoId("_31LqgFfiEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty regularly posts only variation margin."
    )]
    OneWayPartiallyCollateralisedCounterparty2,
}
