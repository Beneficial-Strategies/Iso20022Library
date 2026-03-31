// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.KYCCheckType1Choice
{
    /// <summary>
    /// Type of Know Your Customer (KYC) check type expressed as a code.
    /// </summary>
    [IsoId("_CsmgIBRyEeOKWo1NF21OVw")]
    [DisplayName("Code")]
    public record Code : KYCCheckType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of Know Your Customer (KYC) or anti-money laundering due diligence to which the investor has been subjected.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required KnowYourCustomerCheckType1Code Value { get; init; }
    }
}
