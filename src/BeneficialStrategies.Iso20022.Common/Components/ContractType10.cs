// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract attributes.
/// </summary>
[IsoId("_qmrCNXhCEeu3kecHd7QKUQ")]
[DisplayName("Contract Type")]
public partial record ContractType10
{
    #nullable enable
    
    /// <summary>
    /// Classification of information according to contract type.
    /// </summary>
    [IsoId("_q25PgXhCEeu3kecHd7QKUQ")]
    [DisplayName("Contract Type")]
    [IsoXmlTag("CtrctTp")]
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    
    /// <summary>
    /// Specifies the classification according to the asset class of the contract.
    /// </summary>
    [IsoId("_q25Pg3hCEeu3kecHd7QKUQ")]
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    public ProductType4Code? AssetClass { get; init; } 
    
    /// <summary>
    /// Specifies the classification of the derivative product.
    /// </summary>
    [IsoId("_q25PhXhCEeu3kecHd7QKUQ")]
    [DisplayName("Product Classification")]
    [IsoXmlTag("PdctClssfctn")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    public IsoCFIOct2015Identifier? ProductClassification { get; init; } 
    
    /// <summary>
    /// Specifies the identification of the derivative product.
    /// </summary>
    [IsoId("_q25PiXhCEeu3kecHd7QKUQ")]
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    public SecurityIdentification22? ProductIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type.
    /// </summary>
    [IsoId("_q25Pi3hCEeu3kecHd7QKUQ")]
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public SecurityIdentification36Choice_? UnderlyingInstrument { get; init; } 
    
    /// <summary>
    /// Currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of first leg.
    /// </summary>
    [IsoId("_q25PjXhCEeu3kecHd7QKUQ")]
    [DisplayName("Notional Currency")]
    [IsoXmlTag("NtnlCcy")]
    public LegCurrency2? NotionalCurrency { get; init; } 
    
    /// <summary>
    /// Specifies the currency to be used for cash settlement of the transaction. For multicurrency transactions that do not net, specify the currency to be delivered for each leg.
    /// </summary>
    [IsoId("_q25Pj3hCEeu3kecHd7QKUQ")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public LegCurrency2? SettlementCurrency { get; init; } 
    
    /// <summary>
    /// Specifies the place where settlement of the transaction occurs as stipulated in the contract.
    /// </summary>
    [IsoId("_q25PkXhCEeu3kecHd7QKUQ")]
    [DisplayName("Place Of Settlement")]
    [IsoXmlTag("PlcOfSttlm")]
    public CountryCode? PlaceOfSettlement { get; init; } 
    
    
    #nullable disable
    
}
