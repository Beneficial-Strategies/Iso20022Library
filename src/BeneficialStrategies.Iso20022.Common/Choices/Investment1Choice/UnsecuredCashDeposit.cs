// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Investment1Choice
{
    /// <summary>
    /// Indicates that the investment was made in an unsecured deposit at a commercial deposit taking institution.
    /// </summary>
    [IsoId("_8csFMLJUEeaYqc4G3TTwhA")]
    [DisplayName("Unsecured Cash Deposit")]
    public record UnsecuredCashDeposit : Investment1Choice_
    {
        /// <summary>
        /// Date on which the deposit matures.
        /// </summary>
        [IsoId("_H_pLALJVEeaYqc4G3TTwhA")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate MaturityDate { get; init; }

        /// <summary>
        /// Specifies the value of the deposit.
        /// </summary>
        [IsoId("_LYG7oLJVEeaYqc4G3TTwhA")]
        [DisplayName("Value")]
        [IsoXmlTag("Val")]
        public required ActiveCurrencyAndAmount Value { get; init; }

        /// <summary>
        /// Identifies the legal entity that takes the deposit.
        /// </summary>
        [IsoId("_N0LVcLJVEeaYqc4G3TTwhA")]
        [DisplayName("Counterparty Identification")]
        [IsoXmlTag("CtrPtyId")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier CounterpartyIdentification { get; init; }
    }
}
