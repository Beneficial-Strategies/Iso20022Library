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
/// Describes the related items or attachments (such as message types and number of messages types) within the file.
/// </summary>
[IsoId("_jLluVe5NEeCisYr99QEiWA_942484578")]
[DisplayName("Manifest Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ManifestDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ManifestDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ManifestDetails1( System.String reqDocumentType,System.UInt64 reqNumberOfDocuments )
    {
        DocumentType = reqDocumentType;
        NumberOfDocuments = reqNumberOfDocuments;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of items contained in the document set. An initial list of values can be found in the ISO20022 message type catalogue such as admi, camt, pacs, sese, semt etc. ISO messages.
    /// </summary>
    [IsoId("_jLvfUO5NEeCisYr99QEiWA_-354097622")]
    [DisplayName("Document Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocTp")]
    #endif
    [IsoXmlTag("DocTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text DocumentType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DocumentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DocumentType { get; init; } 
    #else
    public System.String DocumentType { get; set; } 
    #endif
    
    /// <summary>
    /// Gives the number of instances (messages) for each declared type.
    /// </summary>
    [IsoId("_jLvfUe5NEeCisYr99QEiWA_-683335600")]
    [DisplayName("Number Of Documents")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDocs")]
    #endif
    [IsoXmlTag("NbOfDocs")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber NumberOfDocuments { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 NumberOfDocuments { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 NumberOfDocuments { get; init; } 
    #else
    public System.UInt64 NumberOfDocuments { get; set; } 
    #endif
    
    
    #nullable disable
    
}
