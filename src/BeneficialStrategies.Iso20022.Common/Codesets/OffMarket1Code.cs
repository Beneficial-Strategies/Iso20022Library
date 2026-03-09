// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the trade was executed off-market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aOfyUdp-Ed-ak6NoX_4Aeg_1810038493")]
[Description(@"Indicates that the trade was executed off-market.")]
[DerivedFrom(typeof(OffMarketCode))]
public enum OffMarket1Code
{
    /// <summary>
    /// Trade was executed off-market.
    /// Encoded/decoded by serializers as &quot;XOFF&quot;.
    /// </summary>
    [EnumMember(Value = "XOFF")]
    [IsoId("_aOfyUtp-Ed-ak6NoX_4Aeg_-2050871151")]
    [Description(@"Trade was executed off-market.")]
    OffMarket = OffMarketCode.OffMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade was executed off-exchange because the instrument is not admitted to trade on an exchange.
    /// Encoded/decoded by serializers as &quot;XXXX&quot;.
    /// </summary>
    [EnumMember(Value = "XXXX")]
    [IsoId("_aOfyU9p-Ed-ak6NoX_4Aeg_-103068136")]
    [Description(@"Trade was executed off-exchange because the instrument is not admitted to trade on an exchange.")]
    NotAdmittedOnExchange = OffMarketCode.NotAdmittedOnExchange, // same ordinal as derivation source for type conversions
    
}
