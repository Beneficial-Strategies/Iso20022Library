// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of Know Your Customer (KYC) or anti-money laundering due diligence to which the investor has been subjected.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4-CwIBRxEeOKWo1NF21OVw")]
[Description(@"Specifies the type of Know Your Customer (KYC) or anti-money laundering due diligence to which the investor has been subjected.")]
[DerivedFrom(typeof(KnowYourCustomerCheckTypeCode))]
public enum KnowYourCustomerCheckType1Code
{
    /// <summary>
    /// Enhanced check, typically carried out on accounts that are considered high risk.
    /// Encoded/decoded by serializers as &quot;ENHA&quot;.
    /// </summary>
    [EnumMember(Value = "ENHA")]
    [IsoId("_965EoRRxEeOKWo1NF21OVw")]
    [Description(@"Enhanced check, typically carried out on accounts that are considered high risk.")]
    Enhanced = KnowYourCustomerCheckTypeCode.Enhanced, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Ordinary check, typically carried out on standard accounts.
    /// Encoded/decoded by serializers as &quot;ORDN&quot;.
    /// </summary>
    [EnumMember(Value = "ORDN")]
    [IsoId("_-CrHoRRxEeOKWo1NF21OVw")]
    [Description(@"Ordinary check, typically carried out on standard accounts.")]
    Ordinary = KnowYourCustomerCheckTypeCode.Ordinary, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Simple check, typically carried out on accounts that have a low risk of anti-money laundering, such as an account owned by a financial institution.
    /// Encoded/decoded by serializers as &quot;SIMP&quot;.
    /// </summary>
    [EnumMember(Value = "SIMP")]
    [IsoId("_-KhcERRxEeOKWo1NF21OVw")]
    [Description(@"Simple check, typically carried out on accounts that have a low risk of anti-money laundering, such as an account owned by a financial institution.")]
    Simple = KnowYourCustomerCheckTypeCode.Simple, // same ordinal as derivation source for type conversions
    
}
