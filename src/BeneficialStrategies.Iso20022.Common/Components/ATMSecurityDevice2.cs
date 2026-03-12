// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Hardware security module of the ATM.
/// </summary>
[IsoId("_NXsPkbTkEeeQy4o2AayYHg")]
[DisplayName("ATM Security Device")]
public partial record ATMSecurityDevice2
{
    #nullable enable
    
    /// <summary>
    /// Hardware security module information, so called EPP for Encrypted PIN Pad.
    /// </summary>
    [IsoId("_Ng3ZsbTkEeeQy4o2AayYHg")]
    [DisplayName("Device Property")]
    [IsoXmlTag("DvcPrprty")]
    public ATMEquipment2? DeviceProperty { get; init; } 
    
    /// <summary>
    /// Configuration parameters in use by the security device.
    /// </summary>
    [IsoId("_Ng3Zs7TkEeeQy4o2AayYHg")]
    [DisplayName("Current Configuration")]
    [IsoXmlTag("CurCfgtn")]
    public required ATMSecurityConfiguration1 CurrentConfiguration { get; init; } 
    
    /// <summary>
    /// Configuration parameters supported by the security device.
    /// </summary>
    [IsoId("_Ng3ZtbTkEeeQy4o2AayYHg")]
    [DisplayName("Supported Configuration")]
    [IsoXmlTag("SpprtdCfgtn")]
    public ATMSecurityConfiguration1? SupportedConfiguration { get; init; } 
    
    /// <summary>
    /// Current status of the security device.
    /// </summary>
    [IsoId("_Ng3Zt7TkEeeQy4o2AayYHg")]
    [DisplayName("Current Status")]
    [IsoXmlTag("CurSts")]
    public required ATMStatus2Code CurrentStatus { get; init; } 
    
    /// <summary>
    /// Incident occurring on the device.
    /// </summary>
    [IsoId("_Ng3ZubTkEeeQy4o2AayYHg")]
    [DisplayName("Incident")]
    [IsoXmlTag("Incdnt")]
    public FailureReason5Code? Incident { get; init; } 
    
    /// <summary>
    /// Binding state of the security device.
    /// </summary>
    [IsoId("_BkKhsLTlEeeQy4o2AayYHg")]
    [DisplayName("Binding State")]
    [IsoXmlTag("BndgStat")]
    public TR34Status1Code? BindingState { get; init; } 
    
    
    #nullable disable
    
}
