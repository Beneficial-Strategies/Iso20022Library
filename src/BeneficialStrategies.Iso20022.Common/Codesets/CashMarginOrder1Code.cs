// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies whether an order is a non-margin, an opening margin or a closing margin order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a65lVdp-Ed-ak6NoX_4Aeg_-1022295664")]
[Description(
    @"Identifies whether an order is a non-margin, an opening margin or a closing margin order."
)]
[DerivedFrom(typeof(CashMarginOrderCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CashMarginOrder1Code>))]
#endif
public enum CashMarginOrder1Code
{
    /// <summary>
    /// The principal owns the cash in case of a purchase, or the securities in case of a sale so the execution, if it occurs, will not generate any margin account opening or margin call.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_a65lVtp-Ed-ak6NoX_4Aeg_-964112479")]
    [Description(
        @"The principal owns the cash in case of a purchase, or the securities in case of a sale so the execution, if it occurs, will not generate any margin account opening or margin call."
    )]
    Cash = CashMarginOrderCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The principal order, if executed, will generate a margin account opening or margin call because the principal does not have the cash in case of a purchase or the securities in case of a sale.
    /// Encoded/decoded by serializers as &quot;MRGO&quot;.
    /// </summary>
    [EnumMember(Value = "MRGO")]
    [IsoId("_a65lV9p-Ed-ak6NoX_4Aeg_-964112454")]
    [Description(
        @"The principal order, if executed, will generate a margin account opening or margin call because the principal does not have the cash in case of a purchase or the securities in case of a sale."
    )]
    MarginOpen = CashMarginOrderCode.MarginOpen, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The principal order, if executed, will enable the margin position to be closed and the positions to be covered (for example: purchase of securities that have previously been short-sold, or sale of securities that have been bought on margin).
    /// Encoded/decoded by serializers as &quot;MRGC&quot;.
    /// </summary>
    [EnumMember(Value = "MRGC")]
    [IsoId("_a65lWNp-Ed-ak6NoX_4Aeg_-964112453")]
    [Description(
        @"The principal order, if executed, will enable the margin position to be closed and the positions to be covered (for example: purchase of securities that have previously been short-sold, or sale of securities that have been bought on margin)."
    )]
    MarginClose = CashMarginOrderCode.MarginClose, // same ordinal as derivation source for type conversions
}
