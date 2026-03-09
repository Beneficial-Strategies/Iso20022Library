// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the party responsible for the liability.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uQbcgCDMEeWPMvNwVtiMsA")]
[Description(@"Specifies the party responsible for the liability.")]
[Derivations(typeof(Liability1Code))]
public enum LiabilityCode
{
    /// <summary>
    /// Investor is responsible.
    /// Encoded/decoded by serializers as &quot;INVE&quot;.
    /// </summary>
    [EnumMember(Value = "INVE")]
    [IsoId("_1MIqYCDMEeWPMvNwVtiMsA")]
    [Description(@"Investor is responsible.")]
    Investor,
    
    /// <summary>
    /// Investor is not assumed responsibile.
    /// Encoded/decoded by serializers as &quot;NINV&quot;.
    /// </summary>
    [EnumMember(Value = "NINV")]
    [IsoId("_7hUDwCDMEeWPMvNwVtiMsA")]
    [Description(@"Investor is not assumed responsibile.")]
    NotInvestor,
    
    /// <summary>
    /// Broker is responsible.
    /// Encoded/decoded by serializers as &quot;BROK&quot;.
    /// </summary>
    [EnumMember(Value = "BROK")]
    [IsoId("_9TbU4Da1EeWxoIK_IhudJg")]
    [Description(@"Broker is responsible.")]
    Broker,
    
}
