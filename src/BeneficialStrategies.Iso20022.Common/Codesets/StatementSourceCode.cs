// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the source of the report.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_m5XidfNBEeCuA5Tr22BnwA_665404846")]
[Description(@"Specifies the source of the report.")]
[Derivations(typeof(StatementSource1Code))]
public enum StatementSourceCode
{
    /// <summary>
    /// Accounting.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_m5hTcPNBEeCuA5Tr22BnwA_699577492")]
    [Description(@"Accounting.")]
    Accounting,

    /// <summary>
    /// Custody.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_m5hTcfNBEeCuA5Tr22BnwA_710657512")]
    [Description(@"Custody.")]
    Custody,
}
