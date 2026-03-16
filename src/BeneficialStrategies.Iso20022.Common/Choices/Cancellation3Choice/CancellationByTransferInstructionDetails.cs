// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cancellation3Choice
{
    /// <summary>
    /// Information related to the transfer instruction to be cancelled.
    /// </summary>
    [IsoId("_B6LRACcaEeK33eWt3gq4Fg")]
    [DisplayName("Cancellation By Transfer Instruction Details")]
    [IsoXmlTag("CxlByTrfInstrDtls")]
    public record CancellationByTransferInstructionDetails : Cancellation3Choice_
    {
        /// <summary>
        /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
        /// </summary>
        [IsoId("_eJJ82RgHEeKqWJINzXcn5g")]
        [DisplayName("Primary Individual Investor")]
        [IsoXmlTag("PmryIndvInvstr")]
        public IndividualPerson8? PrimaryIndividualInvestor { get; init; }

        /// <summary>
        /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
        /// </summary>
        [IsoId("_eJJ83RgHEeKqWJINzXcn5g")]
        [DisplayName("Secondary Individual Investor")]
        [IsoXmlTag("ScndryIndvInvstr")]
        public IndividualPerson8? SecondaryIndividualInvestor { get; init; }

        /// <summary>
        /// Information identifying the other individual investors, eg, name, address, social security number and date of birth.
        /// </summary>
        [IsoId("_eJJ84RgHEeKqWJINzXcn5g")]
        [DisplayName("Other Individual Investor")]
        [IsoXmlTag("OthrIndvInvstr")]
        public IndividualPerson8? OtherIndividualInvestor { get; init; }

        /// <summary>
        /// Information identifying the primary corporate investor, eg, name and address.
        /// </summary>
        [IsoId("_eJJ85RgHEeKqWJINzXcn5g")]
        [DisplayName("Primary Corporate Investor")]
        [IsoXmlTag("PmryCorpInvstr")]
        public Organisation4? PrimaryCorporateInvestor { get; init; }

        /// <summary>
        /// Information identifying the secondary corporate investor, eg, name and address.
        /// </summary>
        [IsoId("_eJJ86RgHEeKqWJINzXcn5g")]
        [DisplayName("Secondary Corporate Investor")]
        [IsoXmlTag("ScndryCorpInvstr")]
        public Organisation4? SecondaryCorporateInvestor { get; init; }

        /// <summary>
        /// Information identifying the other corporate investors, eg, name and address.
        /// </summary>
        [IsoId("_eJJ87RgHEeKqWJINzXcn5g")]
        [DisplayName("Other Corporate Investor")]
        [IsoXmlTag("OthrCorpInvstr")]
        public Organisation4? OtherCorporateInvestor { get; init; }

        /// <summary>
        /// Identification of an account owned by the investor at the old plan manager (account servicer).
        /// </summary>
        [IsoId("_eJJ88RgHEeKqWJINzXcn5g")]
        [DisplayName("Transferor Account")]
        [IsoXmlTag("TrfrAcct")]
        public required Account5 TransferorAccount { get; init; }

        /// <summary>
        /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
        /// </summary>
        [IsoId("_eJJ89RgHEeKqWJINzXcn5g")]
        [DisplayName("Nominee Account")]
        [IsoXmlTag("NmneeAcct")]
        public Account6? NomineeAccount { get; init; }

        /// <summary>
        /// Information related to the institution to which the financial instrument is to be transferred.
        /// </summary>
        [IsoId("_eJJ8-RgHEeKqWJINzXcn5g")]
        [DisplayName("Transferee")]
        [IsoXmlTag("Trfee")]
        public required PartyIdentification2Choice_ Transferee { get; init; }

        /// <summary>
        /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
        /// </summary>
        [IsoId("_eJJ8_RgHEeKqWJINzXcn5g")]
        [DisplayName("Cash Account")]
        [IsoXmlTag("CshAcct")]
        public CashAccount11? CashAccount { get; init; }

        /// <summary>
        /// Provides information related to the asset(s) transferred.
        /// </summary>
        [IsoId("_eJJ9ARgHEeKqWJINzXcn5g")]
        [DisplayName("Product Transfer")]
        [IsoXmlTag("PdctTrf")]
        public ValueList<ISATransfer8> ProductTransfer { get; init; } = [];

        // ID for the above is _eJJ9ARgHEeKqWJINzXcn5g

        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_eJJ9BRgHEeKqWJINzXcn5g")]
        [DisplayName("Extension")]
        [IsoXmlTag("Xtnsn")]
        public Extension1? Extension { get; init; }
    }
}
