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
/// Specifies target and actual dates dates related to account opening and closing.
/// </summary>
[IsoId("_UkPlQ9p-Ed-ak6NoX_4Aeg_1731275671")]
[DisplayName("Account Contract")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountContract3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the account and related basic services are expected to be operational for the account owner.
    /// </summary>
    [IsoId("_UkPlRNp-Ed-ak6NoX_4Aeg_1617436605")]
    [DisplayName("Target Go Live Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrgtGoLiveDt")]
    #endif
    [IsoXmlTag("TrgtGoLiveDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TargetGoLiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TargetGoLiveDate { get; init; } 
    #else
    public System.DateOnly? TargetGoLiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the account and related services are expected to cease to be operational for the account owner.
    /// </summary>
    [IsoId("_UkPlRdp-Ed-ak6NoX_4Aeg_912321990")]
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
    /// Date on which the account and related basic services are effectively operational for the account owner.
    /// </summary>
    [IsoId("_UkPlRtp-Ed-ak6NoX_4Aeg_-1950335857")]
    [DisplayName("Go Live Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GoLiveDt")]
    #endif
    [IsoXmlTag("GoLiveDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? GoLiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? GoLiveDate { get; init; } 
    #else
    public System.DateOnly? GoLiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the account and related services cease effectively to be operational for the account owner.
    /// </summary>
    [IsoId("_UkPlR9p-Ed-ak6NoX_4Aeg_-1886056251")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ClosingDate { get; init; } 
    #else
    public System.DateOnly? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicator that the account opening/maintenance/closing process needs to be treated urgently, that is, sooner than the terms established by the service level agreed between the account holder customer and the account servicing institution.
    /// </summary>
    [IsoId("_UkZWQNp-Ed-ak6NoX_4Aeg_1233720020")]
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
    [IsoId("_UkZWQdp-Ed-ak6NoX_4Aeg_-1501580453")]
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
