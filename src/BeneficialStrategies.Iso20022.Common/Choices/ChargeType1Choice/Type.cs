// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargeType1Choice
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RhV099p-Ed-ak6NoX_4Aeg_1081821826")]
    [DisplayName("Type")]
    public partial record Type : ChargeType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies charges linked to the type of service.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required ChargeType13Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
