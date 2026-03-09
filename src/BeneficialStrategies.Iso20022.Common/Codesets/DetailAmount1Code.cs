// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of detail amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ad8DwBbyEeit0dtP9bTmEg")]
[Description(@"Type of detail amount.")]
[DerivedFrom(typeof(DetailAmountCode))]
public enum DetailAmount1Code
{
    /// <summary>
    /// Cashback amount
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_eFR94RbyEeit0dtP9bTmEg")]
    [Description(@"Cashback amount")]
    Cashback = DetailAmountCode.Cashback, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Donation amount
    /// Encoded/decoded by serializers as &quot;DONN&quot;.
    /// </summary>
    [EnumMember(Value = "DONN")]
    [IsoId("_ef6rcRbyEeit0dtP9bTmEg")]
    [Description(@"Donation amount")]
    Donation = DetailAmountCode.Donation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dynamic Currency Conversion type of amount
    /// Encoded/decoded by serializers as &quot;DCCF&quot;.
    /// </summary>
    [EnumMember(Value = "DCCF")]
    [IsoId("_eqBpsRbyEeit0dtP9bTmEg")]
    [Description(@"Dynamic Currency Conversion type of amount")]
    DynamicCurrencyConversionFee = DetailAmountCode.DynamicCurrencyConversionFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Extra charges (for example, minibar, etc.)
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("_e4BCYRbyEeit0dtP9bTmEg")]
    [Description(@"Extra charges (for example, minibar, etc.)")]
    Extra = DetailAmountCode.Extra, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee applicable to a foreign exchange (Forex) transaction
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_fCkskRbyEeit0dtP9bTmEg")]
    [Description(@"Fee applicable to a foreign exchange (Forex) transaction")]
    ForeignExchangeFee = DetailAmountCode.ForeignExchangeFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Gratuity amount
    /// Encoded/decoded by serializers as &quot;GRTY&quot;.
    /// </summary>
    [EnumMember(Value = "GRTY")]
    [IsoId("_fOVQoRbyEeit0dtP9bTmEg")]
    [Description(@"Gratuity amount")]
    Gratuity = DetailAmountCode.Gratuity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of amount defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_fcBHURbyEeit0dtP9bTmEg")]
    [Description(@"Other type of amount defined at national level")]
    OtherNational = DetailAmountCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of amount defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_fogrMRbyEeit0dtP9bTmEg")]
    [Description(@"Other type of amount defined at private level")]
    OtherPrivate = DetailAmountCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fee charged by the acceptor for the transaction.
    /// Encoded/decoded by serializers as &quot;SRCH&quot;.
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_f0aZMRbyEeit0dtP9bTmEg")]
    [Description(@"Fee charged by the acceptor for the transaction.")]
    Surcharge = DetailAmountCode.Surcharge, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax applicable to the transaction
    /// Encoded/decoded by serializers as &quot;TAXT&quot;.
    /// </summary>
    [EnumMember(Value = "TAXT")]
    [IsoId("_gECJkRbyEeit0dtP9bTmEg")]
    [Description(@"Tax applicable to the transaction")]
    Tax = DetailAmountCode.Tax, // same ordinal as derivation source for type conversions
    
}
