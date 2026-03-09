// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of governance process.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_EFRD0ID5Eeiw-daIkkmMqQ")]
[Description(@"Specifies a type of governance process.")]
[Derivations(typeof(GovernanceProcessType1Code))]
public enum GovernanceProcessTypeCode
{
    /// <summary>
    /// Product governance procedure is pursuant to MiFID II.
    /// Encoded/decoded by serializers as &quot;AMIF&quot;.
    /// </summary>
    [EnumMember(Value = "AMIF")]
    [IsoId("_RLTtAID5Eeiw-daIkkmMqQ")]
    [Description(@"Product governance procedure is pursuant to MiFID II.")]
    PursuantMiFID,
    
    /// <summary>
    /// Product governance procedure is comparable to MiFID II.
    /// Encoded/decoded by serializers as &quot;BMIF&quot;.
    /// </summary>
    [EnumMember(Value = "BMIF")]
    [IsoId("_XyRZ8ID5Eeiw-daIkkmMqQ")]
    [Description(@"Product governance procedure is comparable to MiFID II.")]
    ComparibleMiFID,
    
    /// <summary>
    /// Product governance procedure is not in accordance with MiFID II.
    /// Encoded/decoded by serializers as &quot;CMIF&quot;.
    /// </summary>
    [EnumMember(Value = "CMIF")]
    [IsoId("_ZZhEkID5Eeiw-daIkkmMqQ")]
    [Description(@"Product governance procedure is not in accordance with MiFID II.")]
    NotMiFID,
    
    /// <summary>
    /// No information is requested from the issuer.
    /// Encoded/decoded by serializers as &quot;NINF&quot;.
    /// </summary>
    [EnumMember(Value = "NINF")]
    [IsoId("_bK4UgID5Eeiw-daIkkmMqQ")]
    [Description(@"No information is requested from the issuer.")]
    NoInformation,
    
}
