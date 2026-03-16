// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of a counterparty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_eGrH8B3dEeWTa7N6lo4ufA")]
[Description(@"Specifies the nature of a counterparty.")]
[DerivedFrom(typeof(PartyNatureTypeCode))]
public enum PartyNatureType1Code
{
    /// <summary>
    /// Other type of issuer.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ge0rER3dEeWTa7N6lo4ufA")]
    [Description(@"Other type of issuer.")]
    Other = PartyNatureTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer is a non-financial institution.
    /// Encoded/decoded by serializers as &quot;NFIN&quot;.
    /// </summary>
    [EnumMember(Value = "NFIN")]
    [IsoId("_gts0kR3dEeWTa7N6lo4ufA")]
    [Description(@"Issuer is a non-financial institution.")]
    NonFinancialInstitution = PartyNatureTypeCode.NonFinancialInstitution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer is a financial institution.
    /// Encoded/decoded by serializers as &quot;FIIN&quot;.
    /// </summary>
    [EnumMember(Value = "FIIN")]
    [IsoId("_gyBT4R3dEeWTa7N6lo4ufA")]
    [Description(@"Issuer is a financial institution.")]
    FinancialInstitution = PartyNatureTypeCode.FinancialInstitution, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Issuer is a central counterparty.
    /// Encoded/decoded by serializers as &quot;CCPS&quot;.
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_hBMYUR3dEeWTa7N6lo4ufA")]
    [Description(@"Issuer is a central counterparty.")]
    CentralCounterparty = PartyNatureTypeCode.CentralCounterparty, // same ordinal as derivation source for type conversions
}
