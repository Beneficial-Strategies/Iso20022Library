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
/// This record is an implementation of the sese.007.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, eg, a transfer agent, sends the TransferInConfirmation message to the instructing party, eg, an investment manager or its authorised representative, to confirm the receipt of a financial instrument, free of payment, on a given date, from a specified party.
/// This message may also be used to confirm the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.
/// Usage
/// The TransferInConfirmation message is used to confirm receipt of a financial instrument, either from another account owned by the instructing party or from a third party. The reference of the transfer confirmation is identified in TransferConfirmationReference.
/// The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// </summary>
[Description(@"Scope|An executing party, eg, a transfer agent, sends the TransferInConfirmation message to the instructing party, eg, an investment manager or its authorised representative, to confirm the receipt of a financial instrument, free of payment, on a given date, from a specified party.|This message may also be used to confirm the receipt of a financial instrument, free of payment, from another of the instructing parties own accounts or from a third party.|Usage|The TransferInConfirmation message is used to confirm receipt of a financial instrument, either from another account owned by the instructing party or from a third party. The reference of the transfer confirmation is identified in TransferConfirmationReference.|The reference of the original transfer instruction is specified in TransferReference. The message identification of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.")]
[IsoId("_JuZN4tE6Ed-BzquC8wXy7w_13196644")]
[DisplayName("Transfer In Confirmation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferInConfirmationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.007.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInConfV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.007.001.02";
    
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
    /// Constructs a TransferInConfirmationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferInConfirmationV02( MessageIdentification1 reqMessageIdentification,Transfer7 reqTransferDetails,FinancialInstrument13 reqFinancialInstrumentDetails,InvestmentAccount22 reqAccountDetails,DeliverInformation4 reqSettlementDetails )
    {
        MessageIdentification = reqMessageIdentification;
        TransferDetails = reqTransferDetails;
        FinancialInstrumentDetails = reqFinancialInstrumentDetails;
        AccountDetails = reqAccountDetails;
        SettlementDetails = reqSettlementDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_JuZN49E6Ed-BzquC8wXy7w_872070214")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_JuZN5NE6Ed-BzquC8wXy7w_13197035")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? RelatedReference { get; init; } 
    #else
    public AdditionalReference2? RelatedReference { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_JuZN5dE6Ed-BzquC8wXy7w_13197000")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? PoolReference { get; init; } 
    #else
    public AdditionalReference2? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_JuZN5tE6Ed-BzquC8wXy7w_13197077")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference2? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference2? PreviousReference { get; init; } 
    #else
    public AdditionalReference2? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// General information related to the transfer of a financial instrument.
    /// </summary>
    [IsoId("_JuZN59E6Ed-BzquC8wXy7w_13196663")]
    [DisplayName("Transfer Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfDtls")]
    #endif
    [IsoXmlTag("TrfDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Transfer7 TransferDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Transfer7 TransferDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Transfer7 TransferDetails { get; init; } 
    #else
    public Transfer7 TransferDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the financial instrument received.
    /// </summary>
    [IsoId("_JuZN6NE6Ed-BzquC8wXy7w_13196688")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument13 FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument13 FinancialInstrumentDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the account into which the financial instrument was received.
    /// </summary>
    [IsoId("_Jui-4NE6Ed-BzquC8wXy7w_13196940")]
    [DisplayName("Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctDtls")]
    #endif
    [IsoXmlTag("AcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccount22 AccountDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccount22 AccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount22 AccountDetails { get; init; } 
    #else
    public InvestmentAccount22 AccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the delivering side of the transfer.
    /// </summary>
    [IsoId("_Jui-4dE6Ed-BzquC8wXy7w_13196975")]
    [DisplayName("Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDtls")]
    #endif
    [IsoXmlTag("SttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DeliverInformation4 SettlementDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DeliverInformation4 SettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliverInformation4 SettlementDetails { get; init; } 
    #else
    public DeliverInformation4 SettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Jui-4tE6Ed-BzquC8wXy7w_104786759")]
    [DisplayName("Copy Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyDtls")]
    #endif
    [IsoXmlTag("CpyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyInformation2? CopyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyInformation2? CopyDetails { get; init; } 
    #else
    public CopyInformation2? CopyDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Jui-49E6Ed-BzquC8wXy7w_13197112")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since TransferInConfirmationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInConfirmationV02.

