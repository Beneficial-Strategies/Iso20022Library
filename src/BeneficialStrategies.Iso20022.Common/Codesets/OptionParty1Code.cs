// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if a trade party is a buyer or a seller.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aP_AEtp-Ed-ak6NoX_4Aeg_2105414994")]
[Description(@"Specifies if a trade party is a buyer or a seller.")]
[DerivedFrom(typeof(OptionPartyCode))]
public enum OptionParty1Code
{
    /// <summary>
    /// Seller in a trade.
    /// Encoded/decoded by serializers as &quot;SLLR&quot;.
    /// </summary>
    [EnumMember(Value = "SLLR")]
    [IsoId("_aP_AE9p-Ed-ak6NoX_4Aeg_-1870012986")]
    [Description(@"Seller in a trade.")]
    Seller = OptionPartyCode.Seller, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Buyer in a trade.
    /// Encoded/decoded by serializers as &quot;BYER&quot;.
    /// </summary>
    [EnumMember(Value = "BYER")]
    [IsoId("_aP_AFNp-Ed-ak6NoX_4Aeg_-1870012969")]
    [Description(@"Buyer in a trade.")]
    Buyer = OptionPartyCode.Buyer, // same ordinal as derivation source for type conversions
    
}
