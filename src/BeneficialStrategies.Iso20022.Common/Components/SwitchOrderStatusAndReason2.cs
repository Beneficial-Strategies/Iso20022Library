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
[IsoId("_FXOE-zbtEead9bDRE_1DAQ")]
[DisplayName("Switch Order Status And Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SwitchOrderStatusAndReason2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SwitchOrderStatusAndReason2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SwitchOrderStatusAndReason2( System.String reqOrderReference,OrderStatus4Choice_ reqOrderStatus )
    {
        OrderReference = reqOrderReference;
        OrderStatus = reqOrderStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_Fx2LJTbtEead9bDRE_1DAQ")]
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
    /// Unique and unambiguous identifier for the order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Fx2LJzbtEead9bDRE_1DAQ")]
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
    /// Unique and unambiguous investor&apos;s identification of the order. This reference can typically be used in a hub scenario to give the reference of the order as assigned by the underlying client.
    /// </summary>
    [IsoId("_Fx2LKTbtEead9bDRE_1DAQ")]
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
    /// Unique and unambiguous identifier for the order execution, as assigned by the confirming party.
    /// </summary>
    [IsoId("_Fx2LKzbtEead9bDRE_1DAQ")]
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
    /// Unique and unambiguous identifier for the order cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Fx2LLTbtEead9bDRE_1DAQ")]
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
    /// Status of the switch order.
    /// </summary>
    [IsoId("_10GMIEH8EeaV3ab_pHzFIQ")]
    [DisplayName("Order Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrSts")]
    #endif
    [IsoXmlTag("OrdrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderStatus4Choice_ OrderStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OrderStatus4Choice_ OrderStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderStatus4Choice_ OrderStatus { get; init; } 
    #else
    public OrderStatus4Choice_ OrderStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Information about a switch leg that is rejected or repaired.
    /// </summary>
    [IsoId("_Fx2LPTbtEead9bDRE_1DAQ")]
    [DisplayName("Leg Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LegInf")]
    #endif
    [IsoXmlTag("LegInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SwitchLegReferences2? LegInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SwitchLegReferences2? LegInformation { get; init; } 
    #else
    public SwitchLegReferences2? LegInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party that initiates the status of the order.
    /// </summary>
    [IsoId("_Fx2LPzbtEead9bDRE_1DAQ")]
    [DisplayName("Status Initiator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInitr")]
    #endif
    [IsoXmlTag("StsInitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification113? StatusInitiator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification113? StatusInitiator { get; init; } 
    #else
    public PartyIdentification113? StatusInitiator { get; set; } 
    #endif
    
    /// <summary>
    /// Order data.
    /// </summary>
    [IsoId("_Fx2LQTbtEead9bDRE_1DAQ")]
    [DisplayName("Order Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrData")]
    #endif
    [IsoXmlTag("OrdrData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundOrderData6? OrderData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundOrderData6? OrderData { get; init; } 
    #else
    public FundOrderData6? OrderData { get; set; } 
    #endif
    
    /// <summary>
    /// Expected execution information.
    /// </summary>
    [IsoId("_Fx2LQzbtEead9bDRE_1DAQ")]
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
