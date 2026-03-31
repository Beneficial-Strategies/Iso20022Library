// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of command performed by an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_T4nIoIqJEeSRT5rEzcAHEw")]
[Description(@"Type of command performed by an ATM.")]
[Derivations(
    typeof(ATMCommand3Code),
    typeof(ATMCommand4Code),
    typeof(ATMCommand1Code),
    typeof(ATMCommand5Code),
    typeof(ATMCommand2Code),
    typeof(ATMCommand6Code)
)]
public enum ATMCommandCode
{
    /// <summary>
    /// Provide the ATM counters, resetting those that are applicable.
    /// Encoded/decoded by serializers as &quot;ABAL&quot;.
    /// </summary>
    [EnumMember(Value = "ABAL")]
    [IsoId("_y-VqgIqJEeSRT5rEzcAHEw")]
    [Description(@"Provide the ATM counters, resetting those that are applicable.")]
    ATMBalance,

    /// <summary>
    /// Status of the ATM required by the ATM manager.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_1w21cIqJEeSRT5rEzcAHEw")]
    [Description(@"Status of the ATM required by the ATM manager.")]
    ATMStatusUpdate,

    /// <summary>
    /// Update the ATM configuration parameters.
    /// Encoded/decoded by serializers as &quot;CFGT&quot;.
    /// </summary>
    [EnumMember(Value = "CFGT")]
    [IsoId("_39N_UIqJEeSRT5rEzcAHEw")]
    [Description(@"Update the ATM configuration parameters.")]
    ConfigurationUpdate,

    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as &quot;CCNT&quot;.
    /// </summary>
    [EnumMember(Value = "CCNT")]
    [IsoId("_6w-gYIqJEeSRT5rEzcAHEw")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry,

    /// <summary>
    /// Perform a disconnection followed by a reconnection.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_9Qa-UIqJEeSRT5rEzcAHEw")]
    [Description(@"Perform a disconnection followed by a reconnection.")]
    Disconnect,

    /// <summary>
    /// Send a specific message to initiate a process.
    /// Encoded/decoded by serializers as &quot;SNDM&quot;.
    /// </summary>
    [EnumMember(Value = "SNDM")]
    [IsoId("__u06cIqJEeSRT5rEzcAHEw")]
    [Description(@"Send a specific message to initiate a process.")]
    SendMessage,

    /// <summary>
    /// Activate cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KACT&quot;.
    /// </summary>
    [EnumMember(Value = "KACT")]
    [IsoId("_yVp3QIr0EeSvuOJS0mmL0g")]
    [Description(@"Activate cryptographic keys.")]
    KeyActivation,

    /// <summary>
    /// Deactivate cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KDAC&quot;.
    /// </summary>
    [EnumMember(Value = "KDAC")]
    [IsoId("_1RkOwIr0EeSvuOJS0mmL0g")]
    [Description(@"Deactivate cryptographic keys.")]
    KeyDeactivation,

    /// <summary>
    /// Start a cryptographic key download.
    /// Encoded/decoded by serializers as &quot;KDWL&quot;.
    /// </summary>
    [EnumMember(Value = "KDWL")]
    [IsoId("_3V76QIr0EeSvuOJS0mmL0g")]
    [Description(@"Start a cryptographic key download.")]
    KeyDownload,

    /// <summary>
    /// Remove cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KRMV&quot;.
    /// </summary>
    [EnumMember(Value = "KRMV")]
    [IsoId("_6K5VMIr0EeSvuOJS0mmL0g")]
    [Description(@"Remove cryptographic keys.")]
    KeyRemove,

    /// <summary>
    /// Update the configuration of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SCFU&quot;.
    /// </summary>
    [EnumMember(Value = "SCFU")]
    [IsoId("_8XDqwIr0EeSvuOJS0mmL0g")]
    [Description(@"Update the configuration of the hardware security module on the ATM.")]
    SecurityDeviceConfigurationUpdate,

    /// <summary>
    /// Update the security scheme of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SSCU&quot;.
    /// </summary>
    [EnumMember(Value = "SSCU")]
    [IsoId("__F_9QIr0EeSvuOJS0mmL0g")]
    [Description(@"Update the security scheme of the hardware security module on the ATM.")]
    SecurityDeviceSchemeUpdate,

    /// <summary>
    /// Update the status of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SSTU&quot;.
    /// </summary>
    [EnumMember(Value = "SSTU")]
    [IsoId("_BNpmQIr1EeSvuOJS0mmL0g")]
    [Description(@"Update the status of the hardware security module on the ATM.")]
    SecurityDeviceStatusUpdate,

    /// <summary>
    /// Provide the value of the ATM counters, no reinitialisation of the counters.
    /// Encoded/decoded by serializers as &quot;RPTC&quot;.
    /// </summary>
    [EnumMember(Value = "RPTC")]
    [IsoId("_iZdRkK2BEeWMg5rOByfExw")]
    [Description(@"Provide the value of the ATM counters, no reinitialisation of the counters.")]
    CountersReport,

    /// <summary>
    /// Replace an existing key using a Higher Level Authority (HLA) key. In the TR34 scheme this would be used to implement a HLA Rebind operation.
    /// Encoded/decoded by serializers as &quot;HKCG&quot;.
    /// </summary>
    [EnumMember(Value = "HKCG")]
    [IsoId("_BbRoAF2cEeekzJIz1JxYSQ")]
    [Description(
        @"Replace an existing key using a Higher Level Authority (HLA) key. In the TR34 scheme this would be used to implement a HLA Rebind operation."
    )]
    HLAKeyReplace,

    /// <summary>
    /// Remove a cryptographic key using a Higher Level Authority key (HLA). In the TR34 scheme this would be used to implement a HLA Unbind operation.
    /// Encoded/decoded by serializers as &quot;HKRV&quot;.
    /// </summary>
    [EnumMember(Value = "HKRV")]
    [IsoId("_HHSvoF2cEeekzJIz1JxYSQ")]
    [Description(
        @"Remove a cryptographic key using a Higher Level Authority key (HLA). In the TR34 scheme this would be used to implement a HLA Unbind operation."
    )]
    HLAKeyRemove,

    /// <summary>
    /// Replaces an existing cryptographic key. In a TR34 scheme this would be used to implement a Rebind operation.
    /// Encoded/decoded by serializers as &quot;KCHG&quot;.
    /// </summary>
    [EnumMember(Value = "KCHG")]
    [IsoId("_L1CRIF2cEeekzJIz1JxYSQ")]
    [Description(
        @"Replaces an existing cryptographic key. In a TR34 scheme this would be used to implement a Rebind operation."
    )]
    KeyReplace,
}
