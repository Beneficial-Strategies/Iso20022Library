// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external type of party code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-MYPFW7iEeKo25nLKvGr8w_-77531611")]
[Description(
    @"Specifies the external type of party code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalTypeOfParty1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalTypeOfPartyCode>))]
#endif
public enum ExternalTypeOfPartyCode
{
    /// <summary>
    /// Party advising the undertaking.
    /// Encoded/decoded by serializers as &quot;ADVP&quot;.
    /// </summary>
    [EnumMember(Value = "ADVP")]
    [IsoId("_uQCDGfRYEeuLhpyIdtJzwg")]
    [Description(@"Party advising the undertaking.")]
    AdvisingParty,

    /// <summary>
    /// Any bank.
    /// Encoded/decoded by serializers as &quot;ANYB&quot;.
    /// </summary>
    [EnumMember(Value = "ANYB")]
    [IsoId("_uQCDHPRYEeuLhpyIdtJzwg")]
    [Description(@"Any bank.")]
    AnyBank,

    /// <summary>
    /// Party named in the undertaking as the “applicant”.
    /// Encoded/decoded by serializers as &quot;APPL&quot;.
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_uQL0EPRYEeuLhpyIdtJzwg")]
    [Description(@"Party named in the undertaking as the “applicant”. ")]
    Applicant,

    /// <summary>
    /// Party in whose favour the undertaking (or counter-undertaking) is issued.
    /// Encoded/decoded by serializers as &quot;BENE&quot;.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_uQL0E_RYEeuLhpyIdtJzwg")]
    [Description(@"Party in whose favour the undertaking (or counter-undertaking) is issued.")]
    Beneficiary,

    /// <summary>
    /// Party that adds its undertaking to honour the undertaking.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uQL0FvRYEeuLhpyIdtJzwg")]
    [Description(@"Party that adds its undertaking to honour the undertaking.")]
    ConfirmationParty,

    /// <summary>
    /// Beneficiary of the second counter-undertaking.
    /// Encoded/decoded by serializers as &quot;CUB2&quot;.
    /// </summary>
    [EnumMember(Value = "CUB2")]
    [IsoId("_uQL0GfRYEeuLhpyIdtJzwg")]
    [Description(@"Beneficiary of the second counter-undertaking.")]
    SecondCounterUndertakingBeneficiary,

    /// <summary>
    /// Beneficiary of the third counter-undertaking.
    /// Encoded/decoded by serializers as &quot;CUB3&quot;.
    /// </summary>
    [EnumMember(Value = "CUB3")]
    [IsoId("_uQL0HPRYEeuLhpyIdtJzwg")]
    [Description(@"Beneficiary of the third counter-undertaking.")]
    ThirdCounterUndertakingBeneficiary,

    /// <summary>
    /// Party that issues the undertaking (or counter-undertaking).
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_uQU-APRYEeuLhpyIdtJzwg")]
    [Description(@"Party that issues the undertaking (or counter-undertaking). ")]
    Issuer,

    /// <summary>
    /// Party obligated to reimburse the issuer.
    /// Encoded/decoded by serializers as &quot;OBLG&quot;.
    /// </summary>
    [EnumMember(Value = "OBLG")]
    [IsoId("_uQU-A_RYEeuLhpyIdtJzwg")]
    [Description(@"Party obligated to reimburse the issuer. ")]
    Obligor,

    /// <summary>
    /// Party requested to issue an undertaking on behalf of the applicant. Also known as the ordering institution or applicant&apos;s bank.
    /// Encoded/decoded by serializers as &quot;ORDR&quot;.
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_uQevAPRYEeuLhpyIdtJzwg")]
    [Description(
        @"Party requested to issue an undertaking on behalf of the applicant. Also known as the ordering institution or applicant's bank."
    )]
    OrderingParty,

    /// <summary>
    /// Party nominated to receive presentation.
    /// Encoded/decoded by serializers as &quot;PRES&quot;.
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_uQevA_RYEeuLhpyIdtJzwg")]
    [Description(@"Party nominated to receive presentation. ")]
    PresentingParty,

    /// <summary>
    /// Second advising party.
    /// Encoded/decoded by serializers as &quot;SADV&quot;.
    /// </summary>
    [EnumMember(Value = "SADV")]
    [IsoId("_uQevBvRYEeuLhpyIdtJzwg")]
    [Description(@"Second advising party.")]
    SecondAdvisingParty,

    /// <summary>
    /// Party located at specified address.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_uQevCfRYEeuLhpyIdtJzwg")]
    [Description(@"Party located at specified address.")]
    SpecifiedAddress,
}
