// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of a currency conversion request.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_sLedkEerEeODR7vDcYOqmg")]
[Description(@"Result of a currency conversion request.")]
[Derivations(typeof(CurrencyConversionResponse1Code),typeof(CurrencyConversionResponse2Code),typeof(CurrencyConversionResponse3Code))]
public enum CurrencyConversionResponseCode
{
    /// <summary>
    /// The card acceptor has not been recognised.
    /// Encoded/decoded by serializers as &quot;IMER&quot;.
    /// </summary>
    [EnumMember(Value = "IMER")]
    [IsoId("_zUhj4EerEeODR7vDcYOqmg")]
    [Description(@"The card acceptor has not been recognised.")]
    InvalidMerchant,
    
    /// <summary>
    /// The card is not valid for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;ICRD&quot;.
    /// </summary>
    [EnumMember(Value = "ICRD")]
    [IsoId("_6P2XQEerEeODR7vDcYOqmg")]
    [Description(@"The card is not valid for dynamic currency conversion.")]
    InvalidCard,
    
    /// <summary>
    /// Dynamic currency conversion service cannot be offered for this card product.
    /// Encoded/decoded by serializers as &quot;IPRD&quot;.
    /// </summary>
    [EnumMember(Value = "IPRD")]
    [IsoId("_-SjXsEerEeODR7vDcYOqmg")]
    [Description(@"Dynamic currency conversion service cannot be offered for this card product.")]
    InvalidProduct,
    
    /// <summary>
    /// Exchange rates are not available.
    /// Encoded/decoded by serializers as &quot;IRAT&quot;.
    /// </summary>
    [EnumMember(Value = "IRAT")]
    [IsoId("_GG0lQEesEeODR7vDcYOqmg")]
    [Description(@"Exchange rates are not available.")]
    NoRate,
    
    /// <summary>
    /// Dynamic currency conversion may be offered to the cardholder.
    /// Encoded/decoded by serializers as &quot;ODCC&quot;.
    /// </summary>
    [EnumMember(Value = "ODCC")]
    [IsoId("_NRrCYEesEeODR7vDcYOqmg")]
    [Description(@"Dynamic currency conversion may be offered to the cardholder.")]
    Allowed,
    
    /// <summary>
    /// Transaction authorised with dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;DCCA&quot;.
    /// </summary>
    [EnumMember(Value = "DCCA")]
    [IsoId("_Q23ncEesEeODR7vDcYOqmg")]
    [Description(@"Transaction authorised with dynamic currency conversion.")]
    Assumed,
    
    /// <summary>
    /// Dynamic currency conversion is not available for other reason.
    /// Encoded/decoded by serializers as &quot;NDCC&quot;.
    /// </summary>
    [EnumMember(Value = "NDCC")]
    [IsoId("_U82lYEesEeODR7vDcYOqmg")]
    [Description(@"Dynamic currency conversion is not available for other reason.")]
    NotAvailable,
    
    /// <summary>
    /// The ATM is not valid for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;IATM&quot;.
    /// </summary>
    [EnumMember(Value = "IATM")]
    [IsoId("_Iv0o4K4ZEeW_TaP-ygI0SQ")]
    [Description(@"The ATM is not valid for dynamic currency conversion.")]
    InvalidATM,
    
    /// <summary>
    /// The ATM manager is not valid for dynamic currency conversion.
    /// Encoded/decoded by serializers as &quot;IAMG&quot;.
    /// </summary>
    [EnumMember(Value = "IAMG")]
    [IsoId("_MDR9sK4ZEeW_TaP-ygI0SQ")]
    [Description(@"The ATM manager is not valid for dynamic currency conversion.")]
    InvalidATMManager,
    
    /// <summary>
    /// Conversion accepted for the requested amount exclusively.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_Ft9aEK_VEeaepNKtQMrGAQ")]
    [Description(@"Conversion accepted for the requested amount exclusively.")]
    Restriction,
    
    /// <summary>
    /// Conversion accepted for a range of amounts.
    /// Encoded/decoded by serializers as &quot;CATG&quot;.
    /// </summary>
    [EnumMember(Value = "CATG")]
    [IsoId("_LJ43QK_VEeaepNKtQMrGAQ")]
    [Description(@"Conversion accepted for a range of amounts.")]
    Catalogue,
    
}
