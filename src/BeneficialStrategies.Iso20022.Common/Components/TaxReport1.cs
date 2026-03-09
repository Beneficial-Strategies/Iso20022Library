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
/// Contains all needed party details for tax agency (sender of the TaxReport) and tax authority (receiver of the TaxReport) and the details of the reported sales transaction and calculated tax related that specific business transaction.
/// </summary>
[IsoId("_oAv2w1m4EeOQYsoJizpkVw")]
[DisplayName("Tax Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TaxReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TaxReport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TaxReport1( GroupHeader69 reqTaxReportHeader,PartyIdentification72 reqSeller,TradeSettlement2 reqTradeSettlement )
    {
        TaxReportHeader = reqTaxReportHeader;
        Seller = reqSeller;
        TradeSettlement = reqTradeSettlement;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Basic report details.
    /// </summary>
    [IsoId("_trTl01m4EeOQYsoJizpkVw")]
    [DisplayName("Tax Report Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRptHdr")]
    #endif
    [IsoXmlTag("TaxRptHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader69 TaxReportHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader69 TaxReportHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader69 TaxReportHeader { get; init; } 
    #else
    public GroupHeader69 TaxReportHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Tax reporting agent, for example seller.
    /// Responsible to issue tax reporting to tax authority.
    /// </summary>
    [IsoId("_3-XxEFm4EeOQYsoJizpkVw")]
    [DisplayName("Seller")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sellr")]
    #endif
    [IsoXmlTag("Sellr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification72 Seller { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification72 Seller { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification72 Seller { get; init; } 
    #else
    public PartyIdentification72 Seller { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the buyer of goods/service reported in this message.
    /// </summary>
    [IsoId("_7BHwYFm4EeOQYsoJizpkVw")]
    [DisplayName("Buyer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Buyr")]
    #endif
    [IsoXmlTag("Buyr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification72? Buyer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification72? Buyer { get; init; } 
    #else
    public PartyIdentification72? Buyer { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the details of the business transactions reported in the message.
    /// </summary>
    [IsoId("_LaSXMFm5EeOQYsoJizpkVw")]
    [DisplayName("Trade Settlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradSttlm")]
    #endif
    [IsoXmlTag("TradSttlm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeSettlement2 TradeSettlement { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeSettlement2 TradeSettlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeSettlement2 TradeSettlement { get; init; } 
    #else
    public TradeSettlement2 TradeSettlement { get; set; } 
    #endif
    
    /// <summary>
    /// Reserved for parties that may be required by a specific tax authority.
    /// </summary>
    [IsoId("_ErRwwJD1EeSZY4BVJy2t3A")]
    [DisplayName("Other Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPty")]
    #endif
    [IsoXmlTag("OthrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification72? OtherParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification72? OtherParty { get; init; } 
    #else
    public PartyIdentification72? OtherParty { get; set; } 
    #endif
    
    /// <summary>
    /// Additional reference like site key or identifier.
    /// </summary>
    [IsoId("_zSTYoFm6EeOQYsoJizpkVw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation1? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation1? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation1? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Structure to deliver link to external attachment or deliver base64-coded attachment inside message.
    /// </summary>
    [IsoId("_5Jz-kFm6EeOQYsoJizpkVw")]
    [DisplayName("Additional Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRef")]
    #endif
    [IsoXmlTag("AddtlRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentGeneralInformation2? AdditionalReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation2? AdditionalReference { get; init; } 
    #else
    public DocumentGeneralInformation2? AdditionalReference { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_nHYhsEjvEeaOe8w0NJ11wQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
