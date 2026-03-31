// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the legal framework of the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ad115dp-Ed-ak6NoX_4Aeg_-859807356")]
[Description(@"Identifies the legal framework of the transaction.")]
[Derivations(typeof(LegalFramework1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LegalFrameworkCode>))]
#endif
public enum LegalFrameworkCode
{
    /// <summary>
    /// Relates to the French legal framework for repos, that is, relates to a &quot;Pension Livrée&quot;.
    /// Encoded/decoded by serializers as &quot;FRAN&quot;.
    /// </summary>
    [EnumMember(Value = "FRAN")]
    [IsoId("_ad115tp-Ed-ak6NoX_4Aeg_-806240527")]
    [Description(
        @"Relates to the French legal framework for repos, that is, relates to a ""Pension Livrée""."
    )]
    PensionLivree,

    /// <summary>
    /// Relates to the European legal framework for alternative investment fund.
    /// Encoded/decoded by serializers as &quot;AIFD&quot;.
    /// </summary>
    [EnumMember(Value = "AIFD")]
    [IsoId("_3d2MAOQvEeiDdp3LLDFTEQ")]
    [Description(@"Relates to the European legal framework for alternative investment fund.")]
    AlternativeInvestmentFund,

    /// <summary>
    /// Relates to the European legal framework for undertakings for collective investment in transferable securities.
    /// Encoded/decoded by serializers as &quot;UCIT&quot;.
    /// </summary>
    [EnumMember(Value = "UCIT")]
    [IsoId("_PJ6YsOQwEeiDdp3LLDFTEQ")]
    [Description(
        @"Relates to the European legal framework for undertakings for collective investment in transferable securities."
    )]
    UndertakingsForCollectiveInvestmentInTransferableSecurities,

    /// <summary>
    /// Relates to the European legal framework for european social entrepreneurship funds.
    /// Encoded/decoded by serializers as &quot;ESEF&quot;.
    /// </summary>
    [EnumMember(Value = "ESEF")]
    [IsoId("_Z8vHcJ6BEeutguKEfOuVZA")]
    [Description(
        @"Relates to the European legal framework for european social entrepreneurship funds."
    )]
    EuropeanSocialEntrepreneurshipFunds,

    /// <summary>
    /// Relates to the European legal framework for european venture capital funds.
    /// Encoded/decoded by serializers as &quot;EVCA&quot;.
    /// </summary>
    [EnumMember(Value = "EVCA")]
    [IsoId("_pV-iUJ6BEeutguKEfOuVZA")]
    [Description(@"Relates to the European legal framework for european venture capital funds.")]
    EuropeanVentureCapitalFunds,

    /// <summary>
    /// Relates to the European legal framework for european long-term investment funds.
    /// Encoded/decoded by serializers as &quot;LTIF&quot;.
    /// </summary>
    [EnumMember(Value = "LTIF")]
    [IsoId("_Ev_AYJ6CEeutguKEfOuVZA")]
    [Description(
        @"Relates to the European legal framework for european long-term investment funds."
    )]
    EuropeanLong_termInvestmentFunds,
}
