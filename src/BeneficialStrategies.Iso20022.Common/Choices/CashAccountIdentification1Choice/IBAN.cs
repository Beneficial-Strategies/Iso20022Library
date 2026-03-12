// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashAccountIdentification1Choice
{
    /// <summary>
    /// International Bank Account Number (IBAN) - identifier used internationally by financial institutions to uniquely identify the account of a customer. Further specifications of the format and content of the IBAN can be found in the standard ISO 13616 &quot;Banking and related financial services - International Bank Account Number (IBAN)&quot; version 1997-10-01, or later revisions.
    /// </summary>
    [IsoId("_Pdwzpdp-Ed-ak6NoX_4Aeg_2060838797")]
    [DisplayName("IBAN")]
    public partial record IBAN : CashAccountIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// An identifier used internationally by financial institutions to uniquely identify the account of a customer at a financial institution, as described in the latest edition of the international standard ISO 13616. &quot;Banking and related financial services - International Bank Account Number (IBAN)&quot;.
        /// </summary>
        [IsoXmlTag("IBAN")]
        [IsoSimpleType(IsoSimpleType.IBANIdentifier)]
        public required IsoIBANIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
