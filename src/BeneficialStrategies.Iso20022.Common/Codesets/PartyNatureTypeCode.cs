// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the nature of a counterparty.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ei1oQc2IEeS6sY79p-9Zxw")]
[Description(@"Specifies the nature of a counterparty.")]
[Derivations(typeof(PartyNatureType1Code))]
public enum PartyNatureTypeCode
{
    /// <summary>
    /// Issuer is a financial institution.
    /// Encoded/decoded by serializers as &quot;FIIN&quot;.
    /// </summary>
    [EnumMember(Value = "FIIN")]
    [IsoId("_gkuAcM2IEeS6sY79p-9Zxw")]
    [Description(@"Issuer is a financial institution.")]
    FinancialInstitution,

    /// <summary>
    /// Issuer is a non-financial institution.
    /// Encoded/decoded by serializers as &quot;NFIN&quot;.
    /// </summary>
    [EnumMember(Value = "NFIN")]
    [IsoId("_oiP3sM2IEeS6sY79p-9Zxw")]
    [Description(@"Issuer is a non-financial institution.")]
    NonFinancialInstitution,

    /// <summary>
    /// Issuer is a central counterparty.
    /// Encoded/decoded by serializers as &quot;CCPS&quot;.
    /// </summary>
    [EnumMember(Value = "CCPS")]
    [IsoId("_X_ZnsB3dEeWTa7N6lo4ufA")]
    [Description(@"Issuer is a central counterparty.")]
    CentralCounterparty,

    /// <summary>
    /// Other type of issuer.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_bZM1EB3dEeWTa7N6lo4ufA")]
    [Description(@"Other type of issuer.")]
    Other,
}
