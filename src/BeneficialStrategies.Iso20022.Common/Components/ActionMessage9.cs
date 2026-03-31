// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information to display, print or store.
/// </summary>
[IsoId("_V7Cr0VE3EeyApZmLzm74zA")]
[DisplayName("Action Message")]
public record ActionMessage9
{
    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_WBG3kVE3EeyApZmLzm74zA")]
    [DisplayName("Message Destination")]
    [IsoXmlTag("MsgDstn")]
    public required UserInterface4Code MessageDestination { get; init; }

    /// <summary>
    /// Qualification of the information to sent to an output logical device.
    /// </summary>
    [IsoId("_WBG3k1E3EeyApZmLzm74zA")]
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public InformationQualify1Code? InformationQualifier { get; init; }

    /// <summary>
    /// Message format.
    /// </summary>
    [IsoId("_WBG3lVE3EeyApZmLzm74zA")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat3Code? Format { get; init; }

    /// <summary>
    /// Content or reference of the message.
    /// </summary>
    [IsoId("_WBG3l1E3EeyApZmLzm74zA")]
    [DisplayName("Message Content")]
    [IsoXmlTag("MsgCntt")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000, MinimumLength = 1)]
    public IsoMax20000Text? MessageContent { get; init; }

    /// <summary>
    /// Digital signature of the message.
    /// </summary>
    [IsoId("_WBG3mVE3EeyApZmLzm74zA")]
    [DisplayName("Message Content Signature")]
    [IsoXmlTag("MsgCnttSgntr")]
    public ContentInformationType29? MessageContentSignature { get; init; }

    /// <summary>
    /// Content of message displayed or printed as Barcode.
    /// </summary>
    [IsoId("_WBG3m1E3EeyApZmLzm74zA")]
    [DisplayName("Output Barcode")]
    [IsoXmlTag("OutptBrcd")]
    public OutputBarcode1? OutputBarcode { get; init; }

    /// <summary>
    /// Flag to request a message response.
    /// </summary>
    [IsoId("_WBG3nVE3EeyApZmLzm74zA")]
    [DisplayName("Response Required Flag")]
    [IsoXmlTag("RspnReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? ResponseRequiredFlag { get; init; }

    /// <summary>
    /// Number of seconds the message has to be displayed.
    /// </summary>
    [IsoId("_WBG3n1E3EeyApZmLzm74zA")]
    [DisplayName("Minimum Display Time")]
    [IsoXmlTag("MinDispTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MinimumDisplayTime { get; init; }
}
