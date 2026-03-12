// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountOrOperationalError3Choice
{
    /// <summary>
    /// Report information about securities account reference data.
    /// </summary>
    [IsoId("_x4sjgTp1Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Report")]
    public partial record SecuritiesAccountReport : SecuritiesAccountOrOperationalError3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the system security account.
        /// </summary>
        [IsoId("_yC-g4Tp1Eemk2e6qGBk8IQ")]
        [DisplayName("Securities Account Identification")]
        [IsoXmlTag("SctiesAcctId")]
        public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
        
        /// <summary>
        /// Specifies the returned securities account reference data or error information.
        /// </summary>
        [IsoId("_yC-g4zp1Eemk2e6qGBk8IQ")]
        [DisplayName("Securities Account Or Error")]
        [IsoXmlTag("SctiesAcctOrErr")]
        public required SecuritiesAccountOrBusinessError3Choice_ SecuritiesAccountOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
