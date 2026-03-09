// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to contract attributes.
/// </summary>
[IsoId("_qmrCNXhCEeu3kecHd7QKUQ")]
[DisplayName("Contract Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractType10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Classification of information according to contract type.
    /// </summary>
    [IsoId("_q25PgXhCEeu3kecHd7QKUQ")]
    [DisplayName("Contract Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctTp")]
    #endif
    [IsoXmlTag("CtrctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentContractType2Code? ContractType { get; init; } 
    #else
    public FinancialInstrumentContractType2Code? ContractType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the classification according to the asset class of the contract.
    /// </summary>
    [IsoId("_q25Pg3hCEeu3kecHd7QKUQ")]
    [DisplayName("Asset Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstClss")]
    #endif
    [IsoXmlTag("AsstClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProductType4Code? AssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProductType4Code? AssetClass { get; init; } 
    #else
    public ProductType4Code? AssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the classification of the derivative product.
    /// </summary>
    [IsoId("_q25PhXhCEeu3kecHd7QKUQ")]
    [DisplayName("Product Classification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctClssfctn")]
    #endif
    [IsoXmlTag("PdctClssfctn")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCFIOct2015Identifier? ProductClassification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductClassification { get; init; } 
    #else
    public System.String? ProductClassification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the identification of the derivative product.
    /// </summary>
    [IsoId("_q25PiXhCEeu3kecHd7QKUQ")]
    [DisplayName("Product Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctId")]
    #endif
    [IsoXmlTag("PdctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification22? ProductIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification22? ProductIdentification { get; init; } 
    #else
    public SecurityIdentification22? ProductIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification to identify the direct underlying instrument based on its type.
    /// </summary>
    [IsoId("_q25Pi3hCEeu3kecHd7QKUQ")]
    [DisplayName("Underlying Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygInstrm")]
    #endif
    [IsoXmlTag("UndrlygInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification36Choice_? UnderlyingInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification36Choice_? UnderlyingInstrument { get; init; } 
    #else
    public SecurityIdentification36Choice_? UnderlyingInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Currency of the notional amount. 
    /// Usage: In the case of an interest rate or currency derivative contract, this will be the notional currency of first leg.
    /// </summary>
    [IsoId("_q25PjXhCEeu3kecHd7QKUQ")]
    [DisplayName("Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlCcy")]
    #endif
    [IsoXmlTag("NtnlCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegCurrency2? NotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegCurrency2? NotionalCurrency { get; init; } 
    #else
    public LegCurrency2? NotionalCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the currency to be used for cash settlement of the transaction. For multicurrency transactions that do not net, specify the currency to be delivered for each leg.
    /// </summary>
    [IsoId("_q25Pj3hCEeu3kecHd7QKUQ")]
    [DisplayName("Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmCcy")]
    #endif
    [IsoXmlTag("SttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegCurrency2? SettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegCurrency2? SettlementCurrency { get; init; } 
    #else
    public LegCurrency2? SettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the place where settlement of the transaction occurs as stipulated in the contract.
    /// </summary>
    [IsoId("_q25PkXhCEeu3kecHd7QKUQ")]
    [DisplayName("Place Of Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfSttlm")]
    #endif
    [IsoXmlTag("PlcOfSttlm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? PlaceOfSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? PlaceOfSettlement { get; init; } 
    #else
    public string? PlaceOfSettlement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
