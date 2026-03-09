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
/// Contains additional charges related to or during transit (e.g., baggage fee, in-flight purchase). These are separate from the original ticket purchase.
/// </summary>
[IsoId("_2sX-4ZJQEeuuktRxxQZoNQ")]
[DisplayName("Ancillary Purchase")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AncillaryPurchase2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains the form number assigned by the carrier for the transaction. 
    /// </summary>
    [IsoId("_2yvFkZJQEeuuktRxxQZoNQ")]
    [DisplayName("Ancillary Document Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AncllryDocNb")]
    #endif
    [IsoXmlTag("AncllryDocNb")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15Text? AncillaryDocumentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AncillaryDocumentNumber { get; init; } 
    #else
    public System.String? AncillaryDocumentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Document number of related transport details.
    /// </summary>
    [IsoId("_2yvFk5JQEeuuktRxxQZoNQ")]
    [DisplayName("Related Document Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdDocNb")]
    #endif
    [IsoXmlTag("RltdDocNb")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15Text? RelatedDocumentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedDocumentNumber { get; init; } 
    #else
    public System.String? RelatedDocumentNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Contains an ancillary category code for the primary type of service that has been provided. 
    /// </summary>
    [IsoId("_2yvFlZJQEeuuktRxxQZoNQ")]
    [DisplayName("Service Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcCtgyCd")]
    #endif
    [IsoXmlTag("SvcCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? ServiceCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceCategoryCode { get; init; } 
    #else
    public System.String? ServiceCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Contains ancillary service sub category code.
    /// </summary>
    [IsoId("_2yvFl5JQEeuuktRxxQZoNQ")]
    [DisplayName("Service Sub Category Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcSubCtgyCd")]
    #endif
    [IsoXmlTag("SvcSubCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? ServiceSubCategoryCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceSubCategoryCode { get; init; } 
    #else
    public System.String? ServiceSubCategoryCode { get; set; } 
    #endif
    
    /// <summary>
    /// Proprietary service type code assigned by the service provider.
    /// </summary>
    [IsoId("_2yvFmZJQEeuuktRxxQZoNQ")]
    [DisplayName("Service Provider Service Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcPrvdrSvcTp")]
    #endif
    [IsoXmlTag("SvcPrvdrSvcTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceProviderServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceProviderServiceType { get; init; } 
    #else
    public System.String? ServiceProviderServiceType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates reason for the credit to the cardholder.  Includes: ancillary purchase cancelled, passenger transport ticket and related ancillary purchase cancelled, etc.
    /// </summary>
    [IsoId("_2yvFm5JQEeuuktRxxQZoNQ")]
    [DisplayName("Credit Reason Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtRsnCd")]
    #endif
    [IsoXmlTag("CdtRsnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CreditReasonCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CreditReasonCode { get; init; } 
    #else
    public System.String? CreditReasonCode { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_2yvFnZJQEeuuktRxxQZoNQ")]
    [DisplayName("Summary Commodity Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SummryCmmdtyId")]
    #endif
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SummaryCommodityIdentification { get; init; } 
    #else
    public System.String? SummaryCommodityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Ancillary purchase amount.
    /// </summary>
    [IsoId("_2yvFn5JQEeuuktRxxQZoNQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount16? Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount16? Amount { get; init; } 
    #else
    public Amount16? Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Subfield contains the ancillary fee amount.
    /// </summary>
    [IsoId("_2yvFoZJQEeuuktRxxQZoNQ")]
    [DisplayName("Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fee")]
    #endif
    [IsoXmlTag("Fee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? Fee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? Fee { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? Fee { get; set; } 
    #endif
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_2yvFo5JQEeuuktRxxQZoNQ")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax39? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax39? Tax { get; init; } 
    #else
    public Tax39? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Additional user-defined data pertaining to the transportation.
    /// </summary>
    [IsoId("_2yvFpZJQEeuuktRxxQZoNQ")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalData { get; init; } 
    #else
    public System.String? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
