// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status information of the report item.
/// </summary>
[IsoId("_hEIC4b3REeO2FLWuu_JIqg")]
[DisplayName("Report Item Status")]
public partial record ReportItemStatus1
{
    #nullable enable
    
    /// <summary>
    /// Reason for the exception status.
    /// </summary>
    [IsoId("_j5TZgClEEeWwYv6HydV_vw")]
    [DisplayName("Exception")]
    [IsoXmlTag("Xcptn")]
    public required ReportItemRejectionReason1Choice_ Exception { get; init; } 
    
    /// <summary>
    /// Additional information about the reason for the status that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_j5TZgilEEeWwYv6HydV_vw")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    /// <summary>
    /// Details of the report item.
    /// </summary>
    [IsoId("_j5TZhClEEeWwYv6HydV_vw")]
    [DisplayName("Report Item")]
    [IsoXmlTag("RptItm")]
    public ReportItem1? ReportItem { get; init; } 
    
    
    #nullable disable
    
}
