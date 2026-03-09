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
/// Structured call details with address.
/// </summary>
[IsoId("_1J_VOPfGEei89sMSHxl1ew")]
[DisplayName("Telecom Call Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TelecomCallDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Contains call type values.
    /// </summary>
    [IsoId("_1J_VOffGEei89sMSHxl1ew")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TelephonyCallType1Code? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TelephonyCallType1Code? Type { get; init; } 
    #else
    public TelephonyCallType1Code? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Contains other call type values.
    /// </summary>
    [IsoId("_1J_VPvfGEei89sMSHxl1ew")]
    [DisplayName("Other Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTp")]
    #endif
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? OtherType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherType { get; init; } 
    #else
    public System.String? OtherType { get; set; } 
    #endif
    
    /// <summary>
    /// Origination or destination phone number.
    /// </summary>
    [IsoId("_d2rxUffHEei89sMSHxl1ew")]
    [DisplayName("Phone Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PhneNb")]
    #endif
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PhoneNumber { get; init; } 
    #else
    public System.String? PhoneNumber { get; set; } 
    #endif
    
    /// <summary>
    /// City from which or to which the call was made.
    /// </summary>
    [IsoId("_1J_VP_fGEei89sMSHxl1ew")]
    [DisplayName("City")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="City")]
    #endif
    [IsoXmlTag("City")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? City { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? City { get; init; } 
    #else
    public System.String? City { get; set; } 
    #endif
    
    /// <summary>
    /// State from which or to which the call was made.
    /// </summary>
    [IsoId("_1J_VO_fGEei89sMSHxl1ew")]
    [DisplayName("State")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Stat")]
    #endif
    [IsoXmlTag("Stat")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? State { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? State { get; init; } 
    #else
    public System.String? State { get; set; } 
    #endif
    
    /// <summary>
    /// Province from which or to which the call was made.
    /// </summary>
    [IsoId("_1J_VPPfGEei89sMSHxl1ew")]
    [DisplayName("Province")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prvc")]
    #endif
    [IsoXmlTag("Prvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Province { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Province { get; init; } 
    #else
    public System.String? Province { get; set; } 
    #endif
    
    /// <summary>
    /// Country from which or to which the call was made.
    /// </summary>
    [IsoId("_1J_VPffGEei89sMSHxl1ew")]
    [DisplayName("Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ctry")]
    #endif
    [IsoXmlTag("Ctry")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMin2Max3AlphaText? Country { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Country { get; init; } 
    #else
    public System.String? Country { get; set; } 
    #endif
    
    
    #nullable disable
    
}
