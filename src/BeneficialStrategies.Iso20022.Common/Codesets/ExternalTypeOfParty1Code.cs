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
[IsoId("_-MYPFG7iEeKo25nLKvGr8w_227763993")]
[Description(
    @"Specifies the external type of party code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalTypeOfPartyCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalTypeOfParty1Code>))]
#endif
public enum ExternalTypeOfParty1Code
{
    /// <summary>
    /// Party advising the undertaking.
    /// Encoded/decoded by serializers as &quot;ADVP&quot;.
    /// </summary>
    [EnumMember(Value = "ADVP")]
    [IsoId("_uQCDG_RYEeuLhpyIdtJzwg")]
    [Description(@"Party advising the undertaking.")]
    AdvisingParty = ExternalTypeOfPartyCode.AdvisingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any bank.
    /// Encoded/decoded by serializers as &quot;ANYB&quot;.
    /// </summary>
    [EnumMember(Value = "ANYB")]
    [IsoId("_uQCDHvRYEeuLhpyIdtJzwg")]
    [Description(@"Any bank.")]
    AnyBank = ExternalTypeOfPartyCode.AnyBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party named in the undertaking as the “applicant”.
    /// Encoded/decoded by serializers as &quot;APPL&quot;.
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_uQL0EvRYEeuLhpyIdtJzwg")]
    [Description(@"Party named in the undertaking as the “applicant”. ")]
    Applicant = ExternalTypeOfPartyCode.Applicant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party in whose favour the undertaking (or counter-undertaking) is issued.
    /// Encoded/decoded by serializers as &quot;BENE&quot;.
    /// </summary>
    [EnumMember(Value = "BENE")]
    [IsoId("_uQL0FfRYEeuLhpyIdtJzwg")]
    [Description(@"Party in whose favour the undertaking (or counter-undertaking) is issued.")]
    Beneficiary = ExternalTypeOfPartyCode.Beneficiary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that adds its undertaking to honour the undertaking.
    /// Encoded/decoded by serializers as &quot;CONF&quot;.
    /// </summary>
    [EnumMember(Value = "CONF")]
    [IsoId("_uQL0GPRYEeuLhpyIdtJzwg")]
    [Description(@"Party that adds its undertaking to honour the undertaking.")]
    ConfirmationParty = ExternalTypeOfPartyCode.ConfirmationParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Beneficiary of the second counter-undertaking.
    /// Encoded/decoded by serializers as &quot;CUB2&quot;.
    /// </summary>
    [EnumMember(Value = "CUB2")]
    [IsoId("_uQL0G_RYEeuLhpyIdtJzwg")]
    [Description(@"Beneficiary of the second counter-undertaking.")]
    SecondCounterUndertakingBeneficiary =
        ExternalTypeOfPartyCode.SecondCounterUndertakingBeneficiary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Beneficiary of the third counter-undertaking.
    /// Encoded/decoded by serializers as &quot;CUB3&quot;.
    /// </summary>
    [EnumMember(Value = "CUB3")]
    [IsoId("_uQL0HvRYEeuLhpyIdtJzwg")]
    [Description(@"Beneficiary of the third counter-undertaking.")]
    ThirdCounterUndertakingBeneficiary = ExternalTypeOfPartyCode.ThirdCounterUndertakingBeneficiary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues the undertaking (or counter-undertaking).
    /// Encoded/decoded by serializers as &quot;ISSU&quot;.
    /// </summary>
    [EnumMember(Value = "ISSU")]
    [IsoId("_uQU-AvRYEeuLhpyIdtJzwg")]
    [Description(@"Party that issues the undertaking (or counter-undertaking). ")]
    Issuer = ExternalTypeOfPartyCode.Issuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party obligated to reimburse the issuer.
    /// Encoded/decoded by serializers as &quot;OBLG&quot;.
    /// </summary>
    [EnumMember(Value = "OBLG")]
    [IsoId("_uQU-BfRYEeuLhpyIdtJzwg")]
    [Description(@"Party obligated to reimburse the issuer. ")]
    Obligor = ExternalTypeOfPartyCode.Obligor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party requested to issue an undertaking on behalf of the applicant. Also known as the ordering institution or applicant&apos;s bank.
    /// Encoded/decoded by serializers as &quot;ORDR&quot;.
    /// </summary>
    [EnumMember(Value = "ORDR")]
    [IsoId("_uQevAvRYEeuLhpyIdtJzwg")]
    [Description(
        @"Party requested to issue an undertaking on behalf of the applicant. Also known as the ordering institution or applicant's bank."
    )]
    OrderingParty = ExternalTypeOfPartyCode.OrderingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party nominated to receive presentation.
    /// Encoded/decoded by serializers as &quot;PRES&quot;.
    /// </summary>
    [EnumMember(Value = "PRES")]
    [IsoId("_uQevBfRYEeuLhpyIdtJzwg")]
    [Description(@"Party nominated to receive presentation. ")]
    PresentingParty = ExternalTypeOfPartyCode.PresentingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Second advising party.
    /// Encoded/decoded by serializers as &quot;SADV&quot;.
    /// </summary>
    [EnumMember(Value = "SADV")]
    [IsoId("_uQevCPRYEeuLhpyIdtJzwg")]
    [Description(@"Second advising party.")]
    SecondAdvisingParty = ExternalTypeOfPartyCode.SecondAdvisingParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party located at specified address.
    /// Encoded/decoded by serializers as &quot;SPEC&quot;.
    /// </summary>
    [EnumMember(Value = "SPEC")]
    [IsoId("_uQevC_RYEeuLhpyIdtJzwg")]
    [Description(@"Party located at specified address.")]
    SpecifiedAddress = ExternalTypeOfPartyCode.SpecifiedAddress, // same ordinal as derivation source for type conversions
}
