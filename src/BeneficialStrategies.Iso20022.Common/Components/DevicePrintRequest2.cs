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
/// Content of the Print Request message.
/// </summary>
[IsoId("_3nMJkQ0qEeqUVL7sB4m7NA")]
[DisplayName("Device Print Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DevicePrintRequest2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DevicePrintRequest2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DevicePrintRequest2( DocumentType7Code reqDocumentQualifier,ResponseMode1Code reqResponseMode,ActionMessage7 reqOutputContent )
    {
        DocumentQualifier = reqDocumentQualifier;
        ResponseMode = reqResponseMode;
        OutputContent = reqOutputContent;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Qualifies the type of document.
    /// </summary>
    [IsoId("_3yAScQ0qEeqUVL7sB4m7NA")]
    [DisplayName("Document Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DocQlfr")]
    #endif
    [IsoXmlTag("DocQlfr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DocumentType7Code DocumentQualifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DocumentType7Code DocumentQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DocumentType7Code DocumentQualifier { get; init; } 
    #else
    public DocumentType7Code DocumentQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Type of awaited response (none, immediate, after printing, after sound).
    /// </summary>
    [IsoId("_3yAScw0qEeqUVL7sB4m7NA")]
    [DisplayName("Response Mode")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnMd")]
    #endif
    [IsoXmlTag("RspnMd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseMode1Code ResponseMode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseMode1Code ResponseMode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseMode1Code ResponseMode { get; init; } 
    #else
    public ResponseMode1Code ResponseMode { get; set; } 
    #endif
    
    /// <summary>
    /// Flag that the print is integrated to other prints.
    /// </summary>
    [IsoId("_3yASdQ0qEeqUVL7sB4m7NA")]
    [DisplayName("Integrated Print Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntgrtdPrtFlg")]
    #endif
    [IsoXmlTag("IntgrtdPrtFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? IntegratedPrintFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? IntegratedPrintFlag { get; init; } 
    #else
    public System.String? IntegratedPrintFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Flag to require a physical signature by the Customer.
    /// </summary>
    [IsoId("_3yASdw0qEeqUVL7sB4m7NA")]
    [DisplayName("Required Signature Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqrdSgntrFlg")]
    #endif
    [IsoXmlTag("ReqrdSgntrFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? RequiredSignatureFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RequiredSignatureFlag { get; init; } 
    #else
    public System.String? RequiredSignatureFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Content of the message to print.
    /// </summary>
    [IsoId("_3yASeQ0qEeqUVL7sB4m7NA")]
    [DisplayName("Output Content")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutptCntt")]
    #endif
    [IsoXmlTag("OutptCntt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActionMessage7 OutputContent { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActionMessage7 OutputContent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage7 OutputContent { get; init; } 
    #else
    public ActionMessage7 OutputContent { get; set; } 
    #endif
    
    
    #nullable disable
    
}
