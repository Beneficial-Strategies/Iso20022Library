// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Know Your Customer (KYC) or anti-money laundering due diligence to which the investor has been subjected.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_WNjzwRRxEeOKWo1NF21OVw")]
[Description(@"Specifies the type of Know Your Customer (KYC) or anti-money laundering due diligence to which the investor has been subjected.")]
[Derivations(typeof(KnowYourCustomerCheckType1Code))]
public enum KnowYourCustomerCheckTypeCode
{
    /// <summary>
    /// Ordinary check, typically carried out on standard accounts.
    /// Encoded/decoded by serializers as &quot;ORDN&quot;.
    /// </summary>
    [EnumMember(Value = "ORDN")]
    [IsoId("_pgZWYBRxEeOKWo1NF21OVw")]
    [Description(@"Ordinary check, typically carried out on standard accounts.")]
    Ordinary,
    
    /// <summary>
    /// Simple check, typically carried out on accounts that have a low risk of anti-money laundering, such as an account owned by a financial institution.
    /// Encoded/decoded by serializers as &quot;SIMP&quot;.
    /// </summary>
    [EnumMember(Value = "SIMP")]
    [IsoId("_pkaTsBRxEeOKWo1NF21OVw")]
    [Description(@"Simple check, typically carried out on accounts that have a low risk of anti-money laundering, such as an account owned by a financial institution.")]
    Simple,
    
    /// <summary>
    /// Enhanced check, typically carried out on accounts that are considered high risk.
    /// Encoded/decoded by serializers as &quot;ENHA&quot;.
    /// </summary>
    [EnumMember(Value = "ENHA")]
    [IsoId("_po388BRxEeOKWo1NF21OVw")]
    [Description(@"Enhanced check, typically carried out on accounts that are considered high risk.")]
    Enhanced,
    
}
