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
[IsoId("_Zj1khQ1HEeqV4s5SpzR1dQ")]
[DisplayName("Contract Type")]
public partial record ContractType8
{
    #nullable enable
    
    /// <summary>
    /// Classification of information according to contract type.
    /// </summary>
    [IsoId("_Zko1wQ1HEeqV4s5SpzR1dQ")]
    [DisplayName("Contract Type")]
    [IsoXmlTag("CtrctTp")]
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    
    /// <summary>
    /// Specifies the classification according to the asset class of the contract.
    /// </summary>
    [IsoId("_Zko1ww1HEeqV4s5SpzR1dQ")]
    [DisplayName("Asset Class")]
    [IsoXmlTag("AsstClss")]
    public ProductType4Code? AssetClass { get; init; } 
    
    /// <summary>
    /// Specifies the classification of the derivative product.
    /// </summary>
    [IsoId("_Zkpc0Q1HEeqV4s5SpzR1dQ")]
    [DisplayName("Product Classification")]
    [IsoXmlTag("PdctClssfctn")]
    public ProductClassification1Choice_? ProductClassification { get; init; } 
    
    /// <summary>
    /// Specifies the identification of the derivative product.
    /// </summary>
    [IsoId("_Zkpc1Q1HEeqV4s5SpzR1dQ")]
    [DisplayName("Product Identification")]
    [IsoXmlTag("PdctId")]
    public SecurityIdentification18Choice_? ProductIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type.
    /// </summary>
    [IsoId("_Zkpc1w1HEeqV4s5SpzR1dQ")]
    [DisplayName("Underlying Instrument")]
    [IsoXmlTag("UndrlygInstrm")]
    public SecurityIdentification34Choice_? UnderlyingInstrument { get; init; } 
    
    /// <summary>
    /// Currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of first leg.
    /// </summary>
    [IsoId("_Zkpc2Q1HEeqV4s5SpzR1dQ")]
    [DisplayName("Notional Currency First Leg")]
    [IsoXmlTag("NtnlCcyFrstLeg")]
    public ActiveCurrencyCode? NotionalCurrencyFirstLeg { get; init; } 
    
    /// <summary>
    /// Other currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of the second leg.
    /// </summary>
    [IsoId("_Zkpc2w1HEeqV4s5SpzR1dQ")]
    [DisplayName("Notional Currency Second Leg")]
    [IsoXmlTag("NtnlCcyScndLeg")]
    public ActiveCurrencyCode? NotionalCurrencySecondLeg { get; init; } 
    
    /// <summary>
    /// Specifies the currency to be delivered.
    /// </summary>
    [IsoId("_Zkpc3Q1HEeqV4s5SpzR1dQ")]
    [DisplayName("Deliverable Currency")]
    [IsoXmlTag("DlvrblCcy")]
    public ActiveCurrencyCode? DeliverableCurrency { get; init; } 
    
    
    #nullable disable
    
}
