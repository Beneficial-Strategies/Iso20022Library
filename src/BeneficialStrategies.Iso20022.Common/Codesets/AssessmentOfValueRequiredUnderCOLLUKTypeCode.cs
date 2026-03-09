// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies if assessment of value is required under UK Collective Investment Schemes. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 09040.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vpn44CuUEe6GGqp7D_oKtA")]
[Description(@"Specifies if assessment of value is required under UK Collective Investment Schemes. When used in reference to MiFID, this is in the scope of the European MiFID Template (EMT) reference 09040.")]
[Derivations(typeof(AssessmentOfValueRequiredUnderCOLLUKType1Code))]
public enum AssessmentOfValueRequiredUnderCOLLUKTypeCode
{
    /// <summary>
    /// Assessement of value is not required.
    /// Encoded/decoded by serializers as &quot;NSCO&quot;.
    /// </summary>
    [EnumMember(Value = "NSCO")]
    [IsoId("")]
    [Description(@"Assessement of value is not required.")]
    No,

    /// <summary>
    /// Assessement of value is required.
    /// Encoded/decoded by serializers as &quot;YSCO&quot;.
    /// </summary>
    [EnumMember(Value = "YSCO")]
    [IsoId("")]
    [Description(@"Assessement of value is required.")]
    Yes,

}
