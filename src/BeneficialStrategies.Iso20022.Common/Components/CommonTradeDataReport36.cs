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
[IsoId("_ifb7qQ1JEeqV4s5SpzR1dQ")]
[DisplayName("Common Trade Data Report")]
public record CommonTradeDataReport36
{
    /// <summary>
    /// Data specifically related to contract.
    /// </summary>
    [IsoId("_igMJkw1JEeqV4s5SpzR1dQ")]
    [DisplayName("Contract Data")]
    [IsoXmlTag("CtrctData")]
    public ContractType8? ContractData { get; init; }

    /// <summary>
    /// Data related specifically to the transaction.
    /// </summary>
    [IsoId("_igMJlQ1JEeqV4s5SpzR1dQ")]
    [DisplayName("Transaction Data")]
    [IsoXmlTag("TxData")]
    public TradeTransaction27? TransactionData { get; init; }
}
