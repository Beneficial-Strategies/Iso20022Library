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
[IsoId("_zYIag_jNEeiM7KpzmLtmTQ")]
[DisplayName("Fleet Data")]
public partial record FleetData2
{
    #nullable enable
    
    /// <summary>
    /// Invoice Summary information.
    /// </summary>
    [IsoId("_zYIahfjNEeiM7KpzmLtmTQ")]
    [DisplayName("Summary")]
    [IsoXmlTag("Summry")]
    public FleetSummary1? Summary { get; init; } 
    
    /// <summary>
    /// Fleet Line Item component is designed to carry detail level fleet data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to fleet transactions. 
    /// </summary>
    [IsoId("_zYIahPjNEeiM7KpzmLtmTQ")]
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public FleetLineItem1? LineItem { get; init; } 
    
    
    #nullable disable
    
}
