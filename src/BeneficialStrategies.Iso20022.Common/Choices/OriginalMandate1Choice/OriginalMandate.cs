// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate1Choice
{
    /// <summary>
    /// Set of elements used to provide the original mandate data.
    /// </summary>
    [IsoId("_RD1Zldp-Ed-ak6NoX_4Aeg_1242303145")]
    [DisplayName("Original Mandate")]
    [IsoXmlTag("OrgnlMndt")]
    public record OriginalMandate : OriginalMandate1Choice_
    {
        /// <summary>
        /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
        /// </summary>
        [IsoId("_T2pfcNp-Ed-ak6NoX_4Aeg_1069638079")]
        [DisplayName("Mandate Identification")]
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text MandateIdentification { get; init; }

        /// <summary>
        /// Identification for the mandate request, as assigned by the initiating party.
        /// </summary>
        [IsoId("_T2pfcdp-Ed-ak6NoX_4Aeg_-1048171244")]
        [DisplayName("Mandate Request Identification")]
        [IsoXmlTag("MndtReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateRequestIdentification { get; init; }

        /// <summary>
        /// Specifies the type of mandate, such as paper, electronic or scheme.
        /// </summary>
        [IsoId("_T2pfctp-Ed-ak6NoX_4Aeg_551512108")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public MandateTypeInformation1? Type { get; init; }

        /// <summary>
        /// Set of elements used to provide details of the duration of the mandate and occurrence of the underlying transactions.
        /// </summary>
        [IsoId("_T2pfc9p-Ed-ak6NoX_4Aeg_-1287344608")]
        [DisplayName("Occurrences")]
        [IsoXmlTag("Ocrncs")]
        public MandateOccurrences1? Occurrences { get; init; }

        /// <summary>
        /// Fixed amount to be collected from the debtor&apos;s account.
        /// </summary>
        [IsoId("_T2pfdNp-Ed-ak6NoX_4Aeg_-593890533")]
        [DisplayName("Collection Amount")]
        [IsoXmlTag("ColltnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? CollectionAmount { get; init; }

        /// <summary>
        /// Maximum amount that may be collected from the debtor&apos;s account, per instruction.
        /// </summary>
        [IsoId("_T2pfddp-Ed-ak6NoX_4Aeg_-22230938")]
        [DisplayName("Maximum Amount")]
        [IsoXmlTag("MaxAmt")]
        public ActiveOrHistoricCurrencyAndAmount? MaximumAmount { get; init; }

        /// <summary>
        /// Credit party that signs the mandate.
        /// </summary>
        [IsoId("_T2pfdtp-Ed-ak6NoX_4Aeg_83828144")]
        [DisplayName("Creditor Scheme Identification")]
        [IsoXmlTag("CdtrSchmeId")]
        public PartyIdentification32? CreditorSchemeIdentification { get; init; }

        /// <summary>
        /// Party that signs the mandate and to whom an amount of money is due.
        /// </summary>
        [IsoId("_T2pfd9p-Ed-ak6NoX_4Aeg_-860085245")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public required PartyIdentification32 Creditor { get; init; }

        /// <summary>
        /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
        /// </summary>
        [IsoId("_T2pfeNp-Ed-ak6NoX_4Aeg_-1534362198")]
        [DisplayName("Creditor Account")]
        [IsoXmlTag("CdtrAcct")]
        public CashAccount16? CreditorAccount { get; init; }

        /// <summary>
        /// Financial institution servicing an account for the creditor.
        /// </summary>
        [IsoId("_T2zQcNp-Ed-ak6NoX_4Aeg_1720232021")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public BranchAndFinancialInstitutionIdentification4? CreditorAgent { get; init; }

        /// <summary>
        /// Ultimate party to which an amount of money is due.
        /// </summary>
        [IsoId("_T2zQcdp-Ed-ak6NoX_4Aeg_-517457784")]
        [DisplayName("Ultimate Creditor")]
        [IsoXmlTag("UltmtCdtr")]
        public PartyIdentification32? UltimateCreditor { get; init; }

        /// <summary>
        /// Party that signs the mandate and owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_T2zQctp-Ed-ak6NoX_4Aeg_-461122086")]
        [DisplayName("Debtor")]
        [IsoXmlTag("Dbtr")]
        public required PartyIdentification32 Debtor { get; init; }

        /// <summary>
        /// Unambiguous identification of the account of the debtor, to which a debit entry will be made as a result of the transaction.
        /// </summary>
        [IsoId("_T2zQc9p-Ed-ak6NoX_4Aeg_-355577722")]
        [DisplayName("Debtor Account")]
        [IsoXmlTag("DbtrAcct")]
        public CashAccount16? DebtorAccount { get; init; }

        /// <summary>
        /// Financial institution servicing an account for the debtor.
        /// </summary>
        [IsoId("_T2zQdNp-Ed-ak6NoX_4Aeg_1817202281")]
        [DisplayName("Debtor Agent")]
        [IsoXmlTag("DbtrAgt")]
        public required BranchAndFinancialInstitutionIdentification4 DebtorAgent { get; init; }

        /// <summary>
        /// Ultimate party that owes an amount of money to the (ultimate) creditor.
        /// </summary>
        [IsoId("_T2zQddp-Ed-ak6NoX_4Aeg_401444968")]
        [DisplayName("Ultimate Debtor")]
        [IsoXmlTag("UltmtDbtr")]
        public PartyIdentification32? UltimateDebtor { get; init; }

        /// <summary>
        /// Set of elements used to provide information to identify the underlying documents associated with the mandate.
        /// </summary>
        [IsoId("_T2zQdtp-Ed-ak6NoX_4Aeg_-1252987021")]
        [DisplayName("Referred Document")]
        [IsoXmlTag("RfrdDoc")]
        public ReferredDocumentInformation3? ReferredDocument { get; init; }
    }
}
