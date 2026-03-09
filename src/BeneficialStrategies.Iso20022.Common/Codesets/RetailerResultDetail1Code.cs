// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the processing of the message
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KH5RwNxYEeioifFt1dhnJA")]
[Description(@"Result of the processing of the message")]
[DerivedFrom(typeof(RetailerResultDetailCode))]
public enum RetailerResultDetail1Code
{
    /// <summary>
    /// The Initiator of the request has sent an Abort message request, which was accepted and processed.
    /// Encoded/decoded by serializers as &quot;ABRT&quot;.
    /// </summary>
    [EnumMember(Value = "ABRT")]
    [IsoId("_NGX1EdxYEeioifFt1dhnJA")]
    [Description(@"The Initiator of the request has sent an Abort message request, which was accepted and processed.")]
    Aborted = RetailerResultDetailCode.Aborted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The system is busy, try later.
    /// Encoded/decoded by serializers as &quot;BUSY&quot;.
    /// </summary>
    [EnumMember(Value = "BUSY")]
    [IsoId("_NJ8GcdxYEeioifFt1dhnJA")]
    [Description(@"The system is busy, try later.")]
    Busy = RetailerResultDetailCode.Busy, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The user has aborted the transaction on the PED keyboard, for instance during PIN entering.
    /// Encoded/decoded by serializers as &quot;CANC&quot;.
    /// </summary>
    [EnumMember(Value = "CANC")]
    [IsoId("_NXLRMdxYEeioifFt1dhnJA")]
    [Description(@"The user has aborted the transaction on the PED keyboard, for instance during PIN entering.")]
    Cancel = RetailerResultDetailCode.Cancel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device out of order.
    /// Encoded/decoded by serializers as &quot;DEVO&quot;.
    /// </summary>
    [EnumMember(Value = "DEVO")]
    [IsoId("_Na3eYdxYEeioifFt1dhnJA")]
    [Description(@"Device out of order.")]
    DeviceOut = RetailerResultDetailCode.DeviceOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The user has entered the PIN on the PED keyboard and the verification fails.
    /// Encoded/decoded by serializers as &quot;WPIN&quot;.
    /// </summary>
    [EnumMember(Value = "WPIN")]
    [IsoId("_N8gy4dxYEeioifFt1dhnJA")]
    [Description(@"The user has entered the PIN on the PED keyboard and the verification fails.")]
    WrongPIN = RetailerResultDetailCode.WrongPIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acquirer or any host is unreachable or has not answered to an online request, so is considered as temporary unavailable. Depending on the Sale context, the request could be repeated (to be compared with &quot;Refusal&quot;).
    /// Encoded/decoded by serializers as &quot;NHOS&quot;.
    /// </summary>
    [EnumMember(Value = "NHOS")]
    [IsoId("_N_z-gdxYEeioifFt1dhnJA")]
    [Description(@"Acquirer or any host is unreachable or has not answered to an online request, so is considered as temporary unavailable. Depending on the Sale context, the request could be repeated (to be compared with ""Refusal"").")]
    UnreachableHost = RetailerResultDetailCode.UnreachableHost, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The service is not available (not implemented, not configured, protocol version too old...).
    /// Encoded/decoded by serializers as &quot;UNVS&quot;.
    /// </summary>
    [EnumMember(Value = "UNVS")]
    [IsoId("_ODXo0dxYEeioifFt1dhnJA")]
    [Description(@"The service is not available (not implemented, not configured, protocol version too old...).")]
    UnavailableService = RetailerResultDetailCode.UnavailableService, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The hardware is not available (absent, not configured...).
    /// Encoded/decoded by serializers as &quot;UNVD&quot;.
    /// </summary>
    [EnumMember(Value = "UNVD")]
    [IsoId("_OHxnsdxYEeioifFt1dhnJA")]
    [Description(@"The hardware is not available (absent, not configured...).")]
    UnavailableDevice = RetailerResultDetailCode.UnavailableDevice, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The transaction is refused by the host or by the local rules associated to the card or the POI.
    /// Encoded/decoded by serializers as &quot;REFU&quot;.
    /// </summary>
    [EnumMember(Value = "REFU")]
    [IsoId("_OMVXkdxYEeioifFt1dhnJA")]
    [Description(@"The transaction is refused by the host or by the local rules associated to the card or the POI.")]
    Refusal = RetailerResultDetailCode.Refusal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Some sale items are not payable by the card proposed by the Customer.
    /// Encoded/decoded by serializers as &quot;PAYR&quot;.
    /// </summary>
    [EnumMember(Value = "PAYR")]
    [IsoId("_OTlPEdxYEeioifFt1dhnJA")]
    [Description(@"Some sale items are not payable by the card proposed by the Customer.")]
    PaymentRestriction = RetailerResultDetailCode.PaymentRestriction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The transaction is not found (e.g. for a reversal or a repeat).
    /// Encoded/decoded by serializers as &quot;TNFD&quot;.
    /// </summary>
    [EnumMember(Value = "TNFD")]
    [IsoId("_OXthIdxYEeioifFt1dhnJA")]
    [Description(@"The transaction is not found (e.g. for a reversal or a repeat).")]
    NotFound = RetailerResultDetailCode.NotFound, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A service request is sent during a Service dialogue. A combination of services not possible to provide. During the DeviceInitialisationCardReader message processing, the user has entered a card which has to be protected by the POI, and cannot be processed with this device request from the external, and then the Sale System.
    /// Encoded/decoded by serializers as &quot;NALW&quot;.
    /// </summary>
    [EnumMember(Value = "NALW")]
    [IsoId("_OcJ8QdxYEeioifFt1dhnJA")]
    [Description(@"A service request is sent during a Service dialogue. A combination of services not possible to provide. During the DeviceInitialisationCardReader message processing, the user has entered a card which has to be protected by the POI, and cannot be processed with this device request from the external, and then the Sale System.")]
    NotAllowed = RetailerResultDetailCode.NotAllowed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Not logged in.
    /// Encoded/decoded by serializers as &quot;LOUT&quot;.
    /// </summary>
    [EnumMember(Value = "LOUT")]
    [IsoId("_OgC9wdxYEeioifFt1dhnJA")]
    [Description(@"Not logged in.")]
    LoggedOut = RetailerResultDetailCode.LoggedOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The card entered by the Customer cannot be processed by the POI because this card is not configured in the system.
    /// Encoded/decoded by serializers as &quot;IVCA&quot;.
    /// </summary>
    [EnumMember(Value = "IVCA")]
    [IsoId("_OkTLodxYEeioifFt1dhnJA")]
    [Description(@"The card entered by the Customer cannot be processed by the POI because this card is not configured in the system.")]
    InvalidCard = RetailerResultDetailCode.InvalidCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// If the Input Device request a NotifyCardInputFlag and the Customer enters a card in the card reader without answers to the Input command, the POI abort the Input command processing, and answer a dedicated ErrorCondition value in the Input response message.
    /// Encoded/decoded by serializers as &quot;ICAR&quot;.
    /// </summary>
    [EnumMember(Value = "ICAR")]
    [IsoId("_OoZBcdxYEeioifFt1dhnJA")]
    [Description(@"If the Input Device request a NotifyCardInputFlag and the Customer enters a card in the card reader without answers to the Input command, the POI abort the Input command processing, and answer a dedicated ErrorCondition value in the Input response message.")]
    InsertedCard = RetailerResultDetailCode.InsertedCard, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The transaction is still in progress and then the command cannot be processed.
    /// Encoded/decoded by serializers as &quot;WIPG&quot;.
    /// </summary>
    [EnumMember(Value = "WIPG")]
    [IsoId("_OtBp0dxYEeioifFt1dhnJA")]
    [Description(@"The transaction is still in progress and then the command cannot be processed.")]
    InProgress = RetailerResultDetailCode.InProgress, // same ordinal as derivation source for type conversions
    
}
