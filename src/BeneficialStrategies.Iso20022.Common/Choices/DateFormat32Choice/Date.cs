// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateFormat32Choice
{
    /// <summary>
    /// Date expressed as a calendar date.
    /// </summary>
    [IsoId("_MMyiI0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Date")]
    public partial record Date : DateFormat32Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
