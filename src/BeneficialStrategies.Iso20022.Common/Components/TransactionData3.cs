// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Data3.
/// </summary>
[IsoId("_Z2GcQBA3Ee6N57R8Wekj-w")]
[DisplayName("Transaction Data3")]
public record TransactionData3
{
    /// <summary>
    /// Passive Or Aggressive Indicator.
    /// </summary>
    [DisplayName("Passive Or Aggressive Indicator")]
    [IsoXmlTag("PssvOrAggrssvInd")]
    public PassiveOrAgressiveType1Code? PassiveOrAggressiveIndicator { get; init; }

    /// <summary>
    /// Strategy Linked Order Identification.
    /// </summary>
    [DisplayName("Strategy Linked Order Identification")]
    [IsoXmlTag("StrtgyLkdOrdrId")]
    public IsoMax50Text? StrategyLinkedOrderIdentification { get; init; }

    /// <summary>
    /// Traded Quantity.
    /// </summary>
    [DisplayName("Traded Quantity")]
    [IsoXmlTag("TraddQty")]
    public FinancialInstrumentQuantity25Choice_? TradedQuantity { get; init; }

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public IsoMax52Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Transaction Price.
    /// </summary>
    [DisplayName("Transaction Price")]
    [IsoXmlTag("TxPric")]
    public SecuritiesTransactionPrice4Choice_? TransactionPrice { get; init; }
}
