// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of specific services for DeviceResponse.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TTnzwN7EEeiwsev40qZGEQ")]
[Description(@"List of specific services for DeviceResponse.")]
[DerivedFrom(typeof(RetailerServiceCode))]
public enum RetailerService9Code
{
    /// <summary>
    /// One system responds to the other system for a display request.
    /// Encoded/decoded by serializers as &quot;DDYP&quot;.
    /// </summary>
    [EnumMember(Value = "DDYP")]
    [IsoId("_YsANsd7EEeiwsev40qZGEQ")]
    [Description(@"One system responds to the other system for a display request.")]
    DeviceDisplayResponse = RetailerServiceCode.DeviceDisplayResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One system responds to the other System for a input request.
    /// Encoded/decoded by serializers as &quot;DINP&quot;.
    /// </summary>
    [EnumMember(Value = "DINP")]
    [IsoId("_ZT7wYd7EEeiwsev40qZGEQ")]
    [Description(@"One system responds to the other System for a input request.")]
    DeviceInputResponse = RetailerServiceCode.DeviceInputResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One system responds to the other System for a print request.
    /// Encoded/decoded by serializers as &quot;DPRP&quot;.
    /// </summary>
    [EnumMember(Value = "DPRP")]
    [IsoId("_aC3S8d7EEeiwsev40qZGEQ")]
    [Description(@"One system responds to the other System for a print request.")]
    DevicePrintResponse = RetailerServiceCode.DevicePrintResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One system responds to the other System for a play sound request.
    /// Encoded/decoded by serializers as &quot;DSOP&quot;.
    /// </summary>
    [EnumMember(Value = "DSOP")]
    [IsoId("_a3Assd7EEeiwsev40qZGEQ")]
    [Description(@"One system responds to the other System for a play sound request.")]
    DevicePlaySoundResponse = RetailerServiceCode.DevicePlaySoundResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// One system responds to the other System for secure data input.
    /// Encoded/decoded by serializers as &quot;DSIP&quot;.
    /// </summary>
    [EnumMember(Value = "DSIP")]
    [IsoId("_cnBRwd7EEeiwsev40qZGEQ")]
    [Description(@"One system responds to the other System for secure data input.")]
    DeviceSecureInputResponse = RetailerServiceCode.DeviceSecureInputResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI system responds to the Sale System for a card reader initialisation.
    /// Encoded/decoded by serializers as &quot;DCIP&quot;.
    /// </summary>
    [EnumMember(Value = "DCIP")]
    [IsoId("_dfCe4d7EEeiwsev40qZGEQ")]
    [Description(@"The POI system responds to the Sale System for a card reader initialisation.")]
    DeviceInitialisationCardReaderResponse = RetailerServiceCode.DeviceInitialisationCardReaderResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI system responds to the Sale System for a card reader Application Protocol Data Unit sending.
    /// Encoded/decoded by serializers as &quot;DCAP&quot;.
    /// </summary>
    [EnumMember(Value = "DCAP")]
    [IsoId("_eE2hsd7EEeiwsev40qZGEQ")]
    [Description(@"The POI system responds to the Sale System for a card reader Application Protocol Data Unit sending.")]
    DeviceSendApplicationProtocolDataUnitCardReaderResponse = RetailerServiceCode.DeviceSendApplicationProtocolDataUnitCardReaderResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI system responds to the Sale System for a card reader power off.
    /// Encoded/decoded by serializers as &quot;DCPP&quot;.
    /// </summary>
    [EnumMember(Value = "DCPP")]
    [IsoId("_fRKj0d7EEeiwsev40qZGEQ")]
    [Description(@"The POI system responds to the Sale System for a card reader power off.")]
    DevicePowerOffCardRequestResponse = RetailerServiceCode.DevicePowerOffCardRequestResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The POI system responds to the Sale System after a message transmission.
    /// Encoded/decoded by serializers as &quot;DCOP&quot;.
    /// </summary>
    [EnumMember(Value = "DCOP")]
    [IsoId("_gJwYsd7EEeiwsev40qZGEQ")]
    [Description(@"The POI system responds to the Sale System after a message transmission.")]
    DeviceTransmissionMessageResponse = RetailerServiceCode.DeviceTransmissionMessageResponse, // same ordinal as derivation source for type conversions
    
}
