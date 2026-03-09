// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status report of an individual order of a bulk or multiple or switch order cancellation instruction that was previously received.
/// </summary>
[IsoId("_RMeYPNp-Ed-ak6NoX_4Aeg_-887862240")]
[DisplayName("Individual Order Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualOrderStatusAndReason4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualOrderStatusAndReason4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualOrderStatusAndReason4( System.String reqOrderReference,OrderCancellationStatus1Code reqStatus,RejectedStatus7 reqRejected )
    {
        OrderReference = reqOrderReference;
        Status = reqStatus;
        Rejected = reqRejected;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_RMeYPdp-Ed-ak6NoX_4Aeg_1308741188")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_RMeYPtp-Ed-ak6NoX_4Aeg_-116720316")]
    [DisplayName("Order Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrRef")]
    #endif
    [IsoXmlTag("OrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text OrderReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OrderReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OrderReference { get; init; } 
    #else
    public System.String OrderReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous investor&apos;s identification of an order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_RMeYP9p-Ed-ak6NoX_4Aeg_-116720299")]
    [DisplayName("Client Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntRef")]
    #endif
    [IsoXmlTag("ClntRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientReference { get; init; } 
    #else
    public System.String? ClientReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_RMoJMNp-Ed-ak6NoX_4Aeg_816035445")]
    [DisplayName("Cancellation Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRef")]
    #endif
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CancellationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationReference { get; init; } 
    #else
    public System.String? CancellationReference { get; set; } 
    #endif
    
    /// <summary>
    /// Cancellation status of the order.
    /// </summary>
    [IsoId("_RMoJMdp-Ed-ak6NoX_4Aeg_-887862198")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderCancellationStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderCancellationStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderCancellationStatus1Code Status { get; init; } 
    #else
    public OrderCancellationStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the individual order cancellation request is rejected.
    /// </summary>
    [IsoId("_RMoJMtp-Ed-ak6NoX_4Aeg_1303154650")]
    [DisplayName("Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjctd")]
    #endif
    [IsoXmlTag("Rjctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectedStatus7 Rejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectedStatus7 Rejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedStatus7 Rejected { get; init; } 
    #else
    public RejectedStatus7 Rejected { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status of the individual order cancellation.
    /// </summary>
    [IsoId("_RMoJM9p-Ed-ak6NoX_4Aeg_95905389")]
    [DisplayName("Status Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInitr")]
    #endif
    [IsoXmlTag("StsInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification2Choice_? StatusInitiator { get; init; } 
    #else
    public PartyIdentification2Choice_? StatusInitiator { get; set; } 
    #endif
    
    /// <summary>
    /// Account information of the individual order cancellation for which the status is given.
    /// </summary>
    [IsoId("_RMoJNNp-Ed-ak6NoX_4Aeg_5464410")]
    [DisplayName("Investment Account Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctDtls")]
    #endif
    [IsoXmlTag("InvstmtAcctDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccount13? InvestmentAccountDetails { get; init; } 
    #else
    public InvestmentAccount13? InvestmentAccountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instrument information of the individual order cancellation for which the status is given.
    /// </summary>
    [IsoId("_RMoJNdp-Ed-ak6NoX_4Aeg_19318173")]
    [DisplayName("Financial Instrument Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmDtls")]
    #endif
    [IsoXmlTag("FinInstrmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrument10? FinancialInstrumentDetails { get; init; } 
    #else
    public FinancialInstrument10? FinancialInstrumentDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
