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
[IsoId("_Ry7DIZ_7EfC4Q_xhaK1hdQ")]
[DisplayName("Action Message12")]
public record ActionMessage12
{
    /// <summary>
    /// Destination of the message.
    /// </summary>
    [IsoId("_R0SVFZ_7EfC4Q_xhaK1hdQ")]
    [DisplayName("Message Destination")]
    [IsoXmlTag("MsgDstn")]
    public required UserInterface9Code MessageDestination { get; init; }

    /// <summary>
    /// Qualification of the information to sent to an output logical device.
    /// </summary>
    [IsoId("_R0SVG5_7EfC4Q_xhaK1hdQ")]
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public InformationQualify1Code? InformationQualifier { get; init; }

    /// <summary>
    /// Message format.
    /// </summary>
    [IsoId("_R0SVIZ_7EfC4Q_xhaK1hdQ")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat3Code? Format { get; init; }

    /// <summary>
    /// Content or reference of the message.
    /// </summary>
    [IsoId("_R0SVJ5_7EfC4Q_xhaK1hdQ")]
    [DisplayName("Message Content")]
    [IsoXmlTag("MsgCntt")]
    public IsoMax20000Text? MessageContent { get; init; }

    /// <summary>
    /// Digital signature of the message.
    /// </summary>
    [IsoId("_R0SVLZ_7EfC4Q_xhaK1hdQ")]
    [DisplayName("Message Content Signature")]
    [IsoXmlTag("MsgCnttSgntr")]
    public ContentInformationType38? MessageContentSignature { get; init; }

    /// <summary>
    /// Content of message displayed or printed as Barcode.
    /// </summary>
    [IsoId("_R0SVM5_7EfC4Q_xhaK1hdQ")]
    [DisplayName("Output Barcode")]
    [IsoXmlTag("OutptBrcd")]
    public OutputBarcode2? OutputBarcode { get; init; }

    /// <summary>
    /// Flag to request a message response.
    /// </summary>
    [IsoId("_R0SVOZ_7EfC4Q_xhaK1hdQ")]
    [DisplayName("Response Required Flag")]
    [IsoXmlTag("RspnReqrdFlg")]
    public IsoTrueFalseIndicator? ResponseRequiredFlag { get; init; }

    /// <summary>
    /// Number of seconds the message has to be displayed.
    /// </summary>
    [IsoId("_R0SVP5_7EfC4Q_xhaK1hdQ")]
    [DisplayName("Minimum Display Time")]
    [IsoXmlTag("MinDispTm")]
    public IsoNumber? MinimumDisplayTime { get; init; }
}
