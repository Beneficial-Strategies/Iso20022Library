// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of entity acting as a Payment Initiation Service Provider.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_7K32gROEEfC1ZfCQz0xB3g")]
[Description(@"Type of entity acting as a Payment Initiation Service Provider.")]
[DerivedFrom(typeof(PartyTypeCode))]
public enum ATICAPartyType1Code
{
    /// <summary>
    /// Card acceptor, party accepting the card and presenting transaction data to the acquirer.
    /// Encoded/decoded by serializers as &quot;ACCP&quot;.
    /// </summary>
    [EnumMember(Value = "ACCP")]
    [IsoId("_7SPp0ROEEfC1ZfCQz0xB3g")]
    [Description(@"Card acceptor, party accepting the card and presenting transaction data to the acquirer.")]
    Acceptor = PartyTypeCode.Acceptor,

    /// <summary>
    /// Entity providing acquiring card payment processing services on behalf on an acquirer.
    /// Encoded/decoded by serializers as &quot;ACQP&quot;.
    /// </summary>
    [EnumMember(Value = "ACQP")]
    [IsoId("_OC03sT15EfCQAqQ9lolFUg")]
    [Description(@"Entity providing acquiring card payment processing services on behalf on an acquirer.")]
    AcquirerProcessor = PartyTypeCode.AcquirerProcessor,

    /// <summary>
    /// Entity acquiring card transactions.
    /// Encoded/decoded by serializers as &quot;ACQR&quot;.
    /// </summary>
    [EnumMember(Value = "ACQR")]
    [IsoId("_7SPp0xOEEfC1ZfCQz0xB3g")]
    [Description(@"Entity acquiring card transactions.")]
    Acquirer = PartyTypeCode.Acquirer,

    /// <summary>
    /// Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.
    /// Encoded/decoded by serializers as &quot;AGNT&quot;.
    /// </summary>
    [EnumMember(Value = "AGNT")]
    [IsoId("_7SPp2xOEEfC1ZfCQz0xB3g")]
    [Description(@"Entity providing card payment processing services acting as an intermediary between an acquirer and an issuer.")]
    Agent = PartyTypeCode.Agent,

    /// <summary>
    /// Entity providing issuing card payment processing services on behalf on an issuer.
    /// Encoded/decoded by serializers as &quot;CISP&quot;.
    /// </summary>
    [EnumMember(Value = "CISP")]
    [IsoId("_O-MTwT15EfCQAqQ9lolFUg")]
    [Description(@"Entity providing issuing card payment processing services on behalf on an issuer.")]
    CardIssuerProcessor = PartyTypeCode.CardIssuerProcessor,

    /// <summary>
    /// Party that issues cards.
    /// Encoded/decoded by serializers as &quot;CISS&quot;.
    /// </summary>
    [EnumMember(Value = "CISS")]
    [IsoId("_7SPp1xOEEfC1ZfCQz0xB3g")]
    [Description(@"Party that issues cards.")]
    CardIssuer = PartyTypeCode.CardIssuer,

    /// <summary>
    /// Party to whom the card issuer delegates to authorise card payment transactions.
    /// Encoded/decoded by serializers as &quot;DLIS&quot;.
    /// </summary>
    [EnumMember(Value = "DLIS")]
    [IsoId("_7SPp2ROEEfC1ZfCQz0xB3g")]
    [Description(@"Party to whom the card issuer delegates to authorise card payment transactions.")]
    DelegateIssuer = PartyTypeCode.DelegateIssuer,

    /// <summary>
    /// Application in the smart card.
    /// Encoded/decoded by serializers as &quot;ICCA&quot;.
    /// </summary>
    [EnumMember(Value = "ICCA")]
    [IsoId("_7SPp1ROEEfC1ZfCQz0xB3g")]
    [Description(@"Application in the smart card.")]
    CardApplication = PartyTypeCode.CardApplication,

    /// <summary>
    /// Entity providing payments services.
    /// Encoded/decoded by serializers as &quot;PASP&quot;.
    /// </summary>
    [EnumMember(Value = "PASP")]
    [IsoId("_hh6toT15EfCQAqQ9lolFUg")]
    [Description(@"Entity providing payments services.")]
    PaymentServiceProvider = PartyTypeCode.PaymentServiceProvider,

    /// <summary>
    /// Provider of an electronic wallet.
    /// Encoded/decoded by serializers as &quot;WLPR&quot;.
    /// </summary>
    [EnumMember(Value = "WLPR")]
    [IsoId("_cloZ0T15EfCQAqQ9lolFUg")]
    [Description(@"Provider of an electronic wallet.")]
    WalletProvider = PartyTypeCode.WalletProvider,
}
