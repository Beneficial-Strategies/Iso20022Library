// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountOrOperationalError2Choice
{
    /// <summary>
    /// Report information about securities account reference data.
    /// </summary>
    [IsoId("_t8qdseGEEeWCAvUNsZ5u6g")]
    [DisplayName("Securities Account Report")]
    public partial record SecuritiesAccountReport : SecuritiesAccountOrOperationalError2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_uIaaseGEEeWCAvUNsZ5u6g")]
        [DisplayName("Securities Account Identification")]
        [IsoXmlTag("SctiesAcctId")]
        public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; } 
        
        /// <summary>
        /// Identifies the returned securities account reference data or error information.
        /// </summary>
        [IsoId("_uIaas-GEEeWCAvUNsZ5u6g")]
        [DisplayName("Securities Account Or Error")]
        [IsoXmlTag("SctiesAcctOrErr")]
        public required SecuritiesAccountOrBusinessError2Choice_ SecuritiesAccountOrError { get; init; } 
        
        
        #nullable disable
        
    }
}
