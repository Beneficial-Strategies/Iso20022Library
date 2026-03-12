// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the collateral substitution response.
/// </summary>
[IsoId("_QnhRA9p-Ed-ak6NoX_4Aeg_908779595")]
[DisplayName("Substitution Response")]
public partial record SubstitutionResponse1
{
    #nullable enable
    
    /// <summary>
    /// Indicates if the substitution request was accepted or rejected.
    /// </summary>
    [IsoId("_QnhRBNp-Ed-ak6NoX_4Aeg_-1628822565")]
    [DisplayName("Response Type")]
    [IsoXmlTag("RspnTp")]
    public required Status4Code ResponseType { get; init; } 
    
    /// <summary>
    /// Provides details about the accepted collateral substitution.
    /// </summary>
    [IsoId("_QnhRBdp-Ed-ak6NoX_4Aeg_-691288487")]
    [DisplayName("Collateral Substitution Acceptance Details")]
    [IsoXmlTag("CollSbstitnAccptncDtls")]
    public CollateralSubstitutionResponse1? CollateralSubstitutionAcceptanceDetails { get; init; } 
    
    /// <summary>
    /// Provides details about the rejected collateral substitution.
    /// </summary>
    [IsoId("_QnhRBtp-Ed-ak6NoX_4Aeg_-417549319")]
    [DisplayName("Collateral Substitution Rejection Details")]
    [IsoXmlTag("CollSbstitnRjctnDtls")]
    public CollateralSubstitutionResponse2? CollateralSubstitutionRejectionDetails { get; init; } 
    
    
    #nullable disable
    
}
