// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Capabilities of the ATM terminal.
/// </summary>
[IsoId("_nwovca1yEeWMg5rOByfExw")]
[DisplayName("Point Of Interaction Capabilities")]
public record PointOfInteractionCapabilities7
{
    /// <summary>
    /// Card reading capabilities of the ATM performing the transaction.
    /// </summary>
    [IsoId("_n8Qwoa1yEeWMg5rOByfExw")]
    [DisplayName("Card Read Data")]
    [IsoXmlTag("CardRdData")]
    public CardDataReading4Code? CardReadData { get; init; }

    /// <summary>
    /// Card writing capabilities of the terminal performing the transaction.
    /// </summary>
    [IsoId("_n8Qwo61yEeWMg5rOByfExw")]
    [DisplayName("Card Write Data")]
    [IsoXmlTag("CardWrtData")]
    public CardDataReading4Code? CardWriteData { get; init; }

    /// <summary>
    /// Customer and card authentication capabilities available at the ATM.
    /// </summary>
    [IsoId("_n8Qwpa1yEeWMg5rOByfExw")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public CardholderVerificationCapability3Code? Authentication { get; init; }

    /// <summary>
    /// Maximum number of digits the ATM is able to accept when the cardholder enters its PIN.
    /// </summary>
    [IsoId("_n8Qwp61yEeWMg5rOByfExw")]
    [DisplayName("PIN Length Capabilities")]
    [IsoXmlTag("PINLngthCpblties")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? PINLengthCapabilities { get; init; }

    /// <summary>
    /// Maximum number of characters of the approval code the ATM is able to manage.
    /// </summary>
    [IsoId("_n8Qwqa1yEeWMg5rOByfExw")]
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("ApprvlCdLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? ApprovalCodeLength { get; init; }

    /// <summary>
    /// Maximum data length in bytes that a card issuer can return to the ICC at the terminal.
    /// </summary>
    [IsoId("_n8Qwq61yEeWMg5rOByfExw")]
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaxScriptLength { get; init; }

    /// <summary>
    /// True if the ATM is able to capture card.
    /// </summary>
    [IsoId("_n8Qwra1yEeWMg5rOByfExw")]
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; }

    /// <summary>
    /// Type of media the ATM is able to dispense.
    /// </summary>
    [IsoId("_zXT3oK1yEeWMg5rOByfExw")]
    [DisplayName("Withdrawal Media")]
    [IsoXmlTag("WdrwlMdia")]
    public ATMMediaType1Code? WithdrawalMedia { get; init; }

    /// <summary>
    /// Type of media the customer is able to deposit in the ATM.
    /// </summary>
    [IsoId("_432IAK1yEeWMg5rOByfExw")]
    [DisplayName("Deposited Media")]
    [IsoXmlTag("DpstdMdia")]
    public ATMMediaType2Code? DepositedMedia { get; init; }

    /// <summary>
    /// Capabilities of the terminal to display or print message to the cardholder and the merchant.
    /// </summary>
    [IsoId("_-GjBgK1yEeWMg5rOByfExw")]
    [DisplayName("Message Capabilities")]
    [IsoXmlTag("MsgCpblties")]
    public DisplayCapabilities5? MessageCapabilities { get; init; }
}
