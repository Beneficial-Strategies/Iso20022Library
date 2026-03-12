// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateFormat54Choice
{
    /// <summary>
    /// Specifies a date code and a time.
    /// </summary>
    [IsoId("_k9m0uc3xEee5nJBZsW8MFQ")]
    [DisplayName("Date Code And Time")]
    public partial record DateCodeAndTime : DateFormat54Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the type of date.
        /// </summary>
        [IsoId("_ctczCZKQEeWHWpTQn1FFVg")]
        [DisplayName("Date Code")]
        [IsoXmlTag("DtCd")]
        public required DateCode26Choice_ DateCode { get; init; } 
        
        /// <summary>
        /// Specifies the time.
        /// </summary>
        [IsoId("_ctczEZKQEeWHWpTQn1FFVg")]
        [DisplayName("Time")]
        [IsoXmlTag("Tm")]
        [IsoSimpleType(IsoSimpleType.ISOTime)]
        public required IsoISOTime Time { get; init; } 
        
        
        #nullable disable
        
    }
}
