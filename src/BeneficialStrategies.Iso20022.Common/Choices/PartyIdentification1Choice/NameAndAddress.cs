// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification1Choice
{
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QQa_odp-Ed-ak6NoX_4Aeg_-395733973")]
    [DisplayName("Name And Address")]
    public partial record NameAndAddress : PartyIdentification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Name by which a party is known and which is usually used to identify that party.
        /// </summary>
        [IsoId("_PZcUV9p-Ed-ak6NoX_4Aeg_-618689920")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public required IsoMax35Text Name { get; init; } 
        
        /// <summary>
        /// Information that locates and identifies a specific address, as defined by postal services.
        /// </summary>
        [IsoId("_PZcUWNp-Ed-ak6NoX_4Aeg_-331477617")]
        [DisplayName("Address")]
        [IsoXmlTag("Adr")]
        public LongPostalAddress1Choice_? Address { get; init; } 
        
        
        #nullable disable
        
    }
}
