// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the report level status advice.
/// </summary>
[IsoId("_CUoXKdGdEeaQk737TH1Fzw")]
[DisplayName("Status Advice Report")]
public partial record StatusAdviceReport3
{
    #nullable enable
    
    /// <summary>
    /// Provides the status for the full message.
    /// </summary>
    [IsoId("_CduBsdGdEeaQk737TH1Fzw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ReportingMessageStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    [IsoId("_CduBs9GdEeaQk737TH1Fzw")]
    [DisplayName("Validation Rule")]
    [IsoXmlTag("VldtnRule")]
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
    
    /// <summary>
    /// Indicates the report date with the status advice message is related to.
    /// </summary>
    [IsoId("_CduBtdGdEeaQk737TH1Fzw")]
    [DisplayName("Message Date")]
    [IsoXmlTag("MsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MessageDate { get; init; } 
    
    /// <summary>
    /// Statistical information on the results of the records processing.
    /// </summary>
    [IsoId("_CduBt9GdEeaQk737TH1Fzw")]
    [DisplayName("Statistics")]
    [IsoXmlTag("Sttstcs")]
    public OriginalReportStatistics3? Statistics { get; init; } 
    
    
    #nullable disable
    
}
