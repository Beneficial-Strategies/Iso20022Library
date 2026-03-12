// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateFormat20Choice
{
    /// <summary>
    /// Specifies a date code and a time.
    /// </summary>
    [IsoId("_lH2aSfZFEd-2Jsl2KtUQCw")]
    [DisplayName("Date Code And Time")]
    public partial record DateCodeAndTime : DateFormat20Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the type of date.
        /// </summary>
        [IsoId("_Q2uKqdp-Ed-ak6NoX_4Aeg_-834882430")]
        [DisplayName("Date Code")]
        [IsoXmlTag("DtCd")]
        public required DateCode4Choice_ DateCode { get; init; } 
        
        /// <summary>
        /// Specifies the time.
        /// </summary>
        [IsoId("_Q237oNp-Ed-ak6NoX_4Aeg_713469563")]
        [DisplayName("Time")]
        [IsoXmlTag("Tm")]
        [IsoSimpleType(IsoSimpleType.ISOTime)]
        public required IsoISOTime Time { get; init; } 
        
        
        #nullable disable
        
    }
}
