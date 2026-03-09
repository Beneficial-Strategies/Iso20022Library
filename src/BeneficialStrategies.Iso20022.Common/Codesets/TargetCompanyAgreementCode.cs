// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// TSE/JASDEC extension codes for the agreement of the target company.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_fRO3QzFZEeGpgKb_ecoJPw")]
[Description(@"TSE/JASDEC extension codes for the agreement of the target company.")]
public enum TargetCompanyAgreementCode
{
    /// <summary>
    /// No agreement of the target company.
    /// Encoded/decoded by serializers as &quot;AGNO&quot;.
    /// </summary>
    [EnumMember(Value = "AGNO")]
    [IsoId("_rXO_wDFZEeGpgKb_ecoJPw")]
    [Description(@"No agreement of the target company.")]
    No,
    
    /// <summary>
    /// Agreement of the target company.
    /// Encoded/decoded by serializers as &quot;AGYS&quot;.
    /// </summary>
    [EnumMember(Value = "AGYS")]
    [IsoId("_rG1zUDFZEeGpgKb_ecoJPw")]
    [Description(@"Agreement of the target company.")]
    Yes,
    
    /// <summary>
    /// Agreement of the target company is not decided.
    /// Encoded/decoded by serializers as &quot;AGND&quot;.
    /// </summary>
    [EnumMember(Value = "AGND")]
    [IsoId("_SYM54DFaEeGpgKb_ecoJPw")]
    [Description(@"Agreement of the target company is not decided.")]
    NotDecided,
    
}
