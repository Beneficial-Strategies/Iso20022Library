// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Party1.
/// </summary>
[IsoId("_4Dhe4yShEe-q757KywUi_g")]
[DisplayName("Settlement Party1")]
public partial record SettlementParty1
{
    #nullable enable

    /// <summary>
    /// Branch Identification.
    /// </summary>
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    public BranchData5? BranchIdentification { get; init; } 

    /// <summary>
    /// Financial Institution Identification.
    /// </summary>
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FinInstnId")]
    public required FinancialInstitutionIdentification23 FinancialInstitutionIdentification { get; init; } 

    
    #nullable disable
    
}
