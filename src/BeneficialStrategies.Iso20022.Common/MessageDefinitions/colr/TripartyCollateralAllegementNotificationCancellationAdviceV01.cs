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


namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.024.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// Triparty agent sends a TripartyCollateralAllegementNotificationCancellationAdvice to the collateral giver or the collateral taker to inform of the cancellation of an allegement notification message previously sent by the triparty agent. 
/// 
/// The collateral giver and the collateral taker are participants of the triparty agents. In the frame of ECMS the collateral taker will be a central bank.
/// 
/// The previously sent message is a TripartyCollateralAllegementNotification
/// </summary>
[Description(@"Scope:|Triparty agent sends a TripartyCollateralAllegementNotificationCancellationAdvice to the collateral giver or the collateral taker to inform of the cancellation of an allegement notification message previously sent by the triparty agent. ||The collateral giver and the collateral taker are participants of the triparty agents. In the frame of ECMS the collateral taker will be a central bank.||The previously sent message is a TripartyCollateralAllegementNotification")]
[IsoId("_rvMtQSs7EeySlt9bF77XfA")]
[DisplayName("Triparty Collateral Allegement Notification Cancellation Advice V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TripartyCollateralAllegementNotificationCancellationAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.024.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollAllgmtNtfctnCxlAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.024.001.01";
    
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
    /// Constructs a TripartyCollateralAllegementNotificationCancellationAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TripartyCollateralAllegementNotificationCancellationAdviceV01( TransactionIdentifications44 reqTransactionInstructionIdentification,CollateralTransactionType1Choice_ reqCollateralTransactionType,ExposureType23Choice_ reqExposureType,CollateralRole1Code reqCollateralSide,CollateralParties8 reqCollateralParties )
    {
        TransactionInstructionIdentification = reqTransactionInstructionIdentification;
        CollateralTransactionType = reqCollateralTransactionType;
        ExposureType = reqExposureType;
        CollateralSide = reqCollateralSide;
        CollateralParties = reqCollateralParties;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_rvMtQys7EeySlt9bF77XfA")]
    [DisplayName("Transaction Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxInstrId")]
    #endif
    [IsoXmlTag("TxInstrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifications44 TransactionInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifications44 TransactionInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifications44 TransactionInstructionIdentification { get; init; } 
    #else
    public TransactionIdentifications44 TransactionInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of collateral instruction.
    /// </summary>
    [IsoId("_rvMtRSs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollTxTp")]
    #endif
    [IsoXmlTag("CollTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralTransactionType1Choice_ CollateralTransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralTransactionType1Choice_ CollateralTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralTransactionType1Choice_ CollateralTransactionType { get; init; } 
    #else
    public CollateralTransactionType1Choice_ CollateralTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_rvMtRys7EeySlt9bF77XfA")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExposureType23Choice_ ExposureType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExposureType23Choice_ ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType23Choice_ ExposureType { get; init; } 
    #else
    public ExposureType23Choice_ ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the alleging side is the collateral taker or giver.
    /// </summary>
    [IsoId("_rvMtSSs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSd")]
    #endif
    [IsoXmlTag("CollSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralRole1Code CollateralSide { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralRole1Code CollateralSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralRole1Code CollateralSide { get; init; } 
    #else
    public CollateralRole1Code CollateralSide { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    [IsoId("_rvMtSys7EeySlt9bF77XfA")]
    [DisplayName("Eligibility Set Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgbltySetPrfl")]
    #endif
    [IsoXmlTag("ElgbltySetPrfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification1? EligibilitySetProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1? EligibilitySetProfile { get; init; } 
    #else
    public GenericIdentification1? EligibilitySetProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of collateral parties. Party A and B will be the opposite  from that provided in the unmatched instruction.
    /// </summary>
    [IsoId("_rvMtTSs7EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPties")]
    #endif
    [IsoXmlTag("CollPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralParties8 CollateralParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralParties8 CollateralParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralParties8 CollateralParties { get; init; } 
    #else
    public CollateralParties8 CollateralParties { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the principal.
    /// </summary>
    [IsoId("_rvMtTys7EeySlt9bF77XfA")]
    [DisplayName("Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmt")]
    #endif
    [IsoXmlTag("TxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection49? TransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection49? TransactionAmount { get; init; } 
    #else
    public AmountAndDirection49? TransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the instructing party requests the instruction to be executed. 
    /// </summary>
    [IsoId("_rvMtUSs7EeySlt9bF77XfA")]
    [DisplayName("Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDt")]
    #endif
    [IsoXmlTag("ReqdExctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rvMtUys7EeySlt9bF77XfA")]
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


// Since TripartyCollateralAllegementNotificationCancellationAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralAllegementNotificationCancellationAdviceV01.

