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
/// This record is an implementation of the colr.010.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralSubstitutionRequest message is sent by either the collateral giver or its collateral manager to the collateral taker or its collateral manager. It is used to request a substitution of collateral by specifying the collateral to be returned and proposing the new type(s) of collateral to be delivered. Note: There are cases where the collateral taker can initiate the CollateralSubstitutionRequest message, for example in case of breach in the concentration limit.
/// 
/// The message definition is intended for use with the ISO20022 Business Application Header.
/// 
/// Usage
/// The CollateralSubstitutionRequest message can be sent by either the collateral giver or collateral taker in order to substitute collateral that is already held by the other party.
/// </summary>
[Description(@"Scope|The CollateralSubstitutionRequest message is sent by either the collateral giver or its collateral manager to the collateral taker or its collateral manager. It is used to request a substitution of collateral by specifying the collateral to be returned and proposing the new type(s) of collateral to be delivered. Note: There are cases where the collateral taker can initiate the CollateralSubstitutionRequest message, for example in case of breach in the concentration limit.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The CollateralSubstitutionRequest message can be sent by either the collateral giver or collateral taker in order to substitute collateral that is already held by the other party.")]
[IsoId("_J4YkgygrEeyB747fKu7_rw")]
[DisplayName("Collateral Substitution Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralSubstitutionRequestV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.010.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollSbstitnReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.010.001.05";
    
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
    /// Constructs a CollateralSubstitutionRequestV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralSubstitutionRequestV05( System.String reqTransactionIdentification,Obligation9 reqObligation,CollateralSubstitution7 reqCollateralSubstitutionReturn )
    {
        TransactionIdentification = reqTransactionIdentification;
        Obligation = reqObligation;
        CollateralSubstitutionReturn = reqCollateralSubstitutionReturn;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_J4YkiSgrEeyB747fKu7_rw")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionIdentification { get; init; } 
    #else
    public System.String TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_J4YkiygrEeyB747fKu7_rw")]
    [DisplayName("Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Oblgtn")]
    #endif
    [IsoXmlTag("Oblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Obligation9 Obligation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Obligation9 Obligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Obligation9 Obligation { get; init; } 
    #else
    public Obligation9 Obligation { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement details for the over the counter market.
    /// </summary>
    [IsoId("_J4YkjSgrEeyB747fKu7_rw")]
    [DisplayName("Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Agrmt")]
    #endif
    [IsoXmlTag("Agrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Agreement4? Agreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Agreement4? Agreement { get; init; } 
    #else
    public Agreement4? Agreement { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the collateral that will be returned.
    /// </summary>
    [IsoId("_J4YkjygrEeyB747fKu7_rw")]
    [DisplayName("Collateral Substitution Return")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSbstitnRtr")]
    #endif
    [IsoXmlTag("CollSbstitnRtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralSubstitution7 CollateralSubstitutionReturn { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralSubstitution7 CollateralSubstitutionReturn { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralSubstitution7 CollateralSubstitutionReturn { get; init; } 
    #else
    public CollateralSubstitution7 CollateralSubstitutionReturn { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the collateral that will be delivered.
    /// </summary>
    [IsoId("_J4YkkSgrEeyB747fKu7_rw")]
    [DisplayName("Collateral Substitution Deliver")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSbstitnDlvr")]
    #endif
    [IsoXmlTag("CollSbstitnDlvr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralSubstitution8? CollateralSubstitutionDeliver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralSubstitution8? CollateralSubstitutionDeliver { get; init; } 
    #else
    public CollateralSubstitution8? CollateralSubstitutionDeliver { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_J4YkkygrEeyB747fKu7_rw")]
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


// Since CollateralSubstitutionRequestV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CollateralSubstitutionRequestV05.

