// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of a requested currency conversion.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fRlkkEesEeODR7vDcYOqmg")]
[Description(@"Result of a requested currency conversion.")]
[DerivedFrom(typeof(CurrencyConversionResponseCode))]
public enum CurrencyConversionResponse1Code
{
    /// <summary>
    /// Dynamic currency conversion may be offered to the cardholder.
    /// Encoded/decoded by serializers as &quot;ODCC&quot;.
    /// </summary>
    [EnumMember(Value = "ODCC")]
    [IsoId("_iDXIoUesEeODR7vDcYOqmg")]
    [Description(@"Dynamic currency conversion may be offered to the cardholder.")]
    Allowed = CurrencyConversionResponseCode.Allowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction authorised with dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCA&quot;.
    /// </summary>
    [EnumMember(Value = "DCCA")]
    [IsoId("_iK9lc0esEeODR7vDcYOqmg")]
    [Description(@"Transaction authorised with dynamic currency conversion.")]
    Assumed = CurrencyConversionResponseCode.Assumed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The card is not valid for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;ICRD&quot;.
    /// </summary>
    [EnumMember(Value = "ICRD")]
    [IsoId("_iOrn0UesEeODR7vDcYOqmg")]
    [Description(@"The card is not valid for dynamic currency conversion.")]
    InvalidCard = CurrencyConversionResponseCode.InvalidCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The card acceptor has not been recognised.
    /// Encoded/decoded by serializers as &quot;IMER&quot;.
    /// </summary>
    [EnumMember(Value = "IMER")]
    [IsoId("_iYN-U0esEeODR7vDcYOqmg")]
    [Description(@"The card acceptor has not been recognised.")]
    InvalidMerchant = CurrencyConversionResponseCode.InvalidMerchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dynamic currency conversion service cannot be offered for this card product.
    /// Encoded/decoded by serializers as &quot;IPRD&quot;.
    /// </summary>
    [EnumMember(Value = "IPRD")]
    [IsoId("_ib8nwUesEeODR7vDcYOqmg")]
    [Description(@"Dynamic currency conversion service cannot be offered for this card product.")]
    InvalidProduct = CurrencyConversionResponseCode.InvalidProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange rates are not available.
    /// Encoded/decoded by serializers as &quot;IRAT&quot;.
    /// </summary>
    [EnumMember(Value = "IRAT")]
    [IsoId("_iipss0esEeODR7vDcYOqmg")]
    [Description(@"Exchange rates are not available.")]
    NoRate = CurrencyConversionResponseCode.NoRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dynamic currency conversion is not available for other reason.
    /// Encoded/decoded by serializers as &quot;NDCC&quot;.
    /// </summary>
    [EnumMember(Value = "NDCC")]
    [IsoId("_ipWxo0esEeODR7vDcYOqmg")]
    [Description(@"Dynamic currency conversion is not available for other reason.")]
    NotAvailable = CurrencyConversionResponseCode.NotAvailable, // same ordinal as derivation source for type conversions
}
