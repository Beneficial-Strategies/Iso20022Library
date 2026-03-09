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
/// Information about a document.
/// </summary>
[IsoId("_96YbSXltEeG7BsjMvd1mEw_-172031402")]
[DisplayName("Document")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Document10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Document10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Document10( UndertakingDocumentType2Choice_ reqDocumentType )
    {
        DocumentType = reqDocumentType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of document.
    /// </summary>
    [IsoId("_96YbSnltEeG7BsjMvd1mEw_-1696622720")]
    [DisplayName("Document Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocTp")]
    #endif
    [IsoXmlTag("DocTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingDocumentType2Choice_ DocumentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingDocumentType2Choice_ DocumentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingDocumentType2Choice_ DocumentType { get; init; } 
    #else
    public UndertakingDocumentType2Choice_ DocumentType { get; set; } 
    #endif
    
    /// <summary>
    /// Channel through which the document should be presented.
    /// </summary>
    [IsoId("_96iMQHltEeG7BsjMvd1mEw_1601272223")]
    [DisplayName("Presentation Channel")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntnChanl")]
    #endif
    [IsoXmlTag("PresntnChanl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Channel1Choice_? PresentationChannel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Channel1Choice_? PresentationChannel { get; init; } 
    #else
    public Channel1Choice_? PresentationChannel { get; set; } 
    #endif
    
    /// <summary>
    /// Format of the document.
    /// </summary>
    [IsoId("_96iMQXltEeG7BsjMvd1mEw_681238571")]
    [DisplayName("Document Format")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocFrmt")]
    #endif
    [IsoXmlTag("DocFrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DocumentFormat1Choice_? DocumentFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentFormat1Choice_? DocumentFormat { get; init; } 
    #else
    public DocumentFormat1Choice_? DocumentFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the document may be a copy of the original document.
    /// </summary>
    [IsoId("_96iMQnltEeG7BsjMvd1mEw_1954061068")]
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
    /// Indication whether the document must be signed.
    /// </summary>
    [IsoId("_96iMQ3ltEeG7BsjMvd1mEw_1042190213")]
    [DisplayName("Signed Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SgndInd")]
    #endif
    [IsoXmlTag("SgndInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SignedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SignedIndicator { get; init; } 
    #else
    public System.String? SignedIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
