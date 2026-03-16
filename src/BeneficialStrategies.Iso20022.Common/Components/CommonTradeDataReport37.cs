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
[IsoId("_EPVkyQ1KEeqV4s5SpzR1dQ")]
[DisplayName("Common Trade Data Report")]
public record CommonTradeDataReport37
{
    /// <summary>
    /// Data related to a trade contract.
    /// </summary>
    [IsoId("_EQKEIQ1KEeqV4s5SpzR1dQ")]
    [DisplayName("Contract Data")]
    [IsoXmlTag("CtrctData")]
    public ContractType8? ContractData { get; init; }

    /// <summary>
    /// Data related specifically to a trade transaction.
    /// </summary>
    [IsoId("_EQKEIw1KEeqV4s5SpzR1dQ")]
    [DisplayName("Transaction Data")]
    [IsoXmlTag("TxData")]
    public required TradeTransaction25 TransactionData { get; init; }

    /// <summary>
    /// Details of the other action type.
    /// </summary>
    [IsoId("_EQKEJQ1KEeqV4s5SpzR1dQ")]
    [DisplayName("Action Type Details")]
    [IsoXmlTag("ActnTpDtls")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50, MinimumLength = 1)]
    public IsoMax50Text? ActionTypeDetails { get; init; }
}
