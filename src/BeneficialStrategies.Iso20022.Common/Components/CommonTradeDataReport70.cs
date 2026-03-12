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
[IsoId("_CCCeAWEbEe2P-L9DBerEgA")]
[DisplayName("Common Trade Data Report")]
public partial record CommonTradeDataReport70
{
    #nullable enable
    
    /// <summary>
    /// Data related to a trade contract.
    /// </summary>
    [IsoId("_CC4ykWEbEe2P-L9DBerEgA")]
    [DisplayName("Contract Data")]
    [IsoXmlTag("CtrctData")]
    public ContractType14? ContractData { get; init; } 
    
    /// <summary>
    /// Data related to a trade transaction.
    /// </summary>
    [IsoId("_CC4yk2EbEe2P-L9DBerEgA")]
    [DisplayName("Transaction Data")]
    [IsoXmlTag("TxData")]
    public required TradeTransaction49 TransactionData { get; init; } 
    
    /// <summary>
    /// Contract modification details expressed as an action type and a reporting level type.
    /// </summary>
    [IsoId("_CC4ylWEbEe2P-L9DBerEgA")]
    [DisplayName("Contract Modification")]
    [IsoXmlTag("CtrctMod")]
    public ContractModification9? ContractModification { get; init; } 
    
    
    #nullable disable
    
}
