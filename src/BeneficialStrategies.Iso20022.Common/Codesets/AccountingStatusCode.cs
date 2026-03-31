// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the accounting status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Kl0T0CDEEeWPMvNwVtiMsA")]
[Description(@"Specifies the accounting status.")]
[Derivations(typeof(AccountingStatus1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AccountingStatusCode>))]
#endif
public enum AccountingStatusCode
{
    /// <summary>
    /// Account or party is regarded as domestic for reporting purposes.
    /// Encoded/decoded by serializers as &quot;YDOM&quot;.
    /// </summary>
    [EnumMember(Value = "YDOM")]
    [IsoId("_RfFRsCDEEeWPMvNwVtiMsA")]
    [Description(@"Account or party is regarded as domestic for reporting purposes.")]
    Domestic,

    /// <summary>
    /// Account or party is not regarded as domestic for reporting purposes.
    /// Encoded/decoded by serializers as &quot;NDOM&quot;.
    /// </summary>
    [EnumMember(Value = "NDOM")]
    [IsoId("_Y8DZkCDEEeWPMvNwVtiMsA")]
    [Description(@"Account or party is not regarded as domestic for reporting purposes.")]
    NotDomestic,
}
