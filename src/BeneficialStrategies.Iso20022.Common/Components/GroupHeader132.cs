// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual notifications included in the message.
/// </summary>
[IsoId("_fi4XMbe4Ee-Dk_aQVAan8Q")]
[DisplayName("Group Header132")]
public record GroupHeader132
{
    /// <summary>
    /// Point to point reference, as assigned by the sender, and sent to the receiver to unambiguously identify the message.
    /// Usage: The sender has to make sure that MessageIdentification is unique per receiver for a pre-agreed period.
    /// </summary>
    [IsoId("_fqxu8be4Ee-Dk_aQVAan8Q")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    [IsoId("_fqxu87e4Ee-Dk_aQVAan8Q")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Party that requests the cash deposit.
    /// </summary>
    [IsoId("_fqxu9be4Ee-Dk_aQVAan8Q")]
    [DisplayName("Cash Sender")]
    [IsoXmlTag("CshSndr")]
    public required Party50Choice_ CashSender { get; init; }

    /// <summary>
    /// Party that responds to the cash deposit request.
    /// </summary>
    [IsoId("_fqxu97e4Ee-Dk_aQVAan8Q")]
    [DisplayName("Cash Receiver")]
    [IsoXmlTag("CshRcvr")]
    public required Party50Choice_ CashReceiver { get; init; }

    /// <summary>
    /// Number of individual requests contained in the message.
    /// </summary>
    [IsoId("_QVH44uSBEe-NFYIkYc90gw")]
    [DisplayName("Number Of Requests")]
    [IsoXmlTag("NbOfReqs")]
    public IsoMax15NumericText? NumberOfRequests { get; init; }

    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    [IsoId("_QVH44-SBEe-NFYIkYc90gw")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    public IsoDecimalNumber? ControlSum { get; init; }
}
