// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.RegularExpressions;
using PartyId127 = BeneficialStrategies.Iso20022.Choices.PartyIdentification127Choice;
using SfkpgPlace28 = BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat28Choice;

namespace BeneficialStrategies.Iso20022.Validation.Components;

/// <summary>
/// Validates <see cref="AccountAndBalance47"/> per the ISO 20022 specification.
/// </summary>
/// <remarks>
/// ISO ID: _945XHRukEeyhRdHRjakS2w
/// Spec source: queried via ISO 20022 MCP server (2026-03-13).
/// All five fields are optional (0..1) at the XSD level, but constraints below
/// apply additional semantic rules.
/// <list type="table">
///   <item><term>SafekeepingAccount</term><description>Max35Text — optional (0..1)</description></item>
///   <item><term>BlockChainAddressOrWallet</term><description>Max140Text — optional (0..1)</description></item>
///   <item><term>AccountOwner</term><description>PartyIdentification127Choice — optional (0..1)</description></item>
///   <item><term>SafekeepingPlace</term><description>SafekeepingPlaceFormat28Choice — optional (0..1)</description></item>
///   <item><term>Balance</term><description>CorporateActionBalanceDetails43 — optional (0..1)</description></item>
/// </list>
///
/// Constraints (from spec):
/// <list type="bullet">
///   <item>
///     <term>SafekeepingPlaceRule</term>
///     <description>
///       SafekeepingPlace is only to be used by global custodians that allow their clients
///       to specify where the securities are to be held, for example, in an ICSD account
///       versus an account at the local CSD. This is a business-context constraint and
///       cannot be enforced structurally from the message content alone; enforcement is
///       the responsibility of the application layer.
///     </description>
///   </item>
///   <item>
///     <term>SafekeepingAccountOrBlockChainAddress1Rule</term>
///     <description>Either SafekeepingAccount or BlockChainAddressOrWallet must be present but not both.</description>
///   </item>
///   <item>
///     <term>SafekeepingAccountOrBlockChainAddress2Rule</term>
///     <description>If BlockChainAddressOrWallet is present then SafekeepingAccount must be absent.</description>
///   </item>
///   <item>
///     <term>SafekeepingAccountOrBlockChainAddress3Rule</term>
///     <description>If SafekeepingAccount is present then BlockChainAddressOrWallet must be absent.</description>
///   </item>
/// </list>
/// </remarks>
public sealed class AccountAndBalance47Validator : AbstractValidator<AccountAndBalance47>
{
    // AnyBICDec2014Identifier (ISO ID: _jp-90kI6EeirV6K70JJQ8Q):
    // Format: 4 chars institution + 2 chars country + 2 chars location + optional 3 chars branch
    private static readonly Regex AnyBicRegex =
        new(
            @"^[A-Z0-9]{4,4}[A-Z]{2,2}[A-Z0-9]{2,2}([A-Z0-9]{3,3}){0,1}$",
            RegexOptions.Compiled | RegexOptions.CultureInvariant
        );

    // CountryCode — ISO 3166 Alpha-2
    private static readonly Regex CountryRegex =
        new(@"^[A-Z]{2}$", RegexOptions.Compiled | RegexOptions.CultureInvariant);

    public AccountAndBalance47Validator()
    {
        // ── Cross-field constraints ───────────────────────────────────────────────
        // SafekeepingPlaceRule: business-context only — cannot be enforced structurally.
        // See XML doc on this class for the full constraint text.

        RuleFor(x => x)
            .Must(x => x.SafekeepingAccount is not null || x.BlockChainAddressOrWallet is not null)
            .WithName("SafekeepingAccountOrBlockChainAddress1Rule")
            .WithMessage(
                "Either SafekeepingAccount or BlockChainAddressOrWallet must be present, "
                    + "but not both (SafekeepingAccountOrBlockChainAddress1Rule)."
            );

        RuleFor(x => x)
            .Must(x =>
                !(x.BlockChainAddressOrWallet is not null && x.SafekeepingAccount is not null)
            )
            .WithName("SafekeepingAccountOrBlockChainAddress2Rule")
            .WithMessage(
                "If BlockChainAddressOrWallet is present then SafekeepingAccount must be absent "
                    + "(SafekeepingAccountOrBlockChainAddress2Rule)."
            );

        RuleFor(x => x)
            .Must(x =>
                !(x.SafekeepingAccount is not null && x.BlockChainAddressOrWallet is not null)
            )
            .WithName("SafekeepingAccountOrBlockChainAddress3Rule")
            .WithMessage(
                "If SafekeepingAccount is present then BlockChainAddressOrWallet must be absent "
                    + "(SafekeepingAccountOrBlockChainAddress3Rule)."
            );

        // SafekeepingAccount (Max35Text) and BlockChainAddressOrWallet (Max140Text):
        // length enforced by their respective struct constructors — no FV rules needed.

        // ── AccountOwner: PartyIdentification127Choice (0..1) ────────────────────
        // Variant: AnyBIC — value must match AnyBICDec2014Identifier pattern
        When(
            x => x.AccountOwner is PartyId127.AnyBIC,
            () =>
                RuleFor(x => ((PartyId127.AnyBIC)x.AccountOwner!).Value)
                    .NotEmpty()
        // AnyBICDec2014Identifier pattern enforced by struct constructor.
        );

        // Variant: ProprietaryIdentification — Identification and Issuer required Max35Text;
        // SchemeName optional Max35Text
        When(
            x => x.AccountOwner is PartyId127.ProprietaryIdentification,
            () =>
            {
                // Length [1..35] enforced by Max35Text constructor for all three fields.
                RuleFor(x => ((PartyId127.ProprietaryIdentification)x.AccountOwner!).Identification)
                    .NotEmpty();

                RuleFor(x => ((PartyId127.ProprietaryIdentification)x.AccountOwner!).Issuer)
                    .NotEmpty();
            }
        );

        // ── SafekeepingPlace: SafekeepingPlaceFormat28Choice (0..1) ──────────────
        // Variant: Country — value is ISO 3166 Alpha-2 country code
        When(
            x => x.SafekeepingPlace is SfkpgPlace28.Country,
            () =>
                RuleFor(x => ((SfkpgPlace28.Country)x.SafekeepingPlace!).Value)
                    .NotEmpty()
        // Pattern ^[A-Z]{2}$ is enforced by CountryCode constructor — no Matches() needed.
        );

        // Variant: Identification — Max35Text length enforced by struct constructor.

        // Variant: TypeAndIdentification — Identification must match AnyBICDec2014Identifier
        When(
            x => x.SafekeepingPlace is SfkpgPlace28.TypeAndIdentification,
            () =>
                RuleFor(x =>
                        ((SfkpgPlace28.TypeAndIdentification)x.SafekeepingPlace!).Identification
                    )
                    .NotEmpty()
        // AnyBICDec2014Identifier pattern enforced by struct constructor.
        );

        // Variant: Proprietary — Identification is Max35Text, length enforced by struct constructor.

        // ── Balance: CorporateActionBalanceDetails43 (0..1) ──────────────────────
        When(
            x => x.Balance is not null,
            () =>
                RuleFor(x => x.Balance)
                    .SetValidator(new CorporateActionBalanceDetails43Validator()!)
        );
    }
}
