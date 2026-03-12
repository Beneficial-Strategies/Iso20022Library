// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument11Choice
{
    /// <summary>
    /// Part of the investment account to or from which cash entries are made.
    /// </summary>
    [IsoId("_SBhw59p-Ed-ak6NoX_4Aeg_-925008187")]
    [DisplayName("Cash Account Details")]
    public partial record CashAccountDetails : PaymentInstrument11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_Rzq7HNp-Ed-ak6NoX_4Aeg_2054866231")]
        [DisplayName("Account Identification")]
        [IsoXmlTag("AcctId")]
        public AccountIdentification1? AccountIdentification { get; init; } 
        
        /// <summary>
        /// Account type.
        /// </summary>
        [IsoId("_Rzq7Hdp-Ed-ak6NoX_4Aeg_2054866247")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public FundCashAccount2Code? Type { get; init; } 
        
        /// <summary>
        /// Purpose of the account/source fund type. This is typically linked to an investment product, eg, wrapper, PEP, ISA.
        /// </summary>
        [IsoId("_Rzq7Htp-Ed-ak6NoX_4Aeg_-1711849455")]
        [DisplayName("Extended Type")]
        [IsoXmlTag("XtndedTp")]
        [IsoSimpleType(IsoSimpleType.Extended350Code)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoExtended350Code? ExtendedType { get; init; } 
        
        
        #nullable disable
        
    }
}
