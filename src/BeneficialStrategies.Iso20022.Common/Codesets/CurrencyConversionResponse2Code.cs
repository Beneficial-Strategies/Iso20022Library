// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of a requested currency conversion.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QOgoAa4ZEeW_TaP-ygI0SQ")]
[Description(@"Result of a requested currency conversion.")]
[DerivedFrom(typeof(CurrencyConversionResponseCode))]
public enum CurrencyConversionResponse2Code
{
    /// <summary>
    /// Dynamic currency conversion may be offered to the cardholder.
    /// Encoded/decoded by serializers as &quot;ODCC&quot;.
    /// </summary>
    [EnumMember(Value = "ODCC")]
    [IsoId("_QZPRUa4ZEeW_TaP-ygI0SQ")]
    [Description(@"Dynamic currency conversion may be offered to the cardholder.")]
    Allowed = CurrencyConversionResponseCode.Allowed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The card is not valid for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;ICRD&quot;.
    /// </summary>
    [EnumMember(Value = "ICRD")]
    [IsoId("_QZPRVa4ZEeW_TaP-ygI0SQ")]
    [Description(@"The card is not valid for dynamic currency conversion.")]
    InvalidCard = CurrencyConversionResponseCode.InvalidCard, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dynamic currency conversion service cannot be offered for this card product.
    /// Encoded/decoded by serializers as &quot;IPRD&quot;.
    /// </summary>
    [EnumMember(Value = "IPRD")]
    [IsoId("_QZPRWa4ZEeW_TaP-ygI0SQ")]
    [Description(@"Dynamic currency conversion service cannot be offered for this card product.")]
    InvalidProduct = CurrencyConversionResponseCode.InvalidProduct, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Exchange rates are not available.
    /// Encoded/decoded by serializers as &quot;IRAT&quot;.
    /// </summary>
    [EnumMember(Value = "IRAT")]
    [IsoId("_QZPRW64ZEeW_TaP-ygI0SQ")]
    [Description(@"Exchange rates are not available.")]
    NoRate = CurrencyConversionResponseCode.NoRate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dynamic currency conversion is not available for other reason.
    /// Encoded/decoded by serializers as &quot;NDCC&quot;.
    /// </summary>
    [EnumMember(Value = "NDCC")]
    [IsoId("_QZPRXa4ZEeW_TaP-ygI0SQ")]
    [Description(@"Dynamic currency conversion is not available for other reason.")]
    NotAvailable = CurrencyConversionResponseCode.NotAvailable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The ATM manager is not valid for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;IAMG&quot;.
    /// </summary>
    [EnumMember(Value = "IAMG")]
    [IsoId("_Ulf2Ya4ZEeW_TaP-ygI0SQ")]
    [Description(@"The ATM manager is not valid for dynamic currency conversion.")]
    InvalidATMManager = CurrencyConversionResponseCode.InvalidATMManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The ATM is not valid for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;IATM&quot;.
    /// </summary>
    [EnumMember(Value = "IATM")]
    [IsoId("_UsWsUa4ZEeW_TaP-ygI0SQ")]
    [Description(@"The ATM is not valid for dynamic currency conversion.")]
    InvalidATM = CurrencyConversionResponseCode.InvalidATM, // same ordinal as derivation source for type conversions
}
