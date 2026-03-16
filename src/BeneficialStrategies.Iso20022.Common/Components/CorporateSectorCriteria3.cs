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
[IsoId("_tkArEdGgEeaQk737TH1Fzw")]
[DisplayName("Corporate Sector Criteria")]
public record CorporateSectorCriteria3
{
    /// <summary>
    /// Indicates that reporting counterparty is a financial institution.
    /// </summary>
    [IsoId("_ttQGodGgEeaQk737TH1Fzw")]
    [DisplayName("Financial Institution Sector")]
    [IsoXmlTag("FISctr")]
    public FinancialPartySectorType1Code? FinancialInstitutionSector { get; init; }

    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_ttQGo9GgEeaQk737TH1Fzw")]
    [DisplayName("Non Financial Institution Sector")]
    [IsoXmlTag("NFISctr")]
    public NonFinancialPartySector1Code? NonFinancialInstitutionSector { get; init; }

    /// <summary>
    /// Indicates that reporting counterparty is another type of counterparty as defined by specific regulations (e.g. a CCP) and the detailed sector is not reported.
    /// </summary>
    [IsoId("_ttQGpdGgEeaQk737TH1Fzw")]
    [DisplayName("Not Reported")]
    [IsoXmlTag("NotRptd")]
    public NotReported1Code? NotReported { get; init; }
}
