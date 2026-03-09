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
/// Contractual details related to the agreement between parties.
/// </summary>
[IsoId("_S_vMYwEcEeCQm6a_G2yO_w_490060980")]
[DisplayName("Trade Agreement")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeAgreement6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeAgreement6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeAgreement6( TradeParty1 reqBuyer,TradeParty1 reqSeller )
    {
        Buyer = reqBuyer;
        Seller = reqSeller;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Party that is specified as the buyer for this trade agreement.
    /// </summary>
    [IsoId("_S_vMZAEcEeCQm6a_G2yO_w_-420004793")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeParty1 Buyer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeParty1 Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1 Buyer { get; init; } 
    #else
    public TradeParty1 Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is specified as the seller for this trade agreement.
    /// </summary>
    [IsoId("_S_vMZQEcEeCQm6a_G2yO_w_-2137864759")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeParty1 Seller { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeParty1 Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1 Seller { get; init; } 
    #else
    public TradeParty1 Seller { get; set; } 
    #endif
    
    /// <summary>
    /// Quotation document referenced from this trade agreement.
    /// </summary>
    [IsoId("_S_vMZgEcEeCQm6a_G2yO_w_1723651688")]
    [DisplayName("Quotation Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtnDocId")]
    #endif
    [IsoXmlTag("QtnDocId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? QuotationDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? QuotationDocumentIdentification { get; init; } 
    #else
    public DocumentIdentification22? QuotationDocumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contract document referenced from this trade agreement.
    /// </summary>
    [IsoId("_S_vMZwEcEeCQm6a_G2yO_w_-365569461")]
    [DisplayName("Contract Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctDocId")]
    #endif
    [IsoXmlTag("CtrctDocId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? ContractDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? ContractDocumentIdentification { get; init; } 
    #else
    public DocumentIdentification22? ContractDocumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Buyer order document referenced from this trade agreement.
    /// </summary>
    [IsoId("_S_vMaAEcEeCQm6a_G2yO_w_154969253")]
    [DisplayName("Buyer Order Identification Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuyrOrdrIdDoc")]
    #endif
    [IsoXmlTag("BuyrOrdrIdDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentIdentification22? BuyerOrderIdentificationDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22? BuyerOrderIdentificationDocument { get; init; } 
    #else
    public DocumentIdentification22? BuyerOrderIdentificationDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Additional document referenced from this trade agreement.
    /// </summary>
    [IsoId("_S_vMaQEcEeCQm6a_G2yO_w_-457727477")]
    [DisplayName("Additional Reference Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRefDoc")]
    #endif
    [IsoXmlTag("AddtlRefDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentGeneralInformation2? AdditionalReferenceDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation2? AdditionalReferenceDocument { get; init; } 
    #else
    public DocumentGeneralInformation2? AdditionalReferenceDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the applicable Incoterm and associated location.
    /// </summary>
    [IsoId("_S_vMagEcEeCQm6a_G2yO_w_-2027263920")]
    [DisplayName("Incoterms")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incotrms")]
    #endif
    [IsoXmlTag("Incotrms")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Incoterms3? Incoterms { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Incoterms3? Incoterms { get; init; } 
    #else
    public Incoterms3? Incoterms { get; set; } 
    #endif
    
    
    #nullable disable
    
}
