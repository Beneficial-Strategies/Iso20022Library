// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of payment system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_a7fbNdp-Ed-ak6NoX_4Aeg_-1434318267")]
[Description(@"Specifies a type of payment system.")]
public enum CashSystemTypeCode
{
    /// <summary>
    /// Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis.
    /// Encoded/decoded by serializers as &quot;ACHS&quot;.
    /// </summary>
    [EnumMember(Value = "ACHS")]
    [IsoId("_a7fbNtp-Ed-ak6NoX_4Aeg_-1434318266")]
    [Description(@"Automated Clearing House. Payment system that clears cash transfers and settles the proceeds in a lump sum, usually on a multilateral netting basis.")]
    ACH,
    
    /// <summary>
    /// Payment system that clears physical or truncated cheques and settles the proceeds in a lump sum, usually on a multilateral netting basis.
    /// Encoded/decoded by serializers as &quot;CHCL&quot;.
    /// </summary>
    [EnumMember(Value = "CHCL")]
    [IsoId("_a7fbN9p-Ed-ak6NoX_4Aeg_-1434318265")]
    [Description(@"Payment system that clears physical or truncated cheques and settles the proceeds in a lump sum, usually on a multilateral netting basis.")]
    ChequeClearing,
    
    /// <summary>
    /// Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money.
    /// Encoded/decoded by serializers as &quot;RTGS&quot;.
    /// </summary>
    [EnumMember(Value = "RTGS")]
    [IsoId("_a7fbONp-Ed-ak6NoX_4Aeg_-1434318264")]
    [Description(@"Real Time Gross Settlement System. Payment system that simultaneously clears individual transfers and settles them in central bank money.")]
    RTGS,
    
}
