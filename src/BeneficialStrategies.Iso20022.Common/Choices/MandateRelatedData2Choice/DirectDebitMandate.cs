// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MandateRelatedData2Choice
{
    /// <summary>
    /// Specific direct debit mandate data.
    /// </summary>
    [IsoId("_a4TwEdcZEeqRFcf2R4bPBw")]
    [DisplayName("Direct Debit Mandate")]
    [IsoXmlTag("DrctDbtMndt")]
    public record DirectDebitMandate : MandateRelatedData2Choice_
    {
        /// <summary>
        /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
        /// </summary>
        [IsoId("_a5rCBdcZEeqRFcf2R4bPBw")]
        [DisplayName("Mandate Identification")]
        [IsoXmlTag("MndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MandateIdentification { get; init; }

        /// <summary>
        /// Date on which the direct debit mandate has been signed by the debtor.
        /// </summary>
        [IsoId("_a5rCB9cZEeqRFcf2R4bPBw")]
        [DisplayName("Date Of Signature")]
        [IsoXmlTag("DtOfSgntr")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? DateOfSignature { get; init; }

        /// <summary>
        /// Indicator notifying whether the underlying mandate is amended or not.
        /// </summary>
        [IsoId("_a5rCCdcZEeqRFcf2R4bPBw")]
        [DisplayName("Amendment Indicator")]
        [IsoXmlTag("AmdmntInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? AmendmentIndicator { get; init; }

        /// <summary>
        /// List of mandate elements that have been modified.
        /// </summary>
        [IsoId("_a5rCC9cZEeqRFcf2R4bPBw")]
        [DisplayName("Amendment Information Details")]
        [IsoXmlTag("AmdmntInfDtls")]
        public AmendmentInformationDetails14? AmendmentInformationDetails { get; init; }

        /// <summary>
        /// Additional security provisions, such as a digital signature, as provided by the debtor.
        /// </summary>
        [IsoId("_a5rCDdcZEeqRFcf2R4bPBw")]
        [DisplayName("Electronic Signature")]
        [IsoXmlTag("ElctrncSgntr")]
        [IsoSimpleType(IsoSimpleType.Max1025Text)]
        [StringLength(maximumLength: 1025, MinimumLength = 1)]
        public IsoMax1025Text? ElectronicSignature { get; init; }

        /// <summary>
        /// Date of the first collection of a direct debit as per the mandate.
        /// </summary>
        [IsoId("_a5rpEdcZEeqRFcf2R4bPBw")]
        [DisplayName("First Collection Date")]
        [IsoXmlTag("FrstColltnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? FirstCollectionDate { get; init; }

        /// <summary>
        /// Date of the final collection of a direct debit as per the mandate.
        /// </summary>
        [IsoId("_a5rpE9cZEeqRFcf2R4bPBw")]
        [DisplayName("Final Collection Date")]
        [IsoXmlTag("FnlColltnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? FinalCollectionDate { get; init; }

        /// <summary>
        /// Regularity with which direct debit instructions are to be created and processed.
        /// </summary>
        [IsoId("_a5rpFdcZEeqRFcf2R4bPBw")]
        [DisplayName("Frequency")]
        [IsoXmlTag("Frqcy")]
        public Frequency36Choice_? Frequency { get; init; }

        /// <summary>
        /// Reason for the direct debit mandate to allow the user to distinguish between different mandates for the same creditor.
        /// </summary>
        [IsoId("_a5rpF9cZEeqRFcf2R4bPBw")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public MandateSetupReason1Choice_? Reason { get; init; }

        /// <summary>
        /// Specifies the number of days the direct debit instruction must be tracked.
        /// </summary>
        [IsoId("_a5rpGdcZEeqRFcf2R4bPBw")]
        [DisplayName("Tracking Days")]
        [IsoXmlTag("TrckgDays")]
        [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
        public IsoExact2NumericText? TrackingDays { get; init; }
    }
}
