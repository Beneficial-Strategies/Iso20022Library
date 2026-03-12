// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document presented for examination.
/// </summary>
[IsoId("_-Eq_uHltEeG7BsjMvd1mEw_-538829885")]
[DisplayName("Demand Documentation")]
public partial record DemandDocumentation1
{
    #nullable enable
    
    /// <summary>
    /// Indication as to whether the presentation is complete.
    /// </summary>
    [IsoId("_-E0JoHltEeG7BsjMvd1mEw_-572404369")]
    [DisplayName("Complete Indicator")]
    [IsoXmlTag("CmpltInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CompleteIndicator { get; init; } 
    
    /// <summary>
    /// Information related to an incomplete presentation.
    /// </summary>
    [IsoId("_-E0JoXltEeG7BsjMvd1mEw_-1669522883")]
    [DisplayName("Completion Information")]
    [IsoXmlTag("CmpltnInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [StringLength(maximumLength: 2000 ,MinimumLength = 1)]
    public IsoMax2000Text? CompletionInformation { get; init; } 
    
    /// <summary>
    /// Document or template enclosed in the demand.
    /// </summary>
    [IsoId("_-E0JonltEeG7BsjMvd1mEw_32400156")]
    [DisplayName("Enclosed File")]
    [IsoXmlTag("NclsdFile")]
    public Document9? EnclosedFile { get; init; } 
    
    /// <summary>
    /// Narrative text constituting the demand.
    /// </summary>
    [IsoId("_-E0Jo3ltEeG7BsjMvd1mEw_370931401")]
    [DisplayName("Demand Narrative")]
    [IsoXmlTag("DmndNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public IsoMax20000Text? DemandNarrative { get; init; } 
    
    
    #nullable disable
    
}
