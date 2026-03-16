// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates that the trade was executed off-market.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aOfyVNp-Ed-ak6NoX_4Aeg_1937485685")]
[Description(@"Indicates that the trade was executed off-market.")]
[Derivations(typeof(OffMarket1Code))]
public enum OffMarketCode
{
    /// <summary>
    /// Trade was executed off-market.
    /// Encoded/decoded by serializers as &quot;XOFF&quot;.
    /// </summary>
    [EnumMember(Value = "XOFF")]
    [IsoId("_aOfyVdp-Ed-ak6NoX_4Aeg_-2107206762")]
    [Description(@"Trade was executed off-market.")]
    OffMarket,

    /// <summary>
    /// Trade was executed off-exchange because the instrument is not admitted to trade on an exchange.
    /// Encoded/decoded by serializers as &quot;XXXX&quot;.
    /// </summary>
    [EnumMember(Value = "XXXX")]
    [IsoId("_aOfyVtp-Ed-ak6NoX_4Aeg_199845376")]
    [Description(
        @"Trade was executed off-exchange because the instrument is not admitted to trade on an exchange."
    )]
    NotAdmittedOnExchange,
}
