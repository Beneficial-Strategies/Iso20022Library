// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reports either on the business information or on a business error.
/// </summary>
[IsoId("_QdJoBXhdEeidzqjNEfehPg")]
[DisplayName("General Business Report")]
public partial record GeneralBusinessReport6
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a general business information system, as assigned by the system transaction administrator.
    /// </summary>
    [IsoId("_QrMrE3hdEeidzqjNEfehPg")]
    [DisplayName("Business Information Reference")]
    [IsoXmlTag("BizInfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text BusinessInformationReference { get; init; } 
    
    /// <summary>
    /// Requested business information.
    /// </summary>
    [IsoId("_QrMrFXhdEeidzqjNEfehPg")]
    [DisplayName("General Business Or Error")]
    [IsoXmlTag("GnlBizOrErr")]
    public required GeneralBusinessOrError8Choice_ GeneralBusinessOrError { get; init; } 
    
    
    #nullable disable
    
}
