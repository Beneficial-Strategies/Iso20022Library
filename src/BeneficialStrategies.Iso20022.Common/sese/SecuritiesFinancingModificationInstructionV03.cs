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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.036.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|An account owner sends a SecuritiesFinancingModificationInstruction to a securities financing transaction account servicer to notify the securities financing transaction account servicer of an update in the details of a repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing transaction that does not impact the original transaction securities quantity.|Such a change may be:|- the providing of closing details not available at the time of the sending of the Securities Financing Instruction, for example, termination date for an open repo,|- the providing of a new rate, for example, a repo rate,|- the rollover of a position extending the closing or maturity date.|The account owner/servicer relationship may be:|- a global custodian which has an account with a local custodian, or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or|- a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of securities financing transactions to a central securities depository or another settlement market infrastructure.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.
/// </summary>
[Description(@"Scope|An account owner sends a SecuritiesFinancingModificationInstruction to a securities financing transaction account servicer to notify the securities financing transaction account servicer of an update in the details of a repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing transaction that does not impact the original transaction securities quantity.|Such a change may be:|- the providing of closing details not available at the time of the sending of the Securities Financing Instruction, for example, termination date for an open repo,|- the providing of a new rate, for example, a repo rate,|- the rollover of a position extending the closing or maturity date.|The account owner/servicer relationship may be:|- a global custodian which has an account with a local custodian, or|- an investment management institution which manage a fund account opened at a custodian, or|- a broker which has an account with a custodian, or|- a central securities depository participant which has an account with a central securities depository, or|- a central securities depository which has an account with a custodian, another central securities depository or another settlement market infrastructure, or|- a central counterparty or a stock exchange or a trade matching utility which need to instruct the settlement of securities financing transactions to a central securities depository or another settlement market infrastructure.||Usage|The message may also be used to:|- re-send a message previously sent,|- provide a third party with a copy of a message for information,|- re-send to a third party a copy of a message for information|using the relevant elements in the Business Application Header.||ISO 15022 - 20022 Coexistence|This ISO 20022 message is reversed engineered from ISO 15022. Both standards will coexist for a certain number of years. Until this coexistence period ends, the usage of certain data types is restricted to ensure interoperability between ISO 15022 and 20022 users. Compliance to these rules is mandatory in a coexistence environment. The coexistence restrictions are described in a Textual Rule linked to the Message Items they concern. These coexistence textual rules are clearly identified as follows: “CoexistenceXxxxRule”.")]
[IsoId("_AtETEfvfEeCBQp5TnX1XKQ")]
[DisplayName("Securities Financing Modification Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancingModificationInstructionV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.036.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgModInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.036.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesFinancingModificationInstructionV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesFinancingModificationInstructionV03( TransactionTypeAndAdditionalParameters7 reqTransactionTypeAndModificationAdditionalParameters,SecuritiesTradeDetails5 reqTradeDetails,SecurityIdentification14 reqFinancialInstrumentIdentification,QuantityAndAccount16 reqQuantityAndAccountDetails,SecuritiesFinancingTransactionDetails19 reqSecuritiesFinancingAdditionalDetails )
    {
        TransactionTypeAndModificationAdditionalParameters = reqTransactionTypeAndModificationAdditionalParameters;
        TradeDetails = reqTradeDetails;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        QuantityAndAccountDetails = reqQuantityAndAccountDetails;
        SecuritiesFinancingAdditionalDetails = reqSecuritiesFinancingAdditionalDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Securities financing transaction identification information, type (repurchase agreement, reverse repurchase agreement, securities lending or securities borrowing), modification information and other parameters.
    /// </summary>
    [IsoId("_AtETJfvfEeCBQp5TnX1XKQ")]
    [DisplayName("Transaction Type And Modification Additional Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTpAndModAddtlParams")]
    #endif
    [IsoXmlTag("TxTpAndModAddtlParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionTypeAndAdditionalParameters7 TransactionTypeAndModificationAdditionalParameters { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionTypeAndAdditionalParameters7 TransactionTypeAndModificationAdditionalParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionTypeAndAdditionalParameters7 TransactionTypeAndModificationAdditionalParameters { get; init; } 
    #else
    public TransactionTypeAndAdditionalParameters7 TransactionTypeAndModificationAdditionalParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the securities financing deal.
    /// </summary>
    [IsoId("_AtETKfvfEeCBQp5TnX1XKQ")]
    [DisplayName("Trade Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtls")]
    #endif
    [IsoXmlTag("TradDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesTradeDetails5 TradeDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesTradeDetails5 TradeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTradeDetails5 TradeDetails { get; init; } 
    #else
    public SecuritiesTradeDetails5 TradeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_AtETLfvfEeCBQp5TnX1XKQ")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_AtETMfvfEeCBQp5TnX1XKQ")]
    [DisplayName("Quantity And Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyAndAcctDtls")]
    #endif
    [IsoXmlTag("QtyAndAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QuantityAndAccount16 QuantityAndAccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QuantityAndAccount16 QuantityAndAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityAndAccount16 QuantityAndAccountDetails { get; init; } 
    #else
    public QuantityAndAccount16 QuantityAndAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the closing of the securities financing transaction.
    /// </summary>
    [IsoId("_AtETNfvfEeCBQp5TnX1XKQ")]
    [DisplayName("Securities Financing Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesFincgAddtlDtls")]
    #endif
    [IsoXmlTag("SctiesFincgAddtlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesFinancingTransactionDetails19 SecuritiesFinancingAdditionalDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesFinancingTransactionDetails19 SecuritiesFinancingAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesFinancingTransactionDetails19 SecuritiesFinancingAdditionalDetails { get; init; } 
    #else
    public SecuritiesFinancingTransactionDetails19 SecuritiesFinancingAdditionalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_AtETOfvfEeCBQp5TnX1XKQ")]
    [DisplayName("Settlement Parameters")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmParams")]
    #endif
    [IsoXmlTag("SttlmParams")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementDetails62? SettlementParameters { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDetails62? SettlementParameters { get; init; } 
    #else
    public SettlementDetails62? SettlementParameters { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_AtETPfvfEeCBQp5TnX1XKQ")]
    [DisplayName("Delivering Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvrgSttlmPties")]
    #endif
    [IsoXmlTag("DlvrgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties10? DeliveringSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties10? DeliveringSettlementParties { get; init; } 
    #else
    public SettlementParties10? DeliveringSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_AtETQfvfEeCBQp5TnX1XKQ")]
    [DisplayName("Receiving Settlement Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvgSttlmPties")]
    #endif
    [IsoXmlTag("RcvgSttlmPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties10? ReceivingSettlementParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties10? ReceivingSettlementParties { get; init; } 
    #else
    public SettlementParties10? ReceivingSettlementParties { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities at the opening of a securities financing transaction.
    /// </summary>
    [IsoId("_AtETRfvfEeCBQp5TnX1XKQ")]
    [DisplayName("Opening Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpngSttlmAmt")]
    #endif
    [IsoXmlTag("OpngSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection10? OpeningSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection10? OpeningSettlementAmount { get; init; } 
    #else
    public AmountAndDirection10? OpeningSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_AtETSfvfEeCBQp5TnX1XKQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since SecuritiesFinancingModificationInstructionV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesFinancingModificationInstructionV03.

