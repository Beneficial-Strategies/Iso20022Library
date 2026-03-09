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
/// Identifies the security instrument by its name and typical characteristics.
/// </summary>
[IsoId("_hepx8ZiqEe2f7NHvXATP5g")]
[DisplayName("Security Instrument Description")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecurityInstrumentDescription23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecurityInstrumentDescription23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecurityInstrumentDescription23( System.String reqFullName,System.String reqClassificationType )
    {
        FullName = reqFullName;
        ClassificationType = reqClassificationType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the financial instrument using an ISIN.
    /// </summary>
    [IsoId("_hhBJcZiqEe2f7NHvXATP5g")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISINOct2015Identifier? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identification { get; init; } 
    #else
    public System.String? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a security by proprietary or domestic identification scheme.
    /// </summary>
    [IsoId("_k7vj4JiqEe2f7NHvXATP5g")]
    [DisplayName("Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrId")]
    #endif
    [IsoXmlTag("OthrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherIdentification1? OtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherIdentification1? OtherIdentification { get; init; } 
    #else
    public OtherIdentification1? OtherIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Full name or description of the financial instrument.
    /// </summary>
    [IsoId("_hhBJc5iqEe2f7NHvXATP5g")]
    [DisplayName("Full Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FullNm")]
    #endif
    [IsoXmlTag("FullNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text FullName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FullName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FullName { get; init; } 
    #else
    public System.String FullName { get; set; } 
    #endif
    
    /// <summary>
    /// Classification type of the financial instrument, as per the ISO classification of financial instrument (CFI) codification, that is common share with voting rights, fully paid, or registered.
    /// </summary>
    [IsoId("_hhBJdZiqEe2f7NHvXATP5g")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoCFIOct2015Identifier ClassificationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClassificationType { get; init; } 
    #else
    public System.String ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the notional is denominated.
    /// </summary>
    [IsoId("_hhBwgZiqEe2f7NHvXATP5g")]
    [DisplayName("Notional Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlCcy")]
    #endif
    [IsoXmlTag("NtnlCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? NotionalCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NotionalCurrency { get; init; } 
    #else
    public string? NotionalCurrency { get; set; } 
    #endif
    
    
    #nullable disable
    
}
