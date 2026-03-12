// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.OrganisationIdentification15Choice
{
    /// <summary>
    /// Unique identification of an organisation, using a client code or a business identification code.
    /// </summary>
    [IsoId("_F-FycMgoEeuGrNSsxk3B0A")]
    [DisplayName("Other")]
    public partial record Other : OrganisationIdentification15Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification of the organisation.
        /// </summary>
        [IsoId("_sAgPEMgnEeuGrNSsxk3B0A")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required GenericIdentification175 Identification { get; init; } 
        
        /// <summary>
        /// Indicates the name of the organisation.
        /// </summary>
        [IsoId("_yyv-8MgnEeuGrNSsxk3B0A")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max105Text)]
        [StringLength(maximumLength: 105 ,MinimumLength = 1)]
        public IsoMax105Text? Name { get; init; } 
        
        /// <summary>
        /// Indicates the domicile of the organisation.
        /// </summary>
        [IsoId("_8ndaQMgnEeuGrNSsxk3B0A")]
        [DisplayName("Domicile")]
        [IsoXmlTag("Dmcl")]
        [IsoSimpleType(IsoSimpleType.Max500Text)]
        [StringLength(maximumLength: 500 ,MinimumLength = 1)]
        public IsoMax500Text? Domicile { get; init; } 
        
        
        #nullable disable
        
    }
}
