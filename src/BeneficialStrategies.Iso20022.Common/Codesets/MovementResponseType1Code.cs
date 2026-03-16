// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of movement response to be returned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jQzlhe5NEeCisYr99QEiWA_-503094567")]
[Description(@"Specifies the type of movement response to be returned.")]
[DerivedFrom(typeof(MovementResponseTypeCode))]
public enum MovementResponseType1Code
{
    /// <summary>
    /// Response will include full details on the movements reported.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_jQ9WgO5NEeCisYr99QEiWA_-739401767")]
    [Description(@"Response will include full details on the movements reported.")]
    Full = MovementResponseTypeCode.Full, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Response will include limited details including the status on the movements reported.
    /// Encoded/decoded by serializers as &quot;STTS&quot;.
    /// </summary>
    [EnumMember(Value = "STTS")]
    [IsoId("_jQ9Wge5NEeCisYr99QEiWA_424690481")]
    [Description(
        @"Response will include limited details including the status on the movements reported."
    )]
    Status = MovementResponseTypeCode.Status, // same ordinal as derivation source for type conversions
}
