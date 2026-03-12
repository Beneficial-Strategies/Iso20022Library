// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Operational construct used to record a position in a set of financial instruments, often linked by a common set of characteristics, ownership or trading strategy.
/// </summary>
[IsoId("_oiOLIHYCEee_qcLXasnA4g")]
[DisplayName("Position Account")]
public partial record PositionAccount1
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of the position account.
    /// </summary>
    [IsoId("_quPhUHYDEee_qcLXasnA4g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification118Choice_ Identification { get; init; } 
    
    
    #nullable disable
    
}
