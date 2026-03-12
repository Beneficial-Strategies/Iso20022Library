// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide information about the reason for the modification and about the application request which triggered this modification.
/// </summary>
[IsoId("_REb2gdp-Ed-ak6NoX_4Aeg_691417052")]
[DisplayName("Investment Account Modification Details")]
public partial record InvestmentAccountModificationDetails
{
    #nullable enable
    
    /// <summary>
    /// Reason for the modification brought to the investment account information.
    /// </summary>
    [IsoId("_REb2gtp-Ed-ak6NoX_4Aeg_-1729726619")]
    [DisplayName("Modification Reason")]
    [IsoXmlTag("ModRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? ModificationReason { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier of the account modification request.
    /// </summary>
    [IsoId("_REb2g9p-Ed-ak6NoX_4Aeg_-1729726542")]
    [DisplayName("Account Application Identification")]
    [IsoXmlTag("AcctApplId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AccountApplicationIdentification { get; init; } 
    
    
    #nullable disable
    
}
