// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SubBalanceType1Choice
{
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_QZ9WIdp-Ed-ak6NoX_4Aeg_-1627975253")]
    [DisplayName("Sub Balance Type")]
    public partial record SubBalanceType : SubBalanceType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of the securities or investment fund balance.
        /// </summary>
        [IsoXmlTag("SubBalTp")]
        public required SecuritiesBalanceType4Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
