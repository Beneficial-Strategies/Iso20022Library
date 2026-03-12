// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Choice between a reason or no reason for the corporate action instruction processing accepted status.
/// </summary>
[IsoId("_6xutiYeUEemJ1cSJJmVYRQ")]
[DisplayName("Accepted Status")]
public partial record AcceptedStatus1
{
    #nullable enable
    
    /// <summary>
    /// Reason not specified.
    /// </summary>
    [IsoId("_6xuti4eUEemJ1cSJJmVYRQ")]
    [DisplayName("No Specified Reason")]
    [IsoXmlTag("NoSpcfdRsn")]
    public required NoReasonCode NoSpecifiedReason { get; init; } 
    
    
    #nullable disable
    
}
