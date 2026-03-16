// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument7Choice
{
    /// <summary>
    /// Written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee).
    /// </summary>
    [IsoId("_VKiwSNp-Ed-ak6NoX_4Aeg_-1553197713")]
    [DisplayName("Cheque Details")]
    [IsoXmlTag("ChqDtls")]
    public record ChequeDetails : PaymentInstrument7Choice_
    {
        /// <summary>
        /// Unique and unambiguous identifier for a cheque as assigned by the financial institution.
        /// </summary>
        [IsoId("_QbdK_Np-Ed-ak6NoX_4Aeg_-241775366")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Number { get; init; }

        /// <summary>
        /// Party to which a cheque is made payable.
        /// </summary>
        [IsoId("_QbdK_dp-Ed-ak6NoX_4Aeg_-241775384")]
        [DisplayName("Payee Identification")]
        [IsoXmlTag("PyeeId")]
        public required PartyIdentification2Choice_ PayeeIdentification { get; init; }

        /// <summary>
        /// Financial institution on which a cheque is drawn, ie, the financial institution that services the account of the entity that issued the cheque.
        /// </summary>
        [IsoId("_QbdK_tp-Ed-ak6NoX_4Aeg_-241775426")]
        [DisplayName("Drawee Identification")]
        [IsoXmlTag("DrweeId")]
        public FinancialInstitutionIdentification3Choice_? DraweeIdentification { get; init; }

        /// <summary>
        /// Account owner that issues a cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
        /// </summary>
        [IsoId("_QbmU4Np-Ed-ak6NoX_4Aeg_-241775434")]
        [DisplayName("Drawer Identification")]
        [IsoXmlTag("DrwrId")]
        public PartyIdentification2Choice_? DrawerIdentification { get; init; }
    }
}
