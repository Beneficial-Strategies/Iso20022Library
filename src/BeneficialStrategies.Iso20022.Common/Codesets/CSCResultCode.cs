// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Result of the printed CSC (Card Security Code) validation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWrswwEcEeCQm6a_G2yO_w_-323244249")]
[Description(@"Result of the printed CSC (Card Security Code) validation.")]
[Derivations(typeof(CSCResult1Code))]
public enum CSCResultCode
{
    /// <summary>
    /// Card security code match.
    /// Encoded/decoded by serializers as &quot;CMCH&quot;.
    /// </summary>
    [EnumMember(Value = "CMCH")]
    [IsoId("_TWrsxAEcEeCQm6a_G2yO_w_-2043310910")]
    [Description(@"Card security code match.")]
    CSCMatch,
    
    /// <summary>
    /// No card security code match.
    /// Encoded/decoded by serializers as &quot;CNMH&quot;.
    /// </summary>
    [EnumMember(Value = "CNMH")]
    [IsoId("_TWrsxQEcEeCQm6a_G2yO_w_-905692296")]
    [Description(@"No card security code match.")]
    CSCNoMatch,
    
    /// <summary>
    /// Card security code not processed for technical reason.
    /// Encoded/decoded by serializers as &quot;CNMT&quot;.
    /// </summary>
    [EnumMember(Value = "CNMT")]
    [IsoId("_TWrsxgEcEeCQm6a_G2yO_w_1950993781")]
    [Description(@"Card security code not processed for technical reason.")]
    CSCTechnical,
    
    /// <summary>
    /// Card security code not processed for non-technical reason.
    /// Encoded/decoded by serializers as &quot;CNMO&quot;.
    /// </summary>
    [EnumMember(Value = "CNMO")]
    [IsoId("_TWrsxwEcEeCQm6a_G2yO_w_1234780389")]
    [Description(@"Card security code not processed for non-technical reason.")]
    CSCNotTechnical,
    
    /// <summary>
    /// Card security code missing in request.
    /// Encoded/decoded by serializers as &quot;CMSS&quot;.
    /// </summary>
    [EnumMember(Value = "CMSS")]
    [IsoId("_TWrsyAEcEeCQm6a_G2yO_w_-764077692")]
    [Description(@"Card security code missing in request.")]
    CSCMissing,
    
    /// <summary>
    /// Card security code not used by issuer.
    /// Encoded/decoded by serializers as &quot;CNUS&quot;.
    /// </summary>
    [EnumMember(Value = "CNUS")]
    [IsoId("_TWrsyQEcEeCQm6a_G2yO_w_690703299")]
    [Description(@"Card security code not used by issuer.")]
    CSCNotUsed,
    
}
