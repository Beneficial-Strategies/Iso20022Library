// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ContractTerm7Choice
{
    /// <summary>
    /// Transaction is  fixed term with a contractually agreed maturity date.
    /// </summary>
    [IsoId("_xsKXY65qEeuo-IflVgGqiA")]
    [DisplayName("Fixed")]
    public record Fixed : ContractTerm7Choice_
    {
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the closing leg (forward leg) of the secured financing transaction.
        /// </summary>
        [IsoId("_x8jj0a5qEeuo-IflVgGqiA")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? MaturityDate { get; init; }

        /// <summary>
        /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable agreement.
        /// </summary>
        [IsoId("_x8jj065qEeuo-IflVgGqiA")]
        [DisplayName("Termination Option")]
        [IsoXmlTag("TermntnOptn")]
        public RepoTerminationOption2Code? TerminationOption { get; init; }
    }
}
