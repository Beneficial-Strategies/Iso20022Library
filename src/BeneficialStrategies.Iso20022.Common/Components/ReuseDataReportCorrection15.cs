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
/// Indicates that the report is correcting the erroneous data fields of a previously submitted position.
/// </summary>
[IsoId("_S05rFcK9EeuCIrYISEfoUg")]
[DisplayName("Reuse Data Report Correction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReuseDataReportCorrection15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReuseDataReportCorrection15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReuseDataReportCorrection15( CounterpartyData87 reqCounterparty,System.DateOnly reqEventDay,System.DateTime reqReportingDateTime,ContractModification3 reqContractModification )
    {
        Counterparty = reqCounterparty;
        EventDay = reqEventDay;
        ReportingDateTime = reqReportingDateTime;
        ContractModification = reqContractModification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_S2WckcK9EeuCIrYISEfoUg")]
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
    [IsoId("_S2Wck8K9EeuCIrYISEfoUg")]
    [DisplayName("Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPty")]
    #endif
    [IsoXmlTag("CtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyData87 Counterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CounterpartyData87 Counterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyData87 Counterparty { get; init; } 
    #else
    public CounterpartyData87 Counterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the security or cash pledged as collateral.
    /// </summary>
    [IsoId("_S2WclcK9EeuCIrYISEfoUg")]
    [DisplayName("Collateral Component")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollCmpnt")]
    #endif
    [IsoXmlTag("CollCmpnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralType19? CollateralComponent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType19? CollateralComponent { get; init; } 
    #else
    public CollateralType19? CollateralComponent { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    [IsoId("_S2Wcl8K9EeuCIrYISEfoUg")]
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
    [IsoId("_S2WcmcK9EeuCIrYISEfoUg")]
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
    [IsoId("_S2Wcm8K9EeuCIrYISEfoUg")]
    [DisplayName("Funding Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndgSrc")]
    #endif
    [IsoXmlTag("FndgSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundingSource3? FundingSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundingSource3? FundingSource { get; init; } 
    #else
    public FundingSource3? FundingSource { get; set; } 
    #endif
    
    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    [IsoId("_S2WcncK9EeuCIrYISEfoUg")]
    [DisplayName("Reconciliation Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcncltnFlg")]
    #endif
    [IsoXmlTag("RcncltnFlg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReconciliationFlag2? ReconciliationFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReconciliationFlag2? ReconciliationFlag { get; init; } 
    #else
    public ReconciliationFlag2? ReconciliationFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Contract modification details expressed as an action type and a reporting level type.
    /// </summary>
    [IsoId("_S2Wcn8K9EeuCIrYISEfoUg")]
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
    [IsoId("_S2WcocK9EeuCIrYISEfoUg")]
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
