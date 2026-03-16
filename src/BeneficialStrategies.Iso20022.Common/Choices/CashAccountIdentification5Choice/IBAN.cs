// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CashAccountIdentification5Choice
{
    /// <summary>
    /// International Bank Account Number (IBAN) - identifier used internationally by financial institutions to uniquely identify the account of a customer. Further specifications of the format and content of the IBAN can be found in the standard ISO 13616 &quot;Banking and related financial services - International Bank Account Number (IBAN)&quot; version 1997-10-01, or later revisions.
    /// </summary>
    [IsoId("_Pdd4sNp-Ed-ak6NoX_4Aeg_-912371557")]
    [DisplayName("IBAN")]
    public record IBAN : CashAccountIdentification5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// The International Bank Account Number is a code used internationally by financial institutions to uniquely identify the account of a customer at a financial institution as described in the 2007 edition of the ISO 13616 standard &quot;Banking and related financial services - International Bank Account Number (IBAN)&quot; and replaced by the more recent edition of the standard.
        /// </summary>
        [IsoXmlTag("IBAN")]
        [IsoSimpleType(IsoSimpleType.IBAN2007Identifier)]
        public required IsoIBAN2007Identifier Value { get; init; }
    }
}
