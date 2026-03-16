// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if the value for money section is filled in the current EMT posting.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EMTDataReportingVFMUKTypeCode")]
[Description(@"Specifies if the value for money section is filled in the current EMT posting.")]
public enum EMTDataReportingVFMUKTypeCode
{
    /// <summary>
    /// Value for money data is being provided.
    /// Encoded/decoded by serializers as &quot;YSCO&quot;.
    /// </summary>
    [EnumMember(Value = "YSCO")]
    [IsoId("_EMTDataReportingVFMUKTypeCode_Yes")]
    [Description(@"Value for money data is being provided.")]
    Yes,

}
