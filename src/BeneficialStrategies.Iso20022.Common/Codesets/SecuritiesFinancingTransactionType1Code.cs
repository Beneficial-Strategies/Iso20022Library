// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of securities financing transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZFoFwdp-Ed-ak6NoX_4Aeg_-1035743681")]
[Description(@"Specifies the type of securities financing transaction.")]
[DerivedFrom(typeof(SecuritiesTransactionTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecuritiesFinancingTransactionType1Code>))]
#endif
public enum SecuritiesFinancingTransactionType1Code
{
    /// <summary>
    /// Relates to a repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;REPU&quot;.
    /// </summary>
    [EnumMember(Value = "REPU")]
    [IsoId("_ZFoFwtp-Ed-ak6NoX_4Aeg_-738371349")]
    [Description(@"Relates to a repurchase agreement transaction.")]
    Repo = SecuritiesTransactionTypeV2Code.Repo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a reverse repurchase agreement transaction.
    /// Encoded/decoded by serializers as &quot;RVPO&quot;.
    /// </summary>
    [EnumMember(Value = "RVPO")]
    [IsoId("_ZFoFw9p-Ed-ak6NoX_4Aeg_-738371331")]
    [Description(@"Relates to a reverse repurchase agreement transaction.")]
    ReverseRepo = SecuritiesTransactionTypeV2Code.ReverseRepo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a securities borrowing operation.
    /// Encoded/decoded by serializers as &quot;SECB&quot;.
    /// </summary>
    [EnumMember(Value = "SECB")]
    [IsoId("_ZFoFxNp-Ed-ak6NoX_4Aeg_-738371296")]
    [Description(@"Relates to a securities borrowing operation.")]
    SecuritiesBorrowing = SecuritiesTransactionTypeV2Code.SecuritiesBorrowing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relates to a securities lending operation.
    /// Encoded/decoded by serializers as &quot;SECL&quot;.
    /// </summary>
    [EnumMember(Value = "SECL")]
    [IsoId("_ZFoFxdp-Ed-ak6NoX_4Aeg_-738371271")]
    [Description(@"Relates to a securities lending operation.")]
    SecuritiesLending = SecuritiesTransactionTypeV2Code.SecuritiesLending, // same ordinal as derivation source for type conversions
}
