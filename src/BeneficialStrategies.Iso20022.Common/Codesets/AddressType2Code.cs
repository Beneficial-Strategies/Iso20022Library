// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of address.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bm2sYNp-Ed-ak6NoX_4Aeg_595056355")]
[Description(@"Specifies the type of address.")]
[DerivedFrom(typeof(AddressTypeCode))]
public enum AddressType2Code
{
    /// <summary>
    /// Address is the complete postal address.
    /// Encoded/decoded by serializers as &quot;ADDR&quot;.
    /// </summary>
    [EnumMember(Value = "ADDR")]
    [IsoId("_bm2sYdp-Ed-ak6NoX_4Aeg_878577717")]
    [Description(@"Address is the complete postal address.")]
    Postal = AddressTypeCode.Postal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Address is a postal office (PO) box.
    /// Encoded/decoded by serializers as &quot;PBOX&quot;.
    /// </summary>
    [EnumMember(Value = "PBOX")]
    [IsoId("_bm2sYtp-Ed-ak6NoX_4Aeg_878578132")]
    [Description(@"Address is a postal office (PO) box.")]
    POBox = AddressTypeCode.POBox, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Address is the home address.
    /// Encoded/decoded by serializers as &quot;HOME&quot;.
    /// </summary>
    [EnumMember(Value = "HOME")]
    [IsoId("_bm2sY9p-Ed-ak6NoX_4Aeg_2106193409")]
    [Description(@"Address is the home address.")]
    Residential = AddressTypeCode.Residential, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Address is the business address.
    /// Encoded/decoded by serializers as &quot;BIZZ&quot;.
    /// </summary>
    [EnumMember(Value = "BIZZ")]
    [IsoId("_bm2sZNp-Ed-ak6NoX_4Aeg_2106193529")]
    [Description(@"Address is the business address.")]
    Business = AddressTypeCode.Business, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Address is the address to which mail is sent.
    /// Encoded/decoded by serializers as &quot;MLTO&quot;.
    /// </summary>
    [EnumMember(Value = "MLTO")]
    [IsoId("_bm2sZdp-Ed-ak6NoX_4Aeg_2106193606")]
    [Description(@"Address is the address to which mail is sent.")]
    MailTo = AddressTypeCode.MailTo, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Address is the address to which delivery is to take place.
    /// Encoded/decoded by serializers as &quot;DLVY&quot;.
    /// </summary>
    [EnumMember(Value = "DLVY")]
    [IsoId("_bm2sZtp-Ed-ak6NoX_4Aeg_2106193624")]
    [Description(@"Address is the address to which delivery is to take place.")]
    DeliveryTo = AddressTypeCode.DeliveryTo, // same ordinal as derivation source for type conversions
    
}
