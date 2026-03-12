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



namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransferOutInstruction message is sent by an instructing party, or an instructing party&apos;s designated agent, to the executing party.
/// This message is used to instruct the delivery of a financial instrument, free of payment, at a given date, to a specified party. This message can be used to instruct the transfer of a financial instrument to an own account or to a third party.
/// Usage
/// The TransferOutInstruction message is used by an instructing party to instruct the executing party to withdraw a financial instrument from one account and deliver it to either another account or to a third party.
/// </summary>
[Description(@"Scope|The TransferOutInstruction message is sent by an instructing party, or an instructing party's designated agent, to the executing party.|This message is used to instruct the delivery of a financial instrument, free of payment, at a given date, to a specified party. This message can be used to instruct the transfer of a financial instrument to an own account or to a third party.|Usage|The TransferOutInstruction message is used by an instructing party to instruct the executing party to withdraw a financial instrument from one account and deliver it to either another account or to a third party.")]
[IsoId("_K2NxmNE6Ed-BzquC8wXy7w_-47353492")]
[DisplayName("Transfer Out Instruction")]
public partial record TransferOutInstruction : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.001.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.001.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.001.001.01";
    
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
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_K2NxmdE6Ed-BzquC8wXy7w_-1535314618")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference2? PoolReference { get; init; } 
    
    /// <summary>
    /// Reference of the linked message that was previously sent.
    /// </summary>
    [IsoId("_K2NxmtE6Ed-BzquC8wXy7w_1182915315")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_K2Nxm9E6Ed-BzquC8wXy7w_-1011295011")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; } 
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_K2NxnNE6Ed-BzquC8wXy7w_-1636080860")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer1 TransferDetails { get; init; } 
    
    /// <summary>
    /// Information related to the financial instrument to be withdrawn.
    /// </summary>
    [IsoId("_K2NxndE6Ed-BzquC8wXy7w_1556003366")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument3 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Information related to the account from which the financial instrument is to be withdrawn.
    /// </summary>
    [IsoId("_K2XikNE6Ed-BzquC8wXy7w_1846996382")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount10 AccountDetails { get; init; } 
    
    /// <summary>
    /// Information related to the receiving side of the transfer.
    /// </summary>
    [IsoId("_K2XikdE6Ed-BzquC8wXy7w_1723243531")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required ReceiveInformation1 SettlementDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_K2XiktE6Ed-BzquC8wXy7w_-406991476")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since TransferOutInstructionDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferOutInstruction.

