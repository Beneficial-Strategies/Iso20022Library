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
/// Currency control document entry supporting the contract registration.
/// </summary>
[IsoId("_UZhbktM-EeSDLevdaFPXHw")]
[DisplayName("Supporting Document Entry")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SupportingDocumentEntry1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SupportingDocumentEntry1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SupportingDocumentEntry1( System.String reqEntryIdentification,DocumentIdentification22 reqOriginalDocument,System.String reqDocumentType,ShipmentAttribute1 reqShipmentAttributes )
    {
        EntryIdentification = reqEntryIdentification;
        OriginalDocument = reqOriginalDocument;
        DocumentType = reqDocumentType;
        ShipmentAttributes = reqShipmentAttributes;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of the supporting document entry.
    /// </summary>
    [IsoId("_OKZKZNM_EeSDLevdaFPXHw")]
    [DisplayName("Entry Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryId")]
    #endif
    [IsoXmlTag("NtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text EntryIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String EntryIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String EntryIdentification { get; init; } 
    #else
    public System.String EntryIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the original document for which the supporting documents are provided.
    /// </summary>
    [IsoId("_U55vVNM_EeSDLevdaFPXHw")]
    [DisplayName("Original Document")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDoc")]
    #endif
    [IsoXmlTag("OrgnlDoc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentIdentification22 OriginalDocument { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentIdentification22 OriginalDocument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentIdentification22 OriginalDocument { get; init; } 
    #else
    public DocumentIdentification22 OriginalDocument { get; set; } 
    #endif
    
    /// <summary>
    /// Document type in a coded form.
    /// TBC: Data must support &quot;_&quot;.
    /// </summary>
    [IsoId("_aRX4YNNBEeSDLevdaFPXHw")]
    [DisplayName("Document Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocTp")]
    #endif
    [IsoXmlTag("DocTp")]
    [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact4AlphaNumericText DocumentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DocumentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DocumentType { get; init; } 
    #else
    public System.String DocumentType { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the supporting document entry.
    /// </summary>
    [IsoId("_iVxMoNNBEeSDLevdaFPXHw")]
    [DisplayName("Total Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmt")]
    #endif
    [IsoXmlTag("TtlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount after shipment of the supporting document entry.
    /// </summary>
    [IsoId("_qZ3l8NNBEeSDLevdaFPXHw")]
    [DisplayName("Total Amount After Shipment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtAftrShipmnt")]
    #endif
    [IsoXmlTag("TtlAmtAftrShipmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalAmountAfterShipment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalAmountAfterShipment { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalAmountAfterShipment { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the supporting document entry in the currency of the contract.
    /// </summary>
    [IsoId("_w5GTMtNBEeSDLevdaFPXHw")]
    [DisplayName("Total Amount In Contract Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtInCtrctCcy")]
    #endif
    [IsoXmlTag("TtlAmtInCtrctCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalAmountInContractCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalAmountInContractCurrency { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalAmountInContractCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount after shipment of the supporting document entry in the currency of the contract.
    /// </summary>
    [IsoId("_w5GTM9NBEeSDLevdaFPXHw")]
    [DisplayName("Total Amount After Shipment In Contract Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtAftrShipmntInCtrctCcy")]
    #endif
    [IsoXmlTag("TtlAmtAftrShipmntInCtrctCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? TotalAmountAfterShipmentInContractCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? TotalAmountAfterShipmentInContractCurrency { get; init; } 
    #else
    public ActiveCurrencyAndAmount? TotalAmountAfterShipmentInContractCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Conditions and attributes related to the shipment.
    /// </summary>
    [IsoId("_Aa6bQNNCEeSDLevdaFPXHw")]
    [DisplayName("Shipment Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShipmntAttrbts")]
    #endif
    [IsoXmlTag("ShipmntAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ShipmentAttribute1 ShipmentAttributes { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ShipmentAttribute1 ShipmentAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShipmentAttribute1 ShipmentAttributes { get; init; } 
    #else
    public ShipmentAttribute1 ShipmentAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the supporting document entry.
    /// </summary>
    [IsoId("_H-HuANNCEeSDLevdaFPXHw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax500Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Documents provided as attachments to the supporting document entry.
    /// </summary>
    [IsoId("_VCOdgdNCEeSDLevdaFPXHw")]
    [DisplayName("Attachment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Attchmnt")]
    #endif
    [IsoXmlTag("Attchmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentGeneralInformation3? Attachment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentGeneralInformation3? Attachment { get; init; } 
    #else
    public DocumentGeneralInformation3? Attachment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
