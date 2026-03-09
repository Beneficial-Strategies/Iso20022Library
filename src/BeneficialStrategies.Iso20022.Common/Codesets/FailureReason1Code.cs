// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of incidents happening during the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TTG0VgEcEeCQm6a_G2yO_w_-530191250")]
[Description(@"List of incidents happening during the transaction.")]
[DerivedFrom(typeof(FailureReasonCode))]
public enum FailureReason1Code
{
    /// <summary>
    /// Customer cancellation, for example removing the card before the end of the transaction.
    /// Encoded/decoded by serializers as &quot;CUCL&quot;.
    /// </summary>
    [EnumMember(Value = "CUCL")]
    [IsoId("_TTG0VwEcEeCQm6a_G2yO_w_1835563439")]
    [Description(@"Customer cancellation, for example removing the card before the end of the transaction.")]
    CustomerCancel = FailureReasonCode.CustomerCancel, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Suspected malfunction.
    /// Encoded/decoded by serializers as &quot;MALF&quot;.
    /// </summary>
    [EnumMember(Value = "MALF")]
    [IsoId("_TTG0WAEcEeCQm6a_G2yO_w_-186424222")]
    [Description(@"Suspected malfunction.")]
    Malfunction = FailureReasonCode.Malfunction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Completed partially.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_TTG0WQEcEeCQm6a_G2yO_w_1750800951")]
    [Description(@"Completed partially.")]
    Partial = FailureReasonCode.Partial, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Response to the previous message was received too late.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_TTG0WgEcEeCQm6a_G2yO_w_267663047")]
    [Description(@"Response to the previous message was received too late.")]
    TooLateResponse = FailureReasonCode.TooLateResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to complete the transaction after the authorisation response.
    /// Encoded/decoded by serializers as &quot;UCMP&quot;.
    /// </summary>
    [EnumMember(Value = "UCMP")]
    [IsoId("_TTG0WwEcEeCQm6a_G2yO_w_-2090079076")]
    [Description(@"Unable to complete the transaction after the authorisation response.")]
    UnableToComplete = FailureReasonCode.UnableToComplete, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unable to deliver the request message to the recipient party.
    /// Encoded/decoded by serializers as &quot;USND&quot;.
    /// </summary>
    [EnumMember(Value = "USND")]
    [IsoId("_TTG0XAEcEeCQm6a_G2yO_w_1028428200")]
    [Description(@"Unable to deliver the request message to the recipient party.")]
    UnableToSend = FailureReasonCode.UnableToSend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).
    /// Encoded/decoded by serializers as &quot;TIMO&quot;.
    /// </summary>
    [EnumMember(Value = "TIMO")]
    [IsoId("_TTG0XQEcEeCQm6a_G2yO_w_-1329313923")]
    [Description(@"Timeout while waiting for a response to a request message, or no response was received (for example connection release before receiving the response).")]
    TimeOut = FailureReasonCode.TimeOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Integrated circuit card declines the transaction before or after the authorisation.
    /// Encoded/decoded by serializers as &quot;CDCL&quot;.
    /// </summary>
    [EnumMember(Value = "CDCL")]
    [IsoId("_TTG0XgEcEeCQm6a_G2yO_w_-1435615927")]
    [Description(@"Integrated circuit card declines the transaction before or after the authorisation.")]
    CardDeclined = FailureReasonCode.CardDeclined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Online authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;NDCL&quot;.
    /// </summary>
    [EnumMember(Value = "NDCL")]
    [IsoId("_TTG0XwEcEeCQm6a_G2yO_w_501609246")]
    [Description(@"Online authorisation declined the transaction.")]
    OnLineDeclined = FailureReasonCode.OnLineDeclined, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline authorisation declined the transaction.
    /// Encoded/decoded by serializers as &quot;FDCL&quot;.
    /// </summary>
    [EnumMember(Value = "FDCL")]
    [IsoId("_TTG0YAEcEeCQm6a_G2yO_w_-981528658")]
    [Description(@"Offline authorisation declined the transaction.")]
    OfflineDeclined = FailureReasonCode.OfflineDeclined, // same ordinal as derivation source for type conversions
    
}
