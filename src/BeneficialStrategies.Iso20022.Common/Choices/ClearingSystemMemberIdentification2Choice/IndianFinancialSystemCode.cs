// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification2Choice
{
    /// <summary>
    /// Indian Financial System Code - identifies Indian financial institutions on the Indian local clearing system.
    /// </summary>
    [IsoId("_TDPFgtp-Ed-ak6NoX_4Aeg_2074902177")]
    [DisplayName("Indian Financial System Code")]
    public partial record IndianFinancialSystemCode : ClearingSystemMemberIdentification2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Indian Financial System Code Identifier. Identifies Indian financial institutions on the Indian national clearing system.
        /// </summary>
        [IsoXmlTag("INIFSC")]
        [IsoSimpleType(IsoSimpleType.IndianFinancialSystemCodeIdentifier)]
        public required IsoIndianFinancialSystemCodeIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
