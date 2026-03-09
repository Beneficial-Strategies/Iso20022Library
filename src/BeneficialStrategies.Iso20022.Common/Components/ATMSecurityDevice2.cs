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
/// Hardware security module of the ATM.
/// </summary>
[IsoId("_NXsPkbTkEeeQy4o2AayYHg")]
[DisplayName("ATM Security Device")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMSecurityDevice2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMSecurityDevice2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMSecurityDevice2( ATMSecurityConfiguration1 reqCurrentConfiguration,ATMStatus2Code reqCurrentStatus )
    {
        CurrentConfiguration = reqCurrentConfiguration;
        CurrentStatus = reqCurrentStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Hardware security module information, so called EPP for Encrypted PIN Pad.
    /// </summary>
    [IsoId("_Ng3ZsbTkEeeQy4o2AayYHg")]
    [DisplayName("Device Property")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvcPrprty")]
    #endif
    [IsoXmlTag("DvcPrprty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMEquipment2? DeviceProperty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMEquipment2? DeviceProperty { get; init; } 
    #else
    public ATMEquipment2? DeviceProperty { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters in use by the security device.
    /// </summary>
    [IsoId("_Ng3Zs7TkEeeQy4o2AayYHg")]
    [DisplayName("Current Configuration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurCfgtn")]
    #endif
    [IsoXmlTag("CurCfgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMSecurityConfiguration1 CurrentConfiguration { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMSecurityConfiguration1 CurrentConfiguration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityConfiguration1 CurrentConfiguration { get; init; } 
    #else
    public ATMSecurityConfiguration1 CurrentConfiguration { get; set; } 
    #endif
    
    /// <summary>
    /// Configuration parameters supported by the security device.
    /// </summary>
    [IsoId("_Ng3ZtbTkEeeQy4o2AayYHg")]
    [DisplayName("Supported Configuration")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpprtdCfgtn")]
    #endif
    [IsoXmlTag("SpprtdCfgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMSecurityConfiguration1? SupportedConfiguration { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMSecurityConfiguration1? SupportedConfiguration { get; init; } 
    #else
    public ATMSecurityConfiguration1? SupportedConfiguration { get; set; } 
    #endif
    
    /// <summary>
    /// Current status of the security device.
    /// </summary>
    [IsoId("_Ng3Zt7TkEeeQy4o2AayYHg")]
    [DisplayName("Current Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurSts")]
    #endif
    [IsoXmlTag("CurSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMStatus2Code CurrentStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMStatus2Code CurrentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMStatus2Code CurrentStatus { get; init; } 
    #else
    public ATMStatus2Code CurrentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Incident occurring on the device.
    /// </summary>
    [IsoId("_Ng3ZubTkEeeQy4o2AayYHg")]
    [DisplayName("Incident")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Incdnt")]
    #endif
    [IsoXmlTag("Incdnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FailureReason5Code? Incident { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FailureReason5Code? Incident { get; init; } 
    #else
    public FailureReason5Code? Incident { get; set; } 
    #endif
    
    /// <summary>
    /// Binding state of the security device.
    /// </summary>
    [IsoId("_BkKhsLTlEeeQy4o2AayYHg")]
    [DisplayName("Binding State")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BndgStat")]
    #endif
    [IsoXmlTag("BndgStat")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TR34Status1Code? BindingState { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TR34Status1Code? BindingState { get; init; } 
    #else
    public TR34Status1Code? BindingState { get; set; } 
    #endif
    
    
    #nullable disable
    
}
