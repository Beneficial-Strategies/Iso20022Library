// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PreferenceToIncome2Choice
{
    /// <summary>
    /// Preference to income expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Qu-j5Np-Ed-ak6NoX_4Aeg_192596703")]
    [DisplayName("Code")]
    public partial record Code : PreferenceToIncome2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the level of priority to claim on income and assets of |the company in case of the payment of dividends and in the event of a bankruptcy, eg, ordinary/common stocks, preferred stocks, subordinated debt, etc.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required PreferenceToIncome1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
