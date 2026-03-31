// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract and transaction details.
/// </summary>
[IsoId("_qXWz0XhCEeu3kecHd7QKUQ")]
[DisplayName("Common Trade Data Report")]
public record CommonTradeDataReport49
{
    /// <summary>
    /// Data related to a trade contract.
    /// </summary>
    [IsoId("_qmrCMXhCEeu3kecHd7QKUQ")]
    [DisplayName("Contract Data")]
    [IsoXmlTag("CtrctData")]
    public ContractType10? ContractData { get; init; }

    /// <summary>
    /// Data related to a trade transaction.
    /// </summary>
    [IsoId("_qmrCM3hCEeu3kecHd7QKUQ")]
    [DisplayName("Transaction Data")]
    [IsoXmlTag("TxData")]
    public required TradeTransaction37 TransactionData { get; init; }
}
