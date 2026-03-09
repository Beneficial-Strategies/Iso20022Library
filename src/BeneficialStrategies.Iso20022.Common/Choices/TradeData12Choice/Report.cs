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
namespace BeneficialStrategies.Iso20022.Choices.TradeData12Choice
{
    /// <summary>
    /// Information concerning the reporting at transaction level.
    /// </summary>
    [IsoId("_SPuq8__kEemm3skPVSMJQg")]
    [DisplayName("Report")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Report : TradeData12Choice_
    #else
    public partial class Report : TradeData12Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Report instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Report( CounterpartyData46 reqCounterpartyData,CollateralType12 reqCollateralComponent,System.DateOnly reqEventDay,System.DateTime reqReportingDateTime,ContractModification3 reqContractModification )
        {
            CounterpartyData = reqCounterpartyData;
            CollateralComponent = reqCollateralComponent;
            EventDay = reqEventDay;
            ReportingDateTime = reqReportingDateTime;
            ContractModification = reqContractModification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_qlrv4f_pEemm3skPVSMJQg")]
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
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_qlrv4__pEemm3skPVSMJQg")]
        [DisplayName("Counterparty Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CtrPtyData")]
        #endif
        [IsoXmlTag("CtrPtyData")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CounterpartyData46 CounterpartyData { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CounterpartyData46 CounterpartyData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CounterpartyData46 CounterpartyData { get; init; } 
        #else
        public CounterpartyData46 CounterpartyData { get; set; } 
        #endif
        
        /// <summary>
        /// Provides the details of the security or cash pledged as collateral.
        /// </summary>
        [IsoId("_qlrv5f_pEemm3skPVSMJQg")]
        [DisplayName("Collateral Component")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollCmpnt")]
        #endif
        [IsoXmlTag("CollCmpnt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CollateralType12 CollateralComponent { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CollateralType12 CollateralComponent { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralType12 CollateralComponent { get; init; } 
        #else
        public CollateralType12 CollateralComponent { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_qlrv6f_pEemm3skPVSMJQg")]
        [DisplayName("Event Day")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EvtDay")]
        #endif
        [IsoXmlTag("EvtDay")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate EventDay { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly EventDay { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly EventDay { get; init; } 
        #else
        public System.DateOnly EventDay { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time of submission of the report to the entitled receiver.
        /// </summary>
        [IsoId("_qlrv6__pEemm3skPVSMJQg")]
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
        /// Information on funding sources used to finance margin loans.
        /// </summary>
        [IsoId("_qlrv7f_pEemm3skPVSMJQg")]
        [DisplayName("Funding Source")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FndgSrc")]
        #endif
        [IsoXmlTag("FndgSrc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public FundingSource1? FundingSource { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public FundingSource1? FundingSource { get; init; } 
        #else
        public FundingSource1? FundingSource { get; set; } 
        #endif
        
        /// <summary>
        /// List of possible values for TRs reconciliation purposes.
        /// </summary>
        [IsoId("_qlrv7__pEemm3skPVSMJQg")]
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
        [IsoId("_qlrv8f_pEemm3skPVSMJQg")]
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
        [IsoId("_qlrv8__pEemm3skPVSMJQg")]
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
