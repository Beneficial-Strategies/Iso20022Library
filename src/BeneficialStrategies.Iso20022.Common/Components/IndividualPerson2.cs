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
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an &apos;artificial person&apos;).
/// </summary>
[IsoId("_VAHB6tp-Ed-ak6NoX_4Aeg_-521052296")]
[DisplayName("Individual Person")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record IndividualPerson2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_VAQy4Np-Ed-ak6NoX_4Aeg_-432395197")]
    [DisplayName("Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nm")]
    #endif
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_VAQy4dp-Ed-ak6NoX_4Aeg_-274470659")]
    [DisplayName("Birth Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BirthDt")]
    #endif
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? BirthDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? BirthDate { get; init; } 
    #else
    public System.DateOnly? BirthDate { get; set; } 
    #endif
    
    /// <summary>
    /// Country and residential status of an individual, for example, non-pernament resident.
    /// </summary>
    [IsoId("_VAQy4tp-Ed-ak6NoX_4Aeg_-45438130")]
    [DisplayName("Country And Residential Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtryAndResdtlSts")]
    #endif
    [IsoXmlTag("CtryAndResdtlSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; init; } 
    #else
    public CountryAndResidentialStatusType1? CountryAndResidentialStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Alternative identification, for example, national registration identification number, passport number, or an account number used to further identify the beneficial owner, for example, a Central Provident Fund (CFP) account as required for Singapore.
    /// </summary>
    [IsoId("_VAQy49p-Ed-ak6NoX_4Aeg_1401717780")]
    [DisplayName("Other Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrId")]
    #endif
    [IsoXmlTag("OthrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification8? OtherIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification8? OtherIdentification { get; init; } 
    #else
    public GenericIdentification8? OtherIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
