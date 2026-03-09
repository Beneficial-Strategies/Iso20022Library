// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies whether an order is a non-margin, an opening margin or a closing margin order.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7DWUNp-Ed-ak6NoX_4Aeg_335335634")]
[Description(@"Identifies whether an order is a non-margin, an opening margin or a closing margin order.")]
[Derivations(typeof(CashMarginOrder1Code))]
public enum CashMarginOrderCode
{
    /// <summary>
    /// The principal owns the cash in case of a purchase, or the securities in case of a sale so the execution, if it occurs, will not generate any margin account opening or margin call.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_a7DWUdp-Ed-ak6NoX_4Aeg_335335635")]
    [Description(@"The principal owns the cash in case of a purchase, or the securities in case of a sale so the execution, if it occurs, will not generate any margin account opening or margin call.")]
    Cash,
    
    /// <summary>
    /// The principal order, if executed, will generate a margin account opening or margin call because the principal does not have the cash in case of a purchase or the securities in case of a sale.
    /// Encoded/decoded by serializers as &quot;MRGO&quot;.
    /// </summary>
    [EnumMember(Value = "MRGO")]
    [IsoId("_a7DWUtp-Ed-ak6NoX_4Aeg_335335636")]
    [Description(@"The principal order, if executed, will generate a margin account opening or margin call because the principal does not have the cash in case of a purchase or the securities in case of a sale.")]
    MarginOpen,
    
    /// <summary>
    /// The principal order, if executed, will enable the margin position to be closed and the positions to be covered (for example: purchase of securities that have previously been short-sold, or sale of securities that have been bought on margin).
    /// Encoded/decoded by serializers as &quot;MRGC&quot;.
    /// </summary>
    [EnumMember(Value = "MRGC")]
    [IsoId("_a7DWU9p-Ed-ak6NoX_4Aeg_335335637")]
    [Description(@"The principal order, if executed, will enable the margin position to be closed and the positions to be covered (for example: purchase of securities that have previously been short-sold, or sale of securities that have been bought on margin).")]
    MarginClose,
    
}
