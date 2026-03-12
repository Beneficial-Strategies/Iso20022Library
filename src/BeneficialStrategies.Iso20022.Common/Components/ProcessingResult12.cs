// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Outcome of the verification processing of the transaction.
/// </summary>
[IsoId("_AkN0cahPEeuOaMA1YOy5YQ")]
[DisplayName("Processing Result")]
public partial record ProcessingResult12
{
    #nullable enable
    
    /// <summary>
    /// Data pertaining to the approval of the transaction.
    /// </summary>
    [IsoId("_Ss6t0MSsEeuBjv5G5kw00g")]
    [DisplayName("Approval Data")]
    [IsoXmlTag("ApprvlData")]
    public ApprovalData1? ApprovalData { get; init; } 
    
    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_ApeH4ahPEeuOaMA1YOy5YQ")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public ResultData11? ResultData { get; init; } 
    
    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("_ApeH46hPEeuOaMA1YOy5YQ")]
    [DisplayName("Original Result Data")]
    [IsoXmlTag("OrgnlRsltData")]
    public ResultData7? OriginalResultData { get; init; } 
    
    /// <summary>
    /// Action required flag.
    /// Default: False: Action Not Required.
    /// True: Action Required.
    /// </summary>
    [IsoId("_ApeH5ahPEeuOaMA1YOy5YQ")]
    [DisplayName("Action Required")]
    [IsoXmlTag("ActnReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ActionRequired { get; init; } 
    
    /// <summary>
    /// Set of actions to be performed.
    /// </summary>
    [IsoId("_ApeH56hPEeuOaMA1YOy5YQ")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action13? Action { get; init; } 
    
    /// <summary>
    /// Additional action to perform.
    /// </summary>
    [IsoId("_ApeH6ahPEeuOaMA1YOy5YQ")]
    [DisplayName("Additional Action")]
    [IsoXmlTag("AddtlActn")]
    public AdditionalAction1? AdditionalAction { get; init; } 
    
    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_ApeH66hPEeuOaMA1YOy5YQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation29? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
