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
/// Provides additional information regarding corporate action details periods details.
/// </summary>
[IsoId("_qdhPgb5WEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Period SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPeriodSD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_qvODgb5WEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which the securities can be submitted to reorganisation deposit service at DTC (The Depository Trust Corporation). DTC &quot;first day for reorganisation deposit&quot; (start date) is the day on which security is eligible for reorganisation deposit service at DTC. DTC &quot;last day for reorganisation deposit&quot; is the last day on which securities are eligible to be submitted for reorganisation deposit service at DTC.
    /// </summary>
    [IsoId("_qvODg75WEeexmbB7KsjCwA")]
    [DisplayName("DTC Reorganisation Deposit Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCReorgDpstPrd")]
    #endif
    [IsoXmlTag("DTCReorgDpstPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period13? DTCReorganisationDepositPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period13? DTCReorganisationDepositPeriod { get; init; } 
    #else
    public Period13? DTCReorganisationDepositPeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
