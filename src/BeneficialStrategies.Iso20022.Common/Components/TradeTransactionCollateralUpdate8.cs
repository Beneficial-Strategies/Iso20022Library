// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the loan used for financing the transaction.
/// </summary>
[IsoId("__yc-Uc0DEeufhKfUxzsnrQ")]
[DisplayName("Trade Transaction Collateral Update")]
public partial record TradeTransactionCollateralUpdate8
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("__0b7Uc0DEeufhKfUxzsnrQ")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Counterparty and related information.
    /// </summary>
    [IsoId("__0b7U80DEeufhKfUxzsnrQ")]
    [DisplayName("Counterparty Specific Data")]
    [IsoXmlTag("CtrPtySpcfcData")]
    public required CounterpartyData88 CounterpartySpecificData { get; init; } 
    
    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    [IsoId("__0b7Vc0DEeufhKfUxzsnrQ")]
    [DisplayName("Loan Data")]
    [IsoXmlTag("LnData")]
    public TransactionLoanData26Choice_? LoanData { get; init; } 
    
    /// <summary>
    /// Provides the details of the collateral used in the transaction.
    /// </summary>
    [IsoId("__0b7V80DEeufhKfUxzsnrQ")]
    [DisplayName("Collateral Data")]
    [IsoXmlTag("CollData")]
    public required TransactionCollateralData18Choice_ CollateralData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("__0b7Wc0DEeufhKfUxzsnrQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
