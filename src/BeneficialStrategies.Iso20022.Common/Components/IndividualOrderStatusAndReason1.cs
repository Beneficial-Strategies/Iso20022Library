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
/// Status report of the individual orders of a bulk or multiple order that was previously received.
/// </summary>
[IsoId("_Uu1Eptp-Ed-ak6NoX_4Aeg_-1083249158")]
[DisplayName("Individual Order Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualOrderStatusAndReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualOrderStatusAndReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualOrderStatusAndReason1( OrderStatus2Code reqStatus,CancelledStatus1 reqCancelled,ConditionallyAcceptedStatus1 reqConditionallyAccepted,InRepairStatus1 reqInRepair,RejectedStatus3 reqRejected,SuspendedStatus1 reqSuspended,RepairedConditions2 reqRepairedConditions,System.String reqOrderReference )
    {
        Status = reqStatus;
        Cancelled = reqCancelled;
        ConditionallyAccepted = reqConditionallyAccepted;
        InRepair = reqInRepair;
        Rejected = reqRejected;
        Suspended = reqSuspended;
        RepairedConditions = reqRepairedConditions;
        OrderReference = reqOrderReference;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of the order is accepted or already executed or sent to next party or received. There is no reason attached.
    /// </summary>
    [IsoId("_Uu1Ep9p-Ed-ak6NoX_4Aeg_-1083249133")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderStatus2Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderStatus2Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderStatus2Code Status { get; init; } 
    #else
    public OrderStatus2Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the individual order details is cancelled.
    /// </summary>
    [IsoId("_Uu1EqNp-Ed-ak6NoX_4Aeg_-1083248574")]
    [DisplayName("Cancelled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Canc")]
    #endif
    [IsoXmlTag("Canc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancelledStatus1 Cancelled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancelledStatus1 Cancelled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancelledStatus1 Cancelled { get; init; } 
    #else
    public CancelledStatus1 Cancelled { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the individual order details is conditionally accepted.
    /// </summary>
    [IsoId("_Uu1Eqdp-Ed-ak6NoX_4Aeg_-1083248754")]
    [DisplayName("Conditionally Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CondlyAccptd")]
    #endif
    [IsoXmlTag("CondlyAccptd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ConditionallyAcceptedStatus1 ConditionallyAccepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ConditionallyAcceptedStatus1 ConditionallyAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConditionallyAcceptedStatus1 ConditionallyAccepted { get; init; } 
    #else
    public ConditionallyAcceptedStatus1 ConditionallyAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the individual order details is in repair.
    /// </summary>
    [IsoId("_Uu1Eqtp-Ed-ak6NoX_4Aeg_-1083248669")]
    [DisplayName("In Repair")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InRpr")]
    #endif
    [IsoXmlTag("InRpr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InRepairStatus1 InRepair { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InRepairStatus1 InRepair { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InRepairStatus1 InRepair { get; init; } 
    #else
    public InRepairStatus1 InRepair { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the individual order details is rejected.
    /// </summary>
    [IsoId("_Uu-OkNp-Ed-ak6NoX_4Aeg_-1083248712")]
    [DisplayName("Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjctd")]
    #endif
    [IsoXmlTag("Rjctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RejectedStatus3 Rejected { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RejectedStatus3 Rejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RejectedStatus3 Rejected { get; init; } 
    #else
    public RejectedStatus3 Rejected { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the individual order details is suspended.
    /// </summary>
    [IsoId("_Uu-Okdp-Ed-ak6NoX_4Aeg_-1083248807")]
    [DisplayName("Suspended")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sspd")]
    #endif
    [IsoXmlTag("Sspd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SuspendedStatus1 Suspended { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SuspendedStatus1 Suspended { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SuspendedStatus1 Suspended { get; init; } 
    #else
    public SuspendedStatus1 Suspended { get; set; } 
    #endif
    
    /// <summary>
    /// Elements from the original individual order details that have been repaired so that the order can be accepted.
    /// </summary>
    [IsoId("_Uu-Oktp-Ed-ak6NoX_4Aeg_-1083248634")]
    [DisplayName("Repaired Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdConds")]
    #endif
    [IsoXmlTag("RprdConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RepairedConditions2 RepairedConditions { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RepairedConditions2 RepairedConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepairedConditions2 RepairedConditions { get; init; } 
    #else
    public RepairedConditions2 RepairedConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Uu-Ok9p-Ed-ak6NoX_4Aeg_-1083249081")]
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
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("_Uu-OlNp-Ed-ak6NoX_4Aeg_-381805168")]
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
    /// Choice between the investment account and the financial instrument.
    /// </summary>
    [IsoId("_Uu-Oldp-Ed-ak6NoX_4Aeg_-1083248185")]
    [DisplayName("Investment Account Or Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstmtAcctOrFinInstrm")]
    #endif
    [IsoXmlTag("InvstmtAcctOrFinInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOrFinancialInstrument1Choice_? InvestmentAccountOrFinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOrFinancialInstrument1Choice_? InvestmentAccountOrFinancialInstrument { get; init; } 
    #else
    public InvestmentAccountOrFinancialInstrument1Choice_? InvestmentAccountOrFinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Information that has been added to the original order.
    /// </summary>
    [IsoId("_Uu-Oltp-Ed-ak6NoX_4Aeg_-1083248280")]
    [DisplayName("New Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewDtls")]
    #endif
    [IsoXmlTag("NewDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpectedExecutionDetails1? NewDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpectedExecutionDetails1? NewDetails { get; init; } 
    #else
    public ExpectedExecutionDetails1? NewDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
