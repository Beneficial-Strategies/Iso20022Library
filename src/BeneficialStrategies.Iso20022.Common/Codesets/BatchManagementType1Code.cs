// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of batch management activity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_PHzAsFAaEeedyPuM0kK2EQ")]
[Description(@"Type of batch management activity.")]
[DerivedFrom(typeof(BatchManagementTypeCode))]
public enum BatchManagementType1Code
{
    /// <summary>
    /// Acknowledgement requested by the originator to the destination (used with a notification message exclusively).
    /// Encoded/decoded by serializers as &quot;AKRQ&quot;.
    /// </summary>
    [EnumMember(Value = "AKRQ")]
    [IsoId("_UGUJIVAaEeedyPuM0kK2EQ")]
    [Description(
        @"Acknowledgement requested by the originator to the destination (used with a notification message exclusively)."
    )]
    AcknowledgementRequest = BatchManagementTypeCode.AcknowledgementRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Acknowledgement response by the destination to the originator (used with a notification message exclusively).
    /// Encoded/decoded by serializers as &quot;AKRP&quot;.
    /// </summary>
    [EnumMember(Value = "AKRP")]
    [IsoId("_UYKuIlAaEeedyPuM0kK2EQ")]
    [Description(
        @"Acknowledgement response by the destination to the originator (used with a notification message exclusively)."
    )]
    AcknowledgementResponse = BatchManagementTypeCode.AcknowledgementResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// End of a collection or batch by the originator (used with a request message exclusively).
    /// Encoded/decoded by serializers as &quot;ENDB&quot;.
    /// </summary>
    [EnumMember(Value = "ENDB")]
    [IsoId("_Uk0DAlAaEeedyPuM0kK2EQ")]
    [Description(
        @"End of a collection or batch by the originator (used with a request message exclusively)."
    )]
    End = BatchManagementTypeCode.End, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any other type of batch management transaction defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_UxKc8lAaEeedyPuM0kK2EQ")]
    [Description(@"Any other type of batch management transaction defined at national level.")]
    OtherNational = BatchManagementTypeCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any other type of batch management transaction defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_VDne4lAaEeedyPuM0kK2EQ")]
    [Description(@"Any other type of batch management transaction defined at private level.")]
    OtherPrivate = BatchManagementTypeCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Initiation of a collection or batch by the originator (used with a request message exclusively).
    /// Encoded/decoded by serializers as &quot;STRT&quot;.
    /// </summary>
    [EnumMember(Value = "STRT")]
    [IsoId("_VQZ9slAaEeedyPuM0kK2EQ")]
    [Description(
        @"Initiation of a collection or batch by the originator (used with a request message exclusively)."
    )]
    Start = BatchManagementTypeCode.Start, // same ordinal as derivation source for type conversions
}
