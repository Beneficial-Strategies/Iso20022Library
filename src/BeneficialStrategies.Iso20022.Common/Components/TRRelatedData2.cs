// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data block for a TR31 or TR34 key block which contains the key being transported.
/// </summary>
[IsoId("_PRFA0LTpEeeQy4o2AayYHg")]
[DisplayName("TR Related Data")]
public partial record TRRelatedData2
{
    #nullable enable
    
    /// <summary>
    /// Specific TR34 command where the TRBlock is a TR34 block.
    /// </summary>
    [IsoId("_PZ0GEbTpEeeQy4o2AayYHg")]
    [DisplayName("TR 34 Command")]
    [IsoXmlTag("TR34Cmd")]
    public TR34Command1Code? TR34Command { get; init; } 
    
    /// <summary>
    /// TR31 or TR34 data block.
    /// </summary>
    [IsoId("_PZ0GE7TpEeeQy4o2AayYHg")]
    [DisplayName("TR Block")]
    [IsoXmlTag("TRBlck")]
    [IsoSimpleType(IsoSimpleType.Max100KBinary)]
    public IsoMax100KBinary? TRBlock { get; init; } 
    
    
    #nullable disable
    
}
