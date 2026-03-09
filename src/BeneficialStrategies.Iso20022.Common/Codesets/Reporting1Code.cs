// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies to which institution the reporting must be done.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZTCPqNp-Ed-ak6NoX_4Aeg_-1780982221")]
[Description(@"Identifies to which institution the reporting must be done.")]
[DerivedFrom(typeof(ReportingCode))]
public enum Reporting1Code
{
    /// <summary>
    /// Trade details are to be reported to a stock exchange.
    /// Encoded/decoded by serializers as &quot;STEX&quot;.
    /// </summary>
    [EnumMember(Value = "STEX")]
    [IsoId("_ZTMAoNp-Ed-ak6NoX_4Aeg_-1707100866")]
    [Description(@"Trade details are to be reported to a stock exchange.")]
    StockExchange = ReportingCode.StockExchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Trade details are to be reported to a regulatory organisation.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_ZTMAodp-Ed-ak6NoX_4Aeg_-1707100823")]
    [Description(@"Trade details are to be reported to a regulatory organisation.")]
    RegulatoryOrganisation = ReportingCode.RegulatoryOrganisation, // same ordinal as derivation source for type conversions
    
}
