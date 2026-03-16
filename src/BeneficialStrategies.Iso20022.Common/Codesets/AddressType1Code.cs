// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of address.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bmtiddp-Ed-ak6NoX_4Aeg_1664808083")]
[Description(@"Specifies the type of address.")]
[DerivedFrom(typeof(AddressTypeCode))]
public enum AddressType1Code
{
    /// <summary>
    /// Address is the home address.
    /// Encoded/decoded by serializers as &quot;HOME&quot;.
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_bmtidtp-Ed-ak6NoX_4Aeg_-1758352550")]
    [Description(@"Address is the home address.")]
    Residential = AddressTypeCode.Residential, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Address is the business address.
    /// Encoded/decoded by serializers as &quot;BIZZ&quot;.
    /// </summary>
    [EnumMember(Value = "BIZZ")]
    [IsoId("_bmtid9p-Ed-ak6NoX_4Aeg_-1742653638")]
    [Description(@"Address is the business address.")]
    Business = AddressTypeCode.Business, // same ordinal as derivation source for type conversions
}
