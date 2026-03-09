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
/// Specifies target dates dates related to account opening and closing.
/// </summary>
[IsoId("_UkGbYdp-Ed-ak6NoX_4Aeg_197946061")]
[DisplayName("Account Contract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountContract4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the account and related services are expected to cease to be operational for the account owner.
    /// </summary>
    [IsoId("_UkPlQNp-Ed-ak6NoX_4Aeg_-621007620")]
    [DisplayName("Target Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtClsgDt")]
    #endif
    [IsoXmlTag("TrgtClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TargetClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TargetClosingDate { get; init; } 
    #else
    public System.DateOnly? TargetClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator that the account opening/maintenance/closing process needs to be treated urgently, that is, sooner than the terms established by the service level agreed between the account holder customer and the account servicing institution.
    /// </summary>
    [IsoId("_UkPlQdp-Ed-ak6NoX_4Aeg_-1796198645")]
    [DisplayName("Urgency Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UrgcyFlg")]
    #endif
    [IsoXmlTag("UrgcyFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? UrgencyFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UrgencyFlag { get; init; } 
    #else
    public System.String? UrgencyFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates removal of the account. After removal, an account will not appear anymore in reports.
    /// </summary>
    [IsoId("_UkPlQtp-Ed-ak6NoX_4Aeg_-1964414832")]
    [DisplayName("Removal Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmvlInd")]
    #endif
    [IsoXmlTag("RmvlInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RemovalIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RemovalIndicator { get; init; } 
    #else
    public System.String? RemovalIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
