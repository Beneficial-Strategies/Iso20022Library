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
/// Location information.
/// </summary>
[IsoId("_-Gm5aHltEeG7BsjMvd1mEw_1246431564")]
[DisplayName("Location")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Location1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Country of jurisdiction.
    /// </summary>
    [IsoId("_-GwDUHltEeG7BsjMvd1mEw_-533557511")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Country { get; init; } 
    #else
    public string? Country { get; set; } 
    #endif
    
    /// <summary>
    /// Codified representation of the jurisdiction as published in ISO 3166-2.
    /// </summary>
    [IsoId("_-GwDUXltEeG7BsjMvd1mEw_-188715898")]
    [DisplayName("Country Sub Division")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrySubDvsn")]
    #endif
    [IsoXmlTag("CtrySubDvsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountrySubdivision1Choice_? CountrySubDivision { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CountrySubdivision1Choice_? CountrySubDivision { get; init; } 
    #else
    public CountrySubdivision1Choice_? CountrySubDivision { get; set; } 
    #endif
    
    /// <summary>
    /// Name of jurisdiction, for example, Frankfurt.
    /// </summary>
    [IsoId("_-GwDUnltEeG7BsjMvd1mEw_-1526701842")]
    [DisplayName("Text")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Txt")]
    #endif
    [IsoXmlTag("Txt")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> Text { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
