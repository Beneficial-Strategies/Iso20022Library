// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Range of time defined by a start date and an end date.
/// </summary>
[IsoId("_3ZZIEVo6Ee23K4GXSpBSeg")]
[DisplayName("Date Period")]
public record DatePeriod4
{
    /// <summary>
    /// Start date of the range.
    /// </summary>
    [IsoId("_3af7U1o6Ee23K4GXSpBSeg")]
    [DisplayName("From Date")]
    [IsoXmlTag("FrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FromDate { get; init; }

    /// <summary>
    /// End date of the range.
    /// </summary>
    [IsoId("_3af7VVo6Ee23K4GXSpBSeg")]
    [DisplayName("To Date")]
    [IsoXmlTag("ToDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ToDate { get; init; }
}
