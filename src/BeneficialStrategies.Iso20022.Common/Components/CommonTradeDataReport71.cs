// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Common Trade Data Report71.
/// </summary>
[IsoId("_8s_STY-REe6Ojt1b3tfu9Q")]
[DisplayName("Common Trade Data Report71")]
public partial record CommonTradeDataReport71
{
    #nullable enable

    /// <summary>
    /// Contract Data.
    /// </summary>
    [DisplayName("Contract Data")]
    [IsoXmlTag("CtrctData")]
    public ContractType15? ContractData { get; init; } 

    /// <summary>
    /// Transaction Data.
    /// </summary>
    [DisplayName("Transaction Data")]
    [IsoXmlTag("TxData")]
    public required TradeTransaction50 TransactionData { get; init; } 

    
    #nullable disable
    
}
