// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates whether transaction is reported for the first time.
/// </summary>
[IsoId("_zvSsgcg3EeuGrNSsxk3B0A")]
[DisplayName("Trade New Transaction")]
public partial record TradeNewTransaction13
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_zwwsEcg3EeuGrNSsxk3B0A")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Set of information specific to counterparties and related fields.
    /// </summary>
    [IsoId("_zwwsE8g3EeuGrNSsxk3B0A")]
    [DisplayName("Counterparty Specific Data")]
    [IsoXmlTag("CtrPtySpcfcData")]
    public required CounterpartyData88 CounterpartySpecificData { get; init; } 
    
    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [IsoId("_zwwsFcg3EeuGrNSsxk3B0A")]
    [DisplayName("Loan Data")]
    [IsoXmlTag("LnData")]
    public required TransactionLoanData30Choice_ LoanData { get; init; } 
    
    /// <summary>
    /// Provides the details of the collateral used in the transaction.
    /// </summary>
    [IsoId("_zwwsF8g3EeuGrNSsxk3B0A")]
    [DisplayName("Collateral Data")]
    [IsoXmlTag("CollData")]
    public TransactionCollateralData18Choice_? CollateralData { get; init; } 
    
    /// <summary>
    /// Information concerning the reported transaction level type.
    /// </summary>
    [IsoId("_zwwsGcg3EeuGrNSsxk3B0A")]
    [DisplayName("Level Type")]
    [IsoXmlTag("LvlTp")]
    public required ModificationLevel1Code LevelType { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_zwwsG8g3EeuGrNSsxk3B0A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
