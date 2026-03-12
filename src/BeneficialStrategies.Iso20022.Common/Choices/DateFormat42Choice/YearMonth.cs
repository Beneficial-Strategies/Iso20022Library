// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateFormat42Choice
{
    /// <summary>
    /// Year and month.
    /// </summary>
    [IsoId("_xXmZwpBrEeaGiLsfv6g8MA")]
    [DisplayName("Year Month")]
    public partial record YearMonth : DateFormat42Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Month within a particular calendar year represented by YYYY-MM (ISO 8601).
        /// </summary>
        [IsoXmlTag("YrMnth")]
        [IsoSimpleType(IsoSimpleType.ISOYearMonth)]
        public required IsoISOYearMonth Value { get; init; } 
        
        
        #nullable disable
        
    }
}
