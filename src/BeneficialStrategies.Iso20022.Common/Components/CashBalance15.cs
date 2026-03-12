// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cash details for amount  assigned as collateral position.
/// </summary>
[IsoId("_rRyqwRIwEeydmIVkS03esw")]
[DisplayName("Cash Balance")]
public partial record CashBalance15
{
    #nullable enable
    
    /// <summary>
    /// Amount of money of the cash balance.
    /// </summary>
    [IsoId("_rn_kMRIwEeydmIVkS03esw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Information needed to process a currency exchange or conversion.
    /// </summary>
    [IsoId("_rn_kMxIwEeydmIVkS03esw")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public ForeignExchangeTerms19? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Account in which cash is maintained.
    /// </summary>
    [IsoId("_rn_kNRIwEeydmIVkS03esw")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    
    /// <summary>
    /// Valuation details for the securities position.
    /// </summary>
    [IsoId("_rn_kNxIwEeydmIVkS03esw")]
    [DisplayName("Valuation Details")]
    [IsoXmlTag("ValtnDtls")]
    public ValuationsDetails2? ValuationDetails { get; init; } 
    
    /// <summary>
    /// Identification of the underlying market value lots based on the term of the underlying trades. The issuer defines the lot identification.
    /// </summary>
    [IsoId("_rn_kORIwEeydmIVkS03esw")]
    [DisplayName("Transaction Lot Number")]
    [IsoXmlTag("TxLotNb")]
    public GenericIdentification178? TransactionLotNumber { get; init; } 
    
    
    #nullable disable
    
}
