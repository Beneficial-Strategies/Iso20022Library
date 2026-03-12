// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice of format for the transfer reason.
/// </summary>
[IsoId("_kgcvYPr5EeCu2Z1WwxJVWA")]
[DisplayName("Transfer Reason")]
public partial record TransferReason1
{
    #nullable enable
    
    /// <summary>
    /// Transfer reason expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_nUBDQfr5EeCu2Z1WwxJVWA")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required TransferReason1Code Code { get; init; } 
    
    /// <summary>
    /// Transfer reason expressed as a proprietary code.
    /// </summary>
    [IsoId("_rZ-zEfr5EeCu2Z1WwxJVWA")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public required GenericIdentification27 Proprietary { get; init; } 
    
    
    #nullable disable
    
}
