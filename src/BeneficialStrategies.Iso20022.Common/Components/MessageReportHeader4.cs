// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of many status advice reports where many received reports are reported at once.
/// </summary>
[IsoId("_CLY7kdGdEeaQk737TH1Fzw")]
[DisplayName("Message Report Header")]
public partial record MessageReportHeader4
{
    #nullable enable
    
    /// <summary>
    /// Provide detail on previously received message reports that are being reported as part of this status advice.
    /// Usage:
    /// When required, this field will be populated with the BAH Business Message Identifier field. Where only a single message report header is used, this field is not used and relies solely on the BAH Business Message Identifier field.
    /// </summary>
    [IsoId("_iChZYOvBEealxoQGKU9EVQ")]
    [DisplayName("Message Report Identifier")]
    [IsoXmlTag("MsgRptIdr")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? MessageReportIdentifier { get; init; } 
    
    /// <summary>
    /// Details the status of the whole message that has been received.
    /// </summary>
    [IsoId("_CUoXI9GdEeaQk737TH1Fzw")]
    [DisplayName("Message Status")]
    [IsoXmlTag("MsgSts")]
    public StatusAdviceReport3? MessageStatus { get; init; } 
    
    /// <summary>
    /// Provides per record status on the report that has been received.
    /// </summary>
    [IsoId("_CUoXJdGdEeaQk737TH1Fzw")]
    [DisplayName("Record Status")]
    [IsoXmlTag("RcrdSts")]
    public StatusReportRecord3? RecordStatus { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_CUoXJ9GdEeaQk737TH1Fzw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
