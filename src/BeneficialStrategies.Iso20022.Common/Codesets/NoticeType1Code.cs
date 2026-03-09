// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined notice type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1tTXBDL3EeKU9IrkkToqcw_-228468236")]
[Description(@"Specifies DTCC (The Depository Trust and Clearing Corporation) defined notice type.")]
[DerivedFrom(typeof(NoticeTypeCode))]
public enum NoticeType1Code
{
    /// <summary>
    /// Notice is universal.
    /// Encoded/decoded by serializers as &quot;UNVL&quot;.
    /// </summary>
    [EnumMember(Value = "UNVL")]
    [IsoId("_1tTXBTL3EeKU9IrkkToqcw_1909543367")]
    [Description(@"Notice is universal.")]
    Universal = NoticeTypeCode.Universal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Notice is specific to the securities registered in DTC&apos;s (The Depository Trust Company) nominee name.
    /// Encoded/decoded by serializers as &quot;CEDE&quot;.
    /// </summary>
    [EnumMember(Value = "CEDE")]
    [IsoId("_1tcg8DL3EeKU9IrkkToqcw_-2060306422")]
    [Description(@"Notice is specific to the securities registered in DTC's (The Depository Trust Company) nominee name.")]
    CedeAndCo = NoticeTypeCode.CedeAndCo, // same ordinal as derivation source for type conversions
    
}
