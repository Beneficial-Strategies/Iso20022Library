// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Amounts;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Choices.AccountIdentification4Choice;
using BeneficialStrategies.Iso20022.Codesets;
using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022;

/// <summary>
/// Shared realistic reference data used across ISO 20022 example tests.
///
/// Scenario: Acme Manufacturing GmbH (Germany) pays GlobalSupply S.A.S. (France)
/// for invoice INV-2024-847, EUR 47,250.00, settled via SEPA/TARGET2.
///
/// The same UETR threads through the pacs.008 → pacs.002 → pacs.004 / camt.056
/// examples to illustrate end-to-end payment lifecycle traceability.
/// </summary>
public static class Iso20022TestData
{
    // ── Reference identifiers ──────────────────────────────────────────────────

    /// <summary>Universally unique end-to-end transaction reference (UUID v4).</summary>
    public const string Uetr = "97ed4827-7b6f-4491-a06f-b548d5a7512d";

    /// <summary>Original pacs.008 message identifier from Deutsche Bank.</summary>
    public const string OriginalPacs008MsgId = "DEUTDEFF/240315/PAC008/00001";

    /// <summary>Instruction identifier assigned by the debtor agent.</summary>
    public const string InstructionId = "DEUTDEFF/240315/INSTR/00001";

    /// <summary>End-to-end identifier assigned by the debtor (Acme).</summary>
    public const string EndToEndId = "ACME/INV-2024-847/PAY001";

    // ── Payment amount ─────────────────────────────────────────────────────────

    public const string Currency = "EUR";
    public const decimal Amount = 47_250.00m;

    /// <summary>EUR 47,250.00 – invoice amount being paid.</summary>
    public static ActiveCurrencyAndAmount InvoiceAmount =>
        new() { Currency = Currency, Amount = Amount, };

    // ── Settlement dates ───────────────────────────────────────────────────────

    public static readonly DateOnly SettlementDate = new(2024, 3, 15);
    public static readonly DateTime MessageCreationDateTime =
        new(2024, 3, 15, 8, 30, 0, DateTimeKind.Utc);

    // ── Debtor: Acme Manufacturing GmbH, Frankfurt ─────────────────────────────

    /// <summary>Debtor bank: Deutsche Bank Frankfurt AG (DEUTDEFF).</summary>
    public static BranchAndFinancialInstitutionIdentification6 DebtorAgent =>
        new()
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification18
            {
                BICFI = "DEUTDEFFXXX",
            },
        };

    /// <summary>Debtor account (German IBAN).</summary>
    public static CashAccount40 DebtorAccount =>
        new()
        {
            Identification = new IBAN { Value = "DE89370400440532013000" },
            Currency = "EUR",
        };

    /// <summary>Debtor party: Acme Manufacturing GmbH.</summary>
    public static PartyIdentification135 Debtor =>
        new()
        {
            Name = "Acme Manufacturing GmbH",
            PostalAddress = new PostalAddress24
            {
                StreetName = "Mainzer Landstrasse",
                BuildingNumber = "46",
                PostCode = "60325",
                TownName = "Frankfurt am Main",
                Country = "DE",
            },
        };

    // ── Creditor: GlobalSupply S.A.S., Paris ───────────────────────────────────

    /// <summary>Creditor bank: BNP Paribas SA, Paris (BNPAFRPP).</summary>
    public static BranchAndFinancialInstitutionIdentification6 CreditorAgent =>
        new()
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification18
            {
                BICFI = "BNPAFRPPXXX",
            },
        };

    /// <summary>Creditor account (French IBAN).</summary>
    public static CashAccount40 CreditorAccount =>
        new()
        {
            Identification = new IBAN { Value = "FR7630006000011234567890189" },
            Currency = "EUR",
        };

    /// <summary>Creditor party: GlobalSupply S.A.S.</summary>
    public static PartyIdentification135 Creditor =>
        new()
        {
            Name = "GlobalSupply S.A.S.",
            PostalAddress = new PostalAddress24
            {
                StreetName = "Rue de Rivoli",
                BuildingNumber = "228",
                PostCode = "75001",
                TownName = "Paris",
                Country = "FR",
            },
        };

    // ── Correspondent bank (for pacs.009 cover scenario) ──────────────────────

    /// <summary>JPMorgan Chase New York – used as correspondent/intermediary agent.</summary>
    public static BranchAndFinancialInstitutionIdentification6 CorrespondentAgent =>
        new()
        {
            FinancialInstitutionIdentification = new FinancialInstitutionIdentification18
            {
                BICFI = "CHASUS33XXX",
            },
        };

    // ── Common settlement instruction (SEPA/TARGET2 clearing) ─────────────────

    public static SettlementInstruction11 ClearingSettlement =>
        new() { SettlementMethod = SettlementMethod1Code.ClearingSystem, };

    public static SettlementInstruction11 CoverSettlement =>
        new() { SettlementMethod = SettlementMethod1Code.CoverMethod, };
}
