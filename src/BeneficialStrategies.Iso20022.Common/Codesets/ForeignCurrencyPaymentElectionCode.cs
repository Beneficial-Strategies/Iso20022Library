// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the foreign currency payment is offered.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1zjwBDL3EeKU9IrkkToqcw_-811455456")]
[Description(@"Specifies whether the foreign currency payment is offered.")]
[Derivations(typeof(ForeignCurrencyPaymentElection1Code))]
public enum ForeignCurrencyPaymentElectionCode
{
    /// <summary>
    /// Foreign currency payment is offered.
    /// Encoded/decoded by serializers as &quot;OFFD&quot;.
    /// </summary>
    [EnumMember(Value = "OFFD")]
    [IsoId("_1zjwBTL3EeKU9IrkkToqcw_-225470944")]
    [Description(@"Foreign currency payment is offered.")]
    Offered,

    /// <summary>
    /// Foreign currency payment is not offered.
    /// Encoded/decoded by serializers as &quot;NOFD&quot;.
    /// </summary>
    [EnumMember(Value = "NOFD")]
    [IsoId("_1zs58DL3EeKU9IrkkToqcw_123403253")]
    [Description(@"Foreign currency payment is not offered.")]
    NotOffered,

    /// <summary>
    /// Foreign currency payment is mandatory.
    /// Encoded/decoded by serializers as &quot;MAND&quot;.
    /// </summary>
    [EnumMember(Value = "MAND")]
    [IsoId("_1zs58TL3EeKU9IrkkToqcw_325823435")]
    [Description(@"Foreign currency payment is mandatory.")]
    Mandatory,
}
