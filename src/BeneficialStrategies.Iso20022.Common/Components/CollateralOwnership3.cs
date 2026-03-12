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
[IsoId("_fy8XnQyiEeukOZYTbzKKxw")]
[DisplayName("Collateral Ownership")]
public partial record CollateralOwnership3
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether collateral is owned by the clearing member or not.
    /// </summary>
    [IsoId("_gHBxIQyiEeukOZYTbzKKxw")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Proprietary { get; init; } 
    
    /// <summary>
    /// Client that owns the collateral.
    /// </summary>
    [IsoId("_gHBxIwyiEeukOZYTbzKKxw")]
    [DisplayName("Client Name")]
    [IsoXmlTag("ClntNm")]
    public PartyIdentification178Choice_? ClientName { get; init; } 
    
    
    #nullable disable
    
}
