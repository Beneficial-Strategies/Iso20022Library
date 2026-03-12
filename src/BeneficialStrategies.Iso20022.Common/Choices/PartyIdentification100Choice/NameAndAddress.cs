// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification100Choice
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_vr0GBYFvEeWtPe6Crjmeug")]
    [DisplayName("Name And Address")]
    public partial record NameAndAddress : PartyIdentification100Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PbOdANp-Ed-ak6NoX_4Aeg_1129576091")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70 ,MinimumLength = 1)]
        public required IsoMax70Text Name { get; init; } 
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_PbOdAdp-Ed-ak6NoX_4Aeg_-1308409680")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        public required PostalAddress2 Address { get; init; } 
        
        
        #nullable disable
        
    }
}
