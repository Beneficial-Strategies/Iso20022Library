// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesOrCash1Choice
{
    /// <summary>
    /// Cash settlement chain parties and accounts.
    /// </summary>
    [IsoId("_yNcsADchEeOA3chqL9a4Rw")]
    [DisplayName("Cash Parties Details")]
    [IsoXmlTag("CshPtiesDtls")]
    public record CashPartiesDetails : SecuritiesOrCash1Choice_
    {
        /// <summary>
        /// Party to which the payment amount must be ultimately delivered. In some cases, this may be a fund.
        /// </summary>
        [IsoId("_nszs4DcjEeOKPpUjhHfcCQ")]
        [DisplayName("Creditor")]
        [IsoXmlTag("Cdtr")]
        public required PartyIdentificationAndAccount96 Creditor { get; init; }

        /// <summary>
        /// Financial institution that services the cash account of the beneficiary (creditor). In some markets, this is also known as receiving agent. The creditor agent is the party where the payment amount must be ultimately delivered on behalf of the beneficiary (creditor), that is, the party where the beneficiary has its account.
        /// </summary>
        [IsoId("_ns0T_zcjEeOKPpUjhHfcCQ")]
        [DisplayName("Creditor Agent")]
        [IsoXmlTag("CdtrAgt")]
        public required PartyIdentificationAndAccount97 CreditorAgent { get; init; }

        /// <summary>
        /// Financial institution through which the transaction must pass to reach the account with institution (creditor agent).
        /// </summary>
        [IsoId("_ns0T8DcjEeOKPpUjhHfcCQ")]
        [DisplayName("Intermediary")]
        [IsoXmlTag("Intrmy")]
        public PartyIdentificationAndAccount97? Intermediary { get; init; }

        /// <summary>
        /// Financial institution through which the transaction must pass to reach the account with institution (creditor agent).
        /// </summary>
        [IsoId("_6CPMETcjEeOKPpUjhHfcCQ")]
        [DisplayName("Intermediary")]
        [IsoXmlTag("Intrmy2")]
        public PartyIdentificationAndAccount97? Intermediary2 { get; init; }
    }
}
