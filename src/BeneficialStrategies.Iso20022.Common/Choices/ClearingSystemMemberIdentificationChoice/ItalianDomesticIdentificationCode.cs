// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentificationChoice
{
    /// <summary>
    /// Italian Domestic Identification Code - identifies Italian financial institutions on the Italian national clearing system. The code is assigned by the Associazione Bancaria Italiana (ABI).
    /// </summary>
    [IsoId("_TDY2h9p-Ed-ak6NoX_4Aeg_-896562589")]
    [DisplayName("Italian Domestic Identification Code")]
    public partial record ItalianDomesticIdentificationCode : ClearingSystemMemberIdentificationChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Italian Domestic Identification Code. Identifies Italian financial institutions on the Italian national clearing system. The code is assigned by the Associazione Bancaria Italiana (ABI).
        /// </summary>
        [IsoXmlTag("ITNCC")]
        [IsoSimpleType(IsoSimpleType.ItalianDomesticIdentifier)]
        public required IsoItalianDomesticIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
