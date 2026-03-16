// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// To indicate either the reference for the Central Counterparty (CCP) leg or the reference for the client leg of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_R6yMsC5TEeK7-OZOLIksSw")]
[Description(
    @"To indicate either the reference for the Central Counterparty (CCP) leg or the reference for the client leg of the transaction."
)]
[DerivedFrom(typeof(SideIndicatorCode))]
public enum SideIndicator1Code
{
    /// <summary>
    /// Clearing broker identification is for the Central Counterparty (CCP) leg.
    /// Encoded/decoded by serializers as &quot;CCPL&quot;.
    /// </summary>
    [EnumMember(Value = "CCPL")]
    [IsoId("__vvtsS5UEeKwTrPDLMbLxA")]
    [Description(@"Clearing broker identification is for the Central Counterparty (CCP) leg.")]
    CCPLeg = SideIndicatorCode.CCPLeg, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clearing broker identification is for the client leg.
    /// Encoded/decoded by serializers as &quot;CLNT&quot;.
    /// </summary>
    [EnumMember(Value = "CLNT")]
    [IsoId("__z2xoS5UEeKwTrPDLMbLxA")]
    [Description(@"Clearing broker identification is for the client leg.")]
    ClientLeg = SideIndicatorCode.ClientLeg, // same ordinal as derivation source for type conversions
}
