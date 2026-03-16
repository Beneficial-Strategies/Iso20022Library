// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the accounting status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_d8OH0CDEEeWPMvNwVtiMsA")]
[Description(@"Specifies the accounting status.")]
[DerivedFrom(typeof(AccountingStatusCode))]
public enum AccountingStatus1Code
{
    /// <summary>
    /// Account or party is regarded as domestic for reporting purposes.
    /// Encoded/decoded by serializers as &quot;YDOM&quot;.
    /// </summary>
    [EnumMember(Value = "YDOM")]
    [IsoId("_gQQnASDEEeWPMvNwVtiMsA")]
    [Description(@"Account or party is regarded as domestic for reporting purposes.")]
    Domestic = AccountingStatusCode.Domestic, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account or party is not regarded as domestic for reporting purposes.
    /// Encoded/decoded by serializers as &quot;NDOM&quot;.
    /// </summary>
    [EnumMember(Value = "NDOM")]
    [IsoId("_gahWQSDEEeWPMvNwVtiMsA")]
    [Description(@"Account or party is not regarded as domestic for reporting purposes.")]
    NotDomestic = AccountingStatusCode.NotDomestic, // same ordinal as derivation source for type conversions
}
