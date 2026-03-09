// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the statement is an accounting or a custody statement.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZF7Astp-Ed-ak6NoX_4Aeg_-1354761740")]
[Description(@"Specifies whether the statement is an accounting or a custody statement.")]
[DerivedFrom(typeof(SecuritiesStatementTypeCode))]
public enum SecuritiesStatementType1Code
{
    /// <summary>
    /// Statement is a custody statement.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_ZF7As9p-Ed-ak6NoX_4Aeg_-1354761291")]
    [Description(@"Statement is a custody statement.")]
    Custody = SecuritiesStatementTypeCode.Custody, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Statement is an accounting statement.
    /// Encoded/decoded by serializers as &quot;ACCT&quot;.
    /// </summary>
    [EnumMember(Value = "ACCT")]
    [IsoId("_ZF7AtNp-Ed-ak6NoX_4Aeg_-1354760395")]
    [Description(@"Statement is an accounting statement.")]
    Accounting = SecuritiesStatementTypeCode.Accounting, // same ordinal as derivation source for type conversions
    
}
