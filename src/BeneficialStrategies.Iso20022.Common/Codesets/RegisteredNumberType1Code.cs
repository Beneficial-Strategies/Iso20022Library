// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code values for the registered number type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8GB9MFf7EeOuDtoQo1qilA")]
[Description(@"Code values for the registered number type.")]
[DerivedFrom(typeof(RegisteredNumberTypeCode))]
public enum RegisteredNumberType1Code
{
    /// <summary>
    /// Australian Business Number (ABN) is a single identifier for use in business dealings with the Australian Taxation Office (ATO) and with other government agencies.
    /// Encoded/decoded by serializers as &quot;ABN&quot;.
    /// </summary>
    [EnumMember(Value = "ABN")]
    [IsoId("_9Y56UVf7EeOuDtoQo1qilA")]
    [Description(@"Australian Business Number (ABN) is a single identifier for use in business dealings with the Australian Taxation Office (ATO) and with other government agencies.")]
    AustralianBusinessNumber = RegisteredNumberTypeCode.AustralianBusinessNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Number identifying a company, issued by the Australian Securities &amp; Investments Commission (ASIC) upon registration.
    /// Encoded/decoded by serializers as &quot;ACN&quot;.
    /// </summary>
    [EnumMember(Value = "ACN")]
    [IsoId("_9eQUYVf7EeOuDtoQo1qilA")]
    [Description(@"Number identifying a company, issued by the Australian Securities & Investments Commission (ASIC) upon registration.")]
    AustralianCompanyNumber = RegisteredNumberTypeCode.AustralianCompanyNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ARBNs are issued to registrable Australian bodies and foreign companies. The ARBN is a unique identifier and no two bodies can have the same ARBN.
    /// Encoded/decoded by serializers as &quot;ARBN&quot;.
    /// </summary>
    [EnumMember(Value = "ARBN")]
    [IsoId("_9lGjQVf7EeOuDtoQo1qilA")]
    [Description(@"ARBNs are issued to registrable Australian bodies and foreign companies. The ARBN is a unique identifier and no two bodies can have the same ARBN.")]
    AustralianRegisteredBodyNumber = RegisteredNumberTypeCode.AustralianRegisteredBodyNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// ARSNs are issued to Managed Investment Schemes. The ARSN is a unique identifier and no two bodies can have the same ARSN.
    /// Encoded/decoded by serializers as &quot;ARSN&quot;.
    /// </summary>
    [EnumMember(Value = "ARSN")]
    [IsoId("_9r8LEVf7EeOuDtoQo1qilA")]
    [Description(@"ARSNs are issued to Managed Investment Schemes. The ARSN is a unique identifier and no two bodies can have the same ARSN.")]
    AustralianRegisteredSchemeNumber = RegisteredNumberTypeCode.AustralianRegisteredSchemeNumber, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other registered number type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_9xJbMVf7EeOuDtoQo1qilA")]
    [Description(@"Other registered number type.")]
    Other = RegisteredNumberTypeCode.Other, // same ordinal as derivation source for type conversions
    
}
