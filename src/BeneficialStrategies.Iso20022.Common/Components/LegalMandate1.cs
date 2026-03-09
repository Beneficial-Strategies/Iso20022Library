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
/// Provides details on the legal basis of the request.
/// </summary>
[IsoId("_bhYnwEJ4EeGuetKibuqsKw")]
[DisplayName("Legal Mandate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LegalMandate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LegalMandate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LegalMandate1( System.String reqParagraph )
    {
        Paragraph = reqParagraph;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the legal mandate paragraph in law which gives power to the authority&apos;s request.
    /// </summary>
    [IsoId("_ZiG61UJ8EeGuetKibuqsKw")]
    [DisplayName("Paragraph")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prgrph")]
    #endif
    [IsoXmlTag("Prgrph")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Paragraph { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Paragraph { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Paragraph { get; init; } 
    #else
    public System.String Paragraph { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies any additional information describing how or why the paragraph of law should be applied.
    /// </summary>
    [IsoId("_buerxUJ8EeGuetKibuqsKw")]
    [DisplayName("Disclaimer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dsclmr")]
    #endif
    [IsoXmlTag("Dsclmr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Disclaimer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Disclaimer { get; init; } 
    #else
    public System.String? Disclaimer { get; set; } 
    #endif
    
    
    #nullable disable
    
}
