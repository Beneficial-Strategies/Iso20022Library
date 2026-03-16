// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the role of a trading party in a transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YZOSyNp-Ed-ak6NoX_4Aeg_539037705")]
[Description(@"Specifies the role of a trading party in a transaction.")]
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
public enum TradingCapacity2Code
{
    /// <summary>
    /// Broker is buying or selling securities for its own account.
    /// Encoded/decoded by serializers as &quot;PRIN&quot;.
    /// </summary>
    [EnumMember(Value = "PRIN")]
    [IsoId("_YZOSydp-Ed-ak6NoX_4Aeg_936150344")]
    [Description(@"Broker is buying or selling securities for its own account.")]
    TradingPrincipal,

    /// <summary>
    /// Broker is trading on behalf of another party.
    /// Encoded/decoded by serializers as &quot;TAGN&quot;.
    /// </summary>
    [EnumMember(Value = "TAGN")]
    [IsoId("_YZOSytp-Ed-ak6NoX_4Aeg_936150369")]
    [Description(@"Broker is trading on behalf of another party.")]
    TradingAgent,
}
