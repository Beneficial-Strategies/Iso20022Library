// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of balances on which the statement is prepared.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZQM-ENp-Ed-ak6NoX_4Aeg_1615497688")]
[Description(@"Specifies the type of balances on which the statement is prepared.")]
[Derivations(typeof(StatementStructure1Code))]
public enum StatementStructureCode
{
    /// <summary>
    /// Statement is sorted by status.
    /// Encoded/decoded by serializers as &quot;STAT&quot;.
    /// </summary>
    [EnumMember(Value = "STAT")]
    [IsoId("_ZQM-Edp-Ed-ak6NoX_4Aeg_1615497706")]
    [Description(@"Statement is sorted by status.")]
    Statuses,

    /// <summary>
    /// Statement is sorted by transaction.
    /// Encoded/decoded by serializers as &quot;TRAN&quot;.
    /// </summary>
    [EnumMember(Value = "TRAN")]
    [IsoId("_ZQM-Etp-Ed-ak6NoX_4Aeg_1615497971")]
    [Description(@"Statement is sorted by transaction.")]
    Transactions,
}
