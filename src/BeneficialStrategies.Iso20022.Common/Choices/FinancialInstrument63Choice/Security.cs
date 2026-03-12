// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrument63Choice
{
    /// <summary>
    /// Identification of the security.
    /// </summary>
    [IsoId("_nj5gMaPvEemf4IaGqCtquA")]
    [DisplayName("Security")]
    public partial record Security : FinancialInstrument63Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
        /// </summary>
        [IsoId("_w33Uk5NJEemQB_8XA98K0Q")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required SecurityIdentification25Choice_ Identification { get; init; } 
        
        /// <summary>
        /// Name of the financial instrument in free format text.
        /// </summary>
        [IsoId("_w33UlZNJEemQB_8XA98K0Q")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? Name { get; init; } 
        
        /// <summary>
        /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
        /// </summary>
        [IsoId("_w33Ul5NJEemQB_8XA98K0Q")]
        [DisplayName("Short Name")]
        [IsoXmlTag("ShrtNm")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? ShortName { get; init; } 
        
        /// <summary>
        /// Type of security.
        /// </summary>
        [IsoId("_qDzm0pNJEemQB_8XA98K0Q")]
        [DisplayName("Classification Type")]
        [IsoXmlTag("ClssfctnTp")]
        public ClassificationType32Choice_? ClassificationType { get; init; } 
        
        
        #nullable disable
        
    }
}
