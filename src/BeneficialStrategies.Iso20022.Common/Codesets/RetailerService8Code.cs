// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of specific services for DeviceRequest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YfHZUN6lEeiwsev40qZGEQ")]
[Description(@"List of specific services for DeviceRequest.")]
[DerivedFrom(typeof(RetailerServiceCode))]
public enum RetailerService8Code
{
    /// <summary>
    /// One System requests the other to display a message for cashier or customer.
    /// Encoded/decoded by serializers as &quot;DDYQ&quot;.
    /// </summary>
    [EnumMember(Value = "DDYQ")]
    [IsoId("_ew3rQd6lEeiwsev40qZGEQ")]
    [Description(@"One System requests the other to display a message for cashier or customer.")]
    DeviceDisplayRequest = RetailerServiceCode.DeviceDisplayRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One system requests to the other System to get data input. 
    /// Encoded/decoded by serializers as &quot;DINQ&quot;.
    /// </summary>
    [EnumMember(Value = "DINQ")]
    [IsoId("_fZRvEd6lEeiwsev40qZGEQ")]
    [Description(@"One system requests to the other System to get data input. ")]
    DeviceInputRequest = RetailerServiceCode.DeviceInputRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One system requests to the other System to print data.
    /// Encoded/decoded by serializers as &quot;DPRQ&quot;.
    /// </summary>
    [EnumMember(Value = "DPRQ")]
    [IsoId("_gIio0d6lEeiwsev40qZGEQ")]
    [Description(@"One system requests to the other System to print data.")]
    DevicePrintRequest = RetailerServiceCode.DevicePrintRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One system requests to the Other System to play a sound.
    /// Encoded/decoded by serializers as &quot;DSOQ&quot;.
    /// </summary>
    [EnumMember(Value = "DSOQ")]
    [IsoId("_gqGdwd6lEeiwsev40qZGEQ")]
    [Description(@"One system requests to the Other System to play a sound.")]
    DevicePlaySoundRequest = RetailerServiceCode.DevicePlaySoundRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One system requests to the Other System to securely get data input (e.g. for PIN).
    /// Encoded/decoded by serializers as &quot;DSIQ&quot;.
    /// </summary>
    [EnumMember(Value = "DSIQ")]
    [IsoId("_h1pD0d6lEeiwsev40qZGEQ")]
    [Description(@"One system requests to the Other System to securely get data input (e.g. for PIN).")]
    DeviceSecureInputRequest = RetailerServiceCode.DeviceSecureInputRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Service to send parameters to use when card reader initializes a new communication with the card.
    /// Encoded/decoded by serializers as &quot;DCIQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCIQ")]
    [IsoId("_iiMAwd6lEeiwsev40qZGEQ")]
    [Description(@"Service to send parameters to use when card reader initializes a new communication with the card.")]
    DeviceInitialisationCardReaderRequest = RetailerServiceCode.DeviceInitialisationCardReaderRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A service to send commands to a card.
    /// Encoded/decoded by serializers as &quot;DCAQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCAQ")]
    [IsoId("_jc7Ksd6lEeiwsev40qZGEQ")]
    [Description(@"A service to send commands to a card.")]
    DeviceSendApplicationProtocolDataUnitCardReaderRequest = RetailerServiceCode.DeviceSendApplicationProtocolDataUnitCardReaderRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Sale system requests to the POI System to power off the card reader.
    /// Encoded/decoded by serializers as &quot;DCPQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCPQ")]
    [IsoId("_kPFncd6lEeiwsev40qZGEQ")]
    [Description(@"The Sale system requests to the POI System to power off the card reader.")]
    DevicePowerOffCardReaderRequest = RetailerServiceCode.DevicePowerOffCardReaderRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The Sale system requests to the POI System to transmit a message (for instance to a mobile server).
    /// Encoded/decoded by serializers as &quot;DCOQ&quot;.
    /// </summary>
    [EnumMember(Value = "DCOQ")]
    [IsoId("_lsuqId6lEeiwsev40qZGEQ")]
    [Description(@"The Sale system requests to the POI System to transmit a message (for instance to a mobile server).")]
    DeviceTransmissionMessageRequest = RetailerServiceCode.DeviceTransmissionMessageRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One system sends a notification to the POI System to update a input request.
    /// Encoded/decoded by serializers as &quot;DINO&quot;.
    /// </summary>
    [EnumMember(Value = "DINO")]
    [IsoId("_mcmA0d6lEeiwsev40qZGEQ")]
    [Description(@"One system sends a notification to the POI System to update a input request.")]
    DeviceInputNotification = RetailerServiceCode.DeviceInputNotification, // same ordinal as derivation source for type conversions
    
}
