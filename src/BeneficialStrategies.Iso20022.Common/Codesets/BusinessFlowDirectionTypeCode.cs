// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the business flow, in order to determine the role of the parties in the business process. This indicator is very important when there are multiple intermediaries in the exchange of information process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6_ikE_skEeCIi9ZETLBv8g")]
[Description(
    @"Identifies the business flow, in order to determine the role of the parties in the business process. This indicator is very important when there are multiple intermediaries in the exchange of information process."
)]
[Derivations(typeof(BusinessFlowDirectionType1Code))]
public enum BusinessFlowDirectionTypeCode
{
    /// <summary>
    /// Assets to be delivered.
    /// Encoded/decoded by serializers as &quot;ADLV&quot;.
    /// </summary>
    [EnumMember(Value = "ADLV")]
    [IsoId("_8y4J9_skEeCIi9ZETLBv8g")]
    [Description(@"Assets to be delivered.")]
    AssetstoBeDelivered,

    /// <summary>
    /// Assets to be received.
    /// Encoded/decoded by serializers as &quot;ARCV&quot;.
    /// </summary>
    [EnumMember(Value = "ARCV")]
    [IsoId("_CNy6h_slEeCIi9ZETLBv8g")]
    [Description(@"Assets to be received.")]
    AssetsToBeReceived,
}
