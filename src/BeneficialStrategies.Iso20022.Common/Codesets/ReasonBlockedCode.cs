// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies information about blocked accounts.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cbTnMC15EeKmpfjBm48yhA_159709836")]
[Description(@"Specifies information about blocked accounts.")]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ReasonBlockedCode>))]
#endif
public enum ReasonBlockedCode
{
    /// <summary>
    /// Account is part of a bankruptcy action.
    /// Encoded/decoded by serializers as &quot;BKRP&quot;.
    /// </summary>
    [EnumMember(Value = "BKRP")]
    [IsoId("_cbdYMC15EeKmpfjBm48yhA_-383720373")]
    [Description(@"Account is part of a bankruptcy action.")]
    Bankruptcy,

    /// <summary>
    /// Account has been given as a warranty.
    /// Encoded/decoded by serializers as &quot;CMNT&quot;.
    /// </summary>
    [EnumMember(Value = "CMNT")]
    [IsoId("_cbdYMS15EeKmpfjBm48yhA_1396499968")]
    [Description(@"Account has been given as a warranty.")]
    Commitment,

    /// <summary>
    /// Account is confiscated.
    /// Encoded/decoded by serializers as &quot;CNFS&quot;.
    /// </summary>
    [EnumMember(Value = "CNFS")]
    [IsoId("_cbdYMi15EeKmpfjBm48yhA_812451577")]
    [Description(@"Account is confiscated.")]
    Confiscation,

    /// <summary>
    /// Account is reserved in contemplation of death.
    /// Encoded/decoded by serializers as &quot;MORT&quot;.
    /// </summary>
    [EnumMember(Value = "MORT")]
    [IsoId("_cbdYMy15EeKmpfjBm48yhA_1444597890")]
    [Description(@"Account is reserved in contemplation of death.")]
    MortisCausa,

    /// <summary>
    /// Account has been given as pledge.
    /// Encoded/decoded by serializers as &quot;PLDG&quot;.
    /// </summary>
    [EnumMember(Value = "PLDG")]
    [IsoId("_cbdYNC15EeKmpfjBm48yhA_873594713")]
    [Description(@"Account has been given as pledge.")]
    Pledged,

    /// <summary>
    /// Account is being reregistered.
    /// Encoded/decoded by serializers as &quot;TRPE&quot;.
    /// </summary>
    [EnumMember(Value = "TRPE")]
    [IsoId("_cbdYNS15EeKmpfjBm48yhA_-1577796035")]
    [Description(@"Account is being reregistered.")]
    Reregistration,

    /// <summary>
    /// Account is being transferred.
    /// Encoded/decoded by serializers as &quot;TRNF&quot;.
    /// </summary>
    [EnumMember(Value = "TRNF")]
    [IsoId("_cbmiIC15EeKmpfjBm48yhA_69837250")]
    [Description(@"Account is being transferred.")]
    Transfer,
}
