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
/// Identification of the product through ISIN.
/// </summary>
[IsoId("_ZSH2YJNkEeytjZlcgApf6A")]
[DisplayName("ISIN Query Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ISINQueryCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
    /// </summary>
    [IsoId("_kIBo8JNkEeytjZlcgApf6A")]
    [DisplayName("Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Idr")]
    #endif
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISINOct2015Identifier? Identifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Identifier { get; init; } 
    #else
    public System.String? Identifier { get; set; } 
    #endif
    
    /// <summary>
    /// Field can be queried for not reported value.
    /// </summary>
    [IsoId("_2ud_oJNkEeytjZlcgApf6A")]
    [DisplayName("Not Reported")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NotRptd")]
    #endif
    [IsoXmlTag("NotRptd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotReported1Code? NotReported { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotReported1Code? NotReported { get; init; } 
    #else
    public NotReported1Code? NotReported { get; set; } 
    #endif
    
    
    #nullable disable
    
}
