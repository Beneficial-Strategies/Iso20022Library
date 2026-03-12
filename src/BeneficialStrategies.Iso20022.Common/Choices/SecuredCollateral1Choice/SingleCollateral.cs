// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuredCollateral1Choice
{
    /// <summary>
    /// Identifies the security pledged via a single ISIN.
    /// </summary>
    [IsoId("_fvQpMJgAEeSfnc-VXAEapg")]
    [DisplayName("Single Collateral")]
    public partial record SingleCollateral : SecuredCollateral1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Nominal amount of the security pledged as collateral. Except for tri-party repos and any other transaction in which the security pledged is not identified via a single ISIN.
        /// </summary>
        [IsoId("_m6QfAZf6EeSfnc-VXAEapg")]
        [DisplayName("Nominal Amount")]
        [IsoXmlTag("NmnlAmt")]
        public ActiveCurrencyAndAmount? NominalAmount { get; init; } 
        
        /// <summary>
        /// International Securities Identification Number (ISIN). A numbering system designed by the United Nation&apos;s International Organisation for Standardisation (ISO). The ISIN is composed of a 2-character prefix representing the country of issue, followed by the national security number (if one exists), and a check digit. Each country has a national numbering agency that assigns ISIN numbers for securities in that country.
        /// </summary>
        [IsoId("_uqx1AZf6EeSfnc-VXAEapg")]
        [DisplayName("ISIN")]
        [IsoXmlTag("ISIN")]
        [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
        public required IsoISINIdentifier ISIN { get; init; } 
        
        
        #nullable disable
        
    }
}
