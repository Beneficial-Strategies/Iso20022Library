// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet data pertaining to the payment transaction.
/// </summary>
[IsoId("_42PC4f5oEeiLerArw36g0w")]
[DisplayName("Fleet Data")]
public partial record FleetData3
{
    #nullable enable
    
    /// <summary>
    /// It is designed to carry detail level fleet data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to fleet transactions. 
    /// </summary>
    [IsoId("_4_1q0_5oEeiLerArw36g0w")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public FleetLineItem2? LineItem { get; init; } 
    
    
    #nullable disable
    
}
