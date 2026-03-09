// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Required status of the ATM, parameters of the status update command.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_W1_04IqLEeSRT5rEzcAHEw")]
[Description(@"Required status of the ATM, parameters of the status update command.")]
[Derivations(typeof(ATMStatus1Code),typeof(ATMStatus2Code),typeof(ATMStatus3Code))]
public enum ATMStatusCode
{
    /// <summary>
    /// Component is in service.
    /// Encoded/decoded by serializers as &quot;INSV&quot;.
    /// </summary>
    [EnumMember(Value = "INSV")]
    [IsoId("_a2vtgIqLEeSRT5rEzcAHEw")]
    [Description(@"Component is in service.")]
    InService,
    
    /// <summary>
    /// ATM out of service.
    /// Encoded/decoded by serializers as &quot;OUTS&quot;.
    /// </summary>
    [EnumMember(Value = "OUTS")]
    [IsoId("_f0JboIqLEeSRT5rEzcAHEw")]
    [Description(@"ATM out of service.")]
    OutOfService,
    
    /// <summary>
    /// Component is activated and in operation.
    /// Encoded/decoded by serializers as &quot;OPER&quot;.
    /// </summary>
    [EnumMember(Value = "OPER")]
    [IsoId("_a3AP8Ir-EeSvuOJS0mmL0g")]
    [Description(@"Component is activated and in operation.")]
    InOperation,
    
    /// <summary>
    /// Component has been stopped.
    /// Encoded/decoded by serializers as &quot;STOP&quot;.
    /// </summary>
    [EnumMember(Value = "STOP")]
    [IsoId("_wnKYsItCEeSxlKlAGYErFg")]
    [Description(@"Component has been stopped.")]
    Stopped,
    
    /// <summary>
    /// Component has been loaded, but not yet activated.
    /// Encoded/decoded by serializers as &quot;WACT&quot;.
    /// </summary>
    [EnumMember(Value = "WACT")]
    [IsoId("_6BC5MItCEeSxlKlAGYErFg")]
    [Description(@"Component has been loaded, but not yet activated.")]
    WaitingActivation,
    
}
