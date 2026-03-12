// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to a linked transaction.
/// </summary>
[IsoId("_QnOWE9p-Ed-ak6NoX_4Aeg_-1322304897")]
[DisplayName("Reference")]
public partial record Reference17
{
    #nullable enable
    
    /// <summary>
    /// Identification of the collateral substitution request.
    /// </summary>
    [IsoId("_QnOWFNp-Ed-ak6NoX_4Aeg_-1310311408")]
    [DisplayName("Collateral Substitution Request Identification")]
    [IsoXmlTag("CollSbstitnReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CollateralSubstitutionRequestIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the collateral substitution response.
    /// </summary>
    [IsoId("_QnOWFdp-Ed-ak6NoX_4Aeg_2000246740")]
    [DisplayName("Collateral Substitution Response Identification")]
    [IsoXmlTag("CollSbstitnRspnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CollateralSubstitutionResponseIdentification { get; init; } 
    
    
    #nullable disable
    
}
