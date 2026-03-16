// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the legal structure of a financial instrument as defined in the scope of European MiFID Template (EMT) reference 00060.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MDTkDQeEeifw8iDiyZLmQ")]
[Description(
    @"Specifies the legal structure of a financial instrument as defined in the scope of European MiFID Template (EMT) reference 00060."
)]
[Derivations(typeof(LegalStructureFinancialInstrument1Code))]
public enum LegalStructureFinancialInstrumentCode
{
    /// <summary>
    /// Legal structure is a structured security.
    /// Encoded/decoded by serializers as &quot;SSEC&quot;.
    /// </summary>
    [EnumMember(Value = "SSEC")]
    [IsoId("_N2fzMDQfEeifw8iDiyZLmQ")]
    [Description(@"Legal structure is a structured security.")]
    StructuredSecurity,

    /// <summary>
    /// Legal structure is a structured fund.
    /// Encoded/decoded by serializers as &quot;SFUN&quot;.
    /// </summary>
    [EnumMember(Value = "SFUN")]
    [IsoId("_QQeiUDQfEeifw8iDiyZLmQ")]
    [Description(@"Legal structure is a structured fund.")]
    StructuredFund,

    /// <summary>
    /// Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;UCIT&quot;.
    /// </summary>
    [EnumMember(Value = "UCIT")]
    [IsoId("_Tw1DoDQfEeifw8iDiyZLmQ")]
    [Description(
        @"Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS)."
    )]
    UCITS,

    /// <summary>
    /// Legal structure is a not an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;NUCI&quot;.
    /// </summary>
    [EnumMember(Value = "NUCI")]
    [IsoId("_V4Ww0DQfEeifw8iDiyZLmQ")]
    [Description(
        @"Legal structure is a not an Undertaking for Collective Investment in Transferable Securities (UCITS)."
    )]
    NonUCITS,

    /// <summary>
    /// Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS) money market fund.
    /// Encoded/decoded by serializers as &quot;UCMM&quot;.
    /// </summary>
    [EnumMember(Value = "UCMM")]
    [IsoId("_PMHN8IBgEei8Q7I_11BpAQ")]
    [Description(
        @"Legal structure is an Undertaking for Collective Investment in Transferable Securities (UCITS) money market fund."
    )]
    UCITSMoneyMarketFund,

    /// <summary>
    /// Legal structure is an exchange traded commodity.
    /// Encoded/decoded by serializers as &quot;EXTC&quot;.
    /// </summary>
    [EnumMember(Value = "EXTC")]
    [IsoId("_VkDAYIBgEei8Q7I_11BpAQ")]
    [Description(@"Legal structure is an exchange traded commodity.")]
    ExchangeTradedCommodity,

    /// <summary>
    /// Legal structure is a money market fund that is not an Undertaking for Collective Investment in Transferable Securities (UCITS).
    /// Encoded/decoded by serializers as &quot;NUMM&quot;.
    /// </summary>
    [EnumMember(Value = "NUMM")]
    [IsoId("_Eau-AIvwEeicrr-UkGlMQA")]
    [Description(
        @"Legal structure is a money market fund that is not an Undertaking for Collective Investment in Transferable Securities (UCITS)."
    )]
    NonUCITSMoneyMarketFund,
}
