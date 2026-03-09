// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the statement is an accounting or a custody statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZF7Atdp-Ed-ak6NoX_4Aeg_-1780504534")]
[Description(@"Specifies whether the statement is an accounting or a custody statement.")]
[Derivations(typeof(SecuritiesStatementType1Code))]
public enum SecuritiesStatementTypeCode
{
    /// <summary>
    /// Statement is a custody statement.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_ZF7Attp-Ed-ak6NoX_4Aeg_-1780504515")]
    [Description(@"Statement is a custody statement.")]
    Custody,
    
    /// <summary>
    /// Statement is an accounting statement.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_ZF7At9p-Ed-ak6NoX_4Aeg_-1780504491")]
    [Description(@"Statement is an accounting statement.")]
    Accounting,
    
}
