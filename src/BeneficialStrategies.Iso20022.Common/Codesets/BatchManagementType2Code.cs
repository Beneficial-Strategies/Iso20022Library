// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of batch management activity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EEiRcJb0Eeuc6pwKtqbEVQ")]
[Description(@"Type of batch management activity.")]
[DerivedFrom(typeof(BatchManagementTypeCode))]
public enum BatchManagementType2Code
{
    /// <summary>
    /// Acknowledgement requested by the originator to the destination (used with a notification message exclusively).
    /// Encoded/decoded by serializers as &quot;AKRQ&quot;.
    /// </summary>
    [EnumMember(Value = "AKRQ")]
    [IsoId("_HTuKQJb0Eeuc6pwKtqbEVQ")]
    [Description(@"Acknowledgement requested by the originator to the destination (used with a notification message exclusively).")]
    AcknowledgementRequest = BatchManagementTypeCode.AcknowledgementRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Acknowledgement response by the destination to the originator (used with a notification message exclusively).
    /// Encoded/decoded by serializers as &quot;AKRP&quot;.
    /// </summary>
    [EnumMember(Value = "AKRP")]
    [IsoId("_HeiTIZb0Eeuc6pwKtqbEVQ")]
    [Description(@"Acknowledgement response by the destination to the originator (used with a notification message exclusively).")]
    AcknowledgementResponse = BatchManagementTypeCode.AcknowledgementResponse, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// End of a collection or batch by the originator (used with a request message exclusively).
    /// Encoded/decoded by serializers as &quot;ENDB&quot;.
    /// </summary>
    [EnumMember(Value = "ENDB")]
    [IsoId("_HmFFkZb0Eeuc6pwKtqbEVQ")]
    [Description(@"End of a collection or batch by the originator (used with a request message exclusively).")]
    End = BatchManagementTypeCode.End, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Contains a list of batch or collection identifications.
    /// Encoded/decoded by serializers as &quot;IDNT&quot;.
    /// </summary>
    [EnumMember(Value = "IDNT")]
    [IsoId("_Htc44Zb0Eeuc6pwKtqbEVQ")]
    [Description(@"Contains a list of batch or collection identifications.")]
    IdentificationList = BatchManagementTypeCode.IdentificationList, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any other type of batch management transaction defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_H0RSkZb0Eeuc6pwKtqbEVQ")]
    [Description(@"Any other type of batch management transaction defined at national level.")]
    OtherNational = BatchManagementTypeCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Any other type of batch management transaction defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_H8W3kZb0Eeuc6pwKtqbEVQ")]
    [Description(@"Any other type of batch management transaction defined at private level.")]
    OtherPrivate = BatchManagementTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A request to resend a batch or collection.
    /// Encoded/decoded by serializers as &quot;RERQ&quot;.
    /// </summary>
    [EnumMember(Value = "RERQ")]
    [IsoId("_IEVu4Zb0Eeuc6pwKtqbEVQ")]
    [Description(@"A request to resend a batch or collection.")]
    ResendRequest = BatchManagementTypeCode.ResendRequest, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Initiation of a collection or batch by the originator (used with a request message exclusively).
    /// Encoded/decoded by serializers as &quot;STRT&quot;.
    /// </summary>
    [EnumMember(Value = "STRT")]
    [IsoId("_ILNL4Zb0Eeuc6pwKtqbEVQ")]
    [Description(@"Initiation of a collection or batch by the originator (used with a request message exclusively).")]
    Start = BatchManagementTypeCode.Start, // same ordinal as derivation source for type conversions
    
}
