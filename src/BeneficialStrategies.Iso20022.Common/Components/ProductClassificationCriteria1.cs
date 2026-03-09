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
/// Criteria regarding product classification.
/// </summary>
[IsoId("_hfq2Ux3YEeWNp95x0ENf8w")]
[DisplayName("Product Classification Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ProductClassificationCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifier is an ISO 10962 Classification of Financial Instrument (CFI).
    /// </summary>
    [IsoId("_hfq2VR3YEeWNp95x0ENf8w")]
    [DisplayName("Classification Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnFinInstrm")]
    #endif
    [IsoXmlTag("ClssfctnFinInstrm")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoCFIOct2015Identifier? ClassificationFinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClassificationFinancialInstrument { get; init; } 
    #else
    public System.String? ClassificationFinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_hfq2VB3YEeWNp95x0ENf8w")]
    [DisplayName("Unique Product Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqPdctIdr")]
    #endif
    [IsoXmlTag("UnqPdctIdr")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? UniqueProductIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UniqueProductIdentifier { get; init; } 
    #else
    public System.String? UniqueProductIdentifier { get; set; } 
    #endif
    
    
    #nullable disable
    
}
