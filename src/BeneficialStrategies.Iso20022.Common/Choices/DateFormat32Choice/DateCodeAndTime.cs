// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateFormat32Choice
{
    /// <summary>
    /// Specifies a date code and a time.
    /// </summary>
    [IsoId("_MMyiK0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Date Code And Time")]
    public partial record DateCodeAndTime : DateFormat32Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the type of date.
        /// </summary>
        [IsoId("_btDb8UENEeWVgfuHGaKtRQ")]
        [DisplayName("Date Code")]
        [IsoXmlTag("DtCd")]
        public required DateCode21Choice_ DateCode { get; init; } 
        
        /// <summary>
        /// Specifies the time.
        /// </summary>
        [IsoId("_btDb-UENEeWVgfuHGaKtRQ")]
        [DisplayName("Time")]
        [IsoXmlTag("Tm")]
        [IsoSimpleType(IsoSimpleType.ISOTime)]
        public required IsoISOTime Time { get; init; } 
        
        
        #nullable disable
        
    }
}
