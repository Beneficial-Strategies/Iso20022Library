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
/// Collection of data for that is exchanged between two or more parties in written, printed or electronic form.
/// </summary>
[IsoId("_SuAjMAEcEeCQm6a_G2yO_w_-887541899")]
[DisplayName("Invoice Header")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceHeader1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvoiceHeader1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvoiceHeader1( System.String reqIdentification,ExternalDocumentType1Code reqTypeCode,System.DateTime reqIssueDateTime )
    {
        Identification = reqIdentification;
        TypeCode = reqTypeCode;
        IssueDateTime = reqIssueDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of this invoice document.
    /// </summary>
    [IsoId("_SuAjMQEcEeCQm6a_G2yO_w_1153581036")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    [IsoId("_SuAjMgEcEeCQm6a_G2yO_w_270347749")]
    [DisplayName("Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpCd")]
    #endif
    [IsoXmlTag("TpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExternalDocumentType1Code TypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExternalDocumentType1Code TypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentType1Code TypeCode { get; init; } 
    #else
    public ExternalDocumentType1Code TypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// Name of invoice document or transaction, for example, tax invoice.
    /// </summary>
    [IsoId("_SuAjMwEcEeCQm6a_G2yO_w_1331699708")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Issue date of the document.
    /// </summary>
    [IsoId("_SuAjNAEcEeCQm6a_G2yO_w_334627355")]
    [DisplayName("Issue Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IsseDtTm")]
    #endif
    [IsoXmlTag("IsseDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime IssueDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime IssueDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime IssueDateTime { get; init; } 
    #else
    public System.DateTime IssueDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issued this invoice document.
    /// </summary>
    [IsoId("_SuAjNQEcEeCQm6a_G2yO_w_-1479749531")]
    [DisplayName("Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issr")]
    #endif
    [IsoXmlTag("Issr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeParty1? Issuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeParty1? Issuer { get; init; } 
    #else
    public TradeParty1? Issuer { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for a language used in this invoice document.
    /// </summary>
    [IsoId("_SuAjNgEcEeCQm6a_G2yO_w_156508683")]
    [DisplayName("Language Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LangCd")]
    #endif
    [IsoXmlTag("LangCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LanguageCode? LanguageCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? LanguageCode { get; init; } 
    #else
    public string? LanguageCode { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator that the document is a copy of the|original document.
    /// </summary>
    [IsoId("_SuAjNwEcEeCQm6a_G2yO_w_448466421")]
    [DisplayName("Copy Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyInd")]
    #endif
    [IsoXmlTag("CpyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CopyIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CopyIndicator { get; init; } 
    #else
    public System.String? CopyIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the function of the document.
    /// </summary>
    [IsoId("_SuAjOAEcEeCQm6a_G2yO_w_1273017488")]
    [DisplayName("Document Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocPurp")]
    #endif
    [IsoXmlTag("DocPurp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; init; } 
    #else
    public ExternalDocumentPurpose1Code? DocumentPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Note included in this invoice document.
    /// </summary>
    [IsoId("_SuAjOQEcEeCQm6a_G2yO_w_-726724604")]
    [DisplayName("Included Note")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InclNote")]
    #endif
    [IsoXmlTag("InclNote")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation6? IncludedNote { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation6? IncludedNote { get; init; } 
    #else
    public AdditionalInformation6? IncludedNote { get; set; } 
    #endif
    
    
    #nullable disable
    
}
