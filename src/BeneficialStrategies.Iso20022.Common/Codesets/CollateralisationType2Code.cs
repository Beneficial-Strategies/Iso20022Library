// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of collateral agreement between two parties.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_A1iQsFfjEeqqKf65rDYWYw")]
[Description(@"Specifies the type of collateral agreement between two parties.")]
[DerivedFrom(typeof(CollateralisationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CollateralisationType2Code>))]
#endif
public enum CollateralisationType2Code
{
    /// <summary>
    /// The collateral agreement between the counterparties stipulates that both counterparties post initial margin and regularly post variation margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;FLCL&quot;.
    /// </summary>
    [EnumMember(Value = "FLCL")]
    [IsoId("_D1TNcVfjEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that both counterparties post initial margin and regularly post variation margin with respect to the derivative transaction."
    )]
    FullyCollateralised = CollateralisationTypeCode.FullyCollateralised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;OWC1&quot;.
    /// </summary>
    [EnumMember(Value = "OWC1")]
    [IsoId("_Ehe-AVfjEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty does not post any margin with respect to the derivative transaction."
    )]
    OneWayCollateralisedCounterparty1 = CollateralisationTypeCode.OneWayCollateralisedCounterparty1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;OWC2&quot;.
    /// </summary>
    [EnumMember(Value = "OWC2")]
    [IsoId("_Ep0aoVfjEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction."
    )]
    OneWayCollateralisedCounterparty2 = CollateralisationTypeCode.OneWayCollateralisedCounterparty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty regularly posts only variation margin.
    /// Encoded/decoded by serializers as &quot;OWP1&quot;.
    /// </summary>
    [EnumMember(Value = "OWP1")]
    [IsoId("_EzpFAVfjEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the reporting counterparty posts the initial margin and regularly posts variation margin and that the other counterparty regularly posts only variation margin. "
    )]
    OneWayPartiallyCollateralisedCounterparty1 =
        CollateralisationTypeCode.OneWayPartiallyCollateralisedCounterparty1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty regularly posts only variation margin.
    /// Encoded/decoded by serializers as &quot;OWP2&quot;.
    /// </summary>
    [EnumMember(Value = "OWP2")]
    [IsoId("_E-DlQVfjEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the other counterparty posts the initial margin and regularly posts variation margin and that the reporting counterparty regularly posts only variation margin."
    )]
    OneWayPartiallyCollateralisedCounterparty2 =
        CollateralisationTypeCode.OneWayPartiallyCollateralisedCounterparty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that both counterparties regularly post only variation margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;PRCL&quot;.
    /// </summary>
    [EnumMember(Value = "PRCL")]
    [IsoId("_FmqdYVfjEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that both counterparties regularly post only variation margin with respect to the derivative transaction."
    )]
    PartiallyCollateralised = CollateralisationTypeCode.PartiallyCollateralised, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the reporting counterparty regularly  posts only variation margin and that the other counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;PRC1&quot;.
    /// </summary>
    [EnumMember(Value = "PRC1")]
    [IsoId("_GISjwVfjEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the reporting counterparty regularly  posts only variation margin and that the other counterparty does not post any margin with respect to the derivative transaction."
    )]
    PartiallyCollateralisedCounterparty1 =
        CollateralisationTypeCode.PartiallyCollateralisedCounterparty1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The collateral agreement between the counterparties stipulates that the other counterparty regularly posts only variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;PRC2&quot;.
    /// </summary>
    [EnumMember(Value = "PRC2")]
    [IsoId("_GREFQVfjEeqqKf65rDYWYw")]
    [Description(
        @"The collateral agreement between the counterparties stipulates that the other counterparty regularly posts only variation margin and that the reporting counterparty does not post any margin with respect to the derivative transaction."
    )]
    PartiallyCollateralisedCounterparty2 =
        CollateralisationTypeCode.PartiallyCollateralisedCounterparty2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// There is no collateral agreement between the counterparties or the collateral agreement between the counterparties stipulates that no collateral (neither initial margin nor variation margin) has to be posted with respect to the derivative transaction.
    /// Encoded/decoded by serializers as &quot;UNCL&quot;.
    /// </summary>
    [EnumMember(Value = "UNCL")]
    [IsoId("_GoH6YVfjEeqqKf65rDYWYw")]
    [Description(
        @"There is no collateral agreement between the counterparties or the collateral agreement between the counterparties stipulates that no collateral (neither initial margin nor variation margin) has to be posted with respect to the derivative transaction."
    )]
    Uncollateralised = CollateralisationTypeCode.Uncollateralised, // same ordinal as derivation source for type conversions
}
