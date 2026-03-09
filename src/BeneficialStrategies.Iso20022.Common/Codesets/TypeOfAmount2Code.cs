// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of amount.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TUJ9OQEcEeCQm6a_G2yO_w_-249770216")]
[Description(@"Identification of the type of amount.")]
[DerivedFrom(typeof(TypeOfAmountCode))]
public enum TypeOfAmount2Code
{
    /// <summary>
    /// Cash-back amount.
    /// Encoded/decoded by serializers as &quot;CSHB&quot;.
    /// </summary>
    [EnumMember(Value = "CSHB")]
    [IsoId("_TUJ9OgEcEeCQm6a_G2yO_w_1893013307")]
    [Description(@"Cash-back amount.")]
    Cashback = TypeOfAmountCode.Cashback, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Gratuity amount.
    /// Encoded/decoded by serializers as &quot;GRTY&quot;.
    /// </summary>
    [EnumMember(Value = "GRTY")]
    [IsoId("_TUJ9OwEcEeCQm6a_G2yO_w_1009780020")]
    [Description(@"Gratuity amount.")]
    Gratuity = TypeOfAmountCode.Gratuity, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Fees.
    /// Encoded/decoded by serializers as &quot;FEES&quot;.
    /// </summary>
    [EnumMember(Value = "FEES")]
    [IsoId("_TUJ9PAEcEeCQm6a_G2yO_w_-1680238167")]
    [Description(@"Fees.")]
    Fees = TypeOfAmountCode.Fees, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Global rebate of the transaction. This amount is counted as a negative amount.
    /// Encoded/decoded by serializers as &quot;RBTS&quot;.
    /// </summary>
    [EnumMember(Value = "RBTS")]
    [IsoId("_TUJ9PQEcEeCQm6a_G2yO_w_1239804117")]
    [Description(@"Global rebate of the transaction. This amount is counted as a negative amount.")]
    Rebates = TypeOfAmountCode.Rebates, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Value added tax amount.
    /// Encoded/decoded by serializers as &quot;VATX&quot;.
    /// </summary>
    [EnumMember(Value = "VATX")]
    [IsoId("_TUJ9PgEcEeCQm6a_G2yO_w_1693891386")]
    [Description(@"Value added tax amount.")]
    ValueAddedTax = TypeOfAmountCode.ValueAddedTax, // same ordinal as derivation source for type conversions
    
}
