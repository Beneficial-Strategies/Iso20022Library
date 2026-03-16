// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the intra-balance movement status query criteria including the status period.
/// </summary>
[IsoId("_Vp21kTp9EemwKdP955WBJQ")]
[DisplayName("Intra Balance Query Status")]
public record IntraBalanceQueryStatus3
{
    /// <summary>
    /// Defines the status type of query criteria.
    /// </summary>
    [IsoId("_V0R84Tp9EemwKdP955WBJQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required IntraBalanceStatusType2 Type { get; init; }

    /// <summary>
    /// Specified date period of the status.
    /// </summary>
    [IsoId("_V0R84zp9EemwKdP955WBJQ")]
    [DisplayName("Date Period")]
    [IsoXmlTag("DtPrd")]
    public DateAndDateTimeSearch5Choice_? DatePeriod { get; init; }
}
