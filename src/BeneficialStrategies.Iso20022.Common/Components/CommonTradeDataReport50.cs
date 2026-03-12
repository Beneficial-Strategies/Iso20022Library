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
[IsoId("_rFUtFXhCEeu3kecHd7QKUQ")]
[DisplayName("Common Trade Data Report")]
public partial record CommonTradeDataReport50
{
    #nullable enable
    
    /// <summary>
    /// Data related to a trade contract.
    /// </summary>
    [IsoId("_rU8dcXhCEeu3kecHd7QKUQ")]
    [DisplayName("Contract Data")]
    [IsoXmlTag("CtrctData")]
    public ContractType10? ContractData { get; init; } 
    
    /// <summary>
    /// Data related to a trade transaction.
    /// </summary>
    [IsoId("_rU8dc3hCEeu3kecHd7QKUQ")]
    [DisplayName("Transaction Data")]
    [IsoXmlTag("TxData")]
    public required TradeTransaction37 TransactionData { get; init; } 
    
    /// <summary>
    /// Contract modification details expressed as an action type and a reporting level type.
    /// </summary>
    [IsoId("_rU8ddXhCEeu3kecHd7QKUQ")]
    [DisplayName("Contract Modification")]
    [IsoXmlTag("CtrctMod")]
    public ContractModification4? ContractModification { get; init; } 
    
    
    #nullable disable
    
}
