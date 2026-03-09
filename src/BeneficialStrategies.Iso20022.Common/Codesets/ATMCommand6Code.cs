// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of command performed by the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-DDJwV_REeeD0NpJQPACzA")]
[Description(@"Type of command performed by the ATM.")]
[DerivedFrom(typeof(ATMCommandCode))]
public enum ATMCommand6Code
{
    /// <summary>
    /// Provide the ATM counters, resetting those that are applicable.
    /// Encoded/decoded by serializers as &quot;ABAL&quot;.
    /// </summary>
    [EnumMember(Value = "ABAL")]
    [IsoId("_-OwDcV_REeeD0NpJQPACzA")]
    [Description(@"Provide the ATM counters, resetting those that are applicable.")]
    ATMBalance = ATMCommandCode.ATMBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of the ATM required by the ATM manager.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_-OwDc1_REeeD0NpJQPACzA")]
    [Description(@"Status of the ATM required by the ATM manager.")]
    ATMStatusUpdate = ATMCommandCode.ATMStatusUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update the ATM configuration parameters.
    /// Encoded/decoded by serializers as &quot;CFGT&quot;.
    /// </summary>
    [EnumMember(Value = "CFGT")]
    [IsoId("_-OwDdV_REeeD0NpJQPACzA")]
    [Description(@"Update the ATM configuration parameters.")]
    ConfigurationUpdate = ATMCommandCode.ConfigurationUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as &quot;CCNT&quot;.
    /// </summary>
    [EnumMember(Value = "CCNT")]
    [IsoId("_-OwDd1_REeeD0NpJQPACzA")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry = ATMCommandCode.CountersInquiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Perform a disconnection followed by a reconnection.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_-OwDeV_REeeD0NpJQPACzA")]
    [Description(@"Perform a disconnection followed by a reconnection.")]
    Disconnect = ATMCommandCode.Disconnect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Activate cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KACT&quot;.
    /// </summary>
    [EnumMember(Value = "KACT")]
    [IsoId("_-OwDe1_REeeD0NpJQPACzA")]
    [Description(@"Activate cryptographic keys.")]
    KeyActivation = ATMCommandCode.KeyActivation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deactivate cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KDAC&quot;.
    /// </summary>
    [EnumMember(Value = "KDAC")]
    [IsoId("_-OwDfV_REeeD0NpJQPACzA")]
    [Description(@"Deactivate cryptographic keys.")]
    KeyDeactivation = ATMCommandCode.KeyDeactivation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Start a cryptographic key download.
    /// Encoded/decoded by serializers as &quot;KDWL&quot;.
    /// </summary>
    [EnumMember(Value = "KDWL")]
    [IsoId("_-OwDf1_REeeD0NpJQPACzA")]
    [Description(@"Start a cryptographic key download.")]
    KeyDownload = ATMCommandCode.KeyDownload, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remove cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KRMV&quot;.
    /// </summary>
    [EnumMember(Value = "KRMV")]
    [IsoId("_-OwDgV_REeeD0NpJQPACzA")]
    [Description(@"Remove cryptographic keys.")]
    KeyRemove = ATMCommandCode.KeyRemove, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update the configuration of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SCFU&quot;.
    /// </summary>
    [EnumMember(Value = "SCFU")]
    [IsoId("_-OwDg1_REeeD0NpJQPACzA")]
    [Description(@"Update the configuration of the hardware security module on the ATM.")]
    SecurityDeviceConfigurationUpdate = ATMCommandCode.SecurityDeviceConfigurationUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update the security scheme of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SSCU&quot;.
    /// </summary>
    [EnumMember(Value = "SSCU")]
    [IsoId("_-OwDhV_REeeD0NpJQPACzA")]
    [Description(@"Update the security scheme of the hardware security module on the ATM.")]
    SecurityDeviceSchemeUpdate = ATMCommandCode.SecurityDeviceSchemeUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update the status of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SSTU&quot;.
    /// </summary>
    [EnumMember(Value = "SSTU")]
    [IsoId("_-OwDh1_REeeD0NpJQPACzA")]
    [Description(@"Update the status of the hardware security module on the ATM.")]
    SecurityDeviceStatusUpdate = ATMCommandCode.SecurityDeviceStatusUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Send a specific message to initiate a process.
    /// Encoded/decoded by serializers as &quot;SNDM&quot;.
    /// </summary>
    [EnumMember(Value = "SNDM")]
    [IsoId("_-OwDiV_REeeD0NpJQPACzA")]
    [Description(@"Send a specific message to initiate a process.")]
    SendMessage = ATMCommandCode.SendMessage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Replace an existing key using a Higher Level Authority (HLA) key. In the TR34 scheme this would be used to implement a HLA Rebind operation.
    /// Encoded/decoded by serializers as &quot;HKCG&quot;.
    /// </summary>
    [EnumMember(Value = "HKCG")]
    [IsoId("___KRIV_REeeD0NpJQPACzA")]
    [Description(@"Replace an existing key using a Higher Level Authority (HLA) key. In the TR34 scheme this would be used to implement a HLA Rebind operation.")]
    HLAKeyReplace = ATMCommandCode.HLAKeyReplace, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remove a cryptographic key using a Higher Level Authority key (HLA). In the TR34 scheme this would be used to implement a HLA Unbind operation.
    /// Encoded/decoded by serializers as &quot;HKRV&quot;.
    /// </summary>
    [EnumMember(Value = "HKRV")]
    [IsoId("_AIxgIV_SEeeD0NpJQPACzA")]
    [Description(@"Remove a cryptographic key using a Higher Level Authority key (HLA). In the TR34 scheme this would be used to implement a HLA Unbind operation.")]
    HLAKeyRemove = ATMCommandCode.HLAKeyRemove, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Replaces an existing cryptographic key. In a TR34 scheme this would be used to implement a Rebind operation.
    /// Encoded/decoded by serializers as &quot;KCHG&quot;.
    /// </summary>
    [EnumMember(Value = "KCHG")]
    [IsoId("_Av38YV_SEeeD0NpJQPACzA")]
    [Description(@"Replaces an existing cryptographic key. In a TR34 scheme this would be used to implement a Rebind operation.")]
    KeyReplace = ATMCommandCode.KeyReplace, // same ordinal as derivation source for type conversions
    
}
