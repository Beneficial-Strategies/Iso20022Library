// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of detail amount
/// </summary>
[DataContract]
[Serializable]
[IsoId("_BM4rsBbxEeit0dtP9bTmEg")]
[Description(@"Type of detail amount")]
[Derivations(typeof(DetailAmount2Code), typeof(DetailAmount1Code))]
public enum DetailAmountCode
{
    /// <summary>
    /// Cashback amount
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_FqYxwBbxEeit0dtP9bTmEg")]
    [Description(@"Cashback amount")]
    Cashback,

    /// <summary>
    /// Dynamic Currency Conversion type of amount
    /// Encoded/decoded by serializers as &quot;DCCF&quot;.
    /// </summary>
    [EnumMember(Value = "DCCF")]
    [IsoId("_RauzUBbxEeit0dtP9bTmEg")]
    [Description(@"Dynamic Currency Conversion type of amount")]
    DynamicCurrencyConversionFee,

    /// <summary>
    /// Donation amount
    /// Encoded/decoded by serializers as &quot;DONN&quot;.
    /// </summary>
    [EnumMember(Value = "DONN")]
    [IsoId("_fQFZkBbxEeit0dtP9bTmEg")]
    [Description(@"Donation amount")]
    Donation,

    /// <summary>
    /// Extra charges (for example, minibar, etc.)
    /// Encoded/decoded by serializers as &quot;EXTR&quot;.
    /// </summary>
    [EnumMember(Value = "EXTR")]
    [IsoId("_k5c10BbxEeit0dtP9bTmEg")]
    [Description(@"Extra charges (for example, minibar, etc.)")]
    Extra,

    /// <summary>
    /// Gratuity amount
    /// Encoded/decoded by serializers as &quot;GRTY&quot;.
    /// </summary>
    [EnumMember(Value = "GRTY")]
    [IsoId("_tCmuQBbxEeit0dtP9bTmEg")]
    [Description(@"Gratuity amount")]
    Gratuity,

    /// <summary>
    /// Other type of amount defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_y7vr4BbxEeit0dtP9bTmEg")]
    [Description(@"Other type of amount defined at national level")]
    OtherNational,

    /// <summary>
    /// Other type of amount defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_5BY0cBbxEeit0dtP9bTmEg")]
    [Description(@"Other type of amount defined at private level")]
    OtherPrivate,

    /// <summary>
    /// Fee charged by the acceptor for the transaction.
    /// Encoded/decoded by serializers as &quot;SRCH&quot;.
    /// </summary>
    [EnumMember(Value = "SRCH")]
    [IsoId("_-ZNNsBbxEeit0dtP9bTmEg")]
    [Description(@"Fee charged by the acceptor for the transaction.")]
    Surcharge,

    /// <summary>
    /// Tax applicable to the transaction
    /// Encoded/decoded by serializers as &quot;TAXT&quot;.
    /// </summary>
    [EnumMember(Value = "TAXT")]
    [IsoId("_HJ7ccBbyEeit0dtP9bTmEg")]
    [Description(@"Tax applicable to the transaction")]
    Tax,

    /// <summary>
    /// Fee applicable to a foreign exchange (Forex) transaction
    /// Encoded/decoded by serializers as &quot;FORX&quot;.
    /// </summary>
    [EnumMember(Value = "FORX")]
    [IsoId("_OB2WgBbyEeit0dtP9bTmEg")]
    [Description(@"Fee applicable to a foreign exchange (Forex) transaction")]
    ForeignExchangeFee,
}
