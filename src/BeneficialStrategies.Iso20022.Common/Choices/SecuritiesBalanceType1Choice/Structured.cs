// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesBalanceType1Choice
{
    /// <summary>
    /// Balance reason in structured format.
    /// </summary>
    [IsoId("_U11Ehtp-Ed-ak6NoX_4Aeg_1393739597")]
    [DisplayName("Structured")]
    public partial record Structured : SecuritiesBalanceType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the securities or investment fund balance.
        /// </summary>
        [IsoXmlTag("Strd")]
        public required SecuritiesBalanceType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
