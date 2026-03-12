// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to display, print or store.
/// </summary>
[IsoId("_REFPEQuIEeqYM5yH99IYQw")]
[DisplayName("Action Message")]
public partial record ActionMessage7
{
    #nullable enable
    
    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_ROyqQQuIEeqYM5yH99IYQw")]
    [DisplayName("Message Destination")]
    [IsoXmlTag("MsgDstn")]
    public required UserInterface4Code MessageDestination { get; init; } 
    
    /// <summary>
    /// Qualification of the information to sent to an output logical device.
    /// </summary>
    [IsoId("_ROyqQwuIEeqYM5yH99IYQw")]
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public InformationQualify1Code? InformationQualifier { get; init; } 
    
    /// <summary>
    /// Message format.
    /// </summary>
    [IsoId("_ROyqRQuIEeqYM5yH99IYQw")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat3Code? Format { get; init; } 
    
    /// <summary>
    /// Content or reference of the message.
    /// </summary>
    [IsoId("_ROyqRwuIEeqYM5yH99IYQw")]
    [DisplayName("Message Content")]
    [IsoXmlTag("MsgCntt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    public required IsoMax20000Text MessageContent { get; init; } 
    
    /// <summary>
    /// Digital signature of the message.
    /// </summary>
    [IsoId("_ROyqSQuIEeqYM5yH99IYQw")]
    [DisplayName("Message Content Signature")]
    [IsoXmlTag("MsgCnttSgntr")]
    public ContentInformationType21? MessageContentSignature { get; init; } 
    
    /// <summary>
    /// Content of message displayed or printed as Barcode.
    /// </summary>
    [IsoId("_ROyqSwuIEeqYM5yH99IYQw")]
    [DisplayName("Output Barcode")]
    [IsoXmlTag("OutptBrcd")]
    public OutputBarcode1? OutputBarcode { get; init; } 
    
    /// <summary>
    /// Flag to request a message response.
    /// </summary>
    [IsoId("_ROyqTQuIEeqYM5yH99IYQw")]
    [DisplayName("Response Required Flag")]
    [IsoXmlTag("RspnReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ResponseRequiredFlag { get; init; } 
    
    /// <summary>
    /// Number of seconds the message has to be displayed.
    /// </summary>
    [IsoId("_ROyqTwuIEeqYM5yH99IYQw")]
    [DisplayName("Minimum Display Time")]
    [IsoXmlTag("MinDispTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MinimumDisplayTime { get; init; } 
    
    
    #nullable disable
    
}
