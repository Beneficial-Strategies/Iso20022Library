// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of pricing calculation method.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aIreMNp-Ed-ak6NoX_4Aeg_-1724055266")]
[Description(@"Specifies the type of pricing calculation method.")]
[DerivedFrom(typeof(PriceMethodCode))]
public enum PriceMethod1Code
{
    /// <summary>
    /// Price will be calculated after the close of the dealing period. An investor, therefore, does not know the exact buy or sell price.
    /// Encoded/decoded by serializers as &quot;FORW&quot;.
    /// </summary>
    [EnumMember(Value = "FORW")]
    [IsoId("_aIreMdp-Ed-ak6NoX_4Aeg_-1724055265")]
    [Description(
        @"Price will be calculated after the close of the dealing period. An investor, therefore, does not know the exact buy or sell price."
    )]
    ForwardPrice = PriceMethodCode.ForwardPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is calculated at an earlier valuation point preceding the dealing period. An investor, therefore, knows the exact buy or sell price.
    /// Encoded/decoded by serializers as &quot;HIST&quot;.
    /// </summary>
    [EnumMember(Value = "HIST")]
    [IsoId("_aIreMtp-Ed-ak6NoX_4Aeg_-1724055264")]
    [Description(
        @"Price is calculated at an earlier valuation point preceding the dealing period. An investor, therefore, knows the exact buy or sell price."
    )]
    HistoricalPrice = PriceMethodCode.HistoricalPrice, // same ordinal as derivation source for type conversions
}
