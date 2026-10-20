// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat31Choice
{
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    [IsoId("_KEW2C0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Date Code")]
    public partial record DateCode : DateFormat31Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DtCd")]
        public required DateCode19Choice_ Value { get; init; }
    }
}
