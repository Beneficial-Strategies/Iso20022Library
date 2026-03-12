// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional information required for distribution in the French market.
/// </summary>
[IsoId("_J8Y8UM3AEeuAE-cYsQdwHQ")]
[DisplayName("Additional Product Information")]
public partial record AdditionalProductInformation2
{
    #nullable enable
    
    /// <summary>
    /// Approach of the Autorite des Marches Financiers (AMF) recommendation 2020-03 to which the fund complies. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT V3.1) reference 01020.
    /// </summary>
    [IsoId("_eNL8AM3AEeuAE-cYsQdwHQ")]
    [DisplayName("AMF Doctrine")]
    [IsoXmlTag("AMFDctrn")]
    public AMFDoctrine1Code? AMFDoctrine { get; init; } 
    
    
    #nullable disable
    
}
