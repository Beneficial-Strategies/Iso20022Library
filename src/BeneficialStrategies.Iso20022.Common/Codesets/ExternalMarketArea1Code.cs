// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external market code, to which the instruction, operation or report relates, in the format of character string with a maximum length of 4 characters.
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_5xnW4DooEeOr__K5A0LSog")]
[Description(
    @"Specifies the external market code, to which the instruction, operation or report relates, in the format of character string with a maximum length of 4 characters.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalMarketAreaCode))]
public enum ExternalMarketArea1Code
{
    /// <summary>
    /// Any market area.
    /// Encoded/decoded by serializers as &quot;ANYY&quot;.
    /// </summary>
    [EnumMember(Value = "ANYY")]
    [IsoId("_uUMxZfRYEeuLhpyIdtJzwg")]
    [Description(@"Any market area.")]
    Any = ExternalMarketAreaCode.Any, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank to bank cash movements.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_uUMxaPRYEeuLhpyIdtJzwg")]
    [Description(@"Bank to bank cash movements.")]
    Cash = ExternalMarketAreaCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Collections.
    /// Encoded/decoded by serializers as &quot;COLL&quot;.
    /// </summary>
    [EnumMember(Value = "COLL")]
    [IsoId("_uUMxa_RYEeuLhpyIdtJzwg")]
    [Description(@"Collections.")]
    Collections = ExternalMarketAreaCode.Collections, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Precious metals and other commodities such as palm oil.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_uUWiYvRYEeuLhpyIdtJzwg")]
    [Description(@"Precious metals and other commodities such as palm oil.")]
    Commodities = ExternalMarketAreaCode.Commodities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment in which one of the parties is not a financial institution.
    /// Encoded/decoded by serializers as &quot;COPA&quot;.
    /// </summary>
    [EnumMember(Value = "COPA")]
    [IsoId("_uUWiZfRYEeuLhpyIdtJzwg")]
    [Description(@"Payment in which one of the parties is not a financial institution.")]
    CommercialPayments = ExternalMarketAreaCode.CommercialPayments, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Futures contracts, options, forward contracts, swaps, etc...
    /// Encoded/decoded by serializers as &quot;DERI&quot;.
    /// </summary>
    [EnumMember(Value = "DERI")]
    [IsoId("_uUgTYvRYEeuLhpyIdtJzwg")]
    [Description(@"Futures contracts, options, forward contracts, swaps, etc...")]
    Derivatives = ExternalMarketAreaCode.Derivatives, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Documentary credits.
    /// Encoded/decoded by serializers as &quot;DOCC&quot;.
    /// </summary>
    [EnumMember(Value = "DOCC")]
    [IsoId("_uUgTZfRYEeuLhpyIdtJzwg")]
    [Description(@"Documentary credits.")]
    DocumentaryCredits = ExternalMarketAreaCode.DocumentaryCredits, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Foreign exchange.
    /// Encoded/decoded by serializers as &quot;FOEX&quot;.
    /// </summary>
    [EnumMember(Value = "FOEX")]
    [IsoId("_uUgTaPRYEeuLhpyIdtJzwg")]
    [Description(@"Foreign exchange.")]
    ForeignExchange = ExternalMarketAreaCode.ForeignExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Guarantees.
    /// Encoded/decoded by serializers as &quot;GUAR&quot;.
    /// </summary>
    [EnumMember(Value = "GUAR")]
    [IsoId("_uUgTa_RYEeuLhpyIdtJzwg")]
    [Description(@"Guarantees.")]
    Guarantees = ExternalMarketAreaCode.Guarantees, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Letters of credit.
    /// Encoded/decoded by serializers as &quot;LETT&quot;.
    /// </summary>
    [EnumMember(Value = "LETT")]
    [IsoId("_uUpdUvRYEeuLhpyIdtJzwg")]
    [Description(@"Letters of credit.")]
    LettersOfCredit = ExternalMarketAreaCode.LettersOfCredit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Loans and deposits.
    /// Encoded/decoded by serializers as &quot;LOAN&quot;.
    /// </summary>
    [EnumMember(Value = "LOAN")]
    [IsoId("_uUpdVfRYEeuLhpyIdtJzwg")]
    [Description(@"Loans and deposits.")]
    Loans = ExternalMarketAreaCode.Loans, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Money markets.
    /// Encoded/decoded by serializers as &quot;MMKT&quot;.
    /// </summary>
    [EnumMember(Value = "MMKT")]
    [IsoId("_uUpdWPRYEeuLhpyIdtJzwg")]
    [Description(@"Money markets.")]
    MoneyMarkets = ExternalMarketAreaCode.MoneyMarkets, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FX forward trade for which only balance is settled.
    /// Encoded/decoded by serializers as &quot;NDLF&quot;.
    /// </summary>
    [EnumMember(Value = "NDLF")]
    [IsoId("_uUpdW_RYEeuLhpyIdtJzwg")]
    [Description(@"FX forward trade for which only balance is settled.")]
    NonDeliverableForward = ExternalMarketAreaCode.NonDeliverableForward, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offshore settlement.
    /// Encoded/decoded by serializers as &quot;OFFS&quot;.
    /// </summary>
    [EnumMember(Value = "OFFS")]
    [IsoId("_uUpdXvRYEeuLhpyIdtJzwg")]
    [Description(@"Offshore settlement.")]
    Offshore = ExternalMarketAreaCode.Offshore, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Onshore settlement.
    /// Encoded/decoded by serializers as &quot;ONSH&quot;.
    /// </summary>
    [EnumMember(Value = "ONSH")]
    [IsoId("_uUzOUvRYEeuLhpyIdtJzwg")]
    [Description(@"Onshore settlement.")]
    Onshore = ExternalMarketAreaCode.Onshore, // same ordinal as derivation source for type conversions

    /// <summary>
    /// FX Options, swap options, etc...
    /// Encoded/decoded by serializers as &quot;OPTI&quot;.
    /// </summary>
    [EnumMember(Value = "OPTI")]
    [IsoId("_uUzOVfRYEeuLhpyIdtJzwg")]
    [Description(@"FX Options, swap options, etc...")]
    Options = ExternalMarketAreaCode.Options, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bonds, equities, futures...
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_uUzOWPRYEeuLhpyIdtJzwg")]
    [Description(@"Bonds, equities, futures...")]
    Securities = ExternalMarketAreaCode.Securities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Documentary credits, collections, guarantees, letters of credit.
    /// Encoded/decoded by serializers as &quot;TFIN&quot;.
    /// </summary>
    [EnumMember(Value = "TFIN")]
    [IsoId("_uUzOW_RYEeuLhpyIdtJzwg")]
    [Description(@"Documentary credits, collections, guarantees, letters of credit.")]
    TradeFinance = ExternalMarketAreaCode.TradeFinance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash management activities.
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_uU8YQvRYEeuLhpyIdtJzwg")]
    [Description(@"Cash management activities.")]
    Treasury = ExternalMarketAreaCode.Treasury, // same ordinal as derivation source for type conversions
}
