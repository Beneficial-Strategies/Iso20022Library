// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identification of the type of entity involved in a maintenance operation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_KTB_x31DEeCF8NjrBemJWQ_1808425989")]
[Description(@"Identification of the type of entity involved in a maintenance operation.")]
[DerivedFrom(typeof(PartyTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyType5Code>))]
#endif
public enum PartyType5Code
{
    /// <summary>
    /// Point Of Interaction initiating the card payment transaction.
    /// Encoded/decoded by serializers as &quot;OPOI&quot;.
    /// </summary>
    [EnumMember(Value = "OPOI")]
    [IsoId("_KTB_yH1DEeCF8NjrBemJWQ_1219111491")]
    [Description(@"Point Of Interaction initiating the card payment transaction.")]
    OriginatingPOI = PartyTypeCode.OriginatingPOI, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_KTB_yX1DEeCF8NjrBemJWQ_990949228")]
    [Description(
        @"Card acceptor, party accepting the card and presenting transaction data to the acquirer."
    )]
    Acceptor = PartyTypeCode.Acceptor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant providing goods and service in the card payment transaction.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_KTLwwH1DEeCF8NjrBemJWQ_-6123125")]
    [Description(@"Merchant providing goods and service in the card payment transaction.")]
    Merchant = PartyTypeCode.Merchant, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_KTLwwX1DEeCF8NjrBemJWQ_-1003195478")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Party acting on behalf of other parties to process or forward data to other parties.
    /// Encoded/decoded by serializers as &quot;ITAG&quot;.
    /// </summary>
    [EnumMember(Value = "ITAG")]
    [IsoId("_KTLwwn1DEeCF8NjrBemJWQ_-2000267831")]
    [Description(
        @"Party acting on behalf of other parties to process or forward data to other parties."
    )]
    IntermediaryAgent = PartyTypeCode.IntermediaryAgent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Responsible for the maintenance of a card payment acceptance terminal.
    /// Encoded/decoded by serializers as &quot;MTMG&quot;.
    /// </summary>
    [EnumMember(Value = "MTMG")]
    [IsoId("_KTLww31DEeCF8NjrBemJWQ_1297627112")]
    [Description(@"Responsible for the maintenance of a card payment acceptance terminal.")]
    MasterTerminalManager = PartyTypeCode.MasterTerminalManager, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Responsible for one or several maintenance functions of a card payment acceptance terminal.
    /// Encoded/decoded by serializers as &quot;TMGT&quot;.
    /// </summary>
    [EnumMember(Value = "TMGT")]
    [IsoId("_KTLwxH1DEeCF8NjrBemJWQ_8597021")]
    [Description(
        @"Responsible for one or several maintenance functions of a card payment acceptance terminal."
    )]
    TerminalManager = PartyTypeCode.TerminalManager, // same ordinal as derivation source for type conversions
}
