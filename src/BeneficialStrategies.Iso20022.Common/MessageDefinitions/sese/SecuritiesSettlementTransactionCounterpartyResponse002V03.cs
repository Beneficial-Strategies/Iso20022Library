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
/// This record is an implementation of the sese.040.002.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account owner sends a SecuritiesSettlementTransactionCounterpartyResponse to advise the account servicer that:
/// - the allegement received is either rejected (that is counterparty&apos;s transaction is unknown) or accepted (i.e. either the allegement was passed to the client or the transaction is know with or without mismatches)
/// - the modification or cancellation request sent by the counterparty for a matched transaction is affirmed or not. The account servicer will therefore proceed or not with the counterparty&apos;s request to modify or cancel the transaction.
/// The account servicer may be a central securities depository or another settlement market infrastructure acting on behalf of their participants
/// The account owner may be:
/// - a central securities depository participant which has an account with a central securities depository or a market infrastructure
/// - an agent (sub-custodian) acting on behalf of their global custodian customer, or
/// - a custodian acting on behalf of an investment management institution or a broker/dealer.
/// 
/// Usage
/// The message may also be used to:
/// - re-send a message sent by the account owner to the account servicer,
/// - provide a third party with a copy of a message being sent by the account owner for information,
/// - re-send to a third party a copy of a message being sent by the account owner for information
/// using the relevant elements in the Business Application Header.
/// </summary>
[Description(@"Scope|An account owner sends a SecuritiesSettlementTransactionCounterpartyResponse to advise the account servicer that:|- the allegement received is either rejected (that is counterparty's transaction is unknown) or accepted (i.e. either the allegement was passed to the client or the transaction is know with or without mismatches)|- the modification or cancellation request sent by the counterparty for a matched transaction is affirmed or not. The account servicer will therefore proceed or not with the counterparty's request to modify or cancel the transaction.|The account servicer may be a central securities depository or another settlement market infrastructure acting on behalf of their participants|The account owner may be:|- a central securities depository participant which has an account with a central securities depository or a market infrastructure|- an agent (sub-custodian) acting on behalf of their global custodian customer, or|- a custodian acting on behalf of an investment management institution or a broker/dealer.||Usage|The message may also be used to:|- re-send a message sent by the account owner to the account servicer,|- provide a third party with a copy of a message being sent by the account owner for information,|- re-send to a third party a copy of a message being sent by the account owner for information|using the relevant elements in the Business Application Header.")]
[IsoId("_hj7N8yAfEeuyDZ-ukt4YRg")]
[DisplayName("Securities Settlement Transaction Counterparty Response 002 V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesSettlementTransactionCounterpartyResponse002V03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.040.002.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesSttlmTxCtrPtyRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.040.002.03";
    
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
    /// Constructs a SecuritiesSettlementTransactionCounterpartyResponse002V03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesSettlementTransactionCounterpartyResponse002V03( TransactionIdentification7 reqTransactionIdentification,ResponseStatus8Choice_ reqResponseStatus )
    {
        TransactionIdentification = reqTransactionIdentification;
        ResponseStatus = reqResponseStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_hj7N9SAfEeuyDZ-ukt4YRg")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification7 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentification7 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification7 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification7 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the response status related to an allegement or a counterparty&apos;s instruction.
    /// </summary>
    [IsoId("_hj7N9yAfEeuyDZ-ukt4YRg")]
    [DisplayName("Response Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnSts")]
    #endif
    [IsoXmlTag("RspnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseStatus8Choice_ ResponseStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseStatus8Choice_ ResponseStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseStatus8Choice_ ResponseStatus { get; init; } 
    #else
    public ResponseStatus8Choice_ ResponseStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the details of the transaction.
    /// </summary>
    [IsoId("_hj7N-SAfEeuyDZ-ukt4YRg")]
    [DisplayName("Transaction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtls")]
    #endif
    [IsoXmlTag("TxDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionDetails146? TransactionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionDetails146? TransactionDetails { get; init; } 
    #else
    public TransactionDetails146? TransactionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_hj7N-yAfEeuyDZ-ukt4YRg")]
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


// Since SecuritiesSettlementTransactionCounterpartyResponse002V03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesSettlementTransactionCounterpartyResponse002V03.

