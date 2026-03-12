// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details for a trade state report.
/// </summary>
[IsoId("_x-2JJcK-EeuCIrYISEfoUg")]
[DisplayName("Trade State Report")]
public partial record TradeStateReport16
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_yAM0AcK-EeuCIrYISEfoUg")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_yAM0A8K-EeuCIrYISEfoUg")]
    [DisplayName("Counterparty Specific Data")]
    [IsoXmlTag("CtrPtySpcfcData")]
    public required CounterpartyData88 CounterpartySpecificData { get; init; } 
    
    /// <summary>
    /// Details of the loan used for financing the transaction.
    /// </summary>
    [IsoId("_yAM0BcK-EeuCIrYISEfoUg")]
    [DisplayName("Loan Data")]
    [IsoXmlTag("LnData")]
    public TransactionLoanData31Choice_? LoanData { get; init; } 
    
    /// <summary>
    /// Set of information on collateral used in the transaction.
    /// </summary>
    [IsoId("_yAM0B8K-EeuCIrYISEfoUg")]
    [DisplayName("Collateral Data")]
    [IsoXmlTag("CollData")]
    public TransactionCollateralData18Choice_? CollateralData { get; init; } 
    
    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    [IsoId("_yAM0CcK-EeuCIrYISEfoUg")]
    [DisplayName("Reconciliation Flag")]
    [IsoXmlTag("RcncltnFlg")]
    public ReconciliationFlag2? ReconciliationFlag { get; init; } 
    
    /// <summary>
    /// Contract modification details expressed as an action type and a reporting level type.
    /// </summary>
    [IsoId("_yAM0C8K-EeuCIrYISEfoUg")]
    [DisplayName("Contract Modification")]
    [IsoXmlTag("CtrctMod")]
    public required ContractModification3 ContractModification { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_yAM0DcK-EeuCIrYISEfoUg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
