// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of address.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bm2sZ9p-Ed-ak6NoX_4Aeg_-1036380604")]
[Description(@"Specifies the type of address.")]
[Derivations(typeof(AddressType2Code), typeof(AddressType1Code))]
public enum AddressTypeCode
{
    /// <summary>
    /// Address is the home address.
    /// Encoded/decoded by serializers as &quot;HOME&quot;.
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_bnAdYNp-Ed-ak6NoX_4Aeg_-921865024")]
    [Description(@"Address is the home address.")]
    Residential,

    /// <summary>
    /// Address is the business address.
    /// Encoded/decoded by serializers as &quot;BIZZ&quot;.
    /// </summary>
    [EnumMember(Value = "BIZZ")]
    [IsoId("_bnAdYdp-Ed-ak6NoX_4Aeg_-921864479")]
    [Description(@"Address is the business address.")]
    Business,

    /// <summary>
    /// Address is the complete postal address.
    /// Encoded/decoded by serializers as &quot;ADDR&quot;.
    /// </summary>
    [EnumMember(Value = "ADDR")]
    [IsoId("_bnAdYtp-Ed-ak6NoX_4Aeg_-915401727")]
    [Description(@"Address is the complete postal address.")]
    Postal,

    /// <summary>
    /// Address is a postal office (PO) box.
    /// Encoded/decoded by serializers as &quot;PBOX&quot;.
    /// </summary>
    [EnumMember(Value = "PBOX")]
    [IsoId("_bnAdY9p-Ed-ak6NoX_4Aeg_-915401692")]
    [Description(@"Address is a postal office (PO) box.")]
    POBox,

    /// <summary>
    /// Address is the address to which mail is sent.
    /// Encoded/decoded by serializers as &quot;MLTO&quot;.
    /// </summary>
    [EnumMember(Value = "MLTO")]
    [IsoId("_bnAdZNp-Ed-ak6NoX_4Aeg_-780997656")]
    [Description(@"Address is the address to which mail is sent.")]
    MailTo,

    /// <summary>
    /// Address is the address to which delivery is to take place.
    /// Encoded/decoded by serializers as &quot;DLVY&quot;.
    /// </summary>
    [EnumMember(Value = "DLVY")]
    [IsoId("_bnAdZdp-Ed-ak6NoX_4Aeg_-780076553")]
    [Description(@"Address is the address to which delivery is to take place.")]
    DeliveryTo,
}
