// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of tax identification number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gK6fQAhJEeSUPbC7DbLJpQ")]
[Description(@"Specifies the type of tax identification number.")]
[DerivedFrom(typeof(TaxIdentificationNumberTypeCode))]
public enum TaxIdentificationNumberType1Code
{
    /// <summary>
    /// Global intermediary tax identification number.
    /// Encoded/decoded by serializers as &quot;GIIN&quot;.
    /// </summary>
    [EnumMember(Value = "GIIN")]
    [IsoId("_i_F3EQhJEeSUPbC7DbLJpQ")]
    [Description(@"Global intermediary tax identification number.")]
    GlobalIntermediaryIdentificationNumber = TaxIdentificationNumberTypeCode.GlobalIntermediaryIdentificationNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Tax identification number.
    /// Encoded/decoded by serializers as &quot;GTIN&quot;.
    /// </summary>
    [EnumMember(Value = "GTIN")]
    [IsoId("_jIUEgQhJEeSUPbC7DbLJpQ")]
    [Description(@"Tax identification number.")]
    TaxIdentificationNumber = TaxIdentificationNumberTypeCode.TaxIdentificationNumber, // same ordinal as derivation source for type conversions
    
}
