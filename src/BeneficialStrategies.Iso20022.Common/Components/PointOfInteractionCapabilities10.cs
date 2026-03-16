// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Point Of Interaction Capabilities10.
/// </summary>
[IsoId("_tdeaEZ9fEe-nbM0aSPcoiQ")]
[DisplayName("Point Of Interaction Capabilities10")]
public partial record PointOfInteractionCapabilities10
{
    #nullable enable

    /// <summary>
    /// Approval Code Length.
    /// </summary>
    [DisplayName("Approval Code Length")]
    [IsoXmlTag("ApprvlCdLngth")]
    public IsoNumber? ApprovalCodeLength { get; init; } 

    /// <summary>
    /// Authentication.
    /// </summary>
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public ValueList<CardholderVerificationCapability3Code> Authentication { get; init; } = [];

    /// <summary>
    /// Card Capture Capable.
    /// </summary>
    [DisplayName("Card Capture Capable")]
    [IsoXmlTag("CardCaptrCpbl")]
    public IsoTrueFalseIndicator? CardCaptureCapable { get; init; } 

    /// <summary>
    /// Card Read Data.
    /// </summary>
    [DisplayName("Card Read Data")]
    [IsoXmlTag("CardRdData")]
    public ValueList<CardDataReading4Code> CardReadData { get; init; } = [];

    /// <summary>
    /// Card Write Data.
    /// </summary>
    [DisplayName("Card Write Data")]
    [IsoXmlTag("CardWrtData")]
    public ValueList<CardDataReading4Code> CardWriteData { get; init; } = [];

    /// <summary>
    /// Deposited Media.
    /// </summary>
    [DisplayName("Deposited Media")]
    [IsoXmlTag("DpstdMdia")]
    public ValueList<ATMMediaType4Code> DepositedMedia { get; init; } = [];

    /// <summary>
    /// Interactive Transactions.
    /// </summary>
    [DisplayName("Interactive Transactions")]
    [IsoXmlTag("IntractvTxs")]
    public ValueList<IsoMax256Text> InteractiveTransactions { get; init; } = [];

    /// <summary>
    /// Max Script Length.
    /// </summary>
    [DisplayName("Max Script Length")]
    [IsoXmlTag("MxScrptLngth")]
    public IsoNumber? MaxScriptLength { get; init; } 

    /// <summary>
    /// Message Capabilities.
    /// </summary>
    [DisplayName("Message Capabilities")]
    [IsoXmlTag("MsgCpblties")]
    public ValueList<DisplayCapabilities5> MessageCapabilities { get; init; } = [];

    /// <summary>
    /// PIN Length Capabilities.
    /// </summary>
    [DisplayName("PIN Length Capabilities")]
    [IsoXmlTag("PINLngthCpblties")]
    public IsoNumber? PINLengthCapabilities { get; init; } 

    /// <summary>
    /// Receipt Printing.
    /// </summary>
    [DisplayName("Receipt Printing")]
    [IsoXmlTag("RctPrtg")]
    public IsoTrueFalseIndicator? ReceiptPrinting { get; init; } 

    /// <summary>
    /// Withdrawal Media.
    /// </summary>
    [DisplayName("Withdrawal Media")]
    [IsoXmlTag("WdrwlMdia")]
    public ValueList<ATMMediaType1Code> WithdrawalMedia { get; init; } = [];

    
    #nullable disable
    
}
