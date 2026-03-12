// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Container for proprietary information. Business content of this element is not specified.
/// </summary>
[IsoId("_pzNDoRXuEeG5vNOLz1X1Ow")]
[DisplayName("Proprietary Data")]
public partial record ProprietaryData5
{
    #nullable enable
    
    /// <summary>
    /// Type of the proprietary document.
    /// </summary>
    [IsoId("_pzW0oRXuEeG5vNOLz1X1Ow")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Technical element wrapping the proprietary message.
    /// </summary>
    [IsoId("_uH-PABXvEeG5vNOLz1X1Ow")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    public required SupplementaryDataEnvelope1 Data { get; init; } 
    
    
    #nullable disable
    
}
