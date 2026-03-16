// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if a trade party is a buyer or a seller.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aP_AFdp-Ed-ak6NoX_4Aeg_1203136897")]
[Description(@"Specifies if a trade party is a buyer or a seller.")]
[Derivations(typeof(OptionParty1Code), typeof(OptionParty3Code))]
public enum OptionPartyCode
{
    /// <summary>
    /// Seller in a trade.
    /// Encoded/decoded by serializers as &quot;SLLR&quot;.
    /// </summary>
    [EnumMember(Value = "SLLR")]
    [IsoId("_aP_AFtp-Ed-ak6NoX_4Aeg_1933638709")]
    [Description(@"Seller in a trade.")]
    Seller,

    /// <summary>
    /// Buyer in a trade.
    /// Encoded/decoded by serializers as &quot;BYER&quot;.
    /// </summary>
    [EnumMember(Value = "BYER")]
    [IsoId("_aP_AF9p-Ed-ak6NoX_4Aeg_1865301081")]
    [Description(@"Buyer in a trade.")]
    Buyer,

    /// <summary>
    /// Indicates the initiator of the trade.
    /// Encoded/decoded by serializers as &quot;TAKE&quot;.
    /// </summary>
    [EnumMember(Value = "TAKE")]
    [IsoId("_GvogoDxIEeWZTovCemTvqg")]
    [Description(@"Indicates the initiator of the trade.")]
    Taker,

    /// <summary>
    /// Indicates the receiver of the trade.
    /// Encoded/decoded by serializers as &quot;MAKE&quot;.
    /// </summary>
    [EnumMember(Value = "MAKE")]
    [IsoId("_KBoc4DxIEeWZTovCemTvqg")]
    [Description(@"Indicates the receiver of the trade.")]
    Maker,
}
