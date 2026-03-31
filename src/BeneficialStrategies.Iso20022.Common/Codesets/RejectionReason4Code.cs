// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for which an execution has not been accepted.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_VvDLgtp-Ed-ak6NoX_4Aeg_-189673926")]
[Description(@"Specifies the reason for which an execution has not been accepted.")]
[DerivedFrom(typeof(RejectionReasonCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RejectionReason4Code>))]
#endif
public enum RejectionReason4Code
{
    /// <summary>
    /// Financial instrument&apos;s symbol has not been recognized.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_VvDLg9p-Ed-ak6NoX_4Aeg_-131495484")]
    [Description(@"Financial instrument's symbol has not been recognized.")]
    UnknownSymbol = RejectionReasonCode.UnknownSymbol, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is for the wrong side.
    /// Encoded/decoded by serializers as &quot;SIDE&quot;.
    /// </summary>
    [EnumMember(Value = "SIDE")]
    [IsoId("_VvDLhNp-Ed-ak6NoX_4Aeg_-127799851")]
    [Description(@"Order is for the wrong side.")]
    WrongSide = RejectionReasonCode.WrongSide, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No counterparty order has been identified.
    /// Encoded/decoded by serializers as &quot;NMAT&quot;.
    /// </summary>
    [EnumMember(Value = "NMAT")]
    [IsoId("_VvDLhdp-Ed-ak6NoX_4Aeg_-59458814")]
    [Description(@"No counterparty order has been identified.")]
    NoMatchInquiry = RejectionReasonCode.NoMatchInquiry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity in the execution exceeds the ordered quantity.
    /// Encoded/decoded by serializers as &quot;EQTY&quot;.
    /// </summary>
    [EnumMember(Value = "EQTY")]
    [IsoId("_VvDLhtp-Ed-ak6NoX_4Aeg_394914525")]
    [Description(@"Quantity in the execution exceeds the ordered quantity.")]
    QuantityExceeds = RejectionReasonCode.QuantityExceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price in the execution exceeds the order price.
    /// Encoded/decoded by serializers as &quot;PRIC&quot;.
    /// </summary>
    [EnumMember(Value = "PRIC")]
    [IsoId("_VvDLh9p-Ed-ak6NoX_4Aeg_428161263")]
    [Description(@"Price in the execution exceeds the order price.")]
    PriceExceeds = RejectionReasonCode.PriceExceeds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// This is primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side&apos;s calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high.
    /// Encoded/decoded by serializers as &quot;CADI&quot;.
    /// </summary>
    [EnumMember(Value = "CADI")]
    [IsoId("_VvDLiNp-Ed-ak6NoX_4Aeg_-877151049")]
    [Description(
        @"This is primarily used when the Notice of Execution received by the buy-side contains fees, gross trade amount, net trade amount, etc., values that differ from the buy-side's calculations. Buy-side may reject the trade if they feel that the difference in calculations is too high."
    )]
    CalculationDifference = RejectionReasonCode.CalculationDifference, // same ordinal as derivation source for type conversions
}
