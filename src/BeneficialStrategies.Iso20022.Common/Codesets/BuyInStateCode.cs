// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of the buy-in transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_FentwJwVEeqtp-LOti013g")]
[Description(@"Specifies the state of the buy-in transaction.")]
[Derivations(typeof(BuyInState1Code))]
public enum BuyInStateCode
{
    /// <summary>
    /// Buy-in was successful.
    /// Encoded/decoded by serializers as &quot;BSSY&quot;.
    /// </summary>
    [EnumMember(Value = "BSSY")]
    [IsoId("_bHt9IJwVEeqtp-LOti013g")]
    [Description(@"Buy-in was successful.")]
    Successful,

    /// <summary>
    /// Buy-in was unsuccessful.
    /// Encoded/decoded by serializers as &quot;BSSN&quot;.
    /// </summary>
    [EnumMember(Value = "BSSN")]
    [IsoId("_bOt9AJwVEeqtp-LOti013g")]
    [Description(@"Buy-in was unsuccessful.")]
    Unsuccesssful,

    /// <summary>
    /// Buy-in was partially successful.
    /// Encoded/decoded by serializers as &quot;BSSP&quot;.
    /// </summary>
    [EnumMember(Value = "BSSP")]
    [IsoId("_bUEXEJwVEeqtp-LOti013g")]
    [Description(@"Buy-in was partially successful.")]
    PartiallySuccessful,
}
