// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the state of the agreement of the custodian record when compared to composite record.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_11V4tDL3EeKU9IrkkToqcw_-319409576")]
[Description(@"Specifies the state of the agreement of the custodian record when compared to composite record.")]
[Derivations(typeof(CustodianRecordAgreementType1Code))]
public enum CustodianRecordAgreementTypeCode
{
    /// <summary>
    /// Custodian record agrees with the composite record.
    /// Encoded/decoded by serializers as &quot;AGRE&quot;.
    /// </summary>
    [EnumMember(Value = "AGRE")]
    [IsoId("_11V4tTL3EeKU9IrkkToqcw_1633271504")]
    [Description(@"Custodian record agrees with the composite record.")]
    Agree,
    
    /// <summary>
    /// Custodian record disagrees with the composite record.
    /// Encoded/decoded by serializers as &quot;DAGR&quot;.
    /// </summary>
    [EnumMember(Value = "DAGR")]
    [IsoId("_11V4tjL3EeKU9IrkkToqcw_429712966")]
    [Description(@"Custodian record disagrees with the composite record.")]
    Disagree,
    
    /// <summary>
    /// No composite record available.
    /// Encoded/decoded by serializers as &quot;NCOP&quot;.
    /// </summary>
    [EnumMember(Value = "NCOP")]
    [IsoId("_11fpsDL3EeKU9IrkkToqcw_-729360725")]
    [Description(@"No composite record available.")]
    NoComposite,
    
}
