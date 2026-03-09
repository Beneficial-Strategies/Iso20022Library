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
/// Identifies a document by a unique identification and a version together with the submitter of the document.|Also specifies the type of document and an index for easy referencing.
/// </summary>
[IsoId("_RaMEFtp-Ed-ak6NoX_4Aeg_-793210991")]
[DisplayName("Document Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentIdentification10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentIdentification10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentIdentification10( System.String reqIdentification,System.UInt64 reqVersion,DataSetType2Code reqType,BICIdentification1 reqSubmitter,System.String reqDocumentIndex )
    {
        Identification = reqIdentification;
        Version = reqVersion;
        Type = reqType;
        Submitter = reqSubmitter;
        DocumentIndex = reqDocumentIndex;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a set of data.
    /// </summary>
    [IsoId("_RaMEF9p-Ed-ak6NoX_4Aeg_-792290935")]
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
    /// Unambiguous identification of the version of a set of data. Example: Version 1.
    /// </summary>
    [IsoId("_RaMEGNp-Ed-ak6NoX_4Aeg_-792290904")]
    [DisplayName("Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vrsn")]
    #endif
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber Version { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Version { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Version { get; init; } 
    #else
    public System.UInt64 Version { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of data set.
    /// </summary>
    [IsoId("_RaMEGdp-Ed-ak6NoX_4Aeg_-792290843")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DataSetType2Code Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DataSetType2Code Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetType2Code Type { get; init; } 
    #else
    public DataSetType2Code Type { get; set; } 
    #endif
    
    /// <summary>
    /// Uniquely identifies the financial institution which has submitted the set of data by using a BIC.
    /// </summary>
    [IsoId("_RaVOANp-Ed-ak6NoX_4Aeg_-792290750")]
    [DisplayName("Submitter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Submitr")]
    #endif
    [IsoXmlTag("Submitr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BICIdentification1 Submitter { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BICIdentification1 Submitter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BICIdentification1 Submitter { get; init; } 
    #else
    public BICIdentification1 Submitter { get; set; } 
    #endif
    
    /// <summary>
    /// Index assigned to the document, to allow easy referencing.
    /// </summary>
    [IsoId("_RaVOAdp-Ed-ak6NoX_4Aeg_-792290812")]
    [DisplayName("Document Index")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocIndx")]
    #endif
    [IsoXmlTag("DocIndx")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax3NumericText DocumentIndex { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String DocumentIndex { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String DocumentIndex { get; init; } 
    #else
    public System.String DocumentIndex { get; set; } 
    #endif
    
    
    #nullable disable
    
}
