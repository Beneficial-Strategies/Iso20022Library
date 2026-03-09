// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Consent type in the context of the General Protection Regulation (GDPR) 2016/679 regulation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aN8PUJTTEemC09f0MxYkRg")]
[Description(@"Consent type in the context of the General Protection Regulation (GDPR) 2016/679 regulation.")]
[Derivations(typeof(GDPRDataConsent1Code))]
public enum GDPRDataConsentCode
{
    /// <summary>
    /// Consent to authorise the controller of personal data processing to process personal data for marketing purposes.
    /// Encoded/decoded by serializers as &quot;DP00&quot;.
    /// </summary>
    [EnumMember(Value = "DP00")]
    [IsoId("_jLKpAJTTEemC09f0MxYkRg")]
    [Description(@"Consent to authorise the controller of personal data processing to process personal data for marketing purposes.")]
    ConsentMarketing,
    
    /// <summary>
    /// Consent to authorise the controller of personal data processing to transfer personal data to other companies belonging to the same group for independent processing for marketing purposes.
    /// Encoded/decoded by serializers as &quot;DP01&quot;.
    /// </summary>
    [EnumMember(Value = "DP01")]
    [IsoId("_CRy34JTWEemC09f0MxYkRg")]
    [Description(@"Consent to authorise the controller of personal data processing to transfer personal data to other companies belonging to the same group for independent processing for marketing purposes.")]
    ConsentTransferSameMarketing,
    
    /// <summary>
    /// Consent to authorise the controller of personal data processing to transfer personal data to third party companies for independent processing for marketing purposes.
    /// Encoded/decoded by serializers as &quot;DP02&quot;.
    /// </summary>
    [EnumMember(Value = "DP02")]
    [IsoId("_E15MUJTWEemC09f0MxYkRg")]
    [Description(@"Consent to authorise the controller of personal data processing to transfer personal data to third party companies for independent processing for marketing purposes.")]
    ConsentTransferThirdPartyMarketing,
    
    /// <summary>
    /// Consent to authorise the controller of personal data processing to process personal data for profiling purposes in order to formulate customised and targeted product and service offers.
    /// Encoded/decoded by serializers as &quot;DP03&quot;.
    /// </summary>
    [EnumMember(Value = "DP03")]
    [IsoId("_FJ-l8JTWEemC09f0MxYkRg")]
    [Description(@"Consent to authorise the controller of personal data processing to process personal data for profiling purposes in order to formulate customised and targeted product and service offers.")]
    ConsentProfilingTargeted,
    
}
