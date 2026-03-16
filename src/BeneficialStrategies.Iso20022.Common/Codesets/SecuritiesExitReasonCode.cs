// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for DTC (The Depository Trust Company) to exit the shares.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_10TW4DL3EeKU9IrkkToqcw_111370307")]
[Description(@"Specifies the reason for DTC (The Depository Trust Company) to exit the shares.")]
[Derivations(typeof(SecuritiesExitReason1Code))]
public enum SecuritiesExitReasonCode
{
    /// <summary>
    /// Shares are restricted.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_10TW4TL3EeKU9IrkkToqcw_-297324899")]
    [Description(@"Shares are restricted.")]
    Restricted,

    /// <summary>
    /// Shares are non transferable.
    /// Encoded/decoded by serializers as &quot;NTRN&quot;.
    /// </summary>
    [EnumMember(Value = "NTRN")]
    [IsoId("_10TW4jL3EeKU9IrkkToqcw_-471335363")]
    [Description(@"Shares are non transferable.")]
    NonTransferable,

    /// <summary>
    /// Other reason.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_10TW4zL3EeKU9IrkkToqcw_849534733")]
    [Description(@"Other reason.")]
    Other,
}
