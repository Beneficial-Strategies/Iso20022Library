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
[IsoId("_E7FbAStJEeyOa655cLd-DQ")]
[DisplayName("Substitution Response")]
public partial record SubstitutionResponse2
{
    #nullable enable
    
    /// <summary>
    /// Indicates if the substitution request was accepted or rejected.
    /// </summary>
    [IsoId("_FS7TRStJEeyOa655cLd-DQ")]
    [DisplayName("Response Type")]
    [IsoXmlTag("RspnTp")]
    public required Status4Code ResponseType { get; init; } 
    
    /// <summary>
    /// Provides details about the accepted collateral substitution.
    /// </summary>
    [IsoId("_FS7TRytJEeyOa655cLd-DQ")]
    [DisplayName("Collateral Substitution Acceptance Details")]
    [IsoXmlTag("CollSbstitnAccptncDtls")]
    public CollateralSubstitutionResponse1? CollateralSubstitutionAcceptanceDetails { get; init; } 
    
    /// <summary>
    /// Provides details about the rejected collateral substitution.
    /// </summary>
    [IsoId("_FS7TSStJEeyOa655cLd-DQ")]
    [DisplayName("Collateral Substitution Rejection Details")]
    [IsoXmlTag("CollSbstitnRjctnDtls")]
    public CollateralSubstitutionResponse3? CollateralSubstitutionRejectionDetails { get; init; } 
    
    
    #nullable disable
    
}
