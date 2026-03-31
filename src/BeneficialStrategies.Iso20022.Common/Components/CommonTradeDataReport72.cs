// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Common Trade Data Report72.
/// </summary>
[IsoId("_5yJBy5BBEe6Ojt1b3tfu9Q")]
[DisplayName("Common Trade Data Report72")]
public record CommonTradeDataReport72
{
    /// <summary>
    /// Contract Data.
    /// </summary>
    [DisplayName("Contract Data")]
    [IsoXmlTag("CtrctData")]
    public ContractType15? ContractData { get; init; }

    /// <summary>
    /// Contract Modification.
    /// </summary>
    [DisplayName("Contract Modification")]
    [IsoXmlTag("CtrctMod")]
    public ContractModification9? ContractModification { get; init; }

    /// <summary>
    /// Transaction Data.
    /// </summary>
    [DisplayName("Transaction Data")]
    [IsoXmlTag("TxData")]
    public required TradeTransaction50 TransactionData { get; init; }
}
