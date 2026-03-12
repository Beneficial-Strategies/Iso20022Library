// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.028.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchInformationResponse message is sent by the account servicer that previously held the account to the new account servicer to signal whether the account owner&apos;s account can be switched and to pass details of payment arrangements to be transferred to the new account servicer if the account may be switched. Confirmation of the balance transfer window is permitted by the old account servicer.
/// </summary>
[Description(@"The AccountSwitchInformationResponse message is sent by the account servicer that previously held the account to the new account servicer to signal whether the account owner's account can be switched and to pass details of payment arrangements to be transferred to the new account servicer if the account may be switched. Confirmation of the balance transfer window is permitted by the old account servicer.")]
[IsoId("_7HK1m242EeiU9cctagi5ow")]
[DisplayName("Account Switch Information Response V")]
public partial record AccountSwitchInformationResponseV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.028.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchInfRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.028.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Unique identification for the message.
    /// </summary>
    [IsoId("_7HK1nW42EeiU9cctagi5ow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_7HK1n242EeiU9cctagi5ow")]
    [DisplayName("Account Switch Details")]
    [IsoXmlTag("AcctSwtchDtls")]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; } 
    
    /// <summary>
    /// New account to which the switch will be made (destination account).
    /// </summary>
    [IsoId("_7HK1oW42EeiU9cctagi5ow")]
    [DisplayName("New Account")]
    [IsoXmlTag("NewAcct")]
    public required CashAccount39 NewAccount { get; init; } 
    
    /// <summary>
    /// Account held at the old account servicer being switched to the new account servicer.
    /// </summary>
    [IsoId("_7HK1o242EeiU9cctagi5ow")]
    [DisplayName("Old Account")]
    [IsoXmlTag("OdAcct")]
    public required CashAccount39 OldAccount { get; init; } 
    
    /// <summary>
    /// Details of debit payment arrangements associated with the old account. For example the payment may be a standing order, a bill payment arrangement or a future dated payment.
    /// </summary>
    [IsoId("_7HK1pW42EeiU9cctagi5ow")]
    [DisplayName("Payment Instruction")]
    [IsoXmlTag("PmtInstr")]
    public PaymentInstruction28? PaymentInstruction { get; init; } 
    
    /// <summary>
    /// Details of a direct debit instruction associated with the old account.
    /// </summary>
    [IsoId("_7HK1p242EeiU9cctagi5ow")]
    [DisplayName("Direct Debit Instruction")]
    [IsoXmlTag("DrctDbtInstr")]
    public DirectDebitInstructionDetails2? DirectDebitInstruction { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7HK1qW42EeiU9cctagi5ow")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since AccountSwitchInformationResponseV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchInformationResponseV02.

