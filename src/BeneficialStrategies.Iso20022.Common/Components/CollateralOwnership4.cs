// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates whether the collateral is proprietarily owned or client owned.
/// </summary>
[IsoId("_pamFBytJEeyOa655cLd-DQ")]
[DisplayName("Collateral Ownership")]
public partial record CollateralOwnership4
{
    #nullable enable
    
    /// <summary>
    /// Indicates that the collateral is owned by the clearing member or not.
    /// </summary>
    [IsoId("_pzBzIStJEeyOa655cLd-DQ")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Proprietary { get; init; } 
    
    /// <summary>
    /// Indicates that the client owns the collateral.
    /// </summary>
    [IsoId("_pzBzIytJEeyOa655cLd-DQ")]
    [DisplayName("Client Name")]
    [IsoXmlTag("ClntNm")]
    public PartyIdentification178Choice_? ClientName { get; init; } 
    
    
    #nullable disable
    
}
