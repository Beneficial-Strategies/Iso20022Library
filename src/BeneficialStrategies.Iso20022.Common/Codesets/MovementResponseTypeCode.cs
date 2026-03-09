// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of movement response to be returned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_jQ9Wgu5NEeCisYr99QEiWA_1302753990")]
[Description(@"Specifies the type of movement response to be returned.")]
[Derivations(typeof(MovementResponseType1Code))]
public enum MovementResponseTypeCode
{
    /// <summary>
    /// Response will include full details on the movements reported.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_jQ9Wg-5NEeCisYr99QEiWA_1188914924")]
    [Description(@"Response will include full details on the movements reported.")]
    Full,
    
    /// <summary>
    /// Response will include limited details including the status on the movements reported.
    /// Encoded/decoded by serializers as &quot;STTS&quot;.
    /// </summary>
    [EnumMember(Value = "STTS")]
    [IsoId("_jRGgcO5NEeCisYr99QEiWA_483800309")]
    [Description(@"Response will include limited details including the status on the movements reported.")]
    Status,
    
}
