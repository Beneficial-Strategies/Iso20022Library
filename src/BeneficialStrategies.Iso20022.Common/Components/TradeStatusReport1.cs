// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the trade status report.
/// </summary>
[IsoId("_-C4P-HltEeG7BsjMvd1mEw_2067370861")]
[DisplayName("Trade Status Report")]
public partial record TradeStatusReport1
{
    #nullable enable
    
    /// <summary>
    /// Information concerning the original message to which the TradeStatusReport is sent in response.
    /// </summary>
    [IsoId("_-C4P-XltEeG7BsjMvd1mEw_420163937")]
    [DisplayName("Original Message Details")]
    [IsoXmlTag("OrgnlMsgDtls")]
    public required OriginalMessage1 OriginalMessageDetails { get; init; } 
    
    /// <summary>
    /// Specifies the processing status of the original message.
    /// </summary>
    [IsoId("_-DCA8HltEeG7BsjMvd1mEw_95108517")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required UndertakingStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Set of elements used to provide detailed information on the status reason.
    /// </summary>
    [IsoId("_-DCA8XltEeG7BsjMvd1mEw_-415310632")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReasonInformation8? StatusReason { get; init; } 
    
    /// <summary>
    /// Additional information related to the report.
    /// </summary>
    [IsoId("_-DCA8nltEeG7BsjMvd1mEw_-952635895")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
