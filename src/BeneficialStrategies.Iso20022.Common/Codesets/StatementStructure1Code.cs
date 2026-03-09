// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of balances on which the statement is prepared.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQD0Jtp-Ed-ak6NoX_4Aeg_-1907403556")]
[Description(@"Specifies the type of balances on which the statement is prepared.")]
[DerivedFrom(typeof(StatementStructureCode))]
public enum StatementStructure1Code
{
    /// <summary>
    /// Statement is sorted by status.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_ZQD0J9p-Ed-ak6NoX_4Aeg_-1906483117")]
    [Description(@"Statement is sorted by status.")]
    Statuses = StatementStructureCode.Statuses, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Statement is sorted by transaction.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZQD0KNp-Ed-ak6NoX_4Aeg_-1906483092")]
    [Description(@"Statement is sorted by transaction.")]
    Transactions = StatementStructureCode.Transactions, // same ordinal as derivation source for type conversions
    
}
