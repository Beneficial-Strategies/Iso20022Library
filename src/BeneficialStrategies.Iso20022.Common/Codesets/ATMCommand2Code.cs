// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of command performed by the ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FSEd8Ir1EeSvuOJS0mmL0g")]
[Description(@"Type of command performed by the ATM.")]
[DerivedFrom(typeof(ATMCommandCode))]
public enum ATMCommand2Code
{
    /// <summary>
    /// Provide the ATM counters, resetting those that are applicable.
    /// Encoded/decoded by serializers as &quot;ABAL&quot;.
    /// </summary>
    [EnumMember(Value = "ABAL")]
    [IsoId("_y5cO4Yr2EeSvuOJS0mmL0g")]
    [Description(@"Provide the ATM counters, resetting those that are applicable.")]
    ATMBalance = ATMCommandCode.ATMBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of the ATM required by the ATM manager.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_zCoAE4r2EeSvuOJS0mmL0g")]
    [Description(@"Status of the ATM required by the ATM manager.")]
    ATMStatusUpdate = ATMCommandCode.ATMStatusUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update the ATM configuration parameters.
    /// Encoded/decoded by serializers as &quot;CFGT&quot;.
    /// </summary>
    [EnumMember(Value = "CFGT")]
    [IsoId("_zH5hoYr2EeSvuOJS0mmL0g")]
    [Description(@"Update the ATM configuration parameters.")]
    ConfigurationUpdate = ATMCommandCode.ConfigurationUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as &quot;CCNT&quot;.
    /// </summary>
    [EnumMember(Value = "CCNT")]
    [IsoId("_zRKLU4r2EeSvuOJS0mmL0g")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry = ATMCommandCode.CountersInquiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Perform a disconnection followed by a reconnection.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_zStqgYr2EeSvuOJS0mmL0g")]
    [Description(@"Perform a disconnection followed by a reconnection.")]
    Disconnect = ATMCommandCode.Disconnect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Activate cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KACT&quot;.
    /// </summary>
    [EnumMember(Value = "KACT")]
    [IsoId("_zcTEU4r2EeSvuOJS0mmL0g")]
    [Description(@"Activate cryptographic keys.")]
    KeyActivation = ATMCommandCode.KeyActivation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Deactivate cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KDAC&quot;.
    /// </summary>
    [EnumMember(Value = "KDAC")]
    [IsoId("_zd2jgYr2EeSvuOJS0mmL0g")]
    [Description(@"Deactivate cryptographic keys.")]
    KeyDeactivation = ATMCommandCode.KeyDeactivation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Start a cryptographic key download.
    /// Encoded/decoded by serializers as &quot;KDWL&quot;.
    /// </summary>
    [EnumMember(Value = "KDWL")]
    [IsoId("_zmgwQ4r2EeSvuOJS0mmL0g")]
    [Description(@"Start a cryptographic key download.")]
    KeyDownload = ATMCommandCode.KeyDownload, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Remove cryptographic keys.
    /// Encoded/decoded by serializers as &quot;KRMV&quot;.
    /// </summary>
    [EnumMember(Value = "KRMV")]
    [IsoId("_zsutAYr2EeSvuOJS0mmL0g")]
    [Description(@"Remove cryptographic keys.")]
    KeyRemove = ATMCommandCode.KeyRemove, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update the configuration of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SCFU&quot;.
    /// </summary>
    [EnumMember(Value = "SCFU")]
    [IsoId("_z1YSs4r2EeSvuOJS0mmL0g")]
    [Description(@"Update the configuration of the hardware security module on the ATM.")]
    SecurityDeviceConfigurationUpdate = ATMCommandCode.SecurityDeviceConfigurationUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update the security scheme of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SSCU&quot;.
    /// </summary>
    [EnumMember(Value = "SSCU")]
    [IsoId("_z6CJMYr2EeSvuOJS0mmL0g")]
    [Description(@"Update the security scheme of the hardware security module on the ATM.")]
    SecurityDeviceSchemeUpdate = ATMCommandCode.SecurityDeviceSchemeUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update the status of the hardware security module on the ATM.
    /// Encoded/decoded by serializers as &quot;SSTU&quot;.
    /// </summary>
    [EnumMember(Value = "SSTU")]
    [IsoId("_0EJHc4r2EeSvuOJS0mmL0g")]
    [Description(@"Update the status of the hardware security module on the ATM.")]
    SecurityDeviceStatusUpdate = ATMCommandCode.SecurityDeviceStatusUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Send a specific message to initiate a process.
    /// Encoded/decoded by serializers as &quot;SNDM&quot;.
    /// </summary>
    [EnumMember(Value = "SNDM")]
    [IsoId("_0Mvp04r2EeSvuOJS0mmL0g")]
    [Description(@"Send a specific message to initiate a process.")]
    SendMessage = ATMCommandCode.SendMessage, // same ordinal as derivation source for type conversions
    
}
