// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccount2Choice
{
    /// <summary>
    /// Range of identifications of the securities accounts.
    /// </summary>
    [IsoId("_4H1_oeGBEeWCAvUNsZ5u6g")]
    [DisplayName("Range")]
    public partial record Range : SecuritiesAccount2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Securities account number or code at which the range starts.
        /// </summary>
        [IsoId("_4UfUgeGBEeWCAvUNsZ5u6g")]
        [DisplayName("From")]
        [IsoXmlTag("Fr")]
        public required SecuritiesAccount19 From { get; init; } 
        
        /// <summary>
        /// Securities account number or code at which the range ends.
        /// </summary>
        [IsoId("_4UfUg-GBEeWCAvUNsZ5u6g")]
        [DisplayName("To")]
        [IsoXmlTag("To")]
        public required SecuritiesAccount19 To { get; init; } 
        
        
        #nullable disable
        
    }
}
