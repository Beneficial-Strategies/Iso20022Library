// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract and transaction details.
/// </summary>
[IsoId("_Zi_P9w1HEeqV4s5SpzR1dQ")]
[DisplayName("Common Trade Data Report")]
public partial record CommonTradeDataReport33
{
    #nullable enable
    
    /// <summary>
    /// Data related to a trade contract.
    /// </summary>
    [IsoId("_Zj1kgQ1HEeqV4s5SpzR1dQ")]
    [DisplayName("Contract Data")]
    [IsoXmlTag("CtrctData")]
    public ContractType8? ContractData { get; init; } 
    
    /// <summary>
    /// Data related to a trade transaction.
    /// </summary>
    [IsoId("_Zj1kgw1HEeqV4s5SpzR1dQ")]
    [DisplayName("Transaction Data")]
    [IsoXmlTag("TxData")]
    public required TradeTransaction24 TransactionData { get; init; } 
    
    
    #nullable disable
    
}
