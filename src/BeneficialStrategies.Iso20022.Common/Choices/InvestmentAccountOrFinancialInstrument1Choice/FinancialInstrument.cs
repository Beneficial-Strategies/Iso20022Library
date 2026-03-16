// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestmentAccountOrFinancialInstrument1Choice
{
    /// <summary>
    /// Instrument that has intrinsic monetary value, and may transfer value, the price of which may be obtained from a financial market, eg, a bond or a cheque.
    /// </summary>
    [IsoId("_UuOntdp-Ed-ak6NoX_4Aeg_-1126591079")]
    [DisplayName("Financial Instrument")]
    public record FinancialInstrument : InvestmentAccountOrFinancialInstrument1Choice_
    {
        /// <summary>
        /// Identification of a security by an ISIN.
        /// </summary>
        [IsoId("_VHQyw9p-Ed-ak6NoX_4Aeg_935715975")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required SecurityIdentification1Choice_ Identification { get; init; }

        /// <summary>
        /// Name of the financial instrument in free format text.
        /// </summary>
        [IsoId("_VHQyxNp-Ed-ak6NoX_4Aeg_935716215")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? Name { get; init; }

        /// <summary>
        /// Additional information about a financial instrument to help identify the instrument.
        /// </summary>
        [IsoId("_VHQyxdp-Ed-ak6NoX_4Aeg_935716232")]
        [DisplayName("Supplementary Identification")]
        [IsoXmlTag("SplmtryId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? SupplementaryIdentification { get; init; }

        /// <summary>
        /// Features of units offered by a fund. For example, a unit may have a specific load structure, eg, front end or back end, an income policy, eg, pay out or accumulate, or a trailer policy, eg, with or without. Fund classes are typically denoted by a single character, eg, &apos;Class A&apos;, &apos;Class 2&apos;.
        /// </summary>
        [IsoId("_VHQyxtp-Ed-ak6NoX_4Aeg_935716285")]
        [DisplayName("Class Type")]
        [IsoXmlTag("ClssTp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? ClassType { get; init; }

        /// <summary>
        /// Form, ie, ownership, of the security, eg, registered or bearer.
        /// </summary>
        [IsoId("_VHQyx9p-Ed-ak6NoX_4Aeg_935716267")]
        [DisplayName("Securities Form")]
        [IsoXmlTag("SctiesForm")]
        public FormOfSecurity1Code? SecuritiesForm { get; init; }

        /// <summary>
        /// Income policy relating to a class type, ie, if income is paid out or retained in the fund.
        /// </summary>
        [IsoId("_VHQyyNp-Ed-ak6NoX_4Aeg_935716311")]
        [DisplayName("Distribution Policy")]
        [IsoXmlTag("DstrbtnPlcy")]
        public DistributionPolicy1Code? DistributionPolicy { get; init; }

        /// <summary>
        /// Company specific description of a group of funds.
        /// </summary>
        [IsoId("_VHQyydp-Ed-ak6NoX_4Aeg_1843918691")]
        [DisplayName("Product Group")]
        [IsoXmlTag("PdctGrp")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? ProductGroup { get; init; }
    }
}
