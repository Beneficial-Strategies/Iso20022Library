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
/// This record is an implementation of the acmt.029.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AccountSwitchCancelExistingPayment message is sent by the new account servicer to the previous account servicer to identify which payment arrangements are to be cancelled on the account owner&apos;s account and when they are to be cancelled. This message is used during a partial switch of the account and may be sent multiple times to allow for the account parties to transfer different payment arrangements at different times during the switch. 
/// </summary>
[Description(@"The AccountSwitchCancelExistingPayment message is sent by the new account servicer to the previous account servicer to identify which payment arrangements are to be cancelled on the account owner's account and when they are to be cancelled. This message is used during a partial switch of the account and may be sent multiple times to allow for the account parties to transfer different payment arrangements at different times during the switch. ")]
[IsoId("_iUM-gU9GEeef4o94AcOdBA")]
[DisplayName("Account Switch Cancel Existing Payment V")]
public partial record AccountSwitchCancelExistingPaymentV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.029.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AcctSwtchCclExstgPmt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.029.001.01";
    
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
    [IsoId("_Hh4xYa5jEee17eDA_q0a9g")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Contains information about the details of the account switch.
    /// </summary>
    [IsoId("_I0dMga5jEee17eDA_q0a9g")]
    [DisplayName("Account Switch Details")]
    [IsoXmlTag("AcctSwtchDtls")]
    public required AccountSwitchDetails1 AccountSwitchDetails { get; init; } 
    
    /// <summary>
    /// Details of the old account.
    /// </summary>
    [IsoId("_iUM-hU9GEeef4o94AcOdBA")]
    [DisplayName("Old Account")]
    [IsoXmlTag("OdAcct")]
    public required CashAccount36 OldAccount { get; init; } 
    
    /// <summary>
    /// Details of a debit payment arrangement associated with the old account. The payment may be a standing order, a bill payment arrangement or a future dated payment.
    /// </summary>
    [IsoId("_hfeYAFDdEeeunetnjWUhcA")]
    [DisplayName("Payment Instruction")]
    [IsoXmlTag("PmtInstr")]
    public PaymentInstruction24? PaymentInstruction { get; init; } 
    
    /// <summary>
    /// Details of a direct debit Instruction associated with the old account.
    /// </summary>
    [IsoId("_YXy34Fy8Eee48PRwcRxS4A")]
    [DisplayName("Direct Debit Instruction")]
    [IsoXmlTag("DrctDbtInstr")]
    public DirectDebitInstructionDetails1? DirectDebitInstruction { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_iUM-i09GEeef4o94AcOdBA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since AccountSwitchCancelExistingPaymentV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AccountSwitchCancelExistingPaymentV01.

