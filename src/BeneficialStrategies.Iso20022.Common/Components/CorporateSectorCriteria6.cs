// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Taxonomy for financial and non financial counterparties.
/// </summary>
[IsoId("_L7E1YZNnEeytjZlcgApf6A")]
[DisplayName("Corporate Sector Criteria")]
public record CorporateSectorCriteria6
{
    /// <summary>
    /// Indicates that reporting counterparty is a financial institution.
    /// </summary>
    [IsoId("_L70cQZNnEeytjZlcgApf6A")]
    [DisplayName("Financial Institution Sector")]
    [IsoXmlTag("FISctr")]
    public SimpleValueList<FinancialPartySectorType2Code> FinancialInstitutionSector { get; init; } =
        [];

    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_L70cQ5NnEeytjZlcgApf6A")]
    [DisplayName("Non Financial Institution Sector")]
    [IsoXmlTag("NFISctr")]
    public SimpleValueList<NonFinancialPartySector1Code> NonFinancialInstitutionSector { get; init; } =
        [];

    /// <summary>
    /// Indicates that reporting counterparty is another type of counterparty as defined by specific regulations (e.g. a CCP) and the detailed sector is not reported.
    /// </summary>
    [IsoId("_L70cRZNnEeytjZlcgApf6A")]
    [DisplayName("Not Reported")]
    [IsoXmlTag("NotRptd")]
    public NotReported1Code? NotReported { get; init; }
}
