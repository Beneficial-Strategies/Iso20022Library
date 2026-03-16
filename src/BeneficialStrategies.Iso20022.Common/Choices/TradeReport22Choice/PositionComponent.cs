// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport22Choice
{
    /// <summary>
    /// Indicates contract that is to be reported as a new trade and also included in a separate position report on the same day.
    /// </summary>
    [IsoId("_zvSsecg3EeuGrNSsxk3B0A")]
    [DisplayName("Position Component")]
    [IsoXmlTag("PosCmpnt")]
    public record PositionComponent : TradeReport22Choice_
    {
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice message.
        /// </summary>
        [IsoId("_AJ1aAcz4EeufhKfUxzsnrQ")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? TechnicalRecordIdentification { get; init; }

        /// <summary>
        /// Data specific to counterparties and related fields.
        /// </summary>
        [IsoId("_AJ1aA8z4EeufhKfUxzsnrQ")]
        [DisplayName("Counterparty Specific Data")]
        [IsoXmlTag("CtrPtySpcfcData")]
        public required CounterpartyData88 CounterpartySpecificData { get; init; }

        /// <summary>
        /// Details of the loan used for financing the transaction.
        /// </summary>
        [IsoId("_AJ1aBcz4EeufhKfUxzsnrQ")]
        [DisplayName("Loan Data")]
        [IsoXmlTag("LnData")]
        public TransactionLoanData32Choice_? LoanData { get; init; }

        /// <summary>
        /// Provides the details of the collateral used in the transaction.
        /// </summary>
        [IsoId("_AJ1aB8z4EeufhKfUxzsnrQ")]
        [DisplayName("Collateral Data")]
        [IsoXmlTag("CollData")]
        public CollateralData35? CollateralData { get; init; }

        /// <summary>
        /// Information concerning the reported transaction level type.
        /// </summary>
        [IsoId("_AJ1aCcz4EeufhKfUxzsnrQ")]
        [DisplayName("Level Type")]
        [IsoXmlTag("LvlTp")]
        public required ModificationLevel1Code LevelType { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_AJ1aC8z4EeufhKfUxzsnrQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
