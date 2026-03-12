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
/// This record is an implementation of the sese.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// TheTransferInConfirmation message is sent by an executing party to the instructing party or the instructing party&apos;s designated agent.
/// This message is used to confirm the receipt of a financial instrument, free of payment, at a given date, from a specified party. This message can also be used to confirm the transfer a financial instrument from an own account or from a third party.
/// Usage
/// TheTransferInConfirmation message is used by an executing party to confirm to the instructing party receipt of a financial instrument, either from another account owned by the instructing party or from a third party.
/// </summary>
[Description(@"Scope|TheTransferInConfirmation message is sent by an executing party to the instructing party or the instructing party's designated agent.|This message is used to confirm the receipt of a financial instrument, free of payment, at a given date, from a specified party. This message can also be used to confirm the transfer a financial instrument from an own account or from a third party.|Usage|TheTransferInConfirmation message is used by an executing party to confirm to the instructing party receipt of a financial instrument, either from another account owned by the instructing party or from a third party.")]
[IsoId("_JMkTONE6Ed-BzquC8wXy7w_-1545863539")]
[DisplayName("Transfer In Confirmation")]
public partial record TransferInConfirmation : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.007.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.007.001.01";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.007.001.01";
    
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
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_JMkTOdE6Ed-BzquC8wXy7w_-169153916")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required AdditionalReference2 RelatedReference { get; init; } 
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_JMkTOtE6Ed-BzquC8wXy7w_1069651183")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference2? PoolReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_JMuEMNE6Ed-BzquC8wXy7w_1503454128")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; } 
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_JMuEMdE6Ed-BzquC8wXy7w_-2005768789")]
    [DisplayName("Transfer Details")]
    [IsoXmlTag("TrfDtls")]
    public required Transfer4 TransferDetails { get; init; } 
    
    /// <summary>
    /// Information related to the financial instrument received.
    /// </summary>
    [IsoId("_JMuEMtE6Ed-BzquC8wXy7w_-1652058290")]
    [DisplayName("Financial Instrument Details")]
    [IsoXmlTag("FinInstrmDtls")]
    public required FinancialInstrument3 FinancialInstrumentDetails { get; init; } 
    
    /// <summary>
    /// Information related to the account into which the financial instrument was received.
    /// </summary>
    [IsoId("_JMuEM9E6Ed-BzquC8wXy7w_1104644640")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    public required InvestmentAccount10 AccountDetails { get; init; } 
    
    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_JMuENNE6Ed-BzquC8wXy7w_-1058954698")]
    [DisplayName("Settlement Details")]
    [IsoXmlTag("SttlmDtls")]
    public required DeliverInformation2 SettlementDetails { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_JMuENdE6Ed-BzquC8wXy7w_879395382")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since TransferInConfirmationDocument is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInConfirmation.

