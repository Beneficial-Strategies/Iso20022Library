// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument25Choice
{
    /// <summary>
    /// Written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee).
    /// </summary>
    [IsoId("_M8JPU_8REemYYvJytExgzA")]
    [DisplayName("Cheque Details")]
    public record ChequeDetails : PaymentInstrument25Choice_
    {
        /// <summary>
        /// Unique and unambiguous identifier for the cheque as assigned by the financial institution.
        /// </summary>
        [IsoId("_BS7wgf8REemYYvJytExgzA")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Number { get; init; }

        /// <summary>
        /// Party to which the cheque is made payable.
        /// </summary>
        [IsoId("_BS7wg_8REemYYvJytExgzA")]
        [DisplayName("Payee Identification")]
        [IsoXmlTag("PyeeId")]
        public PartyIdentification139? PayeeIdentification { get; init; }

        /// <summary>
        /// Financial institution on which the cheque is drawn, that is, the financial institution that services the account of the entity that issued the cheque.
        /// </summary>
        [IsoId("_BS7whf8REemYYvJytExgzA")]
        [DisplayName("Drawee Identification")]
        [IsoXmlTag("DrweeId")]
        public FinancialInstitutionIdentification17? DraweeIdentification { get; init; }

        /// <summary>
        /// Account owner that issues the cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
        /// </summary>
        [IsoId("_BS7wh_8REemYYvJytExgzA")]
        [DisplayName("Drawer Identification")]
        [IsoXmlTag("DrwrId")]
        public PartyIdentification139? DrawerIdentification { get; init; }
    }
}
