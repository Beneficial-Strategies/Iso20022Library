// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Party that communicate with a POI component (Point of Interaction), using a communication device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cUMkAAyHEeKa_56Jbsi1RQ")]
[Description(
    @"Party that communicate with a POI component (Point of Interaction), using a communication device."
)]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType7Code
{
    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_ncXyUQyHEeKa_56Jbsi1RQ")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_ovcjwQyHEeKa_56Jbsi1RQ")]
    [Description(
        @"Party acting on behalf of other parties to process or forward data to other parties."
    )]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party component of a POI system or POI terminal (Point of Interaction).
    /// Encoded/decoded by serializers as &quot;PCPT&quot;.
    /// </summary>
    [EnumMember(Value = "PCPT")]
    [IsoId("_p-bfYQyHEeKa_56Jbsi1RQ")]
    [Description(@"Party component of a POI system or POI terminal (Point of Interaction).")]
    POIComponent = PartyTypeCode.POIComponent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Responsible for one or several maintenance functions of a card payment acceptance terminal.
    /// Encoded/decoded by serializers as &quot;TMGT&quot;.
    /// </summary>
    [EnumMember(Value = "TMGT")]
    [IsoId("_qo1HQQyHEeKa_56Jbsi1RQ")]
    [Description(
        @"Responsible for one or several maintenance functions of a card payment acceptance terminal."
    )]
    TerminalManager = PartyTypeCode.TerminalManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party selling goods and services.
    /// Encoded/decoded by serializers as &quot;SALE&quot;.
    /// </summary>
    [EnumMember(Value = "SALE")]
    [IsoId("_r5bzgQyHEeKa_56Jbsi1RQ")]
    [Description(@"Party selling goods and services.")]
    SaleSystem = PartyTypeCode.SaleSystem, // same ordinal as derivation source for type conversions
}
