// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Investment1Choice
{
    /// <summary>
    /// Indicates that the investment was made in a repurchase agreement.
    /// </summary>
    [IsoId("_AIsK8LJXEeaYqc4G3TTwhA")]
    [DisplayName("Repurchase Agreement")]
    [IsoXmlTag("RpAgrmt")]
    public record RepurchaseAgreement : Investment1Choice_
    {
        /// <summary>
        /// Date on which the repurchase agreement matures.
        /// </summary>
        [IsoId("_oxf3gbJVEeaYqc4G3TTwhA")]
        [DisplayName("Maturity Date")]
        [IsoXmlTag("MtrtyDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate MaturityDate { get; init; }

        /// <summary>
        /// Specifies the repurchase price at maturity of the repo.
        /// </summary>
        [IsoId("_oxf3g7JVEeaYqc4G3TTwhA")]
        [DisplayName("Second Leg Price")]
        [IsoXmlTag("ScndLegPric")]
        public required ActiveCurrencyAndAmount SecondLegPrice { get; init; }

        /// <summary>
        /// Specifies the dirty price of the underlying security or securities in repo.
        /// </summary>
        [IsoId("_-lqgULboEeaqL_M7XFD7PQ")]
        [DisplayName("Collateral Market Value")]
        [IsoXmlTag("CollMktVal")]
        public required ActiveCurrencyAndAmount CollateralMarketValue { get; init; }

        /// <summary>
        /// Identifies the counterparty to the repurchase agreement.
        /// </summary>
        [IsoId("_oxf3hbJVEeaYqc4G3TTwhA")]
        [DisplayName("Counterparty")]
        [IsoXmlTag("CtrPty")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public required IsoLEIIdentifier Counterparty { get; init; }

        /// <summary>
        /// Specifies the type of repurchase agreement.
        /// </summary>
        [IsoId("_3JXU8LJVEeaYqc4G3TTwhA")]
        [DisplayName("Repurchase Agreement Type")]
        [IsoXmlTag("RpAgrmtTp")]
        public required RepurchaseAgreementType3Choice_ RepurchaseAgreementType { get; init; }

        /// <summary>
        /// Identifies the triparty repurchase agent.
        /// </summary>
        [IsoId("_63_i0LJVEeaYqc4G3TTwhA")]
        [DisplayName("Triparty Agent Identification")]
        [IsoXmlTag("TrptyAgtId")]
        [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
        public IsoLEIIdentifier? TripartyAgentIdentification { get; init; }
    }
}
