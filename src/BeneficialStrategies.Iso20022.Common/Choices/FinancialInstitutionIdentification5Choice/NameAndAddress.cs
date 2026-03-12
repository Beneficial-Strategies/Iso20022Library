// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice
{
    /// <summary>
    /// Identifies the name and address of a financial institution.
    /// </summary>
    [IsoId("_TFnrINp-Ed-ak6NoX_4Aeg_426657982")]
    [DisplayName("Name And Address")]
    public partial record NameAndAddress : FinancialInstitutionIdentification5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PZleQtp-Ed-ak6NoX_4Aeg_1385273243")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public required IsoMax70Text Name { get; init; } 
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_PZleQ9p-Ed-ak6NoX_4Aeg_1385275042")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        public required PostalAddress1 PostalAddress { get; init; } 
        
        
        #nullable disable
        
    }
}
