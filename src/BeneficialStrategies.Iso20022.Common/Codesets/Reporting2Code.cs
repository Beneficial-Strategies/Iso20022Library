// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies information with regards to reporting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTMAotp-Ed-ak6NoX_4Aeg_-582451382")]
[Description(@"Specifies information with regards to reporting.")]
[DerivedFrom(typeof(ReportingCode))]
public enum Reporting2Code
{
    /// <summary>
    /// Trade details are to be reported to a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_ZTMAo9p-Ed-ak6NoX_4Aeg_-495638960")]
    [Description(@"Trade details are to be reported to a stock exchange.")]
    StockExchange = ReportingCode.StockExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade details are to be reported to a regulatory organisation.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_ZTMApNp-Ed-ak6NoX_4Aeg_-255523631")]
    [Description(@"Trade details are to be reported to a regulatory organisation.")]
    RegulatoryOrganisation = ReportingCode.RegulatoryOrganisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Report is deferred, for example, because the order was executed in partial fills.
    /// Encoded/decoded by serializers as &quot;DEFR&quot;.
    /// </summary>
    [EnumMember(Value = "DEFR")]
    [IsoId("_ZTMApdp-Ed-ak6NoX_4Aeg_-210271843")]
    [Description(
        @"Report is deferred, for example, because the order was executed in partial fills."
    )]
    DeferredReport = ReportingCode.DeferredReport, // same ordinal as derivation source for type conversions
}
