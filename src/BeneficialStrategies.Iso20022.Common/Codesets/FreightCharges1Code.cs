// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the arrangement as to the freight charges.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ar_modp-Ed-ak6NoX_4Aeg_-1465550015")]
[Description(@"Indicates the arrangement as to the freight charges.")]
[DerivedFrom(typeof(FreightChargesCode))]
public enum FreightCharges1Code
{
    /// <summary>
    /// Freight charges are to collect from consignee.
    /// Encoded/decoded by serializers as &quot;CLCT&quot;.
    /// </summary>
    [EnumMember(Value = "CLCT")]
    [IsoId("_ar_motp-Ed-ak6NoX_4Aeg_-1412907475")]
    [Description(@"Freight charges are to collect from consignee.")]
    Collect = FreightChargesCode.Collect, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Freight charges are paid by shipper.
    /// Encoded/decoded by serializers as &quot;PRPD&quot;.
    /// </summary>
    [EnumMember(Value = "PRPD")]
    [IsoId("_ar_mo9p-Ed-ak6NoX_4Aeg_-1412907458")]
    [Description(@"Freight charges are paid by shipper.")]
    Prepaid = FreightChargesCode.Prepaid, // same ordinal as derivation source for type conversions
    
}
