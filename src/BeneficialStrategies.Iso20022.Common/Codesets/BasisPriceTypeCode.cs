// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Basis price type in a bid order. Used for list trading.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bdLL-dp-Ed-ak6NoX_4Aeg_335335188")]
[Description(@"Basis price type in a bid order. Used for list trading.")]
[Derivations(typeof(BasisPriceType1Code))]
public enum BasisPriceTypeCode
{
    /// <summary>
    /// Closing price at morning session.
    /// Encoded/decoded by serializers as &quot;MSCP&quot;.
    /// </summary>
    [EnumMember(Value = "MSCP")]
    [IsoId("_bdUV4Np-Ed-ak6NoX_4Aeg_335335189")]
    [Description(@"Closing price at morning session.")]
    MorningSessionClosePrice,
    
    /// <summary>
    /// Closing price.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_bdUV4dp-Ed-ak6NoX_4Aeg_335335446")]
    [Description(@"Closing price.")]
    ClosingPrice,
    
    /// <summary>
    /// Current price.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_bdUV4tp-Ed-ak6NoX_4Aeg_335335447")]
    [Description(@"Current price.")]
    CurrentPrice,
    
    /// <summary>
    /// Price computed after a trading halt.
    /// Encoded/decoded by serializers as &quot;SPQO&quot;.
    /// </summary>
    [EnumMember(Value = "SPQO")]
    [IsoId("_bdUV49p-Ed-ak6NoX_4Aeg_335335448")]
    [Description(@"Price computed after a trading halt.")]
    SpecialQuotation,
    
    /// <summary>
    /// Value weighted average price through the day.
    /// Encoded/decoded by serializers as &quot;VWPD&quot;.
    /// </summary>
    [EnumMember(Value = "VWPD")]
    [IsoId("_bdUV5Np-Ed-ak6NoX_4Aeg_335335449")]
    [Description(@"Value weighted average price through the day.")]
    VWAPDay,
    
    /// <summary>
    /// Value weighted average price through a morning session.
    /// Encoded/decoded by serializers as &quot;VWPM&quot;.
    /// </summary>
    [EnumMember(Value = "VWPM")]
    [IsoId("_bdUV5dp-Ed-ak6NoX_4Aeg_335335450")]
    [Description(@"Value weighted average price through a morning session.")]
    VWAPMorning,
    
    /// <summary>
    /// Value weighted average price through an afternoon session.
    /// Encoded/decoded by serializers as &quot;VWPA&quot;.
    /// </summary>
    [EnumMember(Value = "VWPA")]
    [IsoId("_bdUV5tp-Ed-ak6NoX_4Aeg_335335451")]
    [Description(@"Value weighted average price through an afternoon session.")]
    VWAPAfternoon,
    
    /// <summary>
    /// Exercise price defined on a derivative product.
    /// Encoded/decoded by serializers as &quot;STIK&quot;.
    /// </summary>
    [EnumMember(Value = "STIK")]
    [IsoId("_bdUV59p-Ed-ak6NoX_4Aeg_335335452")]
    [Description(@"Exercise price defined on a derivative product.")]
    StrikePrice,
    
    /// <summary>
    /// Price of a trade opening session.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_bdUV6Np-Ed-ak6NoX_4Aeg_335335453")]
    [Description(@"Price of a trade opening session.")]
    OpenPrice,
    
}
