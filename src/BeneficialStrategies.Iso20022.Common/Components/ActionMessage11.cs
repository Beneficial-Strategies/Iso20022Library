// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Action Message11.
/// </summary>
[IsoId("_G9nNoZB7Ee6FLLjWp95ntQ")]
[DisplayName("Action Message11")]
public record ActionMessage11
{
    /// <summary>
    /// Format.
    /// </summary>
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat3Code? Format { get; init; }

    /// <summary>
    /// Information Qualifier.
    /// </summary>
    [DisplayName("Information Qualifier")]
    [IsoXmlTag("InfQlfr")]
    public InformationQualify1Code? InformationQualifier { get; init; }

    /// <summary>
    /// Message Content.
    /// </summary>
    [DisplayName("Message Content")]
    [IsoXmlTag("MsgCntt")]
    public IsoMax20000Text? MessageContent { get; init; }

    /// <summary>
    /// Message Content Signature.
    /// </summary>
    [DisplayName("Message Content Signature")]
    [IsoXmlTag("MsgCnttSgntr")]
    public ContentInformationType38? MessageContentSignature { get; init; }

    /// <summary>
    /// Message Destination.
    /// </summary>
    [DisplayName("Message Destination")]
    [IsoXmlTag("MsgDstn")]
    public required UserInterface4Code MessageDestination { get; init; }

    /// <summary>
    /// Minimum Display Time.
    /// </summary>
    [DisplayName("Minimum Display Time")]
    [IsoXmlTag("MinDispTm")]
    public IsoNumber? MinimumDisplayTime { get; init; }

    /// <summary>
    /// Output Barcode.
    /// </summary>
    [DisplayName("Output Barcode")]
    [IsoXmlTag("OutptBrcd")]
    public OutputBarcode2? OutputBarcode { get; init; }

    /// <summary>
    /// Response Required Flag.
    /// </summary>
    [DisplayName("Response Required Flag")]
    [IsoXmlTag("RspnReqrdFlg")]
    public IsoTrueFalseIndicator? ResponseRequiredFlag { get; init; }
}
