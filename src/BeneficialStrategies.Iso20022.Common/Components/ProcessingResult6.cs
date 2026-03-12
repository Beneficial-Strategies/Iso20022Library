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
[IsoId("_2JXScfBlEeesZ516Jn5sHw")]
[DisplayName("Processing Result")]
public partial record ProcessingResult6
{
    #nullable enable
    
    /// <summary>
    /// Result of the processing.
    /// </summary>
    [IsoId("_2WAnUfBlEeesZ516Jn5sHw")]
    [DisplayName("Result Data")]
    [IsoXmlTag("RsltData")]
    public ResultData6? ResultData { get; init; } 
    
    /// <summary>
    /// Outcome of a previous processing, for example, in response to a duplicate request.
    /// </summary>
    [IsoId("__fwPQRs2EeqrvK3udMUsNQ")]
    [DisplayName("Original Result Data")]
    [IsoXmlTag("OrgnlRsltData")]
    public ResultData1? OriginalResultData { get; init; } 
    
    /// <summary>
    /// Action required flag.
    /// Default: False: Action Not Required.
    /// True: Action Required.
    /// </summary>
    [IsoId("_2WAnU_BlEeesZ516Jn5sHw")]
    [DisplayName("Action Required")]
    [IsoXmlTag("ActnReqrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ActionRequired { get; init; } 
    
    /// <summary>
    /// Set of actions to be performed.
    /// </summary>
    [IsoId("_2WAnVfBlEeesZ516Jn5sHw")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action9? Action { get; init; } 
    
    /// <summary>
    /// Additional action to perform.
    /// </summary>
    [IsoId("_2WAnV_BlEeesZ516Jn5sHw")]
    [DisplayName("Additional Action")]
    [IsoXmlTag("AddtlActn")]
    public AdditionalAction1? AdditionalAction { get; init; } 
    
    /// <summary>
    /// Additional information relevant for the destination.
    /// ISO 8583 bit 44
    /// </summary>
    [IsoId("_2WAnWfBlEeesZ516Jn5sHw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation20? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
