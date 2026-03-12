// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateFormat31Choice
{
    /// <summary>
    /// Date expressed as a calendar date.
    /// </summary>
    [IsoId("_KEW2A0EEEeWVgfuHGaKtRQ")]
    [DisplayName("Date")]
    public partial record Date : DateFormat31Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
