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
[IsoId("_Qlef265pEeuo-IflVgGqiA")]
[DisplayName("Corporate Sector Criteria")]
public record CorporateSectorCriteria5
{
    /// <summary>
    /// Indicates that reporting counterparty is a financial institution.
    /// </summary>
    [IsoId("_Q2nTIa5pEeuo-IflVgGqiA")]
    [DisplayName("Financial Institution Sector")]
    [IsoXmlTag("FISctr")]
    public FinancialPartySectorType2Code? FinancialInstitutionSector { get; init; }

    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_Q2nTI65pEeuo-IflVgGqiA")]
    [DisplayName("Non Financial Institution Sector")]
    [IsoXmlTag("NFISctr")]
    [IsoSimpleType(IsoSimpleType.NACEDomainIdentifier)]
    public IsoNACEDomainIdentifier? NonFinancialInstitutionSector { get; init; }

    /// <summary>
    /// Indicates that reporting counterparty is a financial institution.
    /// </summary>
    [IsoId("_Q2nTJa5pEeuo-IflVgGqiA")]
    [DisplayName("Not Reported")]
    [IsoXmlTag("NotRptd")]
    public NotReported1Code? NotReported { get; init; }
}
