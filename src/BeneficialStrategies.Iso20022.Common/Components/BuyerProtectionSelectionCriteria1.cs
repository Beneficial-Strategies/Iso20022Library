// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Selection criteria for buyer protection query.
/// </summary>
[IsoId("_rPgKMN8nEe-NrtAAlrBEgQ")]
[DisplayName("Buyer Protection Selection Criteria1")]
public record BuyerProtectionSelectionCriteria1
{
    /// <summary>
    /// Unique and unambiguous identification of a financial institution.
    /// </summary>
    [IsoId("__qwV5N-1Ee-Ned3-G07x_A")]
    [DisplayName("Financial Institution Identification")]
    [IsoXmlTag("FIId")]
    public required FinancialInstitutionIdentification28 FinancialInstitutionIdentification { get; init; }

    /// <summary>
    /// Selected safekeeping accounts list to which the corporate action event applies.
    /// </summary>
    [IsoId("_GueI4N-5Ee-Ned3-G07x_A")]
    [DisplayName("Account Identification")]
    [IsoXmlTag("AcctId")]
    public SecuritiesAccountIdentification1Choice_? AccountIdentification { get; init; }

    /// <summary>
    /// International Securities Identification Number (ISIN).
    /// </summary>
    [IsoId("_cYPqgd-1Ee-Ned3-G07x_A")]
    [DisplayName("ISIN")]
    [IsoXmlTag("ISIN")]
    public IsoISINOct2015Identifier? ISIN { get; init; }

    /// <summary>
    /// Reference assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_pE_p9N-1Ee-Ned3-G07x_A")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository.
    /// </summary>
    [IsoId("_vO2kI9-1Ee-Ned3-G07x_A")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction.
    /// </summary>
    [IsoId("_vO2kJN-1Ee-Ned3-G07x_A")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Unique Transaction Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_vO2kJd-1Ee-Ned3-G07x_A")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }
}
