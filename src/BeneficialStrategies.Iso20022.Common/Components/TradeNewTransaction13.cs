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
/// Indicates whether transaction is reported for the first time.
/// </summary>
[IsoId("_zvSsgcg3EeuGrNSsxk3B0A")]
[DisplayName("Trade New Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeNewTransaction13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeNewTransaction13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeNewTransaction13( CounterpartyData88 reqCounterpartySpecificData,TransactionLoanData30Choice_ reqLoanData,ModificationLevel1Code reqLevelType )
    {
        CounterpartySpecificData = reqCounterpartySpecificData;
        LoanData = reqLoanData;
        LevelType = reqLevelType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_zwwsEcg3EeuGrNSsxk3B0A")]
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
    /// Set of information specific to counterparties and related fields.
    /// </summary>
    [IsoId("_zwwsE8g3EeuGrNSsxk3B0A")]
    [DisplayName("Counterparty Specific Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySpcfcData")]
    #endif
    [IsoXmlTag("CtrPtySpcfcData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CounterpartyData88 CounterpartySpecificData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CounterpartyData88 CounterpartySpecificData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CounterpartyData88 CounterpartySpecificData { get; init; } 
    #else
    public CounterpartyData88 CounterpartySpecificData { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [IsoId("_zwwsFcg3EeuGrNSsxk3B0A")]
    [DisplayName("Loan Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnData")]
    #endif
    [IsoXmlTag("LnData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionLoanData30Choice_ LoanData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionLoanData30Choice_ LoanData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionLoanData30Choice_ LoanData { get; init; } 
    #else
    public TransactionLoanData30Choice_ LoanData { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the details of the collateral used in the transaction.
    /// </summary>
    [IsoId("_zwwsF8g3EeuGrNSsxk3B0A")]
    [DisplayName("Collateral Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollData")]
    #endif
    [IsoXmlTag("CollData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionCollateralData18Choice_? CollateralData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionCollateralData18Choice_? CollateralData { get; init; } 
    #else
    public TransactionCollateralData18Choice_? CollateralData { get; set; } 
    #endif
    
    /// <summary>
    /// Information concerning the reported transaction level type.
    /// </summary>
    [IsoId("_zwwsGcg3EeuGrNSsxk3B0A")]
    [DisplayName("Level Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LvlTp")]
    #endif
    [IsoXmlTag("LvlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ModificationLevel1Code LevelType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ModificationLevel1Code LevelType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationLevel1Code LevelType { get; init; } 
    #else
    public ModificationLevel1Code LevelType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_zwwsG8g3EeuGrNSsxk3B0A")]
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
