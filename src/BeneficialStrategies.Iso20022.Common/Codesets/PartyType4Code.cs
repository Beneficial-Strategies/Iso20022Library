// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Entity assigning an identification (for example merchant, acceptor, acquirer, tax authority, etc.).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TTtRQAEcEeCQm6a_G2yO_w_-1492633607")]
[Description(
    @"Entity assigning an identification (for example merchant, acceptor, acquirer, tax authority, etc.)."
)]
[DerivedFrom(typeof(PartyTypeCode))]
public enum PartyType4Code
{
    /// <summary>
    /// Merchant providing goods and service in the card payment transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_TTtRQQEcEeCQm6a_G2yO_w_-1410689751")]
    [Description(@"Merchant providing goods and service in the card payment transaction.")]
    Merchant = PartyTypeCode.Merchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_TTtRQgEcEeCQm6a_G2yO_w_-1002861397")]
    [Description(
        @"Card acceptor, party accepting the card and presenting transaction data to the acquirer."
    )]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_TTtRQwEcEeCQm6a_G2yO_w_1913422956")]
    [Description(
        @"Party acting on behalf of other parties to process or forward data to other parties."
    )]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_TTtRRAEcEeCQm6a_G2yO_w_-444319167")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_TTtRRQEcEeCQm6a_G2yO_w_1902324179")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax authority.
    /// Encoded/decoded by serializers as &quot;TAXH&quot;.
    /// </summary>
    [EnumMember(Value = "TAXH")]
    [IsoId("_TTtRRgEcEeCQm6a_G2yO_w_-2067525610")]
    [Description(@"Tax authority.")]
    TaxAuthority = PartyTypeCode.TaxAuthority, // same ordinal as derivation source for type conversions
}
