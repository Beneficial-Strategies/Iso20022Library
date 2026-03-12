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
[IsoId("_KtVU4QACEeqefbt-QjTNnA")]
[DisplayName("Trade Transaction Collateral Update")]
public partial record TradeTransactionCollateralUpdate5
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    [IsoId("_Kx7hAQACEeqefbt-QjTNnA")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    [IsoId("_Kx7hAwACEeqefbt-QjTNnA")]
    [DisplayName("Counterparty Data")]
    [IsoXmlTag("CtrPtyData")]
    public required CounterpartyData76 CounterpartyData { get; init; } 
    
    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    [IsoId("_Kx7hBQACEeqefbt-QjTNnA")]
    [DisplayName("Loan Data")]
    [IsoXmlTag("LnData")]
    public required TransactionLoanData9Choice_ LoanData { get; init; } 
    
    /// <summary>
    /// Information on collateral used in the transaction.
    /// </summary>
    [IsoId("_Kx7hBwACEeqefbt-QjTNnA")]
    [DisplayName("Collateral Data")]
    [IsoXmlTag("CollData")]
    public required TransactionCollateralData14Choice_ CollateralData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_Kx7hCQACEeqefbt-QjTNnA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
