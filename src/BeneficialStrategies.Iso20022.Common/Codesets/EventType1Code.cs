// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of event.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aki609p-Ed-ak6NoX_4Aeg_-470397126")]
[Description(@"Identifies the type of event.")]
[DerivedFrom(typeof(EventTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EventType1Code>))]
#endif
public enum EventType1Code
{
    /// <summary>
    /// In fixed income this is the put provision on the bond allowing the investor the right to &quot;redeem the bond at a specified price prior to maturity&quot;.
    /// Encoded/decoded by serializers as &quot;PUT1&quot;.
    /// </summary>
    [EnumMember(Value = "PUT1")]
    [IsoId("_aki61Np-Ed-ak6NoX_4Aeg_1311076273")]
    [Description(
        @"In fixed income this is the put provision on the bond allowing the investor the right to ""redeem the bond at a specified price prior to maturity""."
    )]
    Put = EventTypeCode.Put, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In fixed income this is the call provision on the bond allowing the bond issuer &quot;the right to redeem [the bond] prior to its maturity date, under certain conditions.&quot;.
    /// Encoded/decoded by serializers as &quot;CALL&quot;.
    /// </summary>
    [EnumMember(Value = "CALL")]
    [IsoId("_aki61dp-Ed-ak6NoX_4Aeg_1311076290")]
    [Description(
        @"In fixed income this is the call provision on the bond allowing the bond issuer ""the right to redeem [the bond] prior to its maturity date, under certain conditions.""."
    )]
    Call = EventTypeCode.Call, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Synonymous with Put but is the preferred term for certain asset classes in some markets.
    /// Encoded/decoded by serializers as &quot;TEND&quot;.
    /// </summary>
    [EnumMember(Value = "TEND")]
    [IsoId("_aki61tp-Ed-ak6NoX_4Aeg_1311076291")]
    [Description(
        @"Synonymous with Put but is the preferred term for certain asset classes in some markets."
    )]
    Tender = EventTypeCode.Tender, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date when the security is activated for trading and clearing.
    /// Encoded/decoded by serializers as &quot;ACTI&quot;.
    /// </summary>
    [EnumMember(Value = "ACTI")]
    [IsoId("_aki619p-Ed-ak6NoX_4Aeg_1311076308")]
    [Description(@"Date when the security is activated for trading and clearing.")]
    Activation = EventTypeCode.Activation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date when the security is no longer available for trading and clearing.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_aki62Np-Ed-ak6NoX_4Aeg_1311076309")]
    [Description(@"Date when the security is no longer available for trading and clearing.")]
    Inactivation = EventTypeCode.Inactivation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A provision allowing a bond issuer the opportunity to buy outstanding bonds from bondholders for a set rate, using money (a sinking fund) from the issuer&apos;s earnings saved specifically for security buybacks. Because it adds doubt for investors over whether the bond will continue to pay until its maturity date, a sinking fund call is seen as an additional risk for investors.
    /// Encoded/decoded by serializers as &quot;SFCA&quot;.
    /// </summary>
    [EnumMember(Value = "SFCA")]
    [IsoId("_aksr0Np-Ed-ak6NoX_4Aeg_-368590761")]
    [Description(
        @"A provision allowing a bond issuer the opportunity to buy outstanding bonds from bondholders for a set rate, using money (a sinking fund) from the issuer's earnings saved specifically for security buybacks. Because it adds doubt for investors over whether the bond will continue to pay until its maturity date, a sinking fund call is seen as an additional risk for investors."
    )]
    SinkingFundCall = EventTypeCode.SinkingFundCall, // same ordinal as derivation source for type conversions
}
