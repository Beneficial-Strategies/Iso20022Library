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


namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.074.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// A collateral giver/taker sends a TripartyCollateralFinancialInstrumentRemovalRequest to the Triparty Agent to remove a financial instrument from the collateral pool.
/// 
/// The status of this request is provided with the reda.028 , the CollateralDataStatusAdvice.
/// </summary>
[Description(@"Scope:|A collateral giver/taker sends a TripartyCollateralFinancialInstrumentRemovalRequest to the Triparty Agent to remove a financial instrument from the collateral pool.||The status of this request is provided with the reda.028 , the CollateralDataStatusAdvice.")]
[IsoId("_2uaNRys7EeySlt9bF77XfA")]
[DisplayName("Triparty Collateral Unilateral Removal Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TripartyCollateralUnilateralRemovalRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.074.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollUnltrlRmvlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.074.001.01";
    
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
    /// Constructs a TripartyCollateralUnilateralRemovalRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TripartyCollateralUnilateralRemovalRequestV01( Pagination1 reqPagination,System.String reqRemovalRequestIdentification,PartyIdentification232 reqPartyA,CollateralRole1Code reqCollateralSide,RequestDetails28 reqRequestDetails )
    {
        Pagination = reqPagination;
        RemovalRequestIdentification = reqRemovalRequestIdentification;
        PartyA = reqPartyA;
        CollateralSide = reqCollateralSide;
        RequestDetails = reqRequestDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_2uaNSSs7EeySlt9bF77XfA")]
    [DisplayName("Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pgntn")]
    #endif
    [IsoXmlTag("Pgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination1 Pagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination1 Pagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination1 Pagination { get; init; } 
    #else
    public Pagination1 Pagination { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the removal request as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_2uaNSys7EeySlt9bF77XfA")]
    [DisplayName("Removal Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmvlReqId")]
    #endif
    [IsoXmlTag("RmvlReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RemovalRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RemovalRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RemovalRequestIdentification { get; init; } 
    #else
    public System.String RemovalRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Instructing party sending the removal request.
    /// </summary>
    [IsoId("_2uaNTSs7EeySlt9bF77XfA")]
    [DisplayName("Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyA")]
    #endif
    [IsoXmlTag("PtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification232 PartyA { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification232 PartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification232 PartyA { get; init; } 
    #else
    public PartyIdentification232 PartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Party that instructs party A to send the message.
    /// </summary>
    [IsoId("_2uaNTys7EeySlt9bF77XfA")]
    [DisplayName("Client Party A")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntPtyA")]
    #endif
    [IsoXmlTag("ClntPtyA")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification232? ClientPartyA { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification232? ClientPartyA { get; init; } 
    #else
    public PartyIdentification232? ClientPartyA { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    [IsoId("_2uaNUSs7EeySlt9bF77XfA")]
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
    /// Details of the request (the request details block is not repetitive to remove some complexity, only one removal request will be possible per message).
    /// </summary>
    [IsoId("_2uaNUys7EeySlt9bF77XfA")]
    [DisplayName("Request Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqDtls")]
    #endif
    [IsoXmlTag("ReqDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RequestDetails28 RequestDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RequestDetails28 RequestDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RequestDetails28 RequestDetails { get; init; } 
    #else
    public RequestDetails28 RequestDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_2uaNVSs7EeySlt9bF77XfA")]
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


// Since TripartyCollateralUnilateralRemovalRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralUnilateralRemovalRequestV01.

