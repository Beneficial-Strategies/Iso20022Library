// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of command to be performed by an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FHH00IqKEeSRT5rEzcAHEw")]
[Description(@"Type of command to be performed by an ATM.")]
[DerivedFrom(typeof(ATMCommandCode))]
public enum ATMCommand1Code
{
    /// <summary>
    /// Provide the ATM counters, resetting those that are applicable.
    /// Encoded/decoded by serializers as &quot;ABAL&quot;.
    /// </summary>
    [EnumMember(Value = "ABAL")]
    [IsoId("_LkXlEYqKEeSRT5rEzcAHEw")]
    [Description(@"Provide the ATM counters, resetting those that are applicable.")]
    ATMBalance = ATMCommandCode.ATMBalance, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Status of the ATM required by the ATM manager.
    /// Encoded/decoded by serializers as &quot;ASTS&quot;.
    /// </summary>
    [EnumMember(Value = "ASTS")]
    [IsoId("_LpbrQYqKEeSRT5rEzcAHEw")]
    [Description(@"Status of the ATM required by the ATM manager.")]
    ATMStatusUpdate = ATMCommandCode.ATMStatusUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Update the ATM configuration parameters.
    /// Encoded/decoded by serializers as &quot;CFGT&quot;.
    /// </summary>
    [EnumMember(Value = "CFGT")]
    [IsoId("_LuM2gYqKEeSRT5rEzcAHEw")]
    [Description(@"Update the ATM configuration parameters.")]
    ConfigurationUpdate = ATMCommandCode.ConfigurationUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Request the value of the ATM counters.
    /// Encoded/decoded by serializers as &quot;CCNT&quot;.
    /// </summary>
    [EnumMember(Value = "CCNT")]
    [IsoId("_L0KUkYqKEeSRT5rEzcAHEw")]
    [Description(@"Request the value of the ATM counters.")]
    CountersInquiry = ATMCommandCode.CountersInquiry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Perform a disconnection followed by a reconnection.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_L47f0YqKEeSRT5rEzcAHEw")]
    [Description(@"Perform a disconnection followed by a reconnection.")]
    Disconnect = ATMCommandCode.Disconnect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Send a specific message to initiate a process.
    /// Encoded/decoded by serializers as &quot;SNDM&quot;.
    /// </summary>
    [EnumMember(Value = "SNDM")]
    [IsoId("_L9_mAYqKEeSRT5rEzcAHEw")]
    [Description(@"Send a specific message to initiate a process.")]
    SendMessage = ATMCommandCode.SendMessage, // same ordinal as derivation source for type conversions
    
}
