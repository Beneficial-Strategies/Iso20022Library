// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies to which institution the reporting must be done.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTMAptp-Ed-ak6NoX_4Aeg_974356909")]
[Description(@"Identifies to which institution the reporting must be done.")]
[Derivations(typeof(Reporting2Code),typeof(Reporting1Code),typeof(Reporting3Code))]
public enum ReportingCode
{
    /// <summary>
    /// Trade details are to be reported to a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_ZTMAp9p-Ed-ak6NoX_4Aeg_1418569257")]
    [Description(@"Trade details are to be reported to a stock exchange.")]
    StockExchange,
    
    /// <summary>
    /// Trade details are to be reported to a regulatory organisation.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_ZTVxoNp-Ed-ak6NoX_4Aeg_1418569300")]
    [Description(@"Trade details are to be reported to a regulatory organisation.")]
    RegulatoryOrganisation,
    
    /// <summary>
    /// Report is deferred, for example, because the order was executed in partial fills.
    /// Encoded/decoded by serializers as &quot;DEFR&quot;.
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_ZTVxodp-Ed-ak6NoX_4Aeg_1439267994")]
    [Description(@"Report is deferred, for example, because the order was executed in partial fills.")]
    DeferredReport,
    
    /// <summary>
    /// Relates to a buy-in by the market following a delivery transaction failure.
    /// Encoded/decoded by serializers as &quot;BYIY&quot;.
    /// </summary>
    [EnumMember(Value = "BYIY")]
    [IsoId("_4sHBoNB1EeihG9bKfarOOA")]
    [Description(@"Relates to a buy-in by the market following a delivery transaction failure.")]
    BuyIn,
    
}
