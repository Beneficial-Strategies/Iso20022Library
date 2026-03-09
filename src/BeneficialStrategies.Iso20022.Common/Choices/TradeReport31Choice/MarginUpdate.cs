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
namespace BeneficialStrategies.Iso20022.Choices.TradeReport31Choice
{
    /// <summary>
    /// Indicates the report of the collateral data or of their modifications, but not the corrections of the previously reported collateral details.
    /// </summary>
    [IsoId("_o0KFY1osEe23K4GXSpBSeg")]
    [DisplayName("Margin Update")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record MarginUpdate : TradeReport31Choice_
    #else
    public partial class MarginUpdate : TradeReport31Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a MarginUpdate instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public MarginUpdate( TradeCounterpartyReport20 reqCounterpartyIdentification,MarginCollateralReport4 reqCollateral )
        {
            CounterpartyIdentification = reqCounterpartyIdentification;
            Collateral = reqCollateral;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Date and time of submission of the report to the trade repository.
        /// </summary>
        [IsoId("_o13VkVosEe23K4GXSpBSeg")]
        [DisplayName("Reporting Time Stamp")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RptgTmStmp")]
        #endif
        [IsoXmlTag("RptgTmStmp")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODateTime? ReportingTimeStamp { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime? ReportingTimeStamp { get; init; } 
        #else
        public System.DateTime? ReportingTimeStamp { get; set; } 
        #endif
        
        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_o13Vk1osEe23K4GXSpBSeg")]
        [DisplayName("Counterparty Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtyId")]
        #endif
        [IsoXmlTag("CtrPtyId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required TradeCounterpartyReport20 CounterpartyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required TradeCounterpartyReport20 CounterpartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TradeCounterpartyReport20 CounterpartyIdentification { get; init; } 
        #else
        public TradeCounterpartyReport20 CounterpartyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_o13VlVosEe23K4GXSpBSeg")]
        [DisplayName("Event Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EvtDt")]
        #endif
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? EventDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? EventDate { get; init; } 
        #else
        public System.DateOnly? EventDate { get; set; } 
        #endif
        
        /// <summary>
        /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier as agreed with the counterparty. 
        /// </summary>
        [IsoId("_o13Vl1osEe23K4GXSpBSeg")]
        [DisplayName("Transaction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxId")]
        #endif
        [IsoXmlTag("TxId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; init; } 
        #else
        public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Information related to collateral agreement existing between counterparties.
        /// </summary>
        [IsoId("_o13VmVosEe23K4GXSpBSeg")]
        [DisplayName("Collateral")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Coll")]
        #endif
        [IsoXmlTag("Coll")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required MarginCollateralReport4 Collateral { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required MarginCollateralReport4 Collateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MarginCollateralReport4 Collateral { get; init; } 
        #else
        public MarginCollateralReport4 Collateral { get; set; } 
        #endif
        
        /// <summary>
        /// Information on posted collateral and margin.
        /// </summary>
        [IsoId("_o13Vm1osEe23K4GXSpBSeg")]
        [DisplayName("Posted Margin Or Collateral")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PstdMrgnOrColl")]
        #endif
        [IsoXmlTag("PstdMrgnOrColl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PostedMarginOrCollateral6? PostedMarginOrCollateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PostedMarginOrCollateral6? PostedMarginOrCollateral { get; init; } 
        #else
        public PostedMarginOrCollateral6? PostedMarginOrCollateral { get; set; } 
        #endif
        
        /// <summary>
        /// Information on received collateral and margin.
        /// </summary>
        [IsoId("_o13VnVosEe23K4GXSpBSeg")]
        [DisplayName("Received Margin Or Collateral")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RcvdMrgnOrColl")]
        #endif
        [IsoXmlTag("RcvdMrgnOrColl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReceivedMarginOrCollateral6? ReceivedMarginOrCollateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReceivedMarginOrCollateral6? ReceivedMarginOrCollateral { get; init; } 
        #else
        public ReceivedMarginOrCollateral6? ReceivedMarginOrCollateral { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates if a counterparty rating trigger is agreed by the counterparties for the collateral posted by the reporting counterparty.
        /// Usage: If the element is not present, the CounterpartyRatingTrigger is False.
        /// </summary>
        [IsoId("_o13Vn1osEe23K4GXSpBSeg")]
        [DisplayName("Counterparty Rating Trigger Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtyRatgTrggrInd")]
        #endif
        [IsoXmlTag("CtrPtyRatgTrggrInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? CounterpartyRatingTriggerIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CounterpartyRatingTriggerIndicator { get; init; } 
        #else
        public System.String? CounterpartyRatingTriggerIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates if a counterparty rating trigger includes a threshold that increases collateral requirements when the counterparty falls below the single-A rating or equivalent.
        /// Usage: If the CounterpartyRatingTrigger indicator is false, this element is omitted.
        /// </summary>
        [IsoId("_o13VoVosEe23K4GXSpBSeg")]
        [DisplayName("Counterparty Rating Threshold Indicator")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtyRatgThrshldInd")]
        #endif
        [IsoXmlTag("CtrPtyRatgThrshldInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? CounterpartyRatingThresholdIndicator { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CounterpartyRatingThresholdIndicator { get; init; } 
        #else
        public System.String? CounterpartyRatingThresholdIndicator { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_o13Vo1osEe23K4GXSpBSeg")]
        [DisplayName("Technical Attributes")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TechAttrbts")]
        #endif
        [IsoXmlTag("TechAttrbts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TechnicalAttributes6? TechnicalAttributes { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TechnicalAttributes6? TechnicalAttributes { get; init; } 
        #else
        public TechnicalAttributes6? TechnicalAttributes { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_o13VpVosEe23K4GXSpBSeg")]
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
}
