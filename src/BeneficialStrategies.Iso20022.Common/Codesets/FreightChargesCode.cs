// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the arrangement as to the freight charges.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ar_mpNp-Ed-ak6NoX_4Aeg_-1147157283")]
[Description(@"Indicates the arrangement as to the freight charges.")]
[Derivations(typeof(FreightCharges1Code))]
public enum FreightChargesCode
{
    /// <summary>
    /// Freight charges are to collect from consignee.
    /// Encoded/decoded by serializers as &quot;CLCT&quot;.
    /// </summary>
    [EnumMember(Value = "CLCT")]
    [IsoId("_ar_mpdp-Ed-ak6NoX_4Aeg_-915354796")]
    [Description(@"Freight charges are to collect from consignee.")]
    Collect,
    
    /// <summary>
    /// Freight charges are paid by shipper.
    /// Encoded/decoded by serializers as &quot;PRPD&quot;.
    /// </summary>
    [EnumMember(Value = "PRPD")]
    [IsoId("_ar_mptp-Ed-ak6NoX_4Aeg_-799916141")]
    [Description(@"Freight charges are paid by shipper.")]
    Prepaid,
    
}
