// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the legal constraint on the power of attorney.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aHytYdp-Ed-ak6NoX_4Aeg_-1168571799")]
[Description(@"Indicates the legal constraint on the power of attorney.")]
[Derivations(typeof(PowerOfAttorneyLegalisation1Code))]
public enum PowerOfAttorneyLegalisationCode
{
    /// <summary>
    /// Indicates that the power of attorney must be legalised by a notary.
    /// Encoded/decoded by serializers as &quot;NOTA&quot;.
    /// </summary>
    [EnumMember(Value = "NOTA")]
    [IsoId("_aHytYtp-Ed-ak6NoX_4Aeg_-1070679660")]
    [Description(@"Indicates that the power of attorney must be legalised by a notary.")]
    Notary,
    
    /// <summary>
    /// Indicates that the power of attorney must be legalised by a local authority.
    /// Encoded/decoded by serializers as &quot;LOCA&quot;.
    /// </summary>
    [EnumMember(Value = "LOCA")]
    [IsoId("_aHytY9p-Ed-ak6NoX_4Aeg_-999567985")]
    [Description(@"Indicates that the power of attorney must be legalised by a local authority.")]
    LocalAuthority,
    
    /// <summary>
    /// Indicates that the power of attorney must be legalised by a legal officer.
    /// Encoded/decoded by serializers as &quot;APOS&quot;.
    /// </summary>
    [EnumMember(Value = "APOS")]
    [IsoId("_aHytZNp-Ed-ak6NoX_4Aeg_-685567932")]
    [Description(@"Indicates that the power of attorney must be legalised by a legal officer.")]
    Apostilled,
    
    /// <summary>
    /// Indicates that the power of attorney must be legalised by a consular officer.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_aHytZdp-Ed-ak6NoX_4Aeg_-621848373")]
    [Description(@"Indicates that the power of attorney must be legalised by a consular officer.")]
    Consularized,
    
}
