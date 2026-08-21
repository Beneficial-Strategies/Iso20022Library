// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Validation.camt;

/// <summary>
/// Validates <see cref="GetCurrencyExchangeRateV04"/> (camt.016.001.04) per the ISO 20022
/// specification.
/// </summary>
/// <remarks>
/// ISO ID: _jwlbdxbvEeiyVv5j1vf1VQ
/// Spec source: queried via ISO 20022 MCP server (2026-08-20). Registration status: Registered
/// (latest version of this message family — no newer version exists in the repository).
///
/// Scope
/// The GetCurrencyExchangeRate message is sent by a member to the transaction administrator. It
/// is used to request information on static data maintained by the transaction administrator and
/// related to currency exchange details as maintained for the system operations by the
/// transaction administrator.
///
/// Usage
/// The transaction administrator is in charge of providing the members with business
/// information — all information related to the management of the system, not related to the
/// transactions created into the system. When a system manages a pool of accounts in various
/// currencies for a member, there is a need to maintain currency exchange details between the
/// various currencies and the reporting or base currency, used to calculate the actual position
/// of the members in terms of aggregate limits and balances. At any point in time during
/// operating hours, the member can query the transaction administrator for static data related
/// to a currency exchange, based on the source currency and/or the target currency. This message
/// is replied to by a ReturnCurrencyExchangeRate message.
///
/// <list type="table">
///   <item><term>MessageHeader</term><description>MessageHeader1 — required (1..1)</description></item>
///   <item><term>CurrencyQueryDefinition</term><description>CurrencyQueryDefinition3 — optional (0..1)</description></item>
///   <item><term>SupplementaryData</term><description>SupplementaryData1 — optional (0..1)</description></item>
/// </list>
///
/// No cross-field constraints found for this message (no "constraint" declaration rows under its
/// ISO dictionary entry).
///
/// Dependency injection: <c>MessageHeader</c>, the optional <c>CurrencyQueryDefinition</c>
/// building block, and the optional <c>SupplementaryData</c> building block are each validated by
/// an injected <see cref="IValidator{T}"/> rather than a hardcoded <c>new</c> — see the two
/// constructors below.
/// </remarks>
public class GetCurrencyExchangeRateV04Validator : AbstractValidator<GetCurrencyExchangeRateV04>
{
    /// <summary>
    /// Initializes a new instance using dependency injection: the caller supplies the validator
    /// for the required <c>MessageHeader</c> building block and the optional
    /// <c>CurrencyQueryDefinition</c>/<c>SupplementaryData</c> building blocks — e.g. resolved
    /// from a DI container — instead of this type constructing its own.
    /// </summary>
    /// <param name="messageHeaderValidator">
    /// Validator for the required <c>MessageHeader</c> building block (MessageHeader1, 1..1).
    /// </param>
    /// <param name="currencyQueryDefinitionValidator">
    /// Validator for the optional <c>CurrencyQueryDefinition</c> building block
    /// (CurrencyQueryDefinition3, 0..1) — only invoked when present.
    /// </param>
    /// <param name="supplementaryDataValidator">
    /// Validator for the optional <c>SupplementaryData</c> building block (SupplementaryData1,
    /// 0..1) — only invoked when present.
    /// </param>
    public GetCurrencyExchangeRateV04Validator(
        IValidator<MessageHeader1> messageHeaderValidator,
        IValidator<CurrencyQueryDefinition3> currencyQueryDefinitionValidator,
        IValidator<SupplementaryData1> supplementaryDataValidator
    )
    {
        RuleFor(x => x.MessageHeader).SetValidator(messageHeaderValidator);

        When(
            x => x.CurrencyQueryDefinition is not null,
            () => RuleFor(x => x.CurrencyQueryDefinition).SetValidator(currencyQueryDefinitionValidator!)
        );
        When(
            x => x.SupplementaryData is not null,
            () => RuleFor(x => x.SupplementaryData).SetValidator(supplementaryDataValidator!)
        );
    }

    /// <summary>
    /// Initializes a new instance using default dependencies: <c>MessageHeader</c>,
    /// <c>CurrencyQueryDefinition</c>, and <c>SupplementaryData</c> are each validated by their
    /// own default validator (<see cref="MessageHeader1Validator"/>,
    /// <see cref="CurrencyQueryDefinition3Validator"/>, <see cref="SupplementaryData1Validator"/>).
    /// Convenience constructor for callers not using a DI container.
    /// </summary>
    public GetCurrencyExchangeRateV04Validator()
        : this(
            new MessageHeader1Validator(),
            new CurrencyQueryDefinition3Validator(),
            new SupplementaryData1Validator()
        ) { }
}
