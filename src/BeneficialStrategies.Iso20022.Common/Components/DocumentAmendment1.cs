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
/// Indicates whether the supporting document is amending an original document or not, and the reference of the original supporting document, when applicable.
/// </summary>
[IsoId("_3IeEUNLlEeSDLevdaFPXHw")]
[DisplayName("Document Amendment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DocumentAmendment1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DocumentAmendment1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DocumentAmendment1( System.UInt64 reqCorrectionIdentification )
    {
        CorrectionIdentification = reqCorrectionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the correction sequence number used to identify the amendment.
    /// </summary>
    [IsoId("_7aD1UNLlEeSDLevdaFPXHw")]
    [DisplayName("Correction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrctnId")]
    #endif
    [IsoXmlTag("CrrctnId")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber CorrectionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 CorrectionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 CorrectionIdentification { get; init; } 
    #else
    public System.UInt64 CorrectionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the original document being amended.
    /// </summary>
    [IsoId("__vOewNLlEeSDLevdaFPXHw")]
    [DisplayName("Original Document Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlDocId")]
    #endif
    [IsoXmlTag("OrgnlDocId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalDocumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalDocumentIdentification { get; init; } 
    #else
    public System.String? OriginalDocumentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
