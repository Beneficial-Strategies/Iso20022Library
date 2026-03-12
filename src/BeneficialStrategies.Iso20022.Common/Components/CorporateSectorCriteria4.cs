// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Taxonomy for financial and non financial counterparties.
/// </summary>
[IsoId("_S3Jkcc4AEeigHZFdShPUJQ")]
[DisplayName("Corporate Sector Criteria")]
public partial record CorporateSectorCriteria4
{
    #nullable enable
    
    /// <summary>
    /// Indicates that reporting counterparty is a financial institution.
    /// </summary>
    [IsoId("_TA-14c4AEeigHZFdShPUJQ")]
    [DisplayName("Financial Institution Sector")]
    [IsoXmlTag("FISctr")]
    public FinancialPartySectorType2Code? FinancialInstitutionSector { get; init; } 
    
    /// <summary>
    /// Indicates that reporting counterparty is a non financial institution.
    /// </summary>
    [IsoId("_TA-1484AEeigHZFdShPUJQ")]
    [DisplayName("Non Financial Institution Sector")]
    [IsoXmlTag("NFISctr")]
    [IsoSimpleType(IsoSimpleType.NACEDomainIdentifier)]
    public IsoNACEDomainIdentifier? NonFinancialInstitutionSector { get; init; } 
    
    /// <summary>
    /// Indicates that reporting counterparty is a financial institution.
    /// </summary>
    [IsoId("_JebR0M4REeigHZFdShPUJQ")]
    [DisplayName("Not Reported")]
    [IsoXmlTag("NotRptd")]
    public NotReported1Code? NotReported { get; init; } 
    
    
    #nullable disable
    
}
