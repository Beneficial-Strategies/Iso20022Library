// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Entity assigning an identification of an entity involved in a maintenance operation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KTLwxX1DEeCF8NjrBemJWQ_-1689950566")]
[Description(
    @"Entity assigning an identification of an entity involved in a maintenance operation."
)]
[DerivedFrom(typeof(PartyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyType6Code>))]
#endif
public enum PartyType6Code
{
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_KTLwxn1DEeCF8NjrBemJWQ_1494105311")]
    [Description(
        @"Card acceptor, party accepting the card and presenting transaction data to the acquirer."
    )]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant providing goods and service in the card payment transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_KTLwx31DEeCF8NjrBemJWQ_788990696")]
    [Description(@"Merchant providing goods and service in the card payment transaction.")]
    Merchant = PartyTypeCode.Merchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_KTLwyH1DEeCF8NjrBemJWQ_-386200329")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_KTVhwH1DEeCF8NjrBemJWQ_1259067106")]
    [Description(
        @"Party acting on behalf of other parties to process or forward data to other parties."
    )]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Responsible for the maintenance of a card payment acceptance terminal.
    /// Encoded/decoded by serializers as &quot;MTMG&quot;.
    /// </summary>
    [EnumMember(Value = "MTMG")]
    [IsoId("_KTVhwX1DEeCF8NjrBemJWQ_-1497111748")]
    [Description(@"Responsible for the maintenance of a card payment acceptance terminal.")]
    MasterTerminalManager = PartyTypeCode.MasterTerminalManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Responsible for one or several maintenance functions of a card payment acceptance terminal.
    /// Encoded/decoded by serializers as &quot;TMGT&quot;.
    /// </summary>
    [EnumMember(Value = "TMGT")]
    [IsoId("_KTVhwn1DEeCF8NjrBemJWQ_-735077600")]
    [Description(
        @"Responsible for one or several maintenance functions of a card payment acceptance terminal."
    )]
    TerminalManager = PartyTypeCode.TerminalManager, // same ordinal as derivation source for type conversions
}
