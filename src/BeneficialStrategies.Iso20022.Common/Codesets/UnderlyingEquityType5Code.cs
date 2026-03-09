// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type for a contract for equity derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__Zu0kIHBEeaalK9UbuVGFw")]
[Description(@"Specifies the type for a contract for equity derivatives.")]
[DerivedFrom(typeof(UnderlyingTypeV3Code))]
public enum UnderlyingEquityType5Code
{
    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_Q7CIIYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is of other type.")]
    Other = UnderlyingTypeV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is an exchange traded fund.
    /// Encoded/decoded by serializers as &quot;ETFS&quot;.
    /// </summary>
    [EnumMember(Value = "ETFS")]
    [IsoId("_RTu8AYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is an exchange traded fund.")]
    ExchangeTradedFund = UnderlyingTypeV3Code.ExchangeTradedFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is a share.
    /// Encoded/decoded by serializers as &quot;SHRS&quot;.
    /// </summary>
    [EnumMember(Value = "SHRS")]
    [IsoId("_SPsN8YHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a share.")]
    Share = UnderlyingTypeV3Code.Share, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is a stock dividend.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_Ta0kUYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a stock dividend.")]
    StockDividend = UnderlyingTypeV3Code.StockDividend, // same ordinal as derivation source for type conversions
    
}
