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
namespace BeneficialStrategies.Iso20022.Choices.TradeData13Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_x460U__mEemm3skPVSMJQg")]
    [DisplayName("State")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record State : TradeData13Choice_
    #else
    public partial class State : TradeData13Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a State instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public State( System.DateTime reqReportingDateTime,System.DateOnly reqEventDate,Counterparty30 reqCounterparty,System.String reqCollateralPortfolioIdentification,ContractModification3 reqContractModification )
        {
            ReportingDateTime = reqReportingDateTime;
            EventDate = reqEventDate;
            Counterparty = reqCounterparty;
            CollateralPortfolioIdentification = reqCollateralPortfolioIdentification;
            ContractModification = reqContractModification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_x-Irgf_mEemm3skPVSMJQg")]
        [DisplayName("Technical Record Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TechRcrdId")]
        #endif
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TechnicalRecordIdentification { get; init; } 
        #else
        public System.String? TechnicalRecordIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time of submission of the report to the trade repository.
        /// </summary>
        [IsoId("_x-Irg__mEemm3skPVSMJQg")]
        [DisplayName("Reporting Date Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RptgDtTm")]
        #endif
        [IsoXmlTag("RptgDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime ReportingDateTime { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateTime ReportingDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime ReportingDateTime { get; init; } 
        #else
        public System.DateTime ReportingDateTime { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_x-Irhf_mEemm3skPVSMJQg")]
        [DisplayName("Event Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EvtDt")]
        #endif
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate EventDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly EventDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly EventDate { get; init; } 
        #else
        public System.DateOnly EventDate { get; set; } 
        #endif
        
        /// <summary>
        /// Data specific to counterparties of the reported transaction.
        /// </summary>
        [IsoId("_x-Irh__mEemm3skPVSMJQg")]
        [DisplayName("Counterparty")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPty")]
        #endif
        [IsoXmlTag("CtrPty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Counterparty30 Counterparty { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Counterparty30 Counterparty { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Counterparty30 Counterparty { get; init; } 
        #else
        public Counterparty30 Counterparty { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identification of the collateral portfolio.
        /// </summary>
        [IsoId("_x-Irif_mEemm3skPVSMJQg")]
        [DisplayName("Collateral Portfolio Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollPrtflId")]
        #endif
        [IsoXmlTag("CollPrtflId")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax52Text CollateralPortfolioIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String CollateralPortfolioIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String CollateralPortfolioIdentification { get; init; } 
        #else
        public System.String CollateralPortfolioIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Information on posted collateral and margin.
        /// </summary>
        [IsoId("_x-Iri__mEemm3skPVSMJQg")]
        [DisplayName("Posted Margin Or Collateral")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PstdMrgnOrColl")]
        #endif
        [IsoXmlTag("PstdMrgnOrColl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PostedMarginOrCollateral3? PostedMarginOrCollateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PostedMarginOrCollateral3? PostedMarginOrCollateral { get; init; } 
        #else
        public PostedMarginOrCollateral3? PostedMarginOrCollateral { get; set; } 
        #endif
        
        /// <summary>
        /// Information on received collateral and margin.
        /// </summary>
        [IsoId("_x-Irjf_mEemm3skPVSMJQg")]
        [DisplayName("Received Margin Or Collateral")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RcvdMrgnOrColl")]
        #endif
        [IsoXmlTag("RcvdMrgnOrColl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReceivedMarginOrCollateral3? ReceivedMarginOrCollateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReceivedMarginOrCollateral3? ReceivedMarginOrCollateral { get; init; } 
        #else
        public ReceivedMarginOrCollateral3? ReceivedMarginOrCollateral { get; set; } 
        #endif
        
        /// <summary>
        /// List of possible values for TRs reconciliation purposes.
        /// </summary>
        [IsoId("_x-Irj__mEemm3skPVSMJQg")]
        [DisplayName("Reconciliation Flag")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RcncltnFlg")]
        #endif
        [IsoXmlTag("RcncltnFlg")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReconciliationFlag1? ReconciliationFlag { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReconciliationFlag1? ReconciliationFlag { get; init; } 
        #else
        public ReconciliationFlag1? ReconciliationFlag { get; set; } 
        #endif
        
        /// <summary>
        /// Contract modification details expressed as an action type and a reporting level type.
        /// </summary>
        [IsoId("_x-Irkf_mEemm3skPVSMJQg")]
        [DisplayName("Contract Modification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrctMod")]
        #endif
        [IsoXmlTag("CtrctMod")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required ContractModification3 ContractModification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required ContractModification3 ContractModification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContractModification3 ContractModification { get; init; } 
        #else
        public ContractModification3 ContractModification { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_x-Irk__mEemm3skPVSMJQg")]
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
