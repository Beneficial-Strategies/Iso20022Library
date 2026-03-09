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
[IsoId("_TR_TNtp-Ed-ak6NoX_4Aeg_-1985802937")]
[DisplayName("Individual Order Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualOrderStatusAndReason2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a IndividualOrderStatusAndReason2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public IndividualOrderStatusAndReason2( System.String reqOrderReference,OrderStatus4Code reqStatus,CancelledStatus2 reqCancelled,ConditionallyAcceptedStatus2 reqConditionallyAccepted,SuspendedStatus2 reqSuspended,InRepairStatus2 reqInRepair,PartiallySettledStatus1 reqPartiallySettled )
    {
        OrderReference = reqOrderReference;
        Status = reqStatus;
        Cancelled = reqCancelled;
        ConditionallyAccepted = reqConditionallyAccepted;
        Suspended = reqSuspended;
        InRepair = reqInRepair;
        PartiallySettled = reqPartiallySettled;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_TR_TN9p-Ed-ak6NoX_4Aeg_-561399129")]
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
    [IsoId("_TR_TONp-Ed-ak6NoX_4Aeg_-1985802876")]
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
    [IsoId("_TR_TOdp-Ed-ak6NoX_4Aeg_-561398852")]
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
    /// Unique and unambiguous identifier for an order execution, as assigned by a confirming party.
    /// </summary>
    [IsoId("_TR_TOtp-Ed-ak6NoX_4Aeg_2140630642")]
    [DisplayName("Deal Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealRef")]
    #endif
    [IsoXmlTag("DealRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DealReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DealReference { get; init; } 
    #else
    public System.String? DealReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for an order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_TR_TO9p-Ed-ak6NoX_4Aeg_1512317038")]
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
    /// Status of the individual order is accepted or already executed or sent to next party or received. There is no reason attached.
    /// </summary>
    [IsoId("_TSJEMNp-Ed-ak6NoX_4Aeg_-1985802919")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderStatus4Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderStatus4Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderStatus4Code Status { get; init; } 
    #else
    public OrderStatus4Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the individual order is cancelled. This status is used for an order that has been accepted or that has been entered in an order book but that can not be executed.
    /// </summary>
    [IsoId("_TSJEMdp-Ed-ak6NoX_4Aeg_-1985802160")]
    [DisplayName("Cancelled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Canc")]
    #endif
    [IsoXmlTag("Canc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CancelledStatus2 Cancelled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CancelledStatus2 Cancelled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CancelledStatus2 Cancelled { get; init; } 
    #else
    public CancelledStatus2 Cancelled { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the individual order is conditionally accepted.
    /// </summary>
    [IsoId("_TSJEMtp-Ed-ak6NoX_4Aeg_-1985802125")]
    [DisplayName("Conditionally Accepted")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CondlyAccptd")]
    #endif
    [IsoXmlTag("CondlyAccptd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ConditionallyAcceptedStatus2 ConditionallyAccepted { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ConditionallyAcceptedStatus2 ConditionallyAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConditionallyAcceptedStatus2 ConditionallyAccepted { get; init; } 
    #else
    public ConditionallyAcceptedStatus2 ConditionallyAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the individual order is rejected. This status is used for an order that has not been accepted or entered in an order book.
    /// </summary>
    [IsoId("_TSJEM9p-Ed-ak6NoX_4Aeg_-1985802048")]
    [DisplayName("Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rjctd")]
    #endif
    [IsoXmlTag("Rjctd")]
    [MinLength(1)]
    [MaxLength(10)]
    public ValueList<RejectedStatus6> Rejected { get; init; } = new ValueList<RejectedStatus6>(){};
    
    /// <summary>
    /// Status of the individual order is suspended.
    /// </summary>
    [IsoId("_TSJENNp-Ed-ak6NoX_4Aeg_-1985801970")]
    [DisplayName("Suspended")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sspd")]
    #endif
    [IsoXmlTag("Sspd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SuspendedStatus2 Suspended { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SuspendedStatus2 Suspended { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SuspendedStatus2 Suspended { get; init; } 
    #else
    public SuspendedStatus2 Suspended { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the individual order is in repair.
    /// </summary>
    [IsoId("_TSJENdp-Ed-ak6NoX_4Aeg_-1985802083")]
    [DisplayName("In Repair")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InRpr")]
    #endif
    [IsoXmlTag("InRpr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InRepairStatus2 InRepair { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InRepairStatus2 InRepair { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InRepairStatus2 InRepair { get; init; } 
    #else
    public InRepairStatus2 InRepair { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the individual order is partially settled.
    /// </summary>
    [IsoId("_TSJENtp-Ed-ak6NoX_4Aeg_8787634")]
    [DisplayName("Partially Settled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlySttld")]
    #endif
    [IsoXmlTag("PrtlySttld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartiallySettledStatus1 PartiallySettled { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartiallySettledStatus1 PartiallySettled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartiallySettledStatus1 PartiallySettled { get; init; } 
    #else
    public PartiallySettledStatus1 PartiallySettled { get; set; } 
    #endif
    
    /// <summary>
    /// Elements from the original individual order that have been repaired so that the order can be accepted.
    /// </summary>
    [IsoId("_TSJEN9p-Ed-ak6NoX_4Aeg_-1985802451")]
    [DisplayName("Repaired Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RprdConds")]
    #endif
    [IsoXmlTag("RprdConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepairedConditions3? RepairedConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepairedConditions3? RepairedConditions { get; init; } 
    #else
    public RepairedConditions3? RepairedConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status of the order cancellation.
    /// </summary>
    [IsoId("_TSJEONp-Ed-ak6NoX_4Aeg_-1985801893")]
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
    /// Order data.
    /// </summary>
    [IsoId("_TSJEOdp-Ed-ak6NoX_4Aeg_-1985801928")]
    [DisplayName("Order Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrData")]
    #endif
    [IsoXmlTag("OrdrData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundOrderData1? OrderData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundOrderData1? OrderData { get; init; } 
    #else
    public FundOrderData1? OrderData { get; set; } 
    #endif
    
    /// <summary>
    /// Information that has been added to the original order.
    /// </summary>
    [IsoId("_TSS1MNp-Ed-ak6NoX_4Aeg_-1985802005")]
    [DisplayName("New Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewDtls")]
    #endif
    [IsoXmlTag("NewDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExpectedExecutionDetails2? NewDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExpectedExecutionDetails2? NewDetails { get; init; } 
    #else
    public ExpectedExecutionDetails2? NewDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
