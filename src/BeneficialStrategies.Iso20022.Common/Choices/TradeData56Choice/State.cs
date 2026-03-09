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
namespace BeneficialStrategies.Iso20022.Choices.TradeData56Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_SBzrA152Ee2a_-MvhEjKmA")]
    [DisplayName("State")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record State : TradeData56Choice_
    #else
    public partial class State : TradeData56Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a State instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public State( TradeCounterpartyReport20 reqCounterpartyIdentification,MarginCollateralReport4 reqCollateral )
        {
            CounterpartyIdentification = reqCounterpartyIdentification;
            Collateral = reqCollateral;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Date and time of submission of the report to the trade repository.
        /// </summary>
        [IsoId("_SCx7YV52Ee2a_-MvhEjKmA")]
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
        [IsoId("_SCx7Y152Ee2a_-MvhEjKmA")]
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
        [IsoId("_SCx7ZV52Ee2a_-MvhEjKmA")]
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
        [IsoId("_SCx7Z152Ee2a_-MvhEjKmA")]
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
        [IsoId("_SCx7aV52Ee2a_-MvhEjKmA")]
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
        [IsoId("_SCx7a152Ee2a_-MvhEjKmA")]
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
        [IsoId("_SCx7bV52Ee2a_-MvhEjKmA")]
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
        [IsoId("_SCx7b152Ee2a_-MvhEjKmA")]
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
        [IsoId("_SCx7cV52Ee2a_-MvhEjKmA")]
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
        /// Contract modification details expressed as an action type and a reporting level type.
        /// </summary>
        [IsoId("_SCx7c152Ee2a_-MvhEjKmA")]
        [DisplayName("Contract Modification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrctMod")]
        #endif
        [IsoXmlTag("CtrctMod")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ContractModification8? ContractModification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContractModification8? ContractModification { get; init; } 
        #else
        public ContractModification8? ContractModification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies technical attributes of the message.
        /// </summary>
        [IsoId("_SCx7dV52Ee2a_-MvhEjKmA")]
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
        [IsoId("_SCx7d152Ee2a_-MvhEjKmA")]
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
