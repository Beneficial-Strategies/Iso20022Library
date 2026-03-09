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
/// Structured information supplied to fully identify the documents referred to in the remittance information.
/// </summary>
[IsoId("_T3sBSNp-Ed-ak6NoX_4Aeg_402190265")]
[DisplayName("Referred Document Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReferredDocumentInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the type of the referred document.
    /// </summary>
    [IsoId("_T3sBSdp-Ed-ak6NoX_4Aeg_1319309617")]
    [DisplayName("Referred Document Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfrdDocTp")]
    #endif
    [IsoXmlTag("RfrdDocTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReferredDocumentType1? ReferredDocumentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferredDocumentType1? ReferredDocumentType { get; init; } 
    #else
    public ReferredDocumentType1? ReferredDocumentType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identification number of the referred document.
    /// </summary>
    [IsoId("_T31yQNp-Ed-ak6NoX_4Aeg_402190318")]
    [DisplayName("Referred Document Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfrdDocNb")]
    #endif
    [IsoXmlTag("RfrdDocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReferredDocumentNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReferredDocumentNumber { get; init; } 
    #else
    public System.String? ReferredDocumentNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
