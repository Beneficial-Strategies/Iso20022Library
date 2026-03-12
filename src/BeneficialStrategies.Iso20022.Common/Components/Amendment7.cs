// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the amendment.
/// </summary>
[IsoId("_9_dIgXltEeG7BsjMvd1mEw_2073465972")]
[DisplayName("Amendment")]
public partial record Amendment7
{
    #nullable enable
    
    /// <summary>
    /// Identification of the proposed amendment.
    /// </summary>
    [IsoId("_9_dIgnltEeG7BsjMvd1mEw_357421067")]
    [DisplayName("Amendment Identification")]
    [IsoXmlTag("AmdmntId")]
    public required Amendment8 AmendmentIdentification { get; init; } 
    
    /// <summary>
    /// Proposed undertaking amendment status.
    /// </summary>
    [IsoId("_wBqaoH-REeGkFKx_uxUapg")]
    [DisplayName("Amendment Status")]
    [IsoXmlTag("AmdmntSts")]
    public required UndertakingStatus2Code AmendmentStatus { get; init; } 
    
    
    #nullable disable
    
}
