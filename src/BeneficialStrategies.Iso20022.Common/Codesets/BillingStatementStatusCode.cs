// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Defines the status of the billing statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6VUE1pqlEeGSON8vddiWzQ_861577519")]
[Description(@"Defines the status of the billing statement.")]
[Derivations(typeof(BillingStatementStatus1Code))]
public enum BillingStatementStatusCode
{
    /// <summary>
    /// Statement is the original statement.
    /// Encoded/decoded by serializers as &quot;ORGN&quot;.
    /// </summary>
    [EnumMember(Value = "ORGN")]
    [IsoId("_6VUE15qlEeGSON8vddiWzQ_25393892")]
    [Description(@"Statement is the original statement.")]
    Original,

    /// <summary>
    /// Statement replaces the original statement.
    /// Encoded/decoded by serializers as &quot;RPLC&quot;.
    /// </summary>
    [EnumMember(Value = "RPLC")]
    [IsoId("_6Vd10JqlEeGSON8vddiWzQ_1981252080")]
    [Description(@"Statement replaces the original statement.")]
    Replace,

    /// <summary>
    /// Statement is a test statement.
    /// Encoded/decoded by serializers as &quot;TEST&quot;.
    /// </summary>
    [EnumMember(Value = "TEST")]
    [IsoId("_6Vd10ZqlEeGSON8vddiWzQ_612239661")]
    [Description(@"Statement is a test statement.")]
    Test,
}
