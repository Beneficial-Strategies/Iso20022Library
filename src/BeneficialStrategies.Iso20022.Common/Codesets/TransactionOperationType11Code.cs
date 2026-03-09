// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the transaction operation action type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7UXS0E2XEe2bQ-Ksk8mwQg")]
[Description(@"Specifies the transaction operation action type.")]
[DerivedFrom(typeof(TransactionOperationTypeV2Code))]
public enum TransactionOperationType11Code
{
    /// <summary>
    /// Transaction corrects errors in a previously sent transaction.
    /// Encoded/decoded by serializers as &quot;CORR&quot;.
    /// </summary>
    [EnumMember(Value = "CORR")]
    [IsoId("_AHVSkU2YEe2bQ-Ksk8mwQg")]
    [Description(@"Transaction corrects errors in a previously sent transaction.")]
    Correction = TransactionOperationTypeV2Code.Correction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Indicates the report of the collateral data or of their modifications, but not the corrections of the previously reported collateral details.
    /// Encoded/decoded by serializers as &quot;MARU&quot;.
    /// </summary>
    [EnumMember(Value = "MARU")]
    [IsoId("_A3-sYU2YEe2bQ-Ksk8mwQg")]
    [Description(@"Indicates the report of the collateral data or of their modifications, but not the corrections of the previously reported collateral details.")]
    MarginUpdate = TransactionOperationTypeV2Code.MarginUpdate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Transaction is a new transaction.
    /// Encoded/decoded by serializers as &quot;NEWT&quot;.
    /// </summary>
    [EnumMember(Value = "NEWT")]
    [IsoId("_BjAmYU2YEe2bQ-Ksk8mwQg")]
    [Description(@"Transaction is a new transaction.")]
    NewTransaction = TransactionOperationTypeV2Code.NewTransaction, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake or a cancellation of duplicate report.
    /// Encoded/decoded by serializers as &quot;EROR&quot;.
    /// </summary>
    [EnumMember(Value = "EROR")]
    [IsoId("_LmjDUWW_Ee2JluottcAG9w")]
    [Description(@"Cancellation of a wrongly submitted entire report in case the contract never came into existence or was not subject to regulatory reporting requirements but was reported to a regulatory authority by mistake or a cancellation of duplicate report.")]
    Error = TransactionOperationTypeV2Code.Error, // same ordinal as derivation source for type conversions
    
}
