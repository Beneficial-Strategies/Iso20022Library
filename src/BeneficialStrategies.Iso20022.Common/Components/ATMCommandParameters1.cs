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
/// Parameters to be used to update the configuration or the status security device.
/// </summary>
[IsoId("_CxFZMItIEeSxlKlAGYErFg")]
[DisplayName("ATM Command Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMCommandParameters1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Serial number of the device.
    /// </summary>
    [IsoId("_ObyFwItIEeSxlKlAGYErFg")]
    [DisplayName("Serial Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrlNb")]
    #endif
    [IsoXmlTag("SrlNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SerialNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SerialNumber { get; init; } 
    #else
    public System.String? SerialNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Update of the security configuration to apply on the security module of the ATM.
    /// </summary>
    [IsoId("_Sp8IQItIEeSxlKlAGYErFg")]
    [DisplayName("Required Configuration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqrdCfgtn")]
    #endif
    [IsoXmlTag("ReqrdCfgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMSecurityConfiguration1? RequiredConfiguration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityConfiguration1? RequiredConfiguration { get; init; } 
    #else
    public ATMSecurityConfiguration1? RequiredConfiguration { get; set; } 
    #endif
    
    /// <summary>
    /// New status to apply on the security module of the ATM.
    /// </summary>
    [IsoId("_W1WYwItIEeSxlKlAGYErFg")]
    [DisplayName("Required Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqrdSts")]
    #endif
    [IsoXmlTag("ReqrdSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMStatus2Code? RequiredStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMStatus2Code? RequiredStatus { get; init; } 
    #else
    public ATMStatus2Code? RequiredStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
