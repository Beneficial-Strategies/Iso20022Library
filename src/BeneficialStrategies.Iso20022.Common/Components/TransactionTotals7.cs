// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction totals during the reconciliation period, for a certain type of transaction.
/// </summary>
[IsoId("_YvLH8cNWEeWGDrnsYu2p6g")]
[DisplayName("Transaction Totals")]
public partial record TransactionTotals7
{
    #nullable enable
    
    /// <summary>
    /// Identifier assigned by the merchant identifying a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_Y7YX8cNWEeWGDrnsYu2p6g")]
    [DisplayName("POI Group Identification")]
    [IsoXmlTag("POIGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? POIGroupIdentification { get; init; } 
    
    /// <summary>
    /// Category of cards related the acceptance processing rules defined by the acquirer.
    /// </summary>
    [IsoId("_Y7YX88NWEeWGDrnsYu2p6g")]
    [DisplayName("Card Product Profile")]
    [IsoXmlTag("CardPdctPrfl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CardProductProfile { get; init; } 
    
    /// <summary>
    /// Currency associated with the transaction totals.
    /// </summary>
    [IsoId("_Y7YX9cNWEeWGDrnsYu2p6g")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveCurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Identification of the type of transaction.
    /// </summary>
    [IsoId("_Y7YX98NWEeWGDrnsYu2p6g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required TypeTransactionTotals2Code Type { get; init; } 
    
    /// <summary>
    /// Total number of transactions during a reconciliation period.
    /// </summary>
    [IsoId("_Y7YX-cNWEeWGDrnsYu2p6g")]
    [DisplayName("Total Number")]
    [IsoXmlTag("TtlNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber TotalNumber { get; init; } 
    
    /// <summary>
    /// Total amount of a collection of transactions.
    /// </summary>
    [IsoId("_Y7YX-8NWEeWGDrnsYu2p6g")]
    [DisplayName("Cumulative Amount")]
    [IsoXmlTag("CmltvAmt")]
    public required ImpliedCurrencyAndAmount CumulativeAmount { get; init; } 
    
    
    #nullable disable
    
}
