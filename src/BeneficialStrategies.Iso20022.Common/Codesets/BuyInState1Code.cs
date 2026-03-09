// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of the buy-in transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_pvXjAJwVEeqtp-LOti013g")]
[Description(@"Specifies the state of the buy-in transaction.")]
[DerivedFrom(typeof(BuyInStateCode))]
public enum BuyInState1Code
{
    /// <summary>
    /// Buy-in was partially successful.
    /// Encoded/decoded by serializers as &quot;BSSP&quot;.
    /// </summary>
    [EnumMember(Value = "BSSP")]
    [IsoId("_q9Bo8ZwVEeqtp-LOti013g")]
    [Description(@"Buy-in was partially successful.")]
    PartiallySuccessful = BuyInStateCode.PartiallySuccessful, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Buy-in was successful.
    /// Encoded/decoded by serializers as &quot;BSSY&quot;.
    /// </summary>
    [EnumMember(Value = "BSSY")]
    [IsoId("_rBfSMZwVEeqtp-LOti013g")]
    [Description(@"Buy-in was successful.")]
    Successful = BuyInStateCode.Successful, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Buy-in was unsuccessful.
    /// Encoded/decoded by serializers as &quot;BSSN&quot;.
    /// </summary>
    [EnumMember(Value = "BSSN")]
    [IsoId("_rF87cZwVEeqtp-LOti013g")]
    [Description(@"Buy-in was unsuccessful.")]
    Unsuccesssful = BuyInStateCode.Unsuccesssful, // same ordinal as derivation source for type conversions
    
}
