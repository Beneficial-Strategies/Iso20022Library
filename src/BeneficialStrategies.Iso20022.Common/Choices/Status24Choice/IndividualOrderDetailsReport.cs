// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.Status24Choice
{
    /// <summary>
    /// Status report details of an individual order.
    /// </summary>
    [IsoId("_bpQwZEHPEeazV4RAqPV71g")]
    [DisplayName("Individual Order Details Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record IndividualOrderDetailsReport : Status24Choice_
    #else
    public partial class IndividualOrderDetailsReport : Status24Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a IndividualOrderDetailsReport instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public IndividualOrderDetailsReport( System.String reqOrderReference,OrderStatus5Choice_ reqOrderStatus )
        {
            OrderReference = reqOrderReference;
            OrderStatus = reqOrderStatus;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Reference assigned to a set of orders or trades in order to link them together.
        /// </summary>
        [IsoId("_JSDihTbtEead9bDRE_1DAQ")]
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
        [IsoId("_JSDihzbtEead9bDRE_1DAQ")]
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
        [IsoId("_JSDiiTbtEead9bDRE_1DAQ")]
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
        [IsoId("_JSDiizbtEead9bDRE_1DAQ")]
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
        [IsoId("_JSDijTbtEead9bDRE_1DAQ")]
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
        /// Status of the individual order.
        /// </summary>
        [IsoId("_Sop2EEHQEeazV4RAqPV71g")]
        [DisplayName("Order Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrdrSts")]
        #endif
        [IsoXmlTag("OrdrSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required OrderStatus5Choice_ OrderStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required OrderStatus5Choice_ OrderStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public OrderStatus5Choice_ OrderStatus { get; init; } 
        #else
        public OrderStatus5Choice_ OrderStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Elements from the original individual order that have been repaired so that the order can be accepted.
        /// </summary>
        [IsoId("_zyjlwTk2EeapUO0vUIo9Xw")]
        [DisplayName("Repaired Fee")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RprdFee")]
        #endif
        [IsoXmlTag("RprdFee")]
        [MinLength(0)]
        [MaxLength(10)]
        public ValueList<Fee3> RepairedFee { get; init; } = new ValueList<Fee3>(){};
        
        /// <summary>
        /// Party that initiates the status of the order.
        /// </summary>
        [IsoId("_xvSL8UjYEeaUN5TdQqhvNQ")]
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
        [IsoId("_JSDioTbtEead9bDRE_1DAQ")]
        [DisplayName("Order Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="OrdrData")]
        #endif
        [IsoXmlTag("OrdrData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FundOrderData5? OrderData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FundOrderData5? OrderData { get; init; } 
        #else
        public FundOrderData5? OrderData { get; set; } 
        #endif
        
        /// <summary>
        /// Expected execution information.
        /// </summary>
        [IsoId("_JSDiozbtEead9bDRE_1DAQ")]
        [DisplayName("New Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NewDtls")]
        #endif
        [IsoXmlTag("NewDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ExpectedExecutionDetails4? NewDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExpectedExecutionDetails4? NewDetails { get; init; } 
        #else
        public ExpectedExecutionDetails4? NewDetails { get; set; } 
        #endif
        
        /// <summary>
        /// Information about gating and hold back of redemption proceeds.
        /// </summary>
        [IsoId("_gd_YcUgWEea9YuSvQGoi-w")]
        [DisplayName("Gating Or Hold Back Details")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="GtgOrHldBckDtls")]
        #endif
        [IsoXmlTag("GtgOrHldBckDtls")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public HoldBackInformation3? GatingOrHoldBackDetails { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public HoldBackInformation3? GatingOrHoldBackDetails { get; init; } 
        #else
        public HoldBackInformation3? GatingOrHoldBackDetails { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
