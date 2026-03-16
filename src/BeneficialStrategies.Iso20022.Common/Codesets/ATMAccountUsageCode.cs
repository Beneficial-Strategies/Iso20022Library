// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of usage for an account.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ATMAccountUsageCode")]
[Description(@"Type of usage for an account.")]
public enum ATMAccountUsageCode
{
    /// <summary>
    /// Can be both the source and the destination account.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_ATMAccountUsageCode_Both")]
    [Description(@"Can be both the source and the destination account.")]
    Both,

    /// <summary>
    /// Destination account.
    /// Encoded/decoded by serializers as &quot;DSTN&quot;.
    /// </summary>
    [EnumMember(Value = "DSTN")]
    [IsoId("_ATMAccountUsageCode_Destination")]
    [Description(@"Destination account.")]
    Destination,

    /// <summary>
    /// Source account.
    /// Encoded/decoded by serializers as &quot;SRCE&quot;.
    /// </summary>
    [EnumMember(Value = "SRCE")]
    [IsoId("_ATMAccountUsageCode_Source")]
    [Description(@"Source account.")]
    Source,
}
