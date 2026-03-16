// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the status of the confirmation acknowledgement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JyV3kHOxEeSG-OV0nXMl5w")]
[Description(@"Identifies the status of the confirmation acknowledgement.")]
[DerivedFrom(typeof(AffirmStatusCode))]
public enum AffirmStatus1Code
{
    /// <summary>
    /// Notfies that the trade confimation was conpleted.
    /// Encoded/decoded by serializers as &quot;ATCN&quot;.
    /// </summary>
    [EnumMember(Value = "ATCN")]
    [IsoId("_Nub5sXOxEeSG-OV0nXMl5w")]
    [Description(@"Notfies that the trade confimation was conpleted.")]
    AckToConfirmCompleteNotification = AffirmStatusCode.AckToConfirmCompleteNotification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Notfies the clearing status changed.
    /// Encoded/decoded by serializers as &quot;ATSC&quot;.
    /// </summary>
    [EnumMember(Value = "ATSC")]
    [IsoId("_N0344XOxEeSG-OV0nXMl5w")]
    [Description(@"Notfies the clearing status changed.")]
    AckToSettlementStateChanged = AffirmStatusCode.AckToSettlementStateChanged, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data was successfully matched.
    /// Encoded/decoded by serializers as &quot;COMP&quot;.
    /// </summary>
    [EnumMember(Value = "COMP")]
    [IsoId("_N7VGMXOxEeSG-OV0nXMl5w")]
    [Description(@"Data was successfully matched.")]
    Compared = AffirmStatusCode.Compared, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data was mismatched.
    /// Encoded/decoded by serializers as &quot;MISM&quot;.
    /// </summary>
    [EnumMember(Value = "MISM")]
    [IsoId("_OBfYkXOxEeSG-OV0nXMl5w")]
    [Description(@"Data was mismatched.")]
    MisMatched = AffirmStatusCode.MisMatched, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Model has errors.
    /// Encoded/decoded by serializers as &quot;MISE&quot;.
    /// </summary>
    [EnumMember(Value = "MISE")]
    [IsoId("_OHzb8XOxEeSG-OV0nXMl5w")]
    [Description(@"Model has errors.")]
    ModeError = AffirmStatusCode.ModeError, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Have no trading permissions.
    /// Encoded/decoded by serializers as &quot;NOTP&quot;.
    /// </summary>
    [EnumMember(Value = "NOTP")]
    [IsoId("_OOAxoXOxEeSG-OV0nXMl5w")]
    [Description(@"Have no trading permissions.")]
    NoTradingPrivilege = AffirmStatusCode.NoTradingPrivilege, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Query time was out of range.
    /// Encoded/decoded by serializers as &quot;OUOR&quot;.
    /// </summary>
    [EnumMember(Value = "OUOR")]
    [IsoId("_OUS_0XOxEeSG-OV0nXMl5w")]
    [Description(@"Query time was out of range.")]
    OutOfRange = AffirmStatusCode.OutOfRange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Query time was over system service time.
    /// Encoded/decoded by serializers as &quot;OUOS&quot;.
    /// </summary>
    [EnumMember(Value = "OUOS")]
    [IsoId("_OaqGgXOxEeSG-OV0nXMl5w")]
    [Description(@"Query time was over system service time.")]
    OutOfService = AffirmStatusCode.OutOfService, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Format of upload data was right, and system receives successfully.
    /// Encoded/decoded by serializers as &quot;RECE&quot;.
    /// </summary>
    [EnumMember(Value = "RECE")]
    [IsoId("_OhAmIXOxEeSG-OV0nXMl5w")]
    [Description(@"Format of upload data was right, and system receives successfully.")]
    Received = AffirmStatusCode.Received, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Format of upload data was wrong, and system receives unsuccessfully.
    /// Encoded/decoded by serializers as &quot;UNRE&quot;.
    /// </summary>
    [EnumMember(Value = "UNRE")]
    [IsoId("_OnPxAXOxEeSG-OV0nXMl5w")]
    [Description(@"Format of upload data was wrong, and system receives unsuccessfully.")]
    Unreceived = AffirmStatusCode.Unreceived, // same ordinal as derivation source for type conversions
}
