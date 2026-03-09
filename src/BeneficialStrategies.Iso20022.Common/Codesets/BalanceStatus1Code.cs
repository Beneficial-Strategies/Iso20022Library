// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the balance of transactions with a certain status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bkBa2Np-Ed-ak6NoX_4Aeg_1047073628")]
[Description(@"Specifies the balance of transactions with a certain status.")]
[DerivedFrom(typeof(BalanceStatusCode))]
public enum BalanceStatus1Code
{
    /// <summary>
    /// Balance corresponding to the pending transactions.
    /// Encoded/decoded by serializers as &quot;PDNG&quot;.
    /// </summary>
    [EnumMember(Value = "PDNG")]
    [IsoId("_bkLL0Np-Ed-ak6NoX_4Aeg_992302531")]
    [Description(@"Balance corresponding to the pending transactions.")]
    Pending = BalanceStatusCode.Pending, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Final status of a transaction when the associated transfer of cash has been successfully processed.
    /// Encoded/decoded by serializers as &quot;STLD&quot;.
    /// </summary>
    [EnumMember(Value = "STLD")]
    [IsoId("_bkLL0dp-Ed-ak6NoX_4Aeg_992302584")]
    [Description(@"Final status of a transaction when the associated transfer of cash has been successfully processed.")]
    Settled = BalanceStatusCode.Settled, // same ordinal as derivation source for type conversions
    
}
