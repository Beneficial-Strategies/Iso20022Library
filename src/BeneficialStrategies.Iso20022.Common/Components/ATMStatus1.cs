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
/// Global status of the ATM.
/// </summary>
[IsoId("__xSdUIrxEeSvuOJS0mmL0g")]
[DisplayName("ATM Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMStatus1( ATMStatus1Code reqCurrentStatus )
    {
        CurrentStatus = reqCurrentStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Actual status of the ATM.
    /// </summary>
    [IsoId("_O76NYIryEeSvuOJS0mmL0g")]
    [DisplayName("Current Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CurSts")]
    #endif
    [IsoXmlTag("CurSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMStatus1Code CurrentStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMStatus1Code CurrentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMStatus1Code CurrentStatus { get; init; } 
    #else
    public ATMStatus1Code CurrentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Present if the status required by the ATM manager is different from the current status.
    /// </summary>
    [IsoId("_TTaZIIryEeSvuOJS0mmL0g")]
    [DisplayName("Demanded Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmnddSts")]
    #endif
    [IsoXmlTag("DmnddSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMStatus1Code? DemandedStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMStatus1Code? DemandedStatus { get; init; } 
    #else
    public ATMStatus1Code? DemandedStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
