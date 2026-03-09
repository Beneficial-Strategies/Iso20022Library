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
/// Specifies the elements that identify a proxy appointed to represent a party authorised to vote at a shareholders meeting.
/// </summary>
[IsoId("_T4cPNNp-Ed-ak6NoX_4Aeg_-1419937890")]
[DisplayName("Proxy")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Proxy3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proxy.
    /// </summary>
    [IsoId("_T4cPNdp-Ed-ak6NoX_4Aeg_-1419937859")]
    [DisplayName("Proxy Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrxyTp")]
    #endif
    [IsoXmlTag("PrxyTp")]
    [MinLength(1)]
    [MaxLength(2)]
    public SimpleValueList<ProxyType2Code> ProxyType { get; init; } = new SimpleValueList<ProxyType2Code>(){};
    
    /// <summary>
    /// Identifies an authorized proxy which has been assigned by the issuer of the meeting.
    /// </summary>
    [IsoId("_T4cPNtp-Ed-ak6NoX_4Aeg_149527818")]
    [DisplayName("Preassigned Proxy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrssgndPrxy")]
    #endif
    [IsoXmlTag("PrssgndPrxy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IndividualPerson16? PreassignedProxy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IndividualPerson16? PreassignedProxy { get; init; } 
    #else
    public IndividualPerson16? PreassignedProxy { get; set; } 
    #endif
    
    
    #nullable disable
    
}
