// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument20Choice
{
    /// <summary>
    /// Written order on which instructions are given to an account holder (a financial institution) to pay a stated sum to a named recipient (the payee).
    /// </summary>
    [IsoId("_weKLHzbsEead9bDRE_1DAQ")]
    [DisplayName("Cheque Details")]
    public partial record ChequeDetails : PaymentInstrument20Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier for a cheque as assigned by the financial institution.
        /// </summary>
        [IsoId("_w3AI4TbsEead9bDRE_1DAQ")]
        [DisplayName("Number")]
        [IsoXmlTag("Nb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Number { get; init; } 
        
        /// <summary>
        /// Party to which a cheque is made payable.
        /// </summary>
        [IsoId("_w3AI4zbsEead9bDRE_1DAQ")]
        [DisplayName("Payee Identification")]
        [IsoXmlTag("PyeeId")]
        public required PartyIdentification113 PayeeIdentification { get; init; } 
        
        /// <summary>
        /// Financial institution on which a cheque is drawn, that is, the financial institution that services the account of the entity that issued the cheque.
        /// </summary>
        [IsoId("_w3AI5TbsEead9bDRE_1DAQ")]
        [DisplayName("Drawee Identification")]
        [IsoXmlTag("DrweeId")]
        public FinancialInstitutionIdentification10? DraweeIdentification { get; init; } 
        
        /// <summary>
        /// Account owner that issues a cheque ordering the drawee bank to pay a specific amount, upon demand, to the payee.
        /// </summary>
        [IsoId("_w3AI5zbsEead9bDRE_1DAQ")]
        [DisplayName("Drawer Identification")]
        [IsoXmlTag("DrwrId")]
        public PartyIdentification113? DrawerIdentification { get; init; } 
        
        
        #nullable disable
        
    }
}
