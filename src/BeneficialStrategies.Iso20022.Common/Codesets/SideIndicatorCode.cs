// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// To indicate either the reference for the Central Counterparty (CCP) leg or the reference for the client leg of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uQQC4y5SEeK7-OZOLIksSw")]
[Description(
    @"To indicate either the reference for the Central Counterparty (CCP) leg or the reference for the client leg of the transaction."
)]
[Derivations(typeof(SideIndicator1Code))]
public enum SideIndicatorCode
{
    /// <summary>
    /// Clearing broker identification is for the client leg.
    /// Encoded/decoded by serializers as &quot;CLNT&quot;.
    /// </summary>
    [EnumMember(Value = "CLNT")]
    [IsoId("_7nCd0C5SEeK7-OZOLIksSw")]
    [Description(@"Clearing broker identification is for the client leg.")]
    ClientLeg,

    /// <summary>
    /// Clearing broker identification is for the Central Counterparty (CCP) leg.
    /// Encoded/decoded by serializers as &quot;CCPL&quot;.
    /// </summary>
    [EnumMember(Value = "CCPL")]
    [IsoId("_DcQGkC5TEeK7-OZOLIksSw")]
    [Description(@"Clearing broker identification is for the Central Counterparty (CCP) leg.")]
    CCPLeg,
}
