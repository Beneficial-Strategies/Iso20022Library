// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZbPJYtp-Ed-ak6NoX_4Aeg_44026870")]
[Description(@"Identifies whether the regulatory reporting information applies to the debit side, to the credit side or to both debit and credit sides of the transaction.")]
[Derivations(typeof(RegulatoryReportingType1Code))]
public enum RegulatoryReportingTypeCode
{
    /// <summary>
    /// Regulatory information applies to the credit side.
    /// Encoded/decoded by serializers as &quot;CRED&quot;.
    /// </summary>
    [EnumMember(Value = "CRED")]
    [IsoId("_ZbPJY9p-Ed-ak6NoX_4Aeg_314621931")]
    [Description(@"Regulatory information applies to the credit side.")]
    Credit,
    
    /// <summary>
    /// Regulatory information applies to the debit side.
    /// Encoded/decoded by serializers as &quot;DEBT&quot;.
    /// </summary>
    [EnumMember(Value = "DEBT")]
    [IsoId("_ZbPJZNp-Ed-ak6NoX_4Aeg_413436419")]
    [Description(@"Regulatory information applies to the debit side.")]
    Debit,
    
    /// <summary>
    /// Regulatory information applies to both credit and debit sides.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_ZbPJZdp-Ed-ak6NoX_4Aeg_-1707234472")]
    [Description(@"Regulatory information applies to both credit and debit sides.")]
    Both,
    
}
