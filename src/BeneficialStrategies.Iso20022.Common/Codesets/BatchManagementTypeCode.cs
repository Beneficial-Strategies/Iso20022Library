// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of batch management activity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Zw7p8FAXEeedyPuM0kK2EQ")]
[Description(@"Type of batch management activity.")]
[Derivations(typeof(BatchManagementType1Code), typeof(BatchManagementType2Code))]
public enum BatchManagementTypeCode
{
    /// <summary>
    /// Acknowledgement requested by the originator to the destination (used with a notification message exclusively).
    /// Encoded/decoded by serializers as &quot;AKRQ&quot;.
    /// </summary>
    [EnumMember(Value = "AKRQ")]
    [IsoId("_d1SQMFAXEeedyPuM0kK2EQ")]
    [Description(
        @"Acknowledgement requested by the originator to the destination (used with a notification message exclusively)."
    )]
    AcknowledgementRequest,

    /// <summary>
    /// Acknowledgement response by the destination to the originator (used with a notification message exclusively).
    /// Encoded/decoded by serializers as &quot;AKRP&quot;.
    /// </summary>
    [EnumMember(Value = "AKRP")]
    [IsoId("_tIqToFAXEeedyPuM0kK2EQ")]
    [Description(
        @"Acknowledgement response by the destination to the originator (used with a notification message exclusively)."
    )]
    AcknowledgementResponse,

    /// <summary>
    /// End of a collection or batch by the originator (used with a request message exclusively).
    /// Encoded/decoded by serializers as &quot;ENDB&quot;.
    /// </summary>
    [EnumMember(Value = "ENDB")]
    [IsoId("_nGqDAFAZEeedyPuM0kK2EQ")]
    [Description(
        @"End of a collection or batch by the originator (used with a request message exclusively)."
    )]
    End,

    /// <summary>
    /// Initiation of a collection or batch by the originator (used with a request message exclusively).
    /// Encoded/decoded by serializers as &quot;STRT&quot;.
    /// </summary>
    [EnumMember(Value = "STRT")]
    [IsoId("_2CYbcFAZEeedyPuM0kK2EQ")]
    [Description(
        @"Initiation of a collection or batch by the originator (used with a request message exclusively)."
    )]
    Start,

    /// <summary>
    /// Any other type of batch management transaction defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_9_ol4FAZEeedyPuM0kK2EQ")]
    [Description(@"Any other type of batch management transaction defined at national level.")]
    OtherNational,

    /// <summary>
    /// Any other type of batch management transaction defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_GEd_AFAaEeedyPuM0kK2EQ")]
    [Description(@"Any other type of batch management transaction defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// A request to resend a batch or collection.
    /// Encoded/decoded by serializers as &quot;RERQ&quot;.
    /// </summary>
    [EnumMember(Value = "RERQ")]
    [IsoId("_mMiG8JbzEeuc6pwKtqbEVQ")]
    [Description(@"A request to resend a batch or collection.")]
    ResendRequest,

    /// <summary>
    /// Contains a list of batch or collection identifications.
    /// Encoded/decoded by serializers as &quot;IDNT&quot;.
    /// </summary>
    [EnumMember(Value = "IDNT")]
    [IsoId("_vZzu0JbzEeuc6pwKtqbEVQ")]
    [Description(@"Contains a list of batch or collection identifications.")]
    IdentificationList,
}
