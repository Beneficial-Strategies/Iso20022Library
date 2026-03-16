// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of command performed by the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMCommand7Code")]
[Description(@"Type of command performed by the ATM.")]
[DerivedFrom(typeof(ATMCommandCode))]
public enum ATMCommand7Code
{
    /// <summary>
    /// Provide the ATM counters, resetting those that are applicable.
    /// Encoded/decoded by serializers as &quot;ABAL&quot;.
    /// </summary>
    [EnumMember(Value = "ABAL")]
    [IsoId("_ATMCommand7Code_ATMBalance")]
    [Description(@"Provide the ATM counters, resetting those that are applicable.")]
    ATMBalance = ATMCommandCode.ATMBalance,

    /// <summary>
    /// Status of the ATM required by the ATM manager.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_ATMCommand7Code_ATMStatusUpdate")]
    [Description(@"Status of the ATM required by the ATM manager.")]
    ATMStatusUpdate = ATMCommandCode.ATMStatusUpdate,

    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as &quot;CCNT&quot;.
    /// </summary>
    [EnumMember(Value = "CCNT")]
    [IsoId("_ATMCommand7Code_CountersInquiry")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry = ATMCommandCode.CountersInquiry,

    /// <summary>
    /// Update the ATM configuration parameters.
    /// Encoded/decoded by serializers as &quot;CFGT&quot;.
    /// </summary>
    [EnumMember(Value = "CFGT")]
    [IsoId("_ATMCommand7Code_ConfigurationUpdate")]
    [Description(@"Update the ATM configuration parameters.")]
    ConfigurationUpdate = ATMCommandCode.ConfigurationUpdate,

    /// <summary>
    /// Perform a disconnection followed by a reconnection.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_ATMCommand7Code_Disconnect")]
    [Description(@"Perform a disconnection followed by a reconnection.")]
    Disconnect = ATMCommandCode.Disconnect,

    /// <summary>
    /// Replace an existing key using a Higher Level Authority (HLA) key. In the TR34 scheme this would be used to implement a HLA Rebind operation.
    /// Encoded/decoded by serializers as &quot;HKCG&quot;.
    /// </summary>
    [EnumMember(Value = "HKCG")]
    [IsoId("_ATMCommand7Code_HLAKeyReplace")]
    [Description(
        @"Replace an existing key using a Higher Level Authority (HLA) key. In the TR34 scheme this would be used to implement a HLA Rebind operation."
    )]
    HLAKeyReplace = ATMCommandCode.HLAKeyReplace,

    /// <summary>
    /// Remove a cryptographic key using a Higher Level Authority key (HLA). In the TR34 scheme this would be used to implement a HLA Unbind operation.
    /// Encoded/decoded by serializers as &quot;HKRV&quot;.
    /// </summary>
    [EnumMember(Value = "HKRV")]
    [IsoId("_ATMCommand7Code_HLAKeyRemove")]
    [Description(
        @"Remove a cryptographic key using a Higher Level Authority key (HLA). In the TR34 scheme this would be used to implement a HLA Unbind operation."
    )]
    HLAKeyRemove = ATMCommandCode.HLAKeyRemove,

    /// <summary>
    /// Activate cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KACT&quot;.
    /// </summary>
    [EnumMember(Value = "KACT")]
    [IsoId("_ATMCommand7Code_KeyActivation")]
    [Description(@"Activate cryptographic keys.")]
    KeyActivation = ATMCommandCode.KeyActivation,

    /// <summary>
    /// Replaces an existing cryptographic key. In a TR34 scheme this would be used to implement a Rebind operation.
    /// Encoded/decoded by serializers as &quot;KCHG&quot;.
    /// </summary>
    [EnumMember(Value = "KCHG")]
    [IsoId("_ATMCommand7Code_KeyReplace")]
    [Description(
        @"Replaces an existing cryptographic key. In a TR34 scheme this would be used to implement a Rebind operation."
    )]
    KeyReplace = ATMCommandCode.KeyReplace,

    /// <summary>
    /// Deactivate cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KDAC&quot;.
    /// </summary>
    [EnumMember(Value = "KDAC")]
    [IsoId("_ATMCommand7Code_KeyDeactivation")]
    [Description(@"Deactivate cryptographic keys.")]
    KeyDeactivation = ATMCommandCode.KeyDeactivation,

    /// <summary>
    /// Start a cryptographic key download.
    /// Encoded/decoded by serializers as &quot;KDWL&quot;.
    /// </summary>
    [EnumMember(Value = "KDWL")]
    [IsoId("_ATMCommand7Code_KeyDownload")]
    [Description(@"Start a cryptographic key download.")]
    KeyDownload = ATMCommandCode.KeyDownload,

    /// <summary>
    /// Remove cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KRMV&quot;.
    /// </summary>
    [EnumMember(Value = "KRMV")]
    [IsoId("_ATMCommand7Code_KeyRemove")]
    [Description(@"Remove cryptographic keys.")]
    KeyRemove = ATMCommandCode.KeyRemove,

    /// <summary>
    /// Send a ReconciliationRequest message.
    /// Encoded/decoded by serializers as &quot;RREQ&quot;.
    /// </summary>
    [EnumMember(Value = "RREQ")]
    [IsoId("_ATMCommand7Code_ReconciliationRequest")]
    [Description(@"Send a ReconciliationRequest message.")]
    ReconciliationRequest,

    /// <summary>
    /// Update the configuration of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SCFU&quot;.
    /// </summary>
    [EnumMember(Value = "SCFU")]
    [IsoId("_ATMCommand7Code_SecurityDeviceConfigurationUpdate")]
    [Description(@"Update the configuration of the hardware security module on the ATM.")]
    SecurityDeviceConfigurationUpdate = ATMCommandCode.SecurityDeviceConfigurationUpdate,

    /// <summary>
    /// Send a specific message to initiate a process.
    /// Encoded/decoded by serializers as &quot;SNDM&quot;.
    /// </summary>
    [EnumMember(Value = "SNDM")]
    [IsoId("_ATMCommand7Code_SendMessage")]
    [Description(@"Send a specific message to initiate a process.")]
    SendMessage = ATMCommandCode.SendMessage,

    /// <summary>
    /// Update the security scheme of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SSCU&quot;.
    /// </summary>
    [EnumMember(Value = "SSCU")]
    [IsoId("_ATMCommand7Code_SecurityDeviceSchemeUpdate")]
    [Description(@"Update the security scheme of the hardware security module on the ATM.")]
    SecurityDeviceSchemeUpdate = ATMCommandCode.SecurityDeviceSchemeUpdate,

    /// <summary>
    /// Update the status of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SSTU&quot;.
    /// </summary>
    [EnumMember(Value = "SSTU")]
    [IsoId("_ATMCommand7Code_SecurityDeviceStatusUpdate")]
    [Description(@"Update the status of the hardware security module on the ATM.")]
    SecurityDeviceStatusUpdate = ATMCommandCode.SecurityDeviceStatusUpdate,
}
