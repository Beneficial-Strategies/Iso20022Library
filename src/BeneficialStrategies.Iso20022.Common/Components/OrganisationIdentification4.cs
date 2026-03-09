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
/// Unique and unambiguous way to identify an organisation.
/// </summary>
[IsoId("_QRBclNp-Ed-ak6NoX_4Aeg_-1009093521")]
[DisplayName("Organisation Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OrganisationIdentification4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Code allocated to a financial institution or non financial institution by the ISO 9362 Registration Authority as described in ISO 9362 &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
    /// </summary>
    [IsoId("_QRBcldp-Ed-ak6NoX_4Aeg_-1009093512")]
    [DisplayName("BIC Or BEI")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BICOrBEI")]
    #endif
    [IsoXmlTag("BICOrBEI")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? BICOrBEI { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BICOrBEI { get; init; } 
    #else
    public System.String? BICOrBEI { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of an organisation, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_QRBcltp-Ed-ak6NoX_4Aeg_-1009092905")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericOrganisationIdentification1? Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericOrganisationIdentification1? Other { get; init; } 
    #else
    public GenericOrganisationIdentification1? Other { get; set; } 
    #endif
    
    
    #nullable disable
    
}
