// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Description of the nature of execution booking process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aytSp9p-Ed-ak6NoX_4Aeg_335336066")]
[Description(@"Description of the nature of execution booking process.")]
[Derivations(typeof(DayBookingInstruction1Code))]
public enum DayBookingInstructionCode
{
    /// <summary>
    /// Can trigger booking without reference to the order initiator.
    /// Encoded/decoded by serializers as &quot;AUTO&quot;.
    /// </summary>
    [EnumMember(Value = "AUTO")]
    [IsoId("_ay2ckNp-Ed-ak6NoX_4Aeg_335336067")]
    [Description(@"Can trigger booking without reference to the order initiator.")]
    Auto,

    /// <summary>
    /// Speak with order initiator before booking.
    /// Encoded/decoded by serializers as &quot;TALK&quot;.
    /// </summary>
    [EnumMember(Value = "TALK")]
    [IsoId("_ay2ckdp-Ed-ak6NoX_4Aeg_335336068")]
    [Description(@"Speak with order initiator before booking.")]
    SpeakFirst,
}
