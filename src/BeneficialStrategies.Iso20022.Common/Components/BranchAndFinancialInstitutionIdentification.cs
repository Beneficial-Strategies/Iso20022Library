// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organisation established primarily to provide financial services.
/// </summary>
[IsoId("_TFnrI9p-Ed-ak6NoX_4Aeg_-701861729")]
[DisplayName("Branch And Financial Institution Identification")]
public partial record BranchAndFinancialInstitutionIdentification
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial institution, as assigned under an internationally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_TFnrJNp-Ed-ak6NoX_4Aeg_-343537704")]
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FinInstnId")]
    public required FinancialInstitutionIdentification1 FinancialInstitutionIdentification { get; init; } 
    
    /// <summary>
    /// Information identifying a specific branch of a financial institution.||Usage: this component should be used in case the identification information in the financial institution component does not provide identification up to branch level.
    /// </summary>
    [IsoId("_TFnrJdp-Ed-ak6NoX_4Aeg_-346306701")]
    [DisplayName("Branch Identification")]
    [IsoXmlTag("BrnchId")]
    public BranchData? BranchIdentification { get; init; } 
    
    
    #nullable disable
    
}
